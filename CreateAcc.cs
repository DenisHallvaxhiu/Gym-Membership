using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TestForm
{
    public partial class CreateAcc : Form
    {
        public CreateAcc()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

      }

        private void CreateAcc_Load(object sender, EventArgs e){ this.ActiveControl = label1; }

        private void CreateAcc_FormClosing(object sender, FormClosingEventArgs e)
        {
                Application.Exit();   
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFullName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassRT_TextChanged(object sender, EventArgs e){}

        private void textBoxFullName_Enter(object sender, EventArgs e)
        {
            String fname = textBoxFullName.Text;
            if (fname.ToLower().Trim().Equals("full name"))
            {
                textBoxFullName.Text = "";
                textBoxFullName.ForeColor = Color.Black;

            }
        }

        private void textBoxFullName_Leave(object sender, EventArgs e)
        {
            String fname = textBoxFullName.Text;
            if (fname.ToLower().Trim().Equals("full name") ||fname.Trim().Equals(""))
            {
                textBoxFullName.Text = "full name";
                textBoxFullName.ForeColor = Color.Gray;

            }
        }
        private void textBoxEmail_Enter(object sender, EventArgs e)
        {

            String email = textBoxEmail.Text;
           
            if (email.ToLower().Trim().Equals("email address"))
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;

            }
        }
        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            String email = textBoxEmail.Text;
            if (email.ToLower().Trim().Equals("email address") || email.Trim().Equals(""))
            {
                textBoxEmail.Text = "email address";
                textBoxEmail.ForeColor = Color.Gray;

            }
        }

        private void textBoxUser_Enter(object sender, EventArgs e)
        {
            String user = textBoxUser.Text;
            if (user.ToLower().Trim().Equals("user name"))
            {
                textBoxUser.Text = "";
                textBoxUser.ForeColor = Color.Black;

            }
        }

        private void textBoxUser_Leave(object sender, EventArgs e)
        {
            String user = textBoxUser.Text;
            if (user.ToLower().Trim().Equals("user name") || user.Trim().Equals(""))
            {
                textBoxUser.Text = "user name";
                textBoxUser.ForeColor = Color.Gray;

            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            String password = textBoxPassword.Text;
            if (password.ToLower().Trim().Equals("password"))
            {
                textBoxPassword.Text = "";
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassword.ForeColor = Color.Black;

            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            String password = textBoxPassword.Text;
            
            if (password.ToLower().Trim().Equals("password") || password.Trim().Equals(""))
            {
                textBoxPassword.Text = "password";
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.ForeColor = Color.Gray;

            }
        }

        private void textBoxPassCon_Enter(object sender, EventArgs e)
        {
            String passwordCon = textBoxPassCon.Text;
            if (passwordCon.ToLower().Trim().Equals("confirm password"))
            {
                textBoxPassCon.Text = "";
                textBoxPassCon.UseSystemPasswordChar = true;
                textBoxPassCon.ForeColor = Color.Black;

            }
        }

        private void textBoxPassCon_Leave(object sender, EventArgs e)
        {
            String passwordCon = textBoxPassCon.Text;
            if (passwordCon.ToLower().Trim().Equals("confirm password") || passwordCon.Trim().Equals(""))
            {
                textBoxPassCon.Text = "confirm password";
                textBoxPassCon.UseSystemPasswordChar = false;
                textBoxPassCon.ForeColor = Color.Gray;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.ToLower().Trim() != "email address" && textBoxFullName.Text.ToLower().Trim()!="full name"&& textBoxUser.Text.ToLower().Trim()!="user name" && textBoxPassword.Text.ToLower().Trim()!="password") 
            {
                if (textBoxPassword.Text != textBoxPassCon.Text)
                {
                    MessageBox.Show("Passwords do not match");
                }
                else
                {
                    Database db = new Database();
                    MySqlCommand command = new MySqlCommand("INSERT INTO `login`(`username`, `password`, `name`, `email`) VALUES (@user,@pass,@name,@email)", db.GetConnection());

                    command.Parameters.Add("@user", MySqlDbType.VarChar).Value = textBoxUser.Text;
                    command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;
                    command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBoxFullName.Text;
                    command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxEmail.Text;

                    db.openConnection();
                    if (checkUser())
                    {
                        MessageBox.Show("This username already exists.");
                    }
                    else
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Account Created");
                            Form2 form2 = new Form2();
                            this.Hide();
                            form2.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }

                   

                    db.closeConnection();
                }
                
            }
            else {
                MessageBox.Show("Make sure you feel all the information!");
            }
            
            
        }
        public Boolean checkUser()
        {
            Database db = new Database();

            String user = textBoxUser.Text;


            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `login` WHERE `username`=@usn", db.GetConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = user;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
