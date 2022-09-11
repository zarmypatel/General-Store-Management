using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Client
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Add_Product f2 = new Add_Product();
            f2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Service1.Service1Client client = new Service1.Service1Client();
            ProductTable.DataSource = client.ShowProductTable();

        }

        private void ProductTabel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home f2 = new Home();
            Service1.Service1Client client = new Service1.Service1Client();
            ProductTable.DataSource = client.ShowProductTable();
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

        private void button7_Click_1(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = ProductTable.DataSource;
            bs.Filter = string.Format("CONVERT(Product_id,System.String) like '{0}%' OR Product_title like '{0}%' OR Product_type like '{0}%' OR Product_descripation like '{0}%'", textBox1.Text.ToString());
            ProductTable.DataSource = bs;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
