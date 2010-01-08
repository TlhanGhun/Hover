using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using hover;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace hover
{
    public partial class Options : Form
    {


        public Options()
        {
            InitializeComponent();

            ServicePointManager.ServerCertificateValidationCallback += delegate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
            {
              return true;
            };

            this.textBox_password.Text = Crypto.ToInsecureString(Crypto.DecryptString(Properties.Settings.Default.password));
            this.numericUpDown_mailServerPort.Value = Properties.Settings.Default.mailServerPort;
        }

        private bool bla()
        {
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();



            this.Close();
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.password = Crypto.EncryptString(Crypto.ToSecureString(this.textBox_password.Text));
        }



        private string replacePlaceholder(string toBeWorkedOnText)
        {
            toBeWorkedOnText = toBeWorkedOnText.Replace("%title%", "TITLE PLACEHODLER");
            return toBeWorkedOnText.Replace("%text%", "TEXT PLACEHOLDER");
        }

        private void numericUpDown_mailServerPort_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.mailServerPort = Convert.ToInt32(this.numericUpDown_mailServerPort.Value);

        }

        private void button_testMail_Click(object sender, EventArgs e)
        {
      
         }



    }
}
