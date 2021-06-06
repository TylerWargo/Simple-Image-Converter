using System;
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
            FileImageList.Images.Clear();
            FileListView.Clear();
            DialogResult importResult = ImportDialoge.ShowDialog();
            if (importResult == System.Windows.Forms.DialogResult.OK) 
            {
                FileImageList.Images.Add(Image.FromFile(ImportDialoge.FileName));
                FileListView.Items.Add(ImportDialoge.FileName, 0);
            }
        }

        private void Help_Click(object sender, EventArgs e)
        {
            string helpTarget = "https://github.com/TylerWargo/Simple-Image-Converter";
            Process.Start(new ProcessStartInfo(helpTarget) 
            { 
                UseShellExecute = true 
            });
        }

        private void DragHover(DragEventArgs e) 
        {
            if(e.Effect == System.Windows.Forms.DragDropEffects.None)
            {
                e.Effect = System.Windows.Forms.DragDropEffects.Copy;
            }
        }

        private void Form1_DragOver(object sender, DragEventArgs e)
        {
            //MessageBox.Show("Dragging over.");
            DragHover(e);
        }

        private void FileListView_DragOver(object sender, DragEventArgs e)
        {
            DragHover(e);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
