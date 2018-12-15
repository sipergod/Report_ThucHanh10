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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Form2_Load();
        }

        private void Form2_Load()
        {
            var currentDirectory = System.IO.Directory.GetCurrentDirectory();
            currentDirectory = currentDirectory.Substring(0, currentDirectory.LastIndexOf('\\'));
            currentDirectory = currentDirectory.Substring(0, currentDirectory.LastIndexOf('\\'));
            var dir = currentDirectory + @"\data_ch.txt";

            StreamReader file = new StreamReader(dir);
            string lines;
            while ((lines = file.ReadLine()) != null)
            {
                string[] line = lines.Split(',');
                Dataset_CH.HangHoa.Rows.Add(line[0], line[1], line[2], line[3], line[4], line[5]);
            }
            file.Close();

            this.reportViewer1.RefreshReport();
        }
    }
}