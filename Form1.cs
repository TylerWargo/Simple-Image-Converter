﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Simple_Image_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Import_Click(object sender, EventArgs e)
        {
            ImportDialoge.ShowDialog();
        }

        private void Help_Click(object sender, EventArgs e)
        {
            string helpTarget = "https://github.com/TylerWargo/Simple-Image-Converter";
            Process.Start(new ProcessStartInfo(helpTarget) 
            { 
                UseShellExecute = true 
            });

        }
    }
}
