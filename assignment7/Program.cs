using ClassLibrary;

namespace WinFormsApp1
{
    internal static class Program
    {
        public static OrderService orderService = new OrderService();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm()); // Æô¶¯Ö÷´°Ìå
        }
    }
}