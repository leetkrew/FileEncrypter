namespace EncryptDecryptFile
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBrowseInputFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPublicKeyBrowse = new System.Windows.Forms.Button();
            this.txtPublicKeyFile = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnBrowseEncryptedFile = new System.Windows.Forms.Button();
            this.btnBrowsePrivateKey = new System.Windows.Forms.Button();
            this.txtEncryptedFile = new System.Windows.Forms.TextBox();
            this.txtPassPhrase = new System.Windows.Forms.TextBox();
            this.txtPrivateKeyFile = new System.Windows.Forms.TextBox();
            this.btnDisclaimer = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 213);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 17);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "Ready";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(10, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(683, 198);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBrowseInputFile);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnPublicKeyBrowse);
            this.tabPage1.Controls.Add(this.txtPublicKeyFile);
            this.tabPage1.Controls.Add(this.btnEncrypt);
            this.tabPage1.Controls.Add(this.txtInputFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(675, 169);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encrypt File";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBrowseInputFile
            // 
            this.btnBrowseInputFile.Location = new System.Drawing.Point(569, 90);
            this.btnBrowseInputFile.Name = "btnBrowseInputFile";
            this.btnBrowseInputFile.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseInputFile.TabIndex = 23;
            this.btnBrowseInputFile.Text = "Browse";
            this.btnBrowseInputFile.UseVisualStyleBackColor = true;
            this.btnBrowseInputFile.Click += new System.EventHandler(this.btnBrowseInputFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Public Key";
            // 
            // btnPublicKeyBrowse
            // 
            this.btnPublicKeyBrowse.Location = new System.Drawing.Point(569, 39);
            this.btnPublicKeyBrowse.Name = "btnPublicKeyBrowse";
            this.btnPublicKeyBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnPublicKeyBrowse.TabIndex = 20;
            this.btnPublicKeyBrowse.Text = "Browse";
            this.btnPublicKeyBrowse.UseVisualStyleBackColor = true;
            this.btnPublicKeyBrowse.Click += new System.EventHandler(this.btnPublicKeyBrowse_Click);
            // 
            // txtPublicKeyFile
            // 
            this.txtPublicKeyFile.Location = new System.Drawing.Point(23, 39);
            this.txtPublicKeyFile.Name = "txtPublicKeyFile";
            this.txtPublicKeyFile.ReadOnly = true;
            this.txtPublicKeyFile.Size = new System.Drawing.Size(540, 22);
            this.txtPublicKeyFile.TabIndex = 19;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(569, 119);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 18;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtInputFile
            // 
            this.txtInputFile.Location = new System.Drawing.Point(23, 90);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.ReadOnly = true;
            this.txtInputFile.Size = new System.Drawing.Size(540, 22);
            this.txtInputFile.TabIndex = 17;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnDecrypt);
            this.tabPage2.Controls.Add(this.btnBrowseEncryptedFile);
            this.tabPage2.Controls.Add(this.btnBrowsePrivateKey);
            this.tabPage2.Controls.Add(this.txtEncryptedFile);
            this.tabPage2.Controls.Add(this.txtPassPhrase);
            this.tabPage2.Controls.Add(this.txtPrivateKeyFile);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(675, 169);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decrypt File";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Enccrypted File";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Private Key";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(569, 119);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 21;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnBrowseEncryptedFile
            // 
            this.btnBrowseEncryptedFile.Location = new System.Drawing.Point(569, 90);
            this.btnBrowseEncryptedFile.Name = "btnBrowseEncryptedFile";
            this.btnBrowseEncryptedFile.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseEncryptedFile.TabIndex = 20;
            this.btnBrowseEncryptedFile.Text = "Browse";
            this.btnBrowseEncryptedFile.UseVisualStyleBackColor = true;
            this.btnBrowseEncryptedFile.Click += new System.EventHandler(this.btnBrowseEncryptedFile_Click);
            // 
            // btnBrowsePrivateKey
            // 
            this.btnBrowsePrivateKey.Location = new System.Drawing.Point(569, 39);
            this.btnBrowsePrivateKey.Name = "btnBrowsePrivateKey";
            this.btnBrowsePrivateKey.Size = new System.Drawing.Size(75, 23);
            this.btnBrowsePrivateKey.TabIndex = 19;
            this.btnBrowsePrivateKey.Text = "Browse";
            this.btnBrowsePrivateKey.UseVisualStyleBackColor = true;
            this.btnBrowsePrivateKey.Click += new System.EventHandler(this.btnBrowsePrivateKey_Click);
            // 
            // txtEncryptedFile
            // 
            this.txtEncryptedFile.Location = new System.Drawing.Point(23, 90);
            this.txtEncryptedFile.Name = "txtEncryptedFile";
            this.txtEncryptedFile.ReadOnly = true;
            this.txtEncryptedFile.Size = new System.Drawing.Size(540, 22);
            this.txtEncryptedFile.TabIndex = 18;
            // 
            // txtPassPhrase
            // 
            this.txtPassPhrase.Location = new System.Drawing.Point(468, 39);
            this.txtPassPhrase.Name = "txtPassPhrase";
            this.txtPassPhrase.PasswordChar = '*';
            this.txtPassPhrase.Size = new System.Drawing.Size(95, 22);
            this.txtPassPhrase.TabIndex = 17;
            // 
            // txtPrivateKeyFile
            // 
            this.txtPrivateKeyFile.Location = new System.Drawing.Point(23, 39);
            this.txtPrivateKeyFile.Name = "txtPrivateKeyFile";
            this.txtPrivateKeyFile.ReadOnly = true;
            this.txtPrivateKeyFile.Size = new System.Drawing.Size(439, 22);
            this.txtPrivateKeyFile.TabIndex = 16;
            // 
            // btnDisclaimer
            // 
            this.btnDisclaimer.Location = new System.Drawing.Point(14, 12);
            this.btnDisclaimer.Name = "btnDisclaimer";
            this.btnDisclaimer.Size = new System.Drawing.Size(675, 198);
            this.btnDisclaimer.TabIndex = 24;
            this.btnDisclaimer.Text = "button1";
            this.btnDisclaimer.UseVisualStyleBackColor = true;
            this.btnDisclaimer.Click += new System.EventHandler(this.btnDisclaimer_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(675, 169);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(459, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "File Decrypter by RJ Regalado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(527, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "www.rjregalado.com";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(459, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "This program uses library from";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(449, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Legion of the Bouncy Castle Inc.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(562, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 30;
            this.label9.Text = "Bouncy Castle";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(288, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "openssl genrsa -des3 -out private.pem 2048";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(365, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Use the following commands to Generate PEM certificate";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(423, 17);
            this.label13.TabIndex = 34;
            this.label13.Text = "openssl rsa -in private.pem -outform PEM -pubout -out public.pem";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 237);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnDisclaimer);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnBrowseInputFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPublicKeyBrowse;
        private System.Windows.Forms.TextBox txtPublicKeyFile;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtInputFile;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnBrowseEncryptedFile;
        private System.Windows.Forms.Button btnBrowsePrivateKey;
        private System.Windows.Forms.TextBox txtEncryptedFile;
        private System.Windows.Forms.TextBox txtPassPhrase;
        private System.Windows.Forms.TextBox txtPrivateKeyFile;
        private System.Windows.Forms.Button btnDisclaimer;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

