using System;
using System.Windows.Forms;

namespace SyncClient
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Equals(""))
            {
                MessageBox.Show("Enter a Number");
            }
            else
            {
                ServiceReference.Service1Client Proxy = new ServiceReference.Service1Client();
                MessageBox.Show(Proxy.NumberToWords(int.Parse(textBox.Text)).ToString());
            }
        }
    }
}