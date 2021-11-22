
namespace TestForm
{
    partial class CreateAcc
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPassCon = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFullName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxFullName.Location = new System.Drawing.Point(101, 110);
            this.textBoxFullName.MaximumSize = new System.Drawing.Size(370, 50);
            this.textBoxFullName.MinimumSize = new System.Drawing.Size(370, 50);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(370, 50);
            this.textBoxFullName.TabIndex = 200;
            this.textBoxFullName.Text = "full name";
            this.textBoxFullName.TextChanged += new System.EventHandler(this.textBoxFullName_TextChanged);
            this.textBoxFullName.Enter += new System.EventHandler(this.textBoxFullName_Enter);
            this.textBoxFullName.Leave += new System.EventHandler(this.textBoxFullName_Leave);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxEmail.Location = new System.Drawing.Point(101, 180);
            this.textBoxEmail.MaximumSize = new System.Drawing.Size(370, 50);
            this.textBoxEmail.MinimumSize = new System.Drawing.Size(370, 50);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(370, 50);
            this.textBoxEmail.TabIndex = 1;
            this.textBoxEmail.Text = "email address";
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxUser.Location = new System.Drawing.Point(101, 245);
            this.textBoxUser.MaximumSize = new System.Drawing.Size(370, 50);
            this.textBoxUser.MinimumSize = new System.Drawing.Size(370, 50);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(370, 50);
            this.textBoxUser.TabIndex = 2;
            this.textBoxUser.Text = "user name";
            this.textBoxUser.TextChanged += new System.EventHandler(this.textBoxUser_TextChanged);
            this.textBoxUser.Enter += new System.EventHandler(this.textBoxUser_Enter);
            this.textBoxUser.Leave += new System.EventHandler(this.textBoxUser_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxPassword.Location = new System.Drawing.Point(101, 312);
            this.textBoxPassword.MaximumSize = new System.Drawing.Size(370, 50);
            this.textBoxPassword.MinimumSize = new System.Drawing.Size(370, 50);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(370, 50);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.Text = "password";
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // textBoxPassCon
            // 
            this.textBoxPassCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassCon.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxPassCon.Location = new System.Drawing.Point(101, 383);
            this.textBoxPassCon.MaximumSize = new System.Drawing.Size(370, 50);
            this.textBoxPassCon.MinimumSize = new System.Drawing.Size(370, 50);
            this.textBoxPassCon.Name = "textBoxPassCon";
            this.textBoxPassCon.Size = new System.Drawing.Size(370, 50);
            this.textBoxPassCon.TabIndex = 4;
            this.textBoxPassCon.Text = "confirm password";
            this.textBoxPassCon.TextChanged += new System.EventHandler(this.textBoxPassRT_TextChanged);
            this.textBoxPassCon.Enter += new System.EventHandler(this.textBoxPassCon_Enter);
            this.textBoxPassCon.Leave += new System.EventHandler(this.textBoxPassCon_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(101, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(370, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "CREATE YOUR ACCOUNT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 100);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(99, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREATE YOUR ACCOUNT";
            // 
            // CreateAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(588, 515);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPassCon);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxFullName);
            this.Name = "CreateAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAcc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateAcc_FormClosing);
            this.Load += new System.EventHandler(this.CreateAcc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxPassCon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}