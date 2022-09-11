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
    public partial class Delete_Product : Form
    {
        public Delete_Product()
        {
            InitializeComponent();
        }

        private void Delete_Product_Load(object sender, EventArgs e)
        {
            Service1.Service1Client client = new Service1.Service1Client();
            DataTable dt = client.ShowProductTable();
            foreach(DataRow row in dt.Rows)
            {
                string name = row["Product_title"].ToString();
                comboBox1.Items.Add(name);
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Service1.Service1Client client = new Service1.Service1Client();
            string name = comboBox1.Text;

            string msg = client.DeleteProduct(name);
            label2.Text = msg;
            
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = "Result?";
        }
    }
}
