
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
            this.Toolbar = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.Import = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Toolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Toolbar
            // 
            this.Toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Help});
            this.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.Size = new System.Drawing.Size(502, 24);
            this.Toolbar.TabIndex = 0;
            this.Toolbar.Text = "Test";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Import});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(37, 20);
            this.File.Text = "File";
            // 
            // Import
            // 
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(110, 22);
            this.Import.Text = "Import";
            // 
            // Help
            // 
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(44, 20);
            this.Help.Text = "Help";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(346, 243);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 282);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Toolbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.Toolbar;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Simple Image Converter";
            this.Toolbar.ResumeLayout(false);
            this.Toolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip Toolbar;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem Import;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.ListView listView1;
    }
}

