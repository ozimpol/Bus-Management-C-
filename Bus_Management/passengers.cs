using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Management
{
    public partial class passengers : Form
    {
        public passengers()
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void passengers_Load(object sender, EventArgs e)
        {
            // Open the database connection
            con.Open();

            // Create the SELECT statement
            string selectQuery = "SELECT pass_name, pass_phone, sit_num, bus.bus_nu FROM passenger INNER JOIN bus ON passenger.bus_id = bus.bus_id";

            // Execute the SELECT statement
            SqlCommand cmd = new SqlCommand(selectQuery, con);
            SqlDataReader reader = cmd.ExecuteReader();

            // Clear the list view
            listView1.Items.Clear();

            // Create a list to store the passenger entries
            List<string> passengerEntries = new List<string>();

            // Populate the list and add the data to the list view
            while (reader.Read())
            {
                string passName = reader["pass_name"].ToString();
                string passPhone = reader["pass_phone"].ToString();
                string sitNum = reader["sit_num"].ToString();
                string busNu = reader["bus_nu"].ToString();

                // Create a formatted string for each passenger entry
                string passengerEntry = $"{passName}, {passPhone}, {sitNum}, {busNu}";

                // Add the passenger entry to the list
                passengerEntries.Add(passengerEntry);

                ListViewItem item = new ListViewItem(passName);
                item.SubItems.Add(passPhone);
                item.SubItems.Add(sitNum);
                item.SubItems.Add(busNu);

                listView1.Items.Add(item);
            }

            // Close the database connection
            con.Close();

            // Sort the passenger entries by bus number and sit number
            passengerEntries.Sort((a, b) =>
            {
                string[] aValues = a.Split(',');
                string[] bValues = b.Split(',');

                string aBusNu = aValues[3].Trim();
                string bBusNu = bValues[3].Trim();

                // Sort by bus number first
                int busNuComparison = aBusNu.CompareTo(bBusNu);
                if (busNuComparison != 0)
                    return busNuComparison;

                string aSitNum = aValues[2].Trim();
                string bSitNum = bValues[2].Trim();

                // Sort by sit number if bus numbers are the same
                return aSitNum.CompareTo(bSitNum);
            });

            // Clear the list view and add the sorted passenger entries
            listView1.Items.Clear();
            foreach (string passengerEntry in passengerEntries)
            {
                string[] values = passengerEntry.Split(',');
                string passName = values[0].Trim();
                string passPhone = values[1].Trim();
                string sitNum = values[2].Trim();
                string busNu = values[3].Trim();

                ListViewItem item = new ListViewItem(passName);
                item.SubItems.Add(passPhone);
                item.SubItems.Add(sitNum);
                item.SubItems.Add(busNu);

                listView1.Items.Add(item);
            }

            // Clear the items in the ComboBox
            comboBox1.Items.Clear();

            // Open the database connection
            con.Open();

            // Select all bus numbers from the bus table
            SqlCommand cmd7 = new SqlCommand("SELECT bus_nu FROM bus", con);

            // Create a data reader to store the result of the query
            SqlDataReader reader7 = cmd7.ExecuteReader();

            // Add each bus number to the ComboBox
            while (reader7.Read())
            {
                string busNu = reader7["bus_nu"].ToString();
                comboBox1.Items.Add(busNu);
            }

            // Close the data reader
            reader7.Close();

            // Close the database connection
            con.Close();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            string passName = passNameTextBox.Text;
            string passPhone = passPhoneTextBox.Text;
            string busNum = comboBox1.SelectedItem?.ToString();
            string sitNum = comboBox2.SelectedItem?.ToString();

            // Check: No input field should be empty
            if (string.IsNullOrEmpty(passName) || string.IsNullOrEmpty(passPhone) || string.IsNullOrEmpty(busNum) || string.IsNullOrEmpty(sitNum))
            {
                MessageBox.Show("Please fill in all fields.");
                return; // Exit the function
            }

            // Open the database connection
            con.Open();

            // Generate a unique value for the schedule_id
            SqlCommand cmd1 = new SqlCommand("SELECT MAX(passenger_id) FROM passenger", con);
            int passengerId = Convert.ToInt32(cmd1.ExecuteScalar()) + 1;

            SqlCommand cmd4 = new SqlCommand("SELECT bus_id FROM bus WHERE bus_nu = @busNum", con);
            cmd4.Parameters.AddWithValue("@busNum", busNum);
            int busId = (int)cmd4.ExecuteScalar();

            // Check if the selected seat is already taken
            SqlCommand cmd5 = new SqlCommand("SELECT COUNT(*) FROM passenger WHERE bus_id = @busId AND sit_num = @sitNum", con);
            cmd5.Parameters.AddWithValue("@busId", busId);
            cmd5.Parameters.AddWithValue("@sitNum", sitNum);
            int seatCount = Convert.ToInt32(cmd5.ExecuteScalar());

            if (seatCount > 0)
            {
                MessageBox.Show("The selected seat is already taken. Please choose another seat.");
                con.Close();
                return; // Exit the function
            }

            SqlCommand cmd2 = new SqlCommand("INSERT INTO passenger (passenger_id, pass_name, pass_phone, bus_id, sit_num) VALUES (@passengerId, @passName, @passPhone, @busId, @sitNum)", con);
            cmd2.Parameters.AddWithValue("@passengerId", passengerId);
            cmd2.Parameters.AddWithValue("@passName", passName);
            cmd2.Parameters.AddWithValue("@passPhone", passPhone);
            cmd2.Parameters.AddWithValue("@sitNum", sitNum);
            cmd2.Parameters.AddWithValue("@busId", busId);

            try
            {
                // Execute the INSERT command for the schedule table
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding the passenger to the database. " + ex.Message);
            }

            // Close the database connection
            con.Close();

            // Clear the text boxes and combo box selections
            passNameTextBox.Text = " ";
            passPhoneTextBox.Text = " ";
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;

            updateListView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string passName = selectedItem.SubItems[0].Text;

                // Open the database connection
                con.Open();

                // Create the DELETE command
                SqlCommand cmd = new SqlCommand("DELETE FROM passenger WHERE pass_name = @passName", con);
                cmd.Parameters.AddWithValue("@passName", passName);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The passenger was deleted.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting the passenger from the database. " + ex.Message);
                }

                // Close the database connection
                con.Close();
                updateListView();
            }
            else
            {
                MessageBox.Show("Please select a passenger to delete from the list.");
            }
        }

        private void updateListView()
        {
            // Open the database connection
            con.Open();

            // Create the SELECT command
            SqlCommand cmd = new SqlCommand("SELECT pass_name, pass_phone, sit_num, bus.bus_nu FROM passenger INNER JOIN bus ON passenger.bus_id = bus.bus_id", con);

            // Execute the command and get the results
            SqlDataReader reader = cmd.ExecuteReader();

            // Clear the ListView control
            listView1.Items.Clear();

            // Create a list to store the passenger entries
            List<string> passengerEntries = new List<string>();

            // Add the data to the list
            while (reader.Read())
            {
                string passName = reader["pass_name"].ToString();
                string passPhone = reader["pass_phone"].ToString();
                string sitNum = reader["sit_num"].ToString();
                string busNu = reader["bus_nu"].ToString();

                // Create a formatted string for each passenger entry
                string passengerEntry = $"{passName}, {passPhone}, {sitNum}, {busNu}";

                // Add the passenger entry to the list
                passengerEntries.Add(passengerEntry);
            }

            // Close the database connection
            con.Close();

            // Sort the passenger entries by bus number and sit number
            passengerEntries.Sort((a, b) =>
            {
                string[] aValues = a.Split(',');
                string[] bValues = b.Split(',');

                string aBusNu = aValues[3].Trim();
                string bBusNu = bValues[3].Trim();

                // Sort by bus number first
                int busNuComparison = aBusNu.CompareTo(bBusNu);
                if (busNuComparison != 0)
                    return busNuComparison;

                string aSitNum = aValues[2].Trim();
                string bSitNum = bValues[2].Trim();

                // Sort by sit number if bus numbers are the same
                return aSitNum.CompareTo(bSitNum);
            });

            // Display the passenger entries in the ListView control
            foreach (string passengerEntry in passengerEntries)
            {
                string[] values = passengerEntry.Split(',');

                string passName = values[0].Trim();
                string passPhone = values[1].Trim();
                string sitNum = values[2].Trim();
                string busNu = values[3].Trim();

                ListViewItem item = new ListViewItem(passName);
                item.SubItems.Add(passPhone);
                item.SubItems.Add(sitNum);
                item.SubItems.Add(busNu);

                listView1.Items.Add(item);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
