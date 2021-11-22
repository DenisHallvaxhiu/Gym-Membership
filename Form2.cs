using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            String user = username.Text;
            String passw = password.Text;
            

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `login` WHERE `username`=@usn and `password` = @pass", db.GetConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = user;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passw;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Login Successful");
                Form1 form1 = new Form1();
                this.Hide();
                form1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login Unsuccessful");
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateAcc createAcc = new CreateAcc();
            this.Hide();
            createAcc.ShowDialog();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
                Application.Exit();     
        }
    }
}
