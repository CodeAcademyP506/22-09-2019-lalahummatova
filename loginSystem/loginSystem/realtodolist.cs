﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginSystem
{
    public partial class realtodolist : Form
    {
        public realtodolist()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(listadder.Text != "")
            {
                lists.Items.Add(listadder.Text);
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            for (int i = lists.Items.Count - 1; i >= 0; i--)
            {
                if (lists.GetItemChecked(i))
                {
                    lists.Items.Remove(lists.Items[i]);
                }
            }
        }
    }
}
