using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using WinForms.Invoice.Generator.Data;
using WinForms.Invoice.Generator.Logic;
using WinForms.Invoice.Generator.Structure;

namespace WinForms.Invoice.Generator
{
    public partial class InvoiceCalendar : UserControl, ISave
    {
        private readonly BindingSource _bindingSource = new();
        private readonly BindingList<ListBoxItem> _bindingList;
        private List<WorkingDay> _workingDays;
        public InvoiceCalendar()
        {
            InitializeComponent();

            _workingDays = new List<WorkingDay>();
            _bindingList = new BindingList<ListBoxItem>();
            _bindingSource.DataSource = _bindingList;
            listBox.DisplayMember = "Item";
            listBox.ValueMember = "Item";
            listBox.DataSource = _bindingSource;
            listBox.MouseDown += ListBox_MouseDown;
            var contextMenu = new ContextMenuStrip();
            listBox.ContextMenuStrip = contextMenu;
            contextMenu.Items.Add("Delete", null, ContextMenuItem_Click);

        }

        private List<WorkingDay> GetAllWorkingDaysForMonth(int addMonths)
        {
            var listOfWorkingDays = new List<WorkingDay>();
            var firstOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month + addMonths, 1);
            for (var currentDate = firstOfMonth;
                 currentDate.Month == firstOfMonth.Month;
                 currentDate = currentDate.AddDays(1))
            {
                if (currentDate.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday)
                {

                    listOfWorkingDays.Add(new(currentDate, false));
                }
                else
                {

                    listOfWorkingDays.Add(new(currentDate, true));
                }
            }

            return listOfWorkingDays;
        }

        private void ContextMenuItem_Click(object? sender, EventArgs e)
        {
            var selectedItem = listBox.SelectedItem as ListBoxItem;
            if (selectedItem != null)
            {
                var day = _workingDays.First(x => x.Date == selectedItem.Item.Date);
                //Remove from non working days, set to working again
                day.IsWorkingDay = true;
                day.IsHoliday = false;
                _bindingList.RemoveAt(listBox.SelectedIndex);
            }
        }

        private void ListBox_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (sender is ListBox lb)
                {
                    lb.ContextMenuStrip.Show(listBox, e.Location);
                }
            }
        }

        private void InvoiceCalendar_Load(object sender, EventArgs e)
        {
            if (SingletonData.Instance.InvoiceData.DocumentType == Enums.DocumentType.Quote)
            {
                monthCalendar1.SetDate(DateTime.Now.AddMonths(1));
                _workingDays = GetAllWorkingDaysForMonth(1);
            }
            else
            {

                _workingDays = GetAllWorkingDaysForMonth(0);
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (_bindingList.Any(x => x.Item.Equals(e.Start)))
                return;
            //Set as a non working day and a holiday
            _bindingList.Add(new ListBoxItem(e.Start));
            var day = _workingDays.First(x => x.Date == e.Start);
            if (day?.IsWorkingDay == true)
            {
                day.IsWorkingDay = false;
                day.IsHoliday = true;
            }
        }

        public void Save()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SingletonData.Instance.InvoiceData.WorkingDays = _workingDays;
            var wordDocument = new MsWord(SingletonData.Instance.InvoiceData);

            wordDocument.CreateDocument();

            JsonData.SaveData();

        }
    }
}
