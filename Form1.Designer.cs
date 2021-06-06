
namespace Simple_Image_Converter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FileListView = new System.Windows.Forms.ListView();
            this.ToolBarMenuStrip = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.Import = new System.Windows.Forms.ToolStripMenuItem();
            this.Options = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportDialoge = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FileImageList = new System.Windows.Forms.ImageList(this.components);
            this.ToolBarMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FileListView
            // 
            this.FileListView.AllowDrop = true;
            this.FileListView.HideSelection = false;
            this.FileListView.LargeImageList = this.FileImageList;
            this.FileListView.Location = new System.Drawing.Point(12, 27);
            this.FileListView.Name = "FileListView";
            this.FileListView.Size = new System.Drawing.Size(346, 243);
            this.FileListView.TabIndex = 1;
            this.FileListView.UseCompatibleStateImageBehavior = false;
            this.FileListView.DragOver += new System.Windows.Forms.DragEventHandler(this.FileListView_DragOver);
            // 
            // ToolBarMenuStrip
            // 
            this.ToolBarMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Help});
            this.ToolBarMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolBarMenuStrip.Name = "ToolBarMenuStrip";
            this.ToolBarMenuStrip.Size = new System.Drawing.Size(521, 24);
            this.ToolBarMenuStrip.TabIndex = 2;
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Import,
            this.Options});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(37, 20);
            this.File.Text = "File";
            // 
            // Import
            // 
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(116, 22);
            this.Import.Text = "Import";
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Options
            // 
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(116, 22);
            this.Options.Text = "Options";
            // 
            // Help
            // 
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(44, 20);
            this.Help.Text = "Help";
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // ImportDialoge
            // 
            this.ImportDialoge.Filter = "Image files (*.png, *.jpg, *.jpeg, *.jpe, *.jfif) | *.png; *.jpg; *.jpeg; *.jpe; " +
    "*.jfif";
            this.ImportDialoge.Multiselect = true;
            this.ImportDialoge.Title = "Import Image Files";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(364, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 117);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FileImageList
            // 
            this.FileImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.FileImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.FileImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 279);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FileListView);
            this.Controls.Add(this.ToolBarMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.ToolBarMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Simple Image Converter";
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.Form1_DragOver);
            this.ToolBarMenuStrip.ResumeLayout(false);
            this.ToolBarMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView FileListView;
        private System.Windows.Forms.MenuStrip ToolBarMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem Import;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.OpenFileDialog ImportDialoge;
        private System.Windows.Forms.ToolStripMenuItem Options;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList FileImageList;
    }
}

