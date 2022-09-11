using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Add_Product : Form
    {
        public Add_Product()
        {
            InitializeComponent();
        }

        private void Add_Product_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Service1.Service1Client client = new Service1.Service1Client();
            string msg=client.InsertProduct(textBox2.Text, textBox1.Text, richTextBox1.Text);
            label4.Text = msg;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home f2 = new Home();
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Product f2 = new Add_Product();
            f2.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_Product f2 = new Delete_Product();
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Product f2 = new Update_Product();
            f2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide();
            login f2 = new login();
            f2.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            String site = "https://barcode.tec-it.com/en/Code128?data=" + textBox2.Text;
            System.Diagnostics.Process.Start(site);
        }
    }
}
