using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace pro1
{
    public partial class Form1 : Form
    {
        SQLiteConnection cinema_cont;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cinema_cont = new SQLiteConnection("Data Source=Cinema.sqlite; Version=3;");
            cinema_cont.Open();


        }

        private void C_nam_Click(object sender, EventArgs e)
        {

        }

        private void done_Click(object sender, EventArgs e)
        {
            try
            {   
                string str = "insert into customers(name) values ('" + textBox1.Text + "');";
                SQLiteCommand command = new SQLiteCommand(str, cinema_cont);
                command.ExecuteNonQuery();
                var m = new Form2(textBox1.Text);
                m.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("The name is already in use , change it ");
            }

            

        }
    }
}
