namespace Bus_Management
{
    partial class passengers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(passengers));
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            button1 = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox2 = new ComboBox();
            passPhoneTextBox = new TextBox();
            passNameTextBox = new TextBox();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(255, 128, 128);
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.Location = new Point(8, 339);
            listView1.Name = "listView1";
            listView1.Size = new Size(995, 364);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Passenger Name";
            columnHeader1.Width = 248;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Passenger Phone";
            columnHeader2.Width = 248;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Seat Number";
            columnHeader3.Width = 248;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Bus Number";
            columnHeader4.Width = 251;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(8, 12);
            button1.Name = "button1";
            button1.Size = new Size(292, 94);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(passPhoneTextBox);
            groupBox1.Controls.Add(passNameTextBox);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(319, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(679, 295);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Passenger";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(422, 54);
            label3.Name = "label3";
            label3.Size = new Size(119, 28);
            label3.TabIndex = 14;
            label3.Text = "Bus Number";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(422, 85);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(221, 36);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 255);
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(40, 111);
            button2.Name = "button2";
            button2.Size = new Size(129, 142);
            button2.TabIndex = 12;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(429, 186);
            label5.Name = "label5";
            label5.Size = new Size(127, 28);
            label5.TabIndex = 10;
            label5.Text = "Seat Number";
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 186);
            label2.Name = "label2";
            label2.Size = new Size(158, 28);
            label2.TabIndex = 7;
            label2.Text = "Passenger Phone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 54);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 6;
            label1.Text = "Passenger Name";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25" });
            comboBox2.Location = new Point(422, 217);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(221, 36);
            comboBox2.TabIndex = 5;
            // 
            // passPhoneTextBox
            // 
            passPhoneTextBox.Location = new Point(198, 217);
            passPhoneTextBox.Name = "passPhoneTextBox";
            passPhoneTextBox.Size = new Size(169, 34);
            passPhoneTextBox.TabIndex = 2;
            // 
            // passNameTextBox
            // 
            passNameTextBox.Location = new Point(198, 85);
            passNameTextBox.Name = "passNameTextBox";
            passNameTextBox.Size = new Size(169, 34);
            passNameTextBox.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 255, 255);
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(8, 125);
            button3.Name = "button3";
            button3.Size = new Size(292, 94);
            button3.TabIndex = 6;
            button3.Text = "Delete Selected Passenger";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // passengers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(1010, 703);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "passengers";
            Text = "passengers";
            Load += passengers_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button button1;
        private GroupBox groupBox1;
        private Button button2;
        private Label label5;
        private Label label2;
        private Label label1;
        private ComboBox comboBox2;
        private TextBox passPhoneTextBox;
        private TextBox passNameTextBox;
        private Label label3;
        private ComboBox comboBox1;
        private Button button3;
    }
}