namespace _3DSTitleIdEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.loadGameImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overwriteGameImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.titleIdTextBox = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.toolStrip.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(256, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadGameImageToolStripMenuItem,
            this.overwriteGameImageToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // loadGameImageToolStripMenuItem
            // 
            this.loadGameImageToolStripMenuItem.Name = "loadGameImageToolStripMenuItem";
            this.loadGameImageToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.loadGameImageToolStripMenuItem.Text = "Load game image";
            this.loadGameImageToolStripMenuItem.Click += new System.EventHandler(this.loadGameImageToolStripMenuItem_Click);
            // 
            // overwriteGameImageToolStripMenuItem
            // 
            this.overwriteGameImageToolStripMenuItem.Enabled = false;
            this.overwriteGameImageToolStripMenuItem.Name = "overwriteGameImageToolStripMenuItem";
            this.overwriteGameImageToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.overwriteGameImageToolStripMenuItem.Text = "Overwrite game image";
            this.overwriteGameImageToolStripMenuItem.Click += new System.EventHandler(this.overwriteGameImageToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // titleIdTextBox
            // 
            this.titleIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleIdTextBox.Location = new System.Drawing.Point(15, 19);
            this.titleIdTextBox.Name = "titleIdTextBox";
            this.titleIdTextBox.Size = new System.Drawing.Size(211, 20);
            this.titleIdTextBox.TabIndex = 1;
            this.titleIdTextBox.TextChanged += new System.EventHandler(this.titleIdTextBox_TextChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.titleIdTextBox);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(12, 28);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(232, 55);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Title ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 95);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.toolStrip);
            this.Name = "Form1";
            this.Text = "3DS Title ID Editor";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem loadGameImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overwriteGameImageToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox titleIdTextBox;
        private System.Windows.Forms.GroupBox groupBox;
    }
}

