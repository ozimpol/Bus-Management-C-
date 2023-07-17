using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Management
{
    public partial class Drivers : Form
    {
        public Drivers()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source = ADN1;Initial Catalog=busdata;Integrated Security=true");


        private void Drivers_Load(object sender, EventArgs e)
        {
            con.Open();
            listView1.Items.Clear();
            SqlCommand komut = new SqlCommand("select * from driver", con);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["driver_name"].ToString();
                ekle.SubItems.Add(oku["driver_phone"].ToString());
                listView1.Items.Add(ekle);

            }
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Hide();
        }

        private void LoadDataIntoListView()
        {

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM driver", con);

            SqlDataReader reader = cmd.ExecuteReader();

            listView1.Items.Clear();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["driver_name"].ToString());
                item.SubItems.Add(reader["driver_phone"].ToString());
                listView1.Items.Add(item);
            }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string driverName = selectedItem.SubItems[0].Text;

                // Open the database connection
                con.Open();

                // Create the DELETE command
                SqlCommand cmd = new SqlCommand("DELETE FROM driver WHERE driver_name = @driverName", con);
                cmd.Parameters.AddWithValue("@driverName", driverName);

                // Execute the command
                int rowsAffected = cmd.ExecuteNonQuery();

                // Close the database connection
                con.Close();

                // Check if the record was successfully deleted
                if (rowsAffected > 0)
                {
                    MessageBox.Show("The driver '" + driverName + "' has been deleted.");
                    LoadDataIntoListView();
                }
                else
                {
                    MessageBox.Show("Error deleting the driver '" + driverName + "' from the database.");
                }
            }
            else
            {
                MessageBox.Show("Please select a driver to delete from the list.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string driverName = nameTextBox.Text;
            string driverPhone = phoneTextBox.Text;

            // Check: No input field should be empty
            if (string.IsNullOrEmpty(driverName) || string.IsNullOrEmpty(driverPhone))
            {
                MessageBox.Show("Please fill in all input fields.");
                return; // Exit the function
            }

            // Open the database connection
            con.Open();

            // Generate a unique value for the driver_id
            SqlCommand cmd1 = new SqlCommand("SELECT MAX(driver_id) FROM driver", con);
            int driverId = Convert.ToInt32(cmd1.ExecuteScalar()) + 1;

            // Create the INSERT command
            SqlCommand cmd2 = new SqlCommand("INSERT INTO driver (driver_id, driver_name, driver_phone) VALUES (@driverId, @driverName, @driverPhone)", con);
            cmd2.Parameters.AddWithValue("@driverId", driverId);
            cmd2.Parameters.AddWithValue("@driverName", driverName);
            cmd2.Parameters.AddWithValue("@driverPhone", driverPhone);

            // Execute the command
            try
            {
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding the driver '" + driverName + "' to the database. " + ex.Message);
            }

            // Close the database connection
            con.Close();

            // Reload the data into the ListView control
            LoadDataIntoListView();

            // Clear the input fields
            nameTextBox.Text = " ";
            phoneTextBox.Text = " ";
        }

    }
}
