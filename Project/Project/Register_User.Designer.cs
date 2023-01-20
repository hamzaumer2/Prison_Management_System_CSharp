namespace Project
{
    partial class Register_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_User));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelHeading = new System.Windows.Forms.Label();
            this.RegisterFN = new System.Windows.Forms.TextBox();
            this.RegisterLN = new System.Windows.Forms.TextBox();
            this.RegisterUsername = new System.Windows.Forms.TextBox();
            this.RegisterPhone = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.RegisterPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.RegisterDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LabelHeading
            // 
            this.LabelHeading.AutoSize = true;
            this.LabelHeading.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelHeading.Location = new System.Drawing.Point(0, 27);
            this.LabelHeading.Name = "LabelHeading";
            this.LabelHeading.Size = new System.Drawing.Size(251, 40);
            this.LabelHeading.TabIndex = 1;
            this.LabelHeading.Text = "Registration Portal";
            // 
            // RegisterFN
            // 
            this.RegisterFN.Location = new System.Drawing.Point(279, 89);
            this.RegisterFN.Name = "RegisterFN";
            this.RegisterFN.PlaceholderText = "First Name";
            this.RegisterFN.Size = new System.Drawing.Size(250, 27);
            this.RegisterFN.TabIndex = 2;
            this.RegisterFN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RegisterLN
            // 
            this.RegisterLN.Location = new System.Drawing.Point(555, 89);
            this.RegisterLN.Name = "RegisterLN";
            this.RegisterLN.PlaceholderText = "Last Name";
            this.RegisterLN.Size = new System.Drawing.Size(250, 27);
            this.RegisterLN.TabIndex = 3;
            this.RegisterLN.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // RegisterUsername
            // 
            this.RegisterUsername.Location = new System.Drawing.Point(279, 150);
            this.RegisterUsername.Name = "RegisterUsername";
            this.RegisterUsername.PlaceholderText = "Username";
            this.RegisterUsername.Size = new System.Drawing.Size(250, 27);
            this.RegisterUsername.TabIndex = 4;
            this.RegisterUsername.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // RegisterPhone
            // 
            this.RegisterPhone.Location = new System.Drawing.Point(555, 209);
            this.RegisterPhone.Name = "RegisterPhone";
            this.RegisterPhone.PlaceholderText = "Phone Number";
            this.RegisterPhone.Size = new System.Drawing.Size(250, 27);
            this.RegisterPhone.TabIndex = 6;
            this.RegisterPhone.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(279, 269);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 24);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(451, 269);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 24);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // RegisterPassword
            // 
            this.RegisterPassword.Location = new System.Drawing.Point(279, 209);
            this.RegisterPassword.Name = "RegisterPassword";
            this.RegisterPassword.PasswordChar = '*';
            this.RegisterPassword.PlaceholderText = "Password";
            this.RegisterPassword.Size = new System.Drawing.Size(250, 27);
            this.RegisterPassword.TabIndex = 9;
            this.RegisterPassword.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(555, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Register User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(667, 428);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(138, 20);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back To Main Menu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // RegisterDate
            // 
            this.RegisterDate.Location = new System.Drawing.Point(555, 148);
            this.RegisterDate.Name = "RegisterDate";
            this.RegisterDate.Size = new System.Drawing.Size(250, 27);
            this.RegisterDate.TabIndex = 12;
            this.RegisterDate.Tag = "Date of Birth";
            this.RegisterDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(555, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(555, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 18;
            // 
            // Register_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(831, 458);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegisterDate);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RegisterPassword);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.RegisterPhone);
            this.Controls.Add(this.RegisterUsername);
            this.Controls.Add(this.RegisterLN);
            this.Controls.Add(this.RegisterFN);
            this.Controls.Add(this.LabelHeading);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Register_User";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Label LabelHeading;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private Button button1;
        private TextBox RegisterPassword;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox RegisterPhone;
        private TextBox RegisterUsername;
        private TextBox RegisterLN;
        private TextBox RegisterFN;
        private DateTimePicker RegisterDate;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}