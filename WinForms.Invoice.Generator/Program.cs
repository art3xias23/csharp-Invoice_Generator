using Velopack;
using WinForms.Invoice.Generator.Logic;

namespace WinForms.Invoice.Generator
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            VelopackApp.Build().Run();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}