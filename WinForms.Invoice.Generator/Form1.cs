namespace WinForms.Invoice.Generator
{
    public partial class Form1 : Form
    {
        private LinkedList<UserControl> ViewControls;
        private LinkedListNode<UserControl> _currentScreen;
        public Form1()
        {
            ViewControls = new LinkedList<UserControl>(new UserControl[] {
                new InvoiceType(),
                new InvoiceCurrency(),
                new InvoiceFirm(Enums.FirmTypeEnum.Origin),
                new InvoiceFirm(Enums.FirmTypeEnum.Target),
                new InvoiceBank(),
                new InvoiceCalendar()
            });
            _currentScreen = ViewControls.First!;
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            pnlMain2.Controls.Add(_currentScreen.Value);
        }

        private void pbRight2_Click(object sender, EventArgs e)
        {

            var nextScreen = _currentScreen?.Next;
            if (nextScreen != null)
            {
                if (_currentScreen!.Value is ISave saveInstance)
                {
                    saveInstance.Save();
                }

                if (nextScreen.Value is InvoiceCalendar)
                {
                    btnCreateInvoice.Visible = true;
                    pbRight2.Visible = false;
                }
                pnlMain2.Controls.Clear();
                pnlMain2.Controls.Add(nextScreen.Value);
                _currentScreen = nextScreen;
            }
        }

        private void pbLeft2_Click(object sender, EventArgs e)
        {
            var previousScreen = _currentScreen?.Previous;
            if (previousScreen != null)
            {
                if (previousScreen.Value is InvoiceBank)
                {
                    btnCreateInvoice.Visible = false;
                    pbRight2.Visible = true;
                }

                pnlMain2.Controls.Clear();
                pnlMain2.Controls.Add(previousScreen.Value);
                _currentScreen = previousScreen;
            }
        }
    }
}