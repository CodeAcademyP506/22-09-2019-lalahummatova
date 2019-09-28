using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace loginSystem
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }
        Form1 mainForm = new Form1();
        private void Button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                string userInfo = textBox1.Text + " " + textBox2.Text;
                File.AppendAllText("UsersData.txt", userInfo + Environment.NewLine);
                this.Hide();
                mainForm.Show();
                
            }
            else
            {
                MessageBox.Show("Butun xanalar doldurulmalidir!");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
