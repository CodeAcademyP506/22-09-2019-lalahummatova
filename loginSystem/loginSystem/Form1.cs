using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        realtodolist td = new realtodolist();
        private void Button1_Click(object sender, EventArgs e)
        {
            var data = File.ReadAllLines("UsersData.txt");
            var userInfo = textBox1.Text + " " + textBox2.Text;
            for(int i = 0; i < data.Length; i++)
            {
                if(data[i] == userInfo)
                {
                    MessageBox.Show("xosh gelmisinizi");
                    this.Hide();
                    td.Show();
                    return;
                    

                }
                
            }
            MessageBox.Show("user is not found");


        }



        private void Button2_Click(object sender, EventArgs e)
        {
            signup mysignup = new signup();
            this.Hide();
            mysignup.Show();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
