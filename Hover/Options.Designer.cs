namespace hover
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_mailServerHost = new System.Windows.Forms.TextBox();
            this.numericUpDown_mailServerPort = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_mailServerSSL = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_from = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_to = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_subject = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_body = new System.Windows.Forms.TextBox();
            this.button_testMail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mailServerPort)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.button1.Location = new System.Drawing.Point(191, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mailserver";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_mailServerHost
            // 
            this.textBox_mailServerHost.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::hover.Properties.Settings.Default, "mailServerHost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_mailServerHost.Location = new System.Drawing.Point(69, 19);
            this.textBox_mailServerHost.Name = "textBox_mailServerHost";
            this.textBox_mailServerHost.Size = new System.Drawing.Size(185, 20);
            this.textBox_mailServerHost.TabIndex = 2;
            this.textBox_mailServerHost.Text = global::hover.Properties.Settings.Default.mailServerHost;
            // 
            // numericUpDown_mailServerPort
            // 
            this.numericUpDown_mailServerPort.Location = new System.Drawing.Point(69, 45);
            this.numericUpDown_mailServerPort.Maximum = new decimal(new int[] {
            32756,
            0,
            0,
            0});
            this.numericUpDown_mailServerPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_mailServerPort.Name = "numericUpDown_mailServerPort";
            this.numericUpDown_mailServerPort.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown_mailServerPort.TabIndex = 3;
            this.numericUpDown_mailServerPort.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown_mailServerPort.ValueChanged += new System.EventHandler(this.numericUpDown_mailServerPort_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // checkBox_mailServerSSL
            // 
            this.checkBox_mailServerSSL.AutoSize = true;
            this.checkBox_mailServerSSL.Checked = global::hover.Properties.Settings.Default.mailServerUseSSL;
            this.checkBox_mailServerSSL.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::hover.Properties.Settings.Default, "mailServerUseSSL", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox_mailServerSSL.Location = new System.Drawing.Point(131, 46);
            this.checkBox_mailServerSSL.Name = "checkBox_mailServerSSL";
            this.checkBox_mailServerSSL.Size = new System.Drawing.Size(68, 17);
            this.checkBox_mailServerSSL.TabIndex = 6;
            this.checkBox_mailServerSSL.Text = "Use SSL";
            this.checkBox_mailServerSSL.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_mailServerHost);
            this.groupBox1.Controls.Add(this.checkBox_mailServerSSL);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown_mailServerPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 77);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_password);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_username);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 86);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account settings";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(70, 54);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(184, 20);
            this.textBox_password.TabIndex = 3;
            this.textBox_password.UseSystemPasswordChar = true;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_username
            // 
            this.textBox_username.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::hover.Properties.Settings.Default, "username", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_username.Location = new System.Drawing.Point(69, 24);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(185, 20);
            this.textBox_username.TabIndex = 1;
            this.textBox_username.Text = global::hover.Properties.Settings.Default.username;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Username";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_body);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBox_subject);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox_to);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox_from);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 223);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Content settings";
            // 
            // textBox_from
            // 
            this.textBox_from.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::hover.Properties.Settings.Default, "from", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_from.Location = new System.Drawing.Point(70, 25);
            this.textBox_from.Name = "textBox_from";
            this.textBox_from.Size = new System.Drawing.Size(184, 20);
            this.textBox_from.TabIndex = 1;
            this.textBox_from.Text = global::hover.Properties.Settings.Default.from;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "From";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "To";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_to
            // 
            this.textBox_to.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::hover.Properties.Settings.Default, "to", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_to.Location = new System.Drawing.Point(69, 54);
            this.textBox_to.Name = "textBox_to";
            this.textBox_to.Size = new System.Drawing.Size(185, 20);
            this.textBox_to.TabIndex = 3;
            this.textBox_to.Text = global::hover.Properties.Settings.Default.to;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Subject";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_subject
            // 
            this.textBox_subject.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::hover.Properties.Settings.Default, "subject", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_subject.Location = new System.Drawing.Point(70, 83);
            this.textBox_subject.Name = "textBox_subject";
            this.textBox_subject.Size = new System.Drawing.Size(184, 20);
            this.textBox_subject.TabIndex = 5;
            this.textBox_subject.Text = global::hover.Properties.Settings.Default.subject;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Message body";
            // 
            // textBox_body
            // 
            this.textBox_body.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::hover.Properties.Settings.Default, "body", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_body.Location = new System.Drawing.Point(11, 133);
            this.textBox_body.Multiline = true;
            this.textBox_body.Name = "textBox_body";
            this.textBox_body.Size = new System.Drawing.Size(243, 84);
            this.textBox_body.TabIndex = 7;
            this.textBox_body.Text = global::hover.Properties.Settings.Default.body;
            // 
            // button_testMail
            // 
            this.button_testMail.Location = new System.Drawing.Point(12, 416);
            this.button_testMail.Name = "button_testMail";
            this.button_testMail.Size = new System.Drawing.Size(94, 23);
            this.button_testMail.TabIndex = 10;
            this.button_testMail.Text = "Send Testmail";
            this.button_testMail.UseVisualStyleBackColor = true;
            this.button_testMail.Click += new System.EventHandler(this.button_testMail_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(284, 451);
            this.Controls.Add(this.button_testMail);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Options";
            this.Text = "Mail me Options";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mailServerPort)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_mailServerHost;
        private System.Windows.Forms.NumericUpDown numericUpDown_mailServerPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_mailServerSSL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_from;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_to;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_subject;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_body;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_testMail;
    }
}