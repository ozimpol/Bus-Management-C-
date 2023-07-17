namespace Bus_Management
{
    partial class Drivers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drivers));
            listView1 = new ListView();
            nameColumn = new ColumnHeader();
            Phone = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            button3 = new Button();
            phoneTextBox = new TextBox();
            label2 = new Label();
            nameTextBox = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top;
            listView1.BackColor = Color.FromArgb(255, 128, 128);
            listView1.Columns.AddRange(new ColumnHeader[] { nameColumn, Phone });
            listView1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.Location = new Point(9, 212);
            listView1.Name = "listView1";
            listView1.Size = new Size(994, 479);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // nameColumn
            // 
            nameColumn.Text = "Name";
            nameColumn.Width = 497;
            // 
            // Phone
            // 
            Phone.Text = "Phone Number";
            Phone.Width = 497;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(9, 12);
            button1.Name = "button1";
            button1.Size = new Size(292, 94);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 255);
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(9, 112);
            button2.Name = "button2";
            button2.Size = new Size(292, 94);
            button2.TabIndex = 2;
            button2.Text = "Delete Selected Driver";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(phoneTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(394, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(589, 194);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add new driver";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 255, 255);
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(16, 62);
            button3.Name = "button3";
            button3.Size = new Size(132, 114);
            button3.TabIndex = 4;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(166, 137);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(410, 38);
            phoneTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(408, 103);
            label2.Name = "label2";
            label2.Size = new Size(168, 31);
            label2.TabIndex = 2;
            label2.Text = "Phone Number";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(166, 62);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(410, 38);
            nameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(434, 28);
            label1.Name = "label1";
            label1.Size = new Size(142, 31);
            label1.TabIndex = 0;
            label1.Text = "Driver Name";
            // 
            // Drivers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(1010, 703);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "Drivers";
            Text = "Drivers";
            Load += Drivers_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader nameColumn;
        private ColumnHeader Phone;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private TextBox phoneTextBox;
        private Label label2;
        private TextBox nameTextBox;
        private Label label1;
        private Button button3;
    }
}