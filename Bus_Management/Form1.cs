using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;


namespace Bus_Management
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            busses busses = new busses();
            busses.Show();
            this.Hide();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            passengers passengers = new passengers();
            passengers.Show();
            this.Hide();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Drivers Drivers = new Drivers();
            Drivers.Show();
            this.Hide();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            schedule schedule = new schedule();
            schedule.Show();
            this.Hide();
        }

    }
}