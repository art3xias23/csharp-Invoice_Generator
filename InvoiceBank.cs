using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Invoice.Generator
{
    public partial class  InvoiceBank: UserControl, ISave
    {
        public InvoiceBank()
        {
            InitializeComponent();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
