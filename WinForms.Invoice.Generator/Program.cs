using WinForms.Invoice.Generator.Logic;

namespace WinForms.Invoice.Generator
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}