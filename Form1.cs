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

        private void calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            _bindingList.Add(new ListBoxItem(e.Start));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

    }
}