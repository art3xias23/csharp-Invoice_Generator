using System.ComponentModel;

namespace WinForms.Invoice.Generator
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bindingSource = new();
        private readonly BindingList<ListBoxItem> _bindingList;
        public Form1()
        {
            InitializeComponent();
            _bindingList = new BindingList<ListBoxItem>();
            _bindingSource.DataSource = _bindingList;
            listBox.DisplayMember = "Item"; 
            listBox.ValueMember = "Item"; 
            listBox.DataSource = _bindingSource;
        }

        private void calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            _bindingList.Add(new ListBoxItem(e.Start));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

    }
}