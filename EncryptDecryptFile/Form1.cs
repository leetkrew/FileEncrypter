using EncryptDecryptFile.Properties;
using EncryptDecryptLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptDecryptFile
{
    public partial class Form1 : Form
    {
        securityHelper sec = new securityHelper();

        private void EnableDisableControls (bool toggle)
        {
            if (toggle)
            {
                lblStatus.Text = "Ready";

            }
            tabControl1.Enabled = toggle;
            lblStatus.Enabled = true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            btnDisclaimer.Text = "THIS PROGRAM HAS BEEN PROVIDED AS-IS WHERE-IS WITHOUT ANY WARRANTY\n\nTHE USER (YOU) AGREES TO USE THIS PROGRAM AT HIS/HER OWN RISK. THE USER AGREES THAT THE AUTHOR OF THIS PROGRAM (RJ REGALADO) WILL NOT BE HELD LIABLE FOR ANY LOSS AND DAMAGES ON THE USER\'S COMPUTER.\n\nCLICK HERE TO CONTINUE";
            
            tabControl1.Visible = false;
            this.Text = Resources.FormCaption;

            txtPublicKeyFile.Text = Settings.Default.publicKeyFile;
            txtInputFile.Text = Settings.Default.inputFile;
            txtPrivateKeyFile.Text = Settings.Default.privateKeyFile;
            txtEncryptedFile.Text = Settings.Default.encryptedFile;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                EnableDisableControls(false);
                if (
                    (!File.Exists(txtPublicKeyFile.Text))
                    || (!File.Exists(txtInputFile.Text))
                    )
                {
                    throw new Exception("File not found, please check your file and try again!");
                }

                if (File.Exists(string.Format("{0}.encrypted", txtInputFile.Text)))
                {
                    var res = MessageBox.Show("Overwrite Existing File?", Resources.FormCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.No)
                    {
                        EnableDisableControls(true);
                        return;
                    }
                }

                
                BackgroundWorker bw = new BackgroundWorker();
                bw.WorkerReportsProgress = true;
                bw.DoWork += new DoWorkEventHandler(
                delegate (object o, DoWorkEventArgs args)
                {
                    bw.ReportProgress(0, "Reading...");
                    byte[] fileBytes = File.ReadAllBytes(txtInputFile.Text);

                    bw.ReportProgress(0, "Preparing Encrypted File...");
                    string encryptedFileB64 = sec.Encrypt(Convert.ToBase64String(fileBytes), txtPublicKeyFile.Text);

                    bw.ReportProgress(0, "Generating Bytes...");
                    byte[] encryptedFileBytes = Convert.FromBase64String(encryptedFileB64);

                    bw.ReportProgress(0, "Writing...");
                    File.WriteAllBytes(string.Format("{0}.encrypted", txtInputFile.Text), encryptedFileBytes);

                    bw.ReportProgress(0, "Cleaning up...");
                    fileBytes = null;
                    encryptedFileB64 = null;
                    encryptedFileBytes = null;
                });

                bw.ProgressChanged += new ProgressChangedEventHandler(delegate (object o, ProgressChangedEventArgs args)
                {
                    lblStatus.Text = args.UserState.ToString();
                });

                bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
                delegate (object o, RunWorkerCompletedEventArgs args)
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.Message, Resources.FormCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Completed", Resources.FormCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    EnableDisableControls(true);
                });

                bw.RunWorkerAsync();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.FormCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableDisableControls(true);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                EnableDisableControls(false);

                if (
                        (!File.Exists(txtPublicKeyFile.Text))
                        || (!File.Exists(txtInputFile.Text))
                        )
                {
                    throw new Exception("File not found, please check your file and try again!");
                }

                if (File.Exists(string.Format("{0}.encrypted", txtInputFile.Text)))
                {
                    var res = MessageBox.Show("Overwrite Existing File?", Resources.FormCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.No)
                    {
                        EnableDisableControls(true);
                        return;
                    }
                }

                BackgroundWorker bw = new BackgroundWorker();
                bw.WorkerReportsProgress = true;
                bw.DoWork += new DoWorkEventHandler(
                delegate (object o, DoWorkEventArgs args)
                {
                    bw.ReportProgress(0, "Reading Encrypted File...");
                    byte[] encryptedFileBytes = File.ReadAllBytes(txtEncryptedFile.Text);


                    bw.ReportProgress(0, "Gathering Data...");
                    string encryptedFileB64 = Convert.ToBase64String(encryptedFileBytes);

                    bw.ReportProgress(0, "Decrypting Encrypted File...");
                    var decryptedFileB64 = sec.Decrypt(encryptedFileB64, txtPassPhrase.Text, txtPrivateKeyFile.Text);

                    bw.ReportProgress(0, "Generating Bytes...");
                    byte[] decryptedFileBytes = Convert.FromBase64String(decryptedFileB64);

                    bw.ReportProgress(0, "Writing...");
                    File.WriteAllBytes(txtEncryptedFile.Text.Substring(0, txtEncryptedFile.Text.Length - 10), decryptedFileBytes);

                    bw.ReportProgress(0, "Cleaning up...");
                    encryptedFileBytes = null;
                    encryptedFileB64 = null;
                    decryptedFileB64 = null;
                    decryptedFileBytes = null;

                });

                bw.ProgressChanged += new ProgressChangedEventHandler(delegate (object o, ProgressChangedEventArgs args)
                {
                    lblStatus.Text = args.UserState.ToString();
                });

                bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
                delegate (object o, RunWorkerCompletedEventArgs args)
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.Message, Resources.FormCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Completed", Resources.FormCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    EnableDisableControls(true);
                });

                bw.RunWorkerAsync();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.FormCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableDisableControls(true);
            }
        }

        private void btnPublicKeyBrowse_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Path.GetDirectoryName(Properties.Settings.Default.publicKeyFile);
            openFileDialog1.Filter = "Privacy Enhanced Mail (*.pem)|*.pem";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            txtPublicKeyFile.Text = openFileDialog1.FileName;
                            Properties.Settings.Default.publicKeyFile = openFileDialog1.FileName;
                            Properties.Settings.Default.Save();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void btnBrowseInputFile_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Path.GetDirectoryName(Settings.Default.inputFile);
            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            txtInputFile.Text = openFileDialog1.FileName;
                            Settings.Default.inputFile = openFileDialog1.FileName;
                            Settings.Default.Save();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void btnBrowsePrivateKey_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Path.GetDirectoryName(Settings.Default.privateKeyFile);
            openFileDialog1.Filter = "Privacy Enhanced Mail (*.pem)|*.pem";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            txtPrivateKeyFile.Text = openFileDialog1.FileName;
                            Settings.Default.privateKeyFile = openFileDialog1.FileName;
                            Settings.Default.Save();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void btnBrowseEncryptedFile_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Path.GetDirectoryName(Settings.Default.encryptedFile);
            openFileDialog1.Filter = "Encrypted File (*.encrypted)|*.encrypted";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            txtEncryptedFile.Text = openFileDialog1.FileName;
                            Settings.Default.encryptedFile = openFileDialog1.FileName;
                            Settings.Default.Save();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        

        private void btnDisclaimer_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            btnDisclaimer.Visible = false;
        }
    }
}
