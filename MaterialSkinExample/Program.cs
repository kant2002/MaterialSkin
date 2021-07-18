using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MaterialSkinExample
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            ComWrappers.RegisterForMarshalling(WinFormsComInterop.WinFormsComWrappers.Instance);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
