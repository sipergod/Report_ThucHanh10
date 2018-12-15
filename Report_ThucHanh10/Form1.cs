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

namespace Report_ThucHanh10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form1_Load();
        }

        private void Form1_Load()
        {
            var currentDirectory = System.IO.Directory.GetCurrentDirectory();
            currentDirectory = currentDirectory.Substring(0, currentDirectory.LastIndexOf('\\'));
            currentDirectory = currentDirectory.Substring(0, currentDirectory.LastIndexOf('\\'));
            var dir = currentDirectory + @"\data_hs.txt";

            StreamReader file = new StreamReader(dir);
            string lines;
            while ((lines = file.ReadLine()) != null)
            {
                string[] line = lines.Split(',');
                Dataset_HS.XepLoai.Rows.Add(line[1], line[2], line[3], line[4], line[5], line[6], line[7], line[0]);
            }
            file.Close();
            
            this.reportViewer1.RefreshReport();
        }
    }
}
