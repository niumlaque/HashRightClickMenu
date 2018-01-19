namespace HashRightClickMenu
{
    using System;
    using System.IO;
    using System.Security.Cryptography;
    using System.Text;
    using System.Windows.Forms;

    public partial class HashForm : Form
    {
        private readonly string path;

        public HashForm(string filePath)
        {
            this.InitializeComponent();
            this.Text = filePath;
            this.path = filePath;
        }

        private static string ComputeWithDispose(HashAlgorithm crypt, string path)
        {
            var result = new StringBuilder(128);
            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (crypt)
            {
                var hash = crypt.ComputeHash(stream);
                foreach (var x in hash)
                {
                    result.Append(x.ToString("x2"));
                }
            }

            return result.ToString();
        }

        private static void SetHashValueWithDispose(TextBox target, Button nextButton, HashAlgorithm crypt, string path)
        {
            try
            {
                target.Text = ComputeWithDispose(crypt, path);
                nextButton.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                target.Text = string.Empty;
            }
        }

        private static void SetClipboard(TextBox target)
        {
            try
            {
                if (!string.IsNullOrEmpty(target.Text))
                {
                    Clipboard.SetText(target.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMD5_Click(object sender, EventArgs e)
        {
            SetHashValueWithDispose(this.txtMD5, this.btnCopyMD5, MD5.Create(), this.path);
        }

        private void btnSHA1_Click(object sender, EventArgs e)
        {
            SetHashValueWithDispose(this.txtSHA1, this.btnCopySHA1, SHA1.Create(), this.path);
        }

        private void btnSHA256_Click(object sender, EventArgs e)
        {
            SetHashValueWithDispose(this.txtSHA256, this.btnCopySHA256, SHA256.Create(), this.path);
        }

        private void btnSHA384_Click(object sender, EventArgs e)
        {
            SetHashValueWithDispose(this.txtSHA384, this.btnCopySHA384, SHA384.Create(), this.path);
        }

        private void btnSHA512_Click(object sender, EventArgs e)
        {
            SetHashValueWithDispose(this.txtSHA512, this.btnCopySHA512, SHA512.Create(), this.path);
        }

        private void btnCopyMD5_Click(object sender, EventArgs e)
        {
            SetClipboard(this.txtMD5);
        }

        private void btnCopySHA1_Click(object sender, EventArgs e)
        {
            SetClipboard(this.txtSHA1);
        }

        private void btnCopySHA256_Click(object sender, EventArgs e)
        {
            SetClipboard(this.txtSHA256);
        }

        private void btnCopySHA384_Click(object sender, EventArgs e)
        {
            SetClipboard(this.txtSHA384);
        }

        private void btnCopySHA512_Click(object sender, EventArgs e)
        {
            SetClipboard(this.txtSHA512);
        }
    }
}
