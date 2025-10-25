using System;
using System.Windows.Forms;

namespace ASyncClient
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
                Proxy.NumberToWordsCompleted += new EventHandler<ServiceReference.NumberToWordsCompletedEventArgs>(saveResult);
                Proxy.NumberToWordsAsync(int.Parse(textBox.Text));
            }
        }
        static void saveResult(object sender, ServiceReference.NumberToWordsCompletedEventArgs e)
        {
            System.IO.File.WriteAllText("C:\\Users\\hamed\\Desktop\\Output.txt", e.Result.ToString());
        }
    }
}