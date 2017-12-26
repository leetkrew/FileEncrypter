namespace EncryptDecryptText
{
    partial class Form1
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
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.txtPublicKeyFile = new System.Windows.Forms.TextBox();
            this.txtCertificateKey = new System.Windows.Forms.TextBox();
            this.txtEncryptedText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDecryptedText = new System.Windows.Forms.TextBox();
            this.btnPublicKeyBrowse = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtPrivateKeyFile = new System.Windows.Forms.TextBox();
            this.btnPrivateKeyBrowse = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPlainText
            // 
            this.txtPlainText.Location = new System.Drawing.Point(51, 25);
            this.txtPlainText.Multiline = true;
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(572, 76);
            this.txtPlainText.TabIndex = 0;
            // 
            // txtPublicKeyFile
            // 
            this.txtPublicKeyFile.Location = new System.Drawing.Point(51, 124);
            this.txtPublicKeyFile.Name = "txtPublicKeyFile";
            this.txtPublicKeyFile.Size = new System.Drawing.Size(491, 22);
            this.txtPublicKeyFile.TabIndex = 1;
            // 
            // txtCertificateKey
            // 
            this.txtCertificateKey.Location = new System.Drawing.Point(50, 374);
            this.txtCertificateKey.Name = "txtCertificateKey";
            this.txtCertificateKey.Size = new System.Drawing.Size(572, 22);
            this.txtCertificateKey.TabIndex = 2;
            // 
            // txtEncryptedText
            // 
            this.txtEncryptedText.Location = new System.Drawing.Point(51, 196);
            this.txtEncryptedText.Multiline = true;
            this.txtEncryptedText.Name = "txtEncryptedText";
            this.txtEncryptedText.Size = new System.Drawing.Size(572, 98);
            this.txtEncryptedText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Plain Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Public Key File";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Encrypted Text";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Decrypted Text";
            // 
            // txtDecryptedText
            // 
            this.txtDecryptedText.Location = new System.Drawing.Point(50, 455);
            this.txtDecryptedText.Multiline = true;
            this.txtDecryptedText.Name = "txtDecryptedText";
            this.txtDecryptedText.Size = new System.Drawing.Size(572, 94);
            this.txtDecryptedText.TabIndex = 9;
            // 
            // btnPublicKeyBrowse
            // 
            this.btnPublicKeyBrowse.Location = new System.Drawing.Point(548, 123);
            this.btnPublicKeyBrowse.Name = "btnPublicKeyBrowse";
            this.btnPublicKeyBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnPublicKeyBrowse.TabIndex = 10;
            this.btnPublicKeyBrowse.Text = "Browse";
            this.btnPublicKeyBrowse.UseVisualStyleBackColor = true;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(547, 402);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 11;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(547, 167);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 12;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtPrivateKeyFile
            // 
            this.txtPrivateKeyFile.Location = new System.Drawing.Point(50, 326);
            this.txtPrivateKeyFile.Name = "txtPrivateKeyFile";
            this.txtPrivateKeyFile.Size = new System.Drawing.Size(491, 22);
            this.txtPrivateKeyFile.TabIndex = 13;
            // 
            // btnPrivateKeyBrowse
            // 
            this.btnPrivateKeyBrowse.Location = new System.Drawing.Point(548, 325);
            this.btnPrivateKeyBrowse.Name = "btnPrivateKeyBrowse";
            this.btnPrivateKeyBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnPrivateKeyBrowse.TabIndex = 14;
            this.btnPrivateKeyBrowse.Text = "Browse";
            this.btnPrivateKeyBrowse.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Private Key File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 561);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPrivateKeyBrowse);
            this.Controls.Add(this.txtPrivateKeyFile);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnPublicKeyBrowse);
            this.Controls.Add(this.txtDecryptedText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEncryptedText);
            this.Controls.Add(this.txtCertificateKey);
            this.Controls.Add(this.txtPublicKeyFile);
            this.Controls.Add(this.txtPlainText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.TextBox txtPublicKeyFile;
        private System.Windows.Forms.TextBox txtCertificateKey;
        private System.Windows.Forms.TextBox txtEncryptedText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDecryptedText;
        private System.Windows.Forms.Button btnPublicKeyBrowse;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtPrivateKeyFile;
        private System.Windows.Forms.Button btnPrivateKeyBrowse;
        private System.Windows.Forms.Label label6;
    }
}

