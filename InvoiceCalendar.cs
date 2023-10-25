using System.ComponentModel;
using WinForms.Invoice.Generator.Structure;

namespace WinForms.Invoice.Generator
{
    public partial class InvoiceCalendar : ISaveUserControl
    {
        private readonly BindingSource _bindingSource = new();
        private readonly BindingList<ListBoxItem> _bindingList;
        public InvoiceCalendar()
        {
            InitializeComponent();
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

        private void ContextMenuItem_Click(object? sender, EventArgs e)
        {
            _bindingList.RemoveAt(listBox.SelectedIndex);
        }

        private void ListBox_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Show the context menu at the cursor's location
                ListBox listBox = (ListBox)sender;
                listBox.ContextMenuStrip.Show(listBox, e.Location);
            }
        }


        private void InvoiceCalendar_Load(object sender, EventArgs e)
        {
            if (SingletonData.Instance.TransitionalData.InvoiceMonth == "Next Month")
            {
                monthCalendar1.SetDate(DateTime.Now.AddMonths(1));
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

            _bindingList.Add(new ListBoxItem(e.Start));
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
