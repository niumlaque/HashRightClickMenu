namespace HashRightClickMenu
{
    partial class HashForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMD5 = new System.Windows.Forms.TextBox();
            this.btnMD5 = new System.Windows.Forms.Button();
            this.btnSHA1 = new System.Windows.Forms.Button();
            this.txtSHA1 = new System.Windows.Forms.TextBox();
            this.btnSHA256 = new System.Windows.Forms.Button();
            this.txtSHA256 = new System.Windows.Forms.TextBox();
            this.btnSHA384 = new System.Windows.Forms.Button();
            this.txtSHA384 = new System.Windows.Forms.TextBox();
            this.btnSHA512 = new System.Windows.Forms.Button();
            this.txtSHA512 = new System.Windows.Forms.TextBox();
            this.btnCopyMD5 = new System.Windows.Forms.Button();
            this.btnCopySHA1 = new System.Windows.Forms.Button();
            this.btnCopySHA256 = new System.Windows.Forms.Button();
            this.btnCopySHA384 = new System.Windows.Forms.Button();
            this.btnCopySHA512 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMD5
            // 
            this.txtMD5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMD5.Location = new System.Drawing.Point(93, 14);
            this.txtMD5.Name = "txtMD5";
            this.txtMD5.ReadOnly = true;
            this.txtMD5.Size = new System.Drawing.Size(454, 19);
            this.txtMD5.TabIndex = 10;
            this.txtMD5.TabStop = false;
            // 
            // btnMD5
            // 
            this.btnMD5.Location = new System.Drawing.Point(12, 12);
            this.btnMD5.Name = "btnMD5";
            this.btnMD5.Size = new System.Drawing.Size(75, 23);
            this.btnMD5.TabIndex = 0;
            this.btnMD5.Text = "MD5";
            this.btnMD5.UseVisualStyleBackColor = true;
            this.btnMD5.Click += new System.EventHandler(this.btnMD5_Click);
            // 
            // btnSHA1
            // 
            this.btnSHA1.Location = new System.Drawing.Point(12, 41);
            this.btnSHA1.Name = "btnSHA1";
            this.btnSHA1.Size = new System.Drawing.Size(75, 23);
            this.btnSHA1.TabIndex = 1;
            this.btnSHA1.Text = "SHA1";
            this.btnSHA1.UseVisualStyleBackColor = true;
            this.btnSHA1.Click += new System.EventHandler(this.btnSHA1_Click);
            // 
            // txtSHA1
            // 
            this.txtSHA1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSHA1.Location = new System.Drawing.Point(93, 43);
            this.txtSHA1.Name = "txtSHA1";
            this.txtSHA1.ReadOnly = true;
            this.txtSHA1.Size = new System.Drawing.Size(454, 19);
            this.txtSHA1.TabIndex = 11;
            this.txtSHA1.TabStop = false;
            // 
            // btnSHA256
            // 
            this.btnSHA256.Location = new System.Drawing.Point(12, 70);
            this.btnSHA256.Name = "btnSHA256";
            this.btnSHA256.Size = new System.Drawing.Size(75, 23);
            this.btnSHA256.TabIndex = 2;
            this.btnSHA256.Text = "SHA256";
            this.btnSHA256.UseVisualStyleBackColor = true;
            this.btnSHA256.Click += new System.EventHandler(this.btnSHA256_Click);
            // 
            // txtSHA256
            // 
            this.txtSHA256.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSHA256.Location = new System.Drawing.Point(93, 72);
            this.txtSHA256.Name = "txtSHA256";
            this.txtSHA256.ReadOnly = true;
            this.txtSHA256.Size = new System.Drawing.Size(454, 19);
            this.txtSHA256.TabIndex = 12;
            this.txtSHA256.TabStop = false;
            // 
            // btnSHA384
            // 
            this.btnSHA384.Location = new System.Drawing.Point(12, 99);
            this.btnSHA384.Name = "btnSHA384";
            this.btnSHA384.Size = new System.Drawing.Size(75, 23);
            this.btnSHA384.TabIndex = 3;
            this.btnSHA384.Text = "SHA384";
            this.btnSHA384.UseVisualStyleBackColor = true;
            this.btnSHA384.Click += new System.EventHandler(this.btnSHA384_Click);
            // 
            // txtSHA384
            // 
            this.txtSHA384.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSHA384.Location = new System.Drawing.Point(93, 101);
            this.txtSHA384.Name = "txtSHA384";
            this.txtSHA384.ReadOnly = true;
            this.txtSHA384.Size = new System.Drawing.Size(454, 19);
            this.txtSHA384.TabIndex = 13;
            this.txtSHA384.TabStop = false;
            // 
            // btnSHA512
            // 
            this.btnSHA512.Location = new System.Drawing.Point(12, 128);
            this.btnSHA512.Name = "btnSHA512";
            this.btnSHA512.Size = new System.Drawing.Size(75, 23);
            this.btnSHA512.TabIndex = 4;
            this.btnSHA512.Text = "SHA512";
            this.btnSHA512.UseVisualStyleBackColor = true;
            this.btnSHA512.Click += new System.EventHandler(this.btnSHA512_Click);
            // 
            // txtSHA512
            // 
            this.txtSHA512.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSHA512.Location = new System.Drawing.Point(93, 130);
            this.txtSHA512.Name = "txtSHA512";
            this.txtSHA512.ReadOnly = true;
            this.txtSHA512.Size = new System.Drawing.Size(454, 19);
            this.txtSHA512.TabIndex = 14;
            this.txtSHA512.TabStop = false;
            // 
            // btnCopyMD5
            // 
            this.btnCopyMD5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyMD5.Location = new System.Drawing.Point(557, 12);
            this.btnCopyMD5.Name = "btnCopyMD5";
            this.btnCopyMD5.Size = new System.Drawing.Size(75, 23);
            this.btnCopyMD5.TabIndex = 5;
            this.btnCopyMD5.Text = "Copy";
            this.btnCopyMD5.UseVisualStyleBackColor = true;
            this.btnCopyMD5.Click += new System.EventHandler(this.btnCopyMD5_Click);
            // 
            // btnCopySHA1
            // 
            this.btnCopySHA1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopySHA1.Location = new System.Drawing.Point(557, 41);
            this.btnCopySHA1.Name = "btnCopySHA1";
            this.btnCopySHA1.Size = new System.Drawing.Size(75, 23);
            this.btnCopySHA1.TabIndex = 6;
            this.btnCopySHA1.Text = "Copy";
            this.btnCopySHA1.UseVisualStyleBackColor = true;
            this.btnCopySHA1.Click += new System.EventHandler(this.btnCopySHA1_Click);
            // 
            // btnCopySHA256
            // 
            this.btnCopySHA256.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopySHA256.Location = new System.Drawing.Point(557, 70);
            this.btnCopySHA256.Name = "btnCopySHA256";
            this.btnCopySHA256.Size = new System.Drawing.Size(75, 23);
            this.btnCopySHA256.TabIndex = 7;
            this.btnCopySHA256.Text = "Copy";
            this.btnCopySHA256.UseVisualStyleBackColor = true;
            this.btnCopySHA256.Click += new System.EventHandler(this.btnCopySHA256_Click);
            // 
            // btnCopySHA384
            // 
            this.btnCopySHA384.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopySHA384.Location = new System.Drawing.Point(557, 99);
            this.btnCopySHA384.Name = "btnCopySHA384";
            this.btnCopySHA384.Size = new System.Drawing.Size(75, 23);
            this.btnCopySHA384.TabIndex = 8;
            this.btnCopySHA384.Text = "Copy";
            this.btnCopySHA384.UseVisualStyleBackColor = true;
            this.btnCopySHA384.Click += new System.EventHandler(this.btnCopySHA384_Click);
            // 
            // btnCopySHA512
            // 
            this.btnCopySHA512.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopySHA512.Location = new System.Drawing.Point(557, 128);
            this.btnCopySHA512.Name = "btnCopySHA512";
            this.btnCopySHA512.Size = new System.Drawing.Size(75, 23);
            this.btnCopySHA512.TabIndex = 9;
            this.btnCopySHA512.Text = "Copy";
            this.btnCopySHA512.UseVisualStyleBackColor = true;
            this.btnCopySHA512.Click += new System.EventHandler(this.btnCopySHA512_Click);
            // 
            // HashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 168);
            this.Controls.Add(this.btnCopySHA512);
            this.Controls.Add(this.btnCopySHA384);
            this.Controls.Add(this.btnCopySHA256);
            this.Controls.Add(this.btnCopySHA1);
            this.Controls.Add(this.btnCopyMD5);
            this.Controls.Add(this.txtSHA512);
            this.Controls.Add(this.btnSHA512);
            this.Controls.Add(this.txtSHA384);
            this.Controls.Add(this.btnSHA384);
            this.Controls.Add(this.txtSHA256);
            this.Controls.Add(this.btnSHA256);
            this.Controls.Add(this.txtSHA1);
            this.Controls.Add(this.btnSHA1);
            this.Controls.Add(this.btnMD5);
            this.Controls.Add(this.txtMD5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HashForm";
            this.ShowIcon = false;
            this.Text = "HashForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMD5;
        private System.Windows.Forms.Button btnMD5;
        private System.Windows.Forms.Button btnSHA1;
        private System.Windows.Forms.TextBox txtSHA1;
        private System.Windows.Forms.Button btnSHA256;
        private System.Windows.Forms.TextBox txtSHA256;
        private System.Windows.Forms.Button btnSHA384;
        private System.Windows.Forms.TextBox txtSHA384;
        private System.Windows.Forms.Button btnSHA512;
        private System.Windows.Forms.TextBox txtSHA512;
        private System.Windows.Forms.Button btnCopyMD5;
        private System.Windows.Forms.Button btnCopySHA1;
        private System.Windows.Forms.Button btnCopySHA256;
        private System.Windows.Forms.Button btnCopySHA384;
        private System.Windows.Forms.Button btnCopySHA512;
    }
}