﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_ThucHanh10
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newform = new Form1();
            newform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2();
            newform.ShowDialog();
        }
    }
}
