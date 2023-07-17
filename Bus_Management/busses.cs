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
    public partial class busses : Form
    {
        public busses()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source = ADN1;Initial Catalog=busdata;Integrated Security=true");


        private void button1_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Hide();
        }

        private void busses_Load(object sender, EventArgs e)
        {
            con.Open();
            listView1.Items.Clear();
            SqlCommand komut = new SqlCommand("SELECT b.bus_nu, s.start_location, s.end_location, s.start_time, s.end_time, d.driver_name FROM bus b INNER JOIN schedule s ON b.schedule_id = s.schedule_id INNER JOIN driver d ON b.driver_id = d.driver_id ORDER BY b.bus_nu ASC", con);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["bus_nu"].ToString();
                ekle.SubItems.Add(oku["start_location"].ToString());
                ekle.SubItems.Add(oku["end_location"].ToString());
                ekle.SubItems.Add(oku["start_time"].ToString());
                ekle.SubItems.Add(oku["end_time"].ToString());
                ekle.SubItems.Add(oku["driver_name"].ToString());

                listView1.Items.Add(ekle);
            }


            con.Close();
            con.Open();
            SqlCommand komut2 = new SqlCommand("SELECT d.driver_name FROM driver d WHERE NOT EXISTS (SELECT 1 FROM bus b WHERE b.driver_id = d.driver_id)", con);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                List<string> driverNames = new List<string>();
                driverNames.Add(oku2["driver_name"].ToString());
                driverNameComboBox.Items.AddRange(driverNames.ToArray());
            }

            con.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string startLocation = startLocationTextBox.Text;
            string endLocation = endLocationTextBox.Text;
            string startTime = startTimeTextBox.Text;
            string endTime = endTimeTextBox.Text;
            string busNumber = busNumberTextBox.Text;
            string driverName = driverNameComboBox.SelectedItem?.ToString();

            // Check: No input field should be empty
            if (string.IsNullOrEmpty(startLocation) || string.IsNullOrEmpty(endLocation) || string.IsNullOrEmpty(startTime) ||
                string.IsNullOrEmpty(endTime) || string.IsNullOrEmpty(busNumber) || string.IsNullOrEmpty(driverName))
            {
                MessageBox.Show("Please fill in all input fields.");
                return; // Exit the function
            }

            // Open the database connection
            con.Open();

            // Generate a unique value for the schedule_id
            SqlCommand cmd1 = new SqlCommand("SELECT MAX(schedule_id) FROM schedule", con);
            int scheduleId = Convert.ToInt32(cmd1.ExecuteScalar()) + 1;

            // Create the INSERT command
            SqlCommand cmd2 = new SqlCommand("INSERT INTO schedule (schedule_id, start_location, end_location, start_time, end_time) VALUES (@scheduleId, @startLocation, @endLocation, @startTime, @endTime)", con);
            cmd2.Parameters.AddWithValue("@scheduleId", scheduleId);
            cmd2.Parameters.AddWithValue("@startLocation", startLocation);
            cmd2.Parameters.AddWithValue("@endLocation", endLocation);
            cmd2.Parameters.AddWithValue("@startTime", startTime);
            cmd2.Parameters.AddWithValue("@endTime", endTime);

            // Execute the INSERT command for the schedule table
            cmd2.ExecuteNonQuery();

            // Get the next available bus ID
            SqlCommand cmd3 = new SqlCommand("SELECT MAX(bus_id) FROM bus", con);
            int busID = Convert.ToInt32(cmd3.ExecuteScalar()) + 1;

            SqlCommand cmd4 = new SqlCommand("SELECT driver_id FROM driver WHERE driver_name = @driverName", con);
            cmd4.Parameters.AddWithValue("@driverName", driverName);
            int driverId = (int)cmd4.ExecuteScalar();

            // Check if the bus number already exists
            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM bus WHERE bus_nu = @busNumber", con);
            checkCmd.Parameters.AddWithValue("@busNumber", busNumber);
            int busCount = Convert.ToInt32(checkCmd.ExecuteScalar());

            if (busCount > 0)
            {
                MessageBox.Show("A bus with the same bus number already exists.");
            }
            else
            {
                // Insert data into the bus table
                SqlCommand busCmd = new SqlCommand("INSERT INTO bus (bus_id, bus_nu, schedule_id, driver_id) VALUES (@busID, @busNumber, @scheduleId, @driverId)", con);
                busCmd.Parameters.AddWithValue("@busID", busID);
                busCmd.Parameters.AddWithValue("@busNumber", busNumber);
                busCmd.Parameters.AddWithValue("@scheduleId", scheduleId);
                busCmd.Parameters.AddWithValue("@driverId", driverId);

                try
                {
                    busCmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding the bus to the database. " + ex.Message);
                }
            }

            listView1.Items.Clear();
            SqlCommand komut = new SqlCommand("SELECT b.bus_nu, s.start_location, s.end_location, s.start_time, s.end_time, d.driver_name FROM bus b INNER JOIN schedule s ON b.schedule_id = s.schedule_id INNER JOIN driver d ON b.driver_id = d.driver_id ORDER BY b.bus_nu ASC", con);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["bus_nu"].ToString();
                ekle.SubItems.Add(oku["start_location"].ToString());
                ekle.SubItems.Add(oku["end_location"].ToString());
                ekle.SubItems.Add(oku["start_time"].ToString());
                ekle.SubItems.Add(oku["end_time"].ToString());
                ekle.SubItems.Add(oku["driver_name"].ToString());

                listView1.Items.Add(ekle);

                startLocationTextBox.Text = "";
                endLocationTextBox.Text = "";
                startTimeTextBox.Text = "";
                endTimeTextBox.Text = "";
                busNumberTextBox.Text = "";
                driverNameComboBox.SelectedItem = null;
            }

            // Close the database connection
            con.Close();
            con.Open();
            driverNameComboBox.Items.Clear();
            SqlCommand komut2 = new SqlCommand("SELECT d.driver_name FROM driver d WHERE NOT EXISTS (SELECT 1 FROM bus b WHERE b.driver_id = d.driver_id)", con);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                List<string> driverNames = new List<string>();
                driverNames.Add(oku2["driver_name"].ToString());
                driverNameComboBox.Items.AddRange(driverNames.ToArray());
            }

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string busNumber = selectedItem.SubItems[0].Text;

                try
                {
                    // Open the database connection
                    con.Open();

                    // Create the DELETE command
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM bus WHERE bus_nu = @busNumber", con))
                    {
                        cmd.Parameters.AddWithValue("@busNumber", busNumber);

                        // Execute the command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if the record was successfully deleted
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("The bus '" + busNumber + "' has been deleted.");

                            listView1.Items.Clear();

                            using (SqlCommand komut = new SqlCommand("SELECT b.bus_nu, s.start_location, s.end_location, s.start_time, s.end_time, d.driver_name FROM bus b INNER JOIN schedule s ON b.schedule_id = s.schedule_id INNER JOIN driver d ON b.driver_id = d.driver_id ORDER BY b.bus_nu ASC", con))
                            {
                                using (SqlDataReader oku = komut.ExecuteReader())
                                {
                                    while (oku.Read())
                                    {
                                        ListViewItem ekle = new ListViewItem();
                                        ekle.Text = oku["bus_nu"].ToString();
                                        ekle.SubItems.Add(oku["start_location"].ToString());
                                        ekle.SubItems.Add(oku["end_location"].ToString());
                                        ekle.SubItems.Add(oku["start_time"].ToString());
                                        ekle.SubItems.Add(oku["end_time"].ToString());
                                        ekle.SubItems.Add(oku["driver_name"].ToString());

                                        listView1.Items.Add(ekle);
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error deleting the bus '" + busNumber + "' from the database.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    // Close the database connection
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a bus to delete from the list.");
            }
            con.Open();
            driverNameComboBox.Items.Clear();
            SqlCommand komut2 = new SqlCommand("SELECT d.driver_name FROM driver d WHERE NOT EXISTS (SELECT 1 FROM bus b WHERE b.driver_id = d.driver_id)", con);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                List<string> driverNames = new List<string>();
                driverNames.Add(oku2["driver_name"].ToString());
                driverNameComboBox.Items.AddRange(driverNames.ToArray());
            }

            con.Close();
        }
    }
}