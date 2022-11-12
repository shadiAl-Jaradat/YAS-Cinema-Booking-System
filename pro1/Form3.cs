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
    public partial class Form3 : Form
    {
        string n;
        string m;

        public Form3(string name,string movie)
        {

            InitializeComponent();
             n = name;
             m = movie;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
           

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label3.Text =n;
            label2.Text = m;
          

        }
    }
}
