using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptDecryptText
{
    public partial class Form1 : Form
    {
        EncryptDecryptLibrary.securityHelper sec = new EncryptDecryptLibrary.securityHelper();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPlainText.Text = "A quick brown fox jumps over the lazy dog";
            txtPublicKeyFile.Text = @"D:\Profile\Documents\Visual Studio 2017\Projects\EncryptDecryptFile\keys\public.pem";
            txtPrivateKeyFile.Text = @"D:\Profile\Documents\Visual Studio 2017\Projects\EncryptDecryptFile\keys\private.pem";
            txtCertificateKey.Text = "password123";
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            txtEncryptedText.Text = sec.Encrypt(txtPlainText.Text, txtPublicKeyFile.Text);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            txtDecryptedText.Text = sec.Decrypt(txtEncryptedText.Text, txtCertificateKey.Text, txtPrivateKeyFile.Text);
        }
    }
}
