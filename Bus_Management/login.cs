using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Management
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                menu menu = new menu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password is wrong!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
