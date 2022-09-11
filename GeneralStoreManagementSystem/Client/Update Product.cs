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
    public partial class Update_Product : Form
    {
        public Update_Product()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = "Result?";
            Service1.Service1Client client = new Service1.Service1Client();
            string name = comboBox1.Text;

            DataTable dt = client.GetProduct(name);
            foreach (DataRow row in dt.Rows)
            {
                string Pname = row["Product_title"].ToString();
                string Ptype = row["Product_type"].ToString();
                string Pdes = row["Product_descripation"].ToString();
                textBox2.Text = Pname;
                textBox1.Text = Ptype;
                richTextBox1.Text = Pdes;
            }

        }

        private void Update_Product_Load(object sender, EventArgs e)
        {
            Service1.Service1Client client = new Service1.Service1Client();
            DataTable dt = client.ShowProductTable();
            foreach (DataRow row in dt.Rows)
            {
                string name = row["Product_title"].ToString();
                comboBox1.Items.Add(name);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Service1.Service1Client client = new Service1.Service1Client();
            string name = comboBox1.Text;
            string title = textBox2.Text;
            string type = textBox1.Text;
            string des = richTextBox1.Text;
            string msg = client.UpdateProduct(name, title, type, des);
            label2.Text = msg;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Product f2 = new Update_Product();
            f2.ShowDialog();
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

        private void button9_Click(object sender, EventArgs e)
        {
            String site = "https://barcode.tec-it.com/en/Code128?data=" + textBox2.Text;
            System.Diagnostics.Process.Start(site);
        }
    }
}
