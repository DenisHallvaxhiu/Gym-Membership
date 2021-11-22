using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TestForm
{

    public partial class Form1 : Form
    {

        static int ticks;
        static int min = 0;


        public Form1()
        {
            InitializeComponent();
            Timer.Start();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String name = textName.Text;
            String age = textAge.Text;
            String cell = textCell.Text;
            String email = textEmail.Text;
            String address = textAddress.Text;

            if (name == "" || age == "" || cell == "" || email == "" || address == "")
            {
                MessageBox.Show("Some informations are missing");
            }
            else
            {
                Database db = new Database();
                MySqlCommand command = new MySqlCommand("INSERT INTO `costumers`(`name`, `age`, `cell`, `email`, `address`,student) VALUES(@name,@age,@cell,@email,@address,@student) ", db.GetConnection());

                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@age", MySqlDbType.VarChar).Value = age;
                command.Parameters.Add("@cell", MySqlDbType.VarChar).Value = cell;
                command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
                command.Parameters.Add("@student", MySqlDbType.VarChar).Value = "NO";

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Account Created");
                }
                else
                    MessageBox.Show("Error");

                db.closeConnection();
            }
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            ticks++;
            //string time = ticks.ToString();
            int sec = ticks;
            string secString = sec.ToString();

            string minString = min.ToString();

            if (sec == 59)
            {
                ticks = -1;
                min++;
            }
            Time.Text = minString + ":" + secString;
        }

        private void Time_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void EmailText_TextChanged(object sender, EventArgs e)
        {

        }

        private void CellText_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgeText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String name = textName.Text;
            String age = textAge.Text;
            String cell = textCell.Text;
            String email = textEmail.Text;
            String address = textAddress.Text;
            if (name == "" || age == "" || cell == "" || email == "" || address == "")
            {
                MessageBox.Show("Some informations are missing");
            }
            else
            {
                if (email.Contains(".edu"))
                {
                    Database db = new Database();
                    MySqlCommand command = new MySqlCommand("INSERT INTO `costumers`(`name`, `age`, `cell`, `email`, `address`,student) VALUES(@name,@age,@cell,@email,@address,@student) ", db.GetConnection());

                    command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                    command.Parameters.Add("@age", MySqlDbType.VarChar).Value = age;
                    command.Parameters.Add("@cell", MySqlDbType.VarChar).Value = cell;
                    command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                    command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
                    command.Parameters.Add("@student", MySqlDbType.VarChar).Value = "YES";

                    db.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Account Created.Approved for student discount");
                    }
                    else
                        MessageBox.Show("Error");

                    db.closeConnection();
                }
                else
                {
                    MessageBox.Show("Error!To be a student you must have an edu email!");
                }
               
            }
          
        }
    }
}
