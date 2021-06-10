
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
            this.FileImageList = new System.Windows.Forms.ImageList(this.components);
            this.ToolBarMenuStrip = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.Import = new System.Windows.Forms.ToolStripMenuItem();
            this.Options = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportDialoge = new System.Windows.Forms.OpenFileDialog();
            this.PreviewPictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ToolBarMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileListView
            // 
            this.FileListView.AllowDrop = true;
            this.FileListView.HideSelection = false;
            this.FileListView.LabelEdit = true;
            this.FileListView.LargeImageList = this.FileImageList;
            this.FileListView.Location = new System.Drawing.Point(12, 27);
            this.FileListView.Name = "FileListView";
            this.FileListView.Size = new System.Drawing.Size(300, 300);
            this.FileListView.TabIndex = 1;
            this.FileListView.UseCompatibleStateImageBehavior = false;
            this.FileListView.DragOver += new System.Windows.Forms.DragEventHandler(this.FileListView_DragOver);
            // 
            // FileImageList
            // 
            this.FileImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.FileImageList.ImageSize = new System.Drawing.Size(50, 50);
            this.FileImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ToolBarMenuStrip
            // 
            this.ToolBarMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Help});
            this.ToolBarMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolBarMenuStrip.Name = "ToolBarMenuStrip";
            this.ToolBarMenuStrip.Size = new System.Drawing.Size(520, 24);
            this.ToolBarMenuStrip.TabIndex = 2;
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Import,
            this.Options,
            this.Exit});
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
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(116, 22);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
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
            // PreviewPictureBox
            // 
            this.PreviewPictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.PreviewPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PreviewPictureBox.InitialImage = null;
            this.PreviewPictureBox.Location = new System.Drawing.Point(318, 27);
            this.PreviewPictureBox.Name = "PreviewPictureBox";
            this.PreviewPictureBox.Size = new System.Drawing.Size(191, 117);
            this.PreviewPictureBox.TabIndex = 4;
            this.PreviewPictureBox.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(318, 150);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(190, 177);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(182, 149);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(182, 149);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 338);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.PreviewPictureBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox PreviewPictureBox;
        private System.Windows.Forms.ImageList FileImageList;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

