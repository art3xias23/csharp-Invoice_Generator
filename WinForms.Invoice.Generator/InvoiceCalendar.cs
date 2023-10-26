using System.ComponentModel;
using WinForms.Invoice.Generator.Logic;
using WinForms.Invoice.Generator.Structure;

namespace WinForms.Invoice.Generator
{
    public partial class InvoiceCalendar : UserControl, ISave
    {
        private readonly BindingSource _bindingSource = new();
        private readonly BindingList<ListBoxItem> _bindingList;
        private List<DateTime> _workingDays;
        public InvoiceCalendar()
        {
            InitializeComponent();

            _workingDays = new List<DateTime>();
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

        private List<DateTime> GetAllWorkingDaysForMonth(int addMonths)
        {
            var listOfWorkingDays = new List<DateTime>();
            var firstOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month + addMonths, 1);
            for (var currentDate = firstOfMonth;
                 currentDate.Month == firstOfMonth.Month;
                 currentDate = currentDate.AddDays(1))
            {
                if (currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    listOfWorkingDays.Add(currentDate);
                }
            }

            return listOfWorkingDays;
        }

        private void ContextMenuItem_Click(object? sender, EventArgs e)
        {
            _workingDays.Add((DateTime)listBox.Items[listBox.SelectedIndex]);
            _bindingList.RemoveAt(listBox.SelectedIndex);
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
            if (SingletonData.Instance.TransitionalData.InvoiceMonth == "Next Month")
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

            _bindingList.Add(new ListBoxItem(e.Start));
            if (_workingDays.Contains(e.Start))
            {
                _workingDays.Remove(e.Start);
            }
        }

        public void Save()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SingletonData.Instance.InvoiceData.WorkingDays = _workingDays;
              var wordDocument = new MsWord(SingletonData.Instance.InvoiceData);

            wordDocument.CreateInvoice();

        }
    }
}
