using System.ComponentModel;

namespace WinForms.Invoice.Generator
{
    public partial class Form1 : Form
    {
        private LinkedList<UserControl> ViewControls;
        public Form1()
        {
            ViewControls = new LinkedList<UserControl>(new UserControl[] {new InvoiceType(), new InvoiceCalendar()});
            InitializeComponent();
        }

     
        private void Form1_Load(object sender, EventArgs e)
        {
        }

    }
}