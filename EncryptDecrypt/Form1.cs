using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptDecrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (optEncrypt.Checked == true)
            {
                if (txtEncryptText.Text != "" && txtPassKey.Text != "")
                {
                    txtResult.Text = EncryptDecryptHelper.EncryptString(txtEncryptText.Text, txtPassKey.Text);
                }
                else
                    MessageBox.Show("Please enter text that will encrypted and passkey!");
            }
            else
            {
                if (txtResult.Text != "" && txtPassKey.Text != "")
                {
                    try
                    {
                        txtEncryptText.Text = EncryptDecryptHelper.DecryptString(txtResult.Text, txtPassKey.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Your passkey is not correct!");
                    }
                    
                }
                else
                    MessageBox.Show("Please enter text that will decrypted and passkey!");
            }
        }

        private void optEncrypt_MouseClick(object sender, MouseEventArgs e)
        {
            txtResult.Text = "";
            txtResult.ReadOnly = true;
            txtEncryptText.ReadOnly = false;
        }

        private void optDecrypt_MouseClick(object sender, MouseEventArgs e)
        {
            txtEncryptText.Text = "";
            txtResult.ReadOnly = false;
            txtEncryptText.ReadOnly = true;
        }
    }
}
