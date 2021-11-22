namespace TestForm
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.textAge = new System.Windows.Forms.TextBox();
            this.textCell = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(400, 269);
            this.textName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textName.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.textName.MinimumSize = new System.Drawing.Size(396, 40);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(596, 69);
            this.textName.TabIndex = 0;
            this.textName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-10, 269);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MinimumSize = new System.Drawing.Size(200, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 77);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AccessibleName = "";
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-10, 385);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.MinimumSize = new System.Drawing.Size(200, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 77);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AccessibleName = "";
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-10, 500);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.MinimumSize = new System.Drawing.Size(200, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 77);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cell:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Time
            // 
            this.Time.BackColor = System.Drawing.Color.MidnightBlue;
            this.Time.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(889, -3);
            this.Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(240, 96);
            this.Time.TabIndex = 6;
            this.Time.Text = "0:0";
            this.Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Time.Click += new System.EventHandler(this.Time_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // textAge
            // 
            this.textAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAge.Location = new System.Drawing.Point(400, 385);
            this.textAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textAge.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.textAge.MinimumSize = new System.Drawing.Size(396, 40);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(596, 69);
            this.textAge.TabIndex = 7;
            this.textAge.TextChanged += new System.EventHandler(this.AgeText_TextChanged);
            // 
            // textCell
            // 
            this.textCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCell.Location = new System.Drawing.Point(400, 500);
            this.textCell.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCell.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.textCell.MinimumSize = new System.Drawing.Size(396, 40);
            this.textCell.Name = "textCell";
            this.textCell.Size = new System.Drawing.Size(596, 69);
            this.textCell.TabIndex = 9;
            this.textCell.TextChanged += new System.EventHandler(this.CellText_TextChanged);
            // 
            // textAddress
            // 
            this.textAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAddress.Location = new System.Drawing.Point(400, 731);
            this.textAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textAddress.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.textAddress.MinimumSize = new System.Drawing.Size(396, 40);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(596, 69);
            this.textAddress.TabIndex = 18;
            this.textAddress.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label7
            // 
            this.label7.AccessibleName = "";
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-10, 731);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.MinimumSize = new System.Drawing.Size(200, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 77);
            this.label7.TabIndex = 15;
            this.label7.Text = "Address";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AccessibleName = "";
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-10, 615);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.MinimumSize = new System.Drawing.Size(200, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 77);
            this.label8.TabIndex = 14;
            this.label8.Text = "Email:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.Location = new System.Drawing.Point(400, 615);
            this.textEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textEmail.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.textEmail.MinimumSize = new System.Drawing.Size(396, 40);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(596, 69);
            this.textEmail.TabIndex = 13;
            this.textEmail.TextChanged += new System.EventHandler(this.EmailText_TextChanged);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::TestForm.Properties.Resources.student_icon_male_group_person_profile_avatar_vector_27926255;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(444, 27);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(230, 217);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::TestForm.Properties.Resources.download;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(116, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 215);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1205, 858);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textCell);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.TextBox textCell;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

