namespace HashRightClickMenu
{
    using System;
    using System.Windows.Forms;
    using Microsoft.Win32;

    public partial class RegisterForm : Form
    {
        private static readonly string verb = Application.ProductName.ToLower();
        private static readonly string description = "Hash";
        private static readonly string rootPath = string.Format("*\\shell\\{0}", verb);
        private static readonly string regPath = string.Format("{0}\\command", rootPath, verb);
        private static readonly string command = string.Format("\"{0}\" \"{1}\"", Application.ExecutablePath, "%1");

        public RegisterForm()
        {
            this.InitializeComponent();
        }

        private static void Register()
        {
            try
            {
                using (var key = Registry.ClassesRoot.CreateSubKey(regPath))
                {
                    key.SetValue("", command);
                }

                using (var key = Registry.ClassesRoot.CreateSubKey(rootPath))
                {
                    key.SetValue("", description);
                }

                MessageBox.Show(string.Format("Add to registry \"HKEY_CLASSES_ROOT\\{0}\"", rootPath), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void Unregister()
        {
            try
            {
                Registry.ClassesRoot.DeleteSubKeyTree(rootPath);
                MessageBox.Show(string.Format("Remove from registry \"HKEY_CLASSES_ROOT\\{0}\"", rootPath), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterButtonClicked(object sender, EventArgs e)
        {
            Register();
        }

        private void UnregisterButtonClicked(object sender, EventArgs e)
        {
            Unregister();
        }
    }
}
