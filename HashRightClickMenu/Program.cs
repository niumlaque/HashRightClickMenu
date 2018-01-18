namespace HashRightClickMenu
{
    using System;
    using System.Windows.Forms;

    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length == 0)
            {
                Application.Run(new RegisterForm());
            }
            else
            {
                Application.Run(new HashForm(args[0]));
            }
        }
    }
}
