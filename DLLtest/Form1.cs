using System;
using System.Windows.Forms;

namespace DLLtest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string ip = textBox1.Text;
            textBox2.Text = SuperFreeApi.IPSearch.IPSearch.GetIPregion (ip);
            textBox3.Text = SuperFreeApi.IPSearch.IPSearch.GetIPlatitude(ip);
            textBox4.Text = SuperFreeApi.IPSearch.IPSearch.GetIPlongitude(ip);
            textBox5.Text = SuperFreeApi.IPSearch.IPSearch.GetIPasn(ip);
            textBox6.Text = SuperFreeApi.IPSearch.IPSearch.GetIPLLC(ip);
        }
    }
}