using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Security.Cryptography;




namespace email
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.button1.Click += new System.EventHandler(this.button1_Click);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                MailMessage msg = new MailMessage();
                SmtpClient client = new SmtpClient();
                msg.From = new MailAddress("cryptocloudsneha0109@gmail.com");
                msg.To.Add(new MailAddress("abc@gmail.com"));
                msg.Subject = subject.Text;
                msg.Body = richTextBox1.Text;
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("cryptocloudsneha0109@gmail.com", "cryptocloud0109");
               
                client.Send(msg);
                MessageBox.Show("message sent");



             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}