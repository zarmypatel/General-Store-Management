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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            string pass = textBox1.Text;
            if(name == "user1" && pass=="user1")
            {
                this.Hide();
                Home f2 = new Home();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Credentials! Try again!");
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration f2 = new Registration();
            f2.ShowDialog();
        }
    }
}
