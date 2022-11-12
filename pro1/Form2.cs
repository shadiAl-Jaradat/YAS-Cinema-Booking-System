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
using System.IO;

namespace pro1
{
    public partial class Form2 : Form
    {
        Customer cust = new Customer();
        SQLiteConnection cinema_cont;
        public Form2(string msg)
        {
            InitializeComponent();
            
            cust.name = msg;


        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Hi "+cust.name+" , choose youe movie : ";
            cinema_cont = new SQLiteConnection("Data Source=Cinema.sqlite; Version=3;");
            cinema_cont.Open();


            string str = "SELECT NUM_SEAT FROM movies WHERE ID=1;";
            SQLiteCommand command = new SQLiteCommand(str, cinema_cont);
            SQLiteDataReader reader = command.ExecuteReader();
            string output="";
            while (reader.Read()) { output += reader["NUM_SEAT"].ToString(); }
            label14.Text =output;

             str = "SELECT NUM_SEAT FROM movies WHERE ID=2;";
             command = new SQLiteCommand(str, cinema_cont);
             reader = command.ExecuteReader();
             output = "";
            while (reader.Read()) { output += reader["NUM_SEAT"].ToString(); }
            label18.Text = output;

            str = "SELECT NUM_SEAT FROM movies WHERE ID=3;";
            command = new SQLiteCommand(str, cinema_cont);
            reader = command.ExecuteReader();
            output = "";
            while (reader.Read()) { output += reader["NUM_SEAT"].ToString(); }
            label23.Text = output;

            str = "SELECT NUM_SEAT FROM movies WHERE ID=4;";
            command = new SQLiteCommand(str, cinema_cont);
            reader = command.ExecuteReader();
            output = "";
            while (reader.Read()) { output += reader["NUM_SEAT"].ToString(); }
            label26.Text = output;

            str = "SELECT NUM_SEAT FROM movies WHERE ID=5;";
            command = new SQLiteCommand(str, cinema_cont);
            reader = command.ExecuteReader();
            output = "";
            while (reader.Read()) { output += reader["NUM_SEAT"].ToString(); }
            label25.Text = output;

            str = "SELECT NUM_SEAT FROM movies WHERE ID=6;";
            command = new SQLiteCommand(str, cinema_cont);
            reader = command.ExecuteReader();
            output = "";
            while (reader.Read()) { output += reader["NUM_SEAT"].ToString(); }
            label24.Text = output;


        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "SELECT FULL FROM movies WHERE ID=1;";
            SQLiteCommand command = new SQLiteCommand(str, cinema_cont);
            SQLiteDataReader reader = command.ExecuteReader();
            int full = 0;
            while (reader.Read()) { full = int.Parse(reader["FULL"].ToString()); }
            str = "SELECT NUM_SEAT FROM movies WHERE ID=1;";
            command = new SQLiteCommand(str, cinema_cont);
            reader = command.ExecuteReader();
            int nums = 0;
            SQLiteCommand command1;
            while (reader.Read()) { nums = int.Parse(reader["NUM_SEAT"].ToString()); }

            if (nums < full)
            {
                string numup = "UPDATE movies SET NUM_SEAT = NUM_SEAT+1 WHERE ID = 1";
                command1 = new SQLiteCommand(numup, cinema_cont);
                command1.ExecuteNonQuery();
                str = "UPDATE customers SET move_name = 'harry potter', move_id = 1 where name = '" + cust.name + "';";
                command1 = new SQLiteCommand(str, cinema_cont);
                command1.ExecuteNonQuery();
                button1.Enabled = false;
                button7.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            else
            {
                MessageBox.Show("no seats in this movie","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            str = "SELECT NUM_SEAT FROM movies WHERE ID=1;";
            command = new SQLiteCommand(str, cinema_cont);
            reader = command.ExecuteReader();
            while (reader.Read()) { nums = int.Parse(reader["NUM_SEAT"].ToString()); }
            label14.Text = nums.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string str = "SELECT FULL FROM movies WHERE ID=2;";
            SQLiteCommand command = new SQLiteCommand(str, cinema_cont);
            SQLiteDataReader reader = command.ExecuteReader();
            int full = 0;
            while (reader.Read()) { full = int.Parse(reader["FULL"].ToString()); }
            str = "SELECT NUM_SEAT FROM movies WHERE ID=2;";
            command = new SQLiteCommand(str, cinema_cont);
            reader = command.ExecuteReader();
            int nums = 0;
            SQLiteCommand command1;
            while (reader.Read()) { nums = int.Parse(reader["NUM_SEAT"].ToString()); }

            if (nums < full)
            {
                string numup = "UPDATE movies SET NUM_SEAT = NUM_SEAT+1 WHERE ID = 2";
                command1 = new SQLiteCommand(numup, cinema_cont);
                command1.ExecuteNonQuery();
                str = "UPDATE customers SET move_name = 'spiderman', move_id = 2 where name = '" + cust.name + "';";
                command1 = new SQLiteCommand(str, cinema_cont);
                command1.ExecuteNonQuery();
                button1.Enabled = false;
                button7.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            else
            {
                MessageBox.Show("no seats in this movie", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            str = "SELECT NUM_SEAT FROM movies WHERE ID=2;";
            command = new SQLiteCommand(str, cinema_cont);
            reader = command.ExecuteReader();
            while (reader.Read()) { nums = int.Parse(reader["NUM_SEAT"].ToString()); }
            label18.Text = nums.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string str = "SELECT FULL FROM movies WHERE ID=3;";
            SQLiteCommand command = new SQLiteCommand(str, cinema_cont);
            SQLiteDataReader reader = command.ExecuteReader();
            int full = 0;
            while (reader.Read()) { full = int.Parse(reader["FULL"].ToString()); }
            str = "SELECT NUM_SEAT FROM movies WHERE ID=3;";
            command = new SQLiteCommand(str, cinema_cont);
            reader = command.ExecuteReader();
            int nums = 0;
            SQLiteCommand command1;
            while (reader.Read()) { nums = int.Parse(reader["NUM_SEAT"].ToString()); }

            if (nums < full)
            {
                string numup = "UPDATE movies SET NUM_SEAT = NUM_SEAT+1 WHERE ID = 3";
                command1 = new SQLiteCommand(numup, cinema_cont);
                command1.ExecuteNonQuery();
                str = "UPDATE customers SET move_name = 'titanic', move_id = 3 where name = '" + cust.name + "';";
                command1 = new SQLiteCommand(str, cinema_cont);
                command1.ExecuteNonQuery();
                button1.Enabled = false;
                button7.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            else
            {
                MessageBox.Show("no seats in this movie", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            str = "SELECT NUM_SEAT FROM movies WHERE ID=3;";
            command = new SQLiteCommand(str, cinema_cont);
            reader = command.ExecuteReader();
            while (reader.Read()) { nums = int.Parse(reader["NUM_SEAT"].ToString()); }
            label23.Text = nums.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str = "SELECT FULL FROM movies WHERE ID=4;";
            SQLiteCommand command = new SQLiteCommand(str, cinema_cont);
            SQLiteDataReader reader = command.ExecuteReader();
            int full = 0;
            while (reader.Read()) { full = int.Parse(reader["FULL"].ToString()); }
            str = "SELECT NUM_SEAT FROM movies WHERE ID=4;";
            command = new SQLiteCommand(str, cinema_cont);
            reader = command.ExecuteReader();
            int nums = 0;
            SQLiteCommand command1;
            while (reader.Read()) { nums = int.Parse(reader["NUM_SEAT"].ToString()); }

            if (nums < full)
            {
                string numup = "UPDATE movies SET NUM_SEAT = NUM_SEAT+1 WHERE ID = 4";
                command1 = new SQLiteCommand(numup, cinema_cont);
                command1.ExecuteNonQuery();
                str = "UPDATE customers SET move_name = 'joker', move_id = 4 where name = '" + cust.name + "';";
                command1 = new SQLiteCommand(str, cinema_cont);
                command1.ExecuteNonQuery();
                button1.Enabled = false;
                button7.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            else
            {
                MessageBox.Show("no seats in this movie", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            str = "SELECT NUM_SEAT FROM movies WHERE ID=4;";
            command = new SQLiteCommand(str, cinema_cont);
            reader = command.ExecuteReader();
            while (reader.Read()) { nums = int.Parse(reader["NUM_SEAT"].ToString()); }
            label26.Text = nums.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = "SELECT FULL FROM movies WHERE ID=5;";
            SQLiteCommand command = new SQLiteCommand(str, cinema_cont);
            SQLiteDataReader reader = command.ExecuteReader();
            int full = 0;
            while (reader.Read()) { full = int.Parse(reader["FULL"].ToString()); }
            str = "SELECT NUM_SEAT FROM movies WHERE ID=5;";
            command = new SQLiteCommand(str, cinema_cont);
            reader = command.ExecuteReader();
            int nums = 0;
            SQLiteCommand command1;
            while (reader.Read()) { nums = int.Parse(reader["NUM_SEAT"].ToString()); }

            if (nums < full)
            {
                string numup = "UPDATE movies SET NUM_SEAT = NUM_SEAT+1 WHERE ID = 5";
                command1 = new SQLiteCommand(numup, cinema_cont);
                command1.ExecuteNonQuery();
                str = "UPDATE customers SET move_name = 'Avengers', move_id = 5 where name = '" + cust.name + "';";
                command1 = new SQLiteCommand(str, cinema_cont);
                command1.ExecuteNonQuery();
                button1.Enabled = false;
                button7.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            else
            {
                MessageBox.Show("no seats in this movie", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            str = "SELECT NUM_SEAT FROM movies WHERE ID=5;";
            command = new SQLiteCommand(str, cinema_cont);
            reader = command.ExecuteReader();
            while (reader.Read()) { nums = int.Parse(reader["NUM_SEAT"].ToString()); }
            label25.Text = nums.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "SELECT FULL FROM movies WHERE ID=6;";
            SQLiteCommand command = new SQLiteCommand(str, cinema_cont);
            SQLiteDataReader reader = command.ExecuteReader();
            int full = 0;
            while (reader.Read()) { full = int.Parse(reader["FULL"].ToString()); }
            str = "SELECT NUM_SEAT FROM movies WHERE ID=6;";
            command = new SQLiteCommand(str, cinema_cont);
            reader = command.ExecuteReader();
            int nums = 0;
            SQLiteCommand command1;
            while (reader.Read()) { nums = int.Parse(reader["NUM_SEAT"].ToString()); }

            if (nums < full)
            {
                string numup = "UPDATE movies SET NUM_SEAT = NUM_SEAT+1 WHERE ID = 6";
                command1 = new SQLiteCommand(numup, cinema_cont);
                command1.ExecuteNonQuery();
                str = "UPDATE customers SET move_name = 'frozen', move_id = 6 where name = '" + cust.name + "';";
                command1 = new SQLiteCommand(str, cinema_cont);
                command1.ExecuteNonQuery();
                button1.Enabled = false;
                button7.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            else
            {
                MessageBox.Show("no seats in this movie", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            str = "SELECT NUM_SEAT FROM movies WHERE ID=6;";
            command = new SQLiteCommand(str, cinema_cont);
            reader = command.ExecuteReader();
            while (reader.Read()) { nums = int.Parse(reader["NUM_SEAT"].ToString()); }
            label24.Text = nums.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLiteCommand command1;
            //string numup = "UPDATE movies SET NUM_SEAT = NUM_SEAT+1 WHERE ID = 6";
            //command1 = new SQLiteCommand(numup, cinema_cont);
            //command1.ExecuteNonQuery();
            //string str = "UPDATE customersa c,movie m SET NUM_SEAT = NUM_SEAT-1  where join c.move_id =m.id and name = '" + cust.name + "' ;";
            //string str = "update num_seat = num_seat-1 from movies m inner join customers c on m.id = c.move_num where num_seat<>0; ";
            string str = "update MOVIES set NUM_SEAT = NUM_SEAT-1 where id = (select move_id from customers where name = '"+cust.name+"')";
            string str2 = "update customers set move_name= null, move_id = null where name = '" + cust.name + "'";
            command1 = new SQLiteCommand(str, cinema_cont);
             command1.ExecuteNonQuery();
            SQLiteCommand command2 = new SQLiteCommand(str2, cinema_cont);
            command2.ExecuteNonQuery();
            button1.Enabled = true;
            button7.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            SQLiteCommand command;
            SQLiteDataReader reader;
            str = "SELECT NUM_SEAT FROM movies WHERE ID=1;";
            command = new SQLiteCommand(str, cinema_cont);
            reader = command.ExecuteReader();
            int nums = int.Parse(reader["NUM_SEAT"].ToString());
            while (reader.Read()) { nums = int.Parse(reader["NUM_SEAT"].ToString()); }
            label14.Text = nums.ToString();

            /*-------------------------*/
            str = "SELECT NUM_SEAT FROM movies WHERE ID=2;";
            command = new SQLiteCommand(str, cinema_cont);
            reader = command.ExecuteReader();
            nums = int.Parse(reader["NUM_SEAT"].ToString());
            while (reader.Read()) { nums = int.Parse(reader["NUM_SEAT"].ToString()); }
            label18.Text = nums.ToString();
            /*----------------------------*/
            str = "SELECT NUM_SEAT FROM movies WHERE ID=3;";
            command = new SQLiteCommand(str, cinema_cont);
            reader = command.ExecuteReader();
            nums = int.Parse(reader["NUM_SEAT"].ToString());
            while (reader.Read()) { nums = int.Parse(reader["NUM_SEAT"].ToString()); }
            label23.Text = nums.ToString();
            /*----------------------------*/
            str = "SELECT NUM_SEAT FROM movies WHERE ID=4;";
            command = new SQLiteCommand(str, cinema_cont);
            reader = command.ExecuteReader();
            nums = int.Parse(reader["NUM_SEAT"].ToString());
            while (reader.Read()) { nums = int.Parse(reader["NUM_SEAT"].ToString()); }
            label26.Text = nums.ToString();
            /*----------------------------*/
            str = "SELECT NUM_SEAT FROM movies WHERE ID=5;";
            command = new SQLiteCommand(str, cinema_cont);
            reader = command.ExecuteReader();
            nums = int.Parse(reader["NUM_SEAT"].ToString());
            while (reader.Read()) { nums = int.Parse(reader["NUM_SEAT"].ToString()); }
            label25.Text = nums.ToString();
            /*------------------------*/
            str = "SELECT NUM_SEAT FROM movies WHERE ID=6;";
            command = new SQLiteCommand(str, cinema_cont);
            reader = command.ExecuteReader();
            nums = int.Parse(reader["NUM_SEAT"].ToString());
            while (reader.Read()) { nums = int.Parse(reader["NUM_SEAT"].ToString()); }
            label24.Text = nums.ToString();


        }

        private void button8_Click(object sender, EventArgs e)
        {
            var m = new Form1();
            m.Show();
            this.Hide();
            string str = "DELETE FROM Customers WHERE Name='"+cust.name+"';";
            SQLiteCommand  command = new SQLiteCommand(str, cinema_cont);
           command.ExecuteNonQuery();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string str = "SELECT * FROM customers WHERE name='"+cust.name+"';";
            SQLiteCommand command = new SQLiteCommand(str, cinema_cont);
            SQLiteDataReader reader = command.ExecuteReader();
            string name = "";
            string movie = "";
            while (reader.Read()) { name += reader["name"].ToString();
                movie += reader["move_name"].ToString();
            }

            var m = new Form3(name,movie);
            m.Show();
            this.Hide();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            StreamWriter printM = new StreamWriter("printMovies.txt");
            

            string str = " select * from movies";
            SQLiteCommand command = new SQLiteCommand(str, cinema_cont);
            SQLiteDataReader reader = command.ExecuteReader();
            string output = "";

            while (reader.Read()) {
                output = reader["ID"].ToString() + ", " + reader["NAME"].ToString() + ", " + reader["PRICE"].ToString() + ", " + reader["NUM_SEAT"].ToString() + ", " + reader["FULL"].ToString();
                printM.WriteLine(output);
            }
            printM.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            StreamReader readM = new StreamReader("readMovies.txt");
            string newMovies = "";
            newMovies = readM.ReadLine();
            while (newMovies != null)
            {
                string sql = "insert into movies values (" + newMovies + ");";
                SQLiteCommand command = new SQLiteCommand(sql, cinema_cont);
                command.ExecuteNonQuery();
                newMovies = readM.ReadLine();
            }
            button11.Enabled = false;
        }
    }
}
