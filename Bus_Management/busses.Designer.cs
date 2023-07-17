namespace Bus_Management
{
    partial class busses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(busses));
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            button1 = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            driverNameComboBox = new ComboBox();
            endTimeTextBox = new TextBox();
            startTimeTextBox = new TextBox();
            endLocationTextBox = new TextBox();
            startLocationTextBox = new TextBox();
            busNumberTextBox = new TextBox();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(255, 128, 128);
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.Location = new Point(7, 335);
            listView1.Name = "listView1";
            listView1.Size = new Size(995, 364);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Bus Number";
            columnHeader1.Width = 165;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Start Location";
            columnHeader2.Width = 165;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Destination";
            columnHeader3.Width = 165;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Departure Time";
            columnHeader4.Width = 165;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Arrival Time";
            columnHeader5.Width = 165;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Bus Driver";
            columnHeader6.Width = 170;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(7, 12);
            button1.Name = "button1";
            button1.Size = new Size(292, 94);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(driverNameComboBox);
            groupBox1.Controls.Add(endTimeTextBox);
            groupBox1.Controls.Add(startTimeTextBox);
            groupBox1.Controls.Add(endLocationTextBox);
            groupBox1.Controls.Add(startLocationTextBox);
            groupBox1.Controls.Add(busNumberTextBox);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(319, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(679, 295);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Bus";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 255);
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(37, 141);
            button2.Name = "button2";
            button2.Size = new Size(129, 142);
            button2.TabIndex = 12;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(198, 141);
            label6.Name = "label6";
            label6.Size = new Size(133, 28);
            label6.TabIndex = 11;
            label6.Text = "Start Location";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(457, 217);
            label5.Name = "label5";
            label5.Size = new Size(100, 28);
            label5.TabIndex = 10;
            label5.Text = "Bus Driver";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(457, 141);
            label4.Name = "label4";
            label4.Size = new Size(116, 28);
            label4.TabIndex = 9;
            label4.Text = "Arrival Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(457, 54);
            label3.Name = "label3";
            label3.Size = new Size(147, 28);
            label3.TabIndex = 8;
            label3.Text = "Departure Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 218);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 7;
            label2.Text = "Destination";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 54);
            label1.Name = "label1";
            label1.Size = new Size(119, 28);
            label1.TabIndex = 6;
            label1.Text = "Bus Number";
            // 
            // driverNameComboBox
            // 
            driverNameComboBox.FormattingEnabled = true;
            driverNameComboBox.Location = new Point(457, 248);
            driverNameComboBox.Name = "driverNameComboBox";
            driverNameComboBox.Size = new Size(169, 36);
            driverNameComboBox.TabIndex = 5;
            // 
            // endTimeTextBox
            // 
            endTimeTextBox.Location = new Point(457, 172);
            endTimeTextBox.Name = "endTimeTextBox";
            endTimeTextBox.Size = new Size(169, 34);
            endTimeTextBox.TabIndex = 4;
            // 
            // startTimeTextBox
            // 
            startTimeTextBox.Location = new Point(457, 85);
            startTimeTextBox.Name = "startTimeTextBox";
            startTimeTextBox.Size = new Size(169, 34);
            startTimeTextBox.TabIndex = 3;
            // 
            // endLocationTextBox
            // 
            endLocationTextBox.Location = new Point(198, 249);
            endLocationTextBox.Name = "endLocationTextBox";
            endLocationTextBox.Size = new Size(169, 34);
            endLocationTextBox.TabIndex = 2;
            // 
            // startLocationTextBox
            // 
            startLocationTextBox.Location = new Point(198, 172);
            startLocationTextBox.Name = "startLocationTextBox";
            startLocationTextBox.Size = new Size(169, 34);
            startLocationTextBox.TabIndex = 1;
            // 
            // busNumberTextBox
            // 
            busNumberTextBox.Location = new Point(198, 85);
            busNumberTextBox.Name = "busNumberTextBox";
            busNumberTextBox.Size = new Size(169, 34);
            busNumberTextBox.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 255, 255);
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(7, 129);
            button3.Name = "button3";
            button3.Size = new Size(292, 94);
            button3.TabIndex = 4;
            button3.Text = "Delete Selected Bus";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // busses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(1010, 703);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "busses";
            Text = "busses";
            Load += busses_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button button1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox driverNameComboBox;
        private TextBox endTimeTextBox;
        private TextBox startTimeTextBox;
        private TextBox endLocationTextBox;
        private TextBox startLocationTextBox;
        private TextBox busNumberTextBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
        private Label label6;
        private Button button3;
    }
}