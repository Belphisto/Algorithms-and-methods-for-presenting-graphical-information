
namespace Coloring_closed_surfaces
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDrow = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonLineScan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSeedFilling = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(605, 346);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDrow,
            this.toolStripSeparator1,
            this.toolStripButtonLineScan,
            this.toolStripSeparator2,
            this.toolStripButtonSeedFilling});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(630, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonDrow
            // 
            this.toolStripButtonDrow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDrow.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDrow.Image")));
            this.toolStripButtonDrow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDrow.Name = "toolStripButtonDrow";
            this.toolStripButtonDrow.Size = new System.Drawing.Size(119, 22);
            this.toolStripButtonDrow.Text = "Нарисовать фигуру";
            this.toolStripButtonDrow.Click += new System.EventHandler(this.toolStripButtonDrow_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonLineScan
            // 
            this.toolStripButtonLineScan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLineScan.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLineScan.Image")));
            this.toolStripButtonLineScan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLineScan.Name = "toolStripButtonLineScan";
            this.toolStripButtonLineScan.Size = new System.Drawing.Size(231, 22);
            this.toolStripButtonLineScan.Text = "Закрасить построчным сканированием";
            this.toolStripButtonLineScan.Click += new System.EventHandler(this.toolStripButtonLineScan_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSeedFilling
            // 
            this.toolStripButtonSeedFilling.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSeedFilling.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSeedFilling.Image")));
            this.toolStripButtonSeedFilling.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSeedFilling.Name = "toolStripButtonSeedFilling";
            this.toolStripButtonSeedFilling.Size = new System.Drawing.Size(188, 22);
            this.toolStripButtonSeedFilling.Text = "Закрасить заливкой с затравкой";
            this.toolStripButtonSeedFilling.Click += new System.EventHandler(this.toolStripButtonSeedFilling_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 382);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Blinova Elena/Coloring closed surfaces";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonDrow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonLineScan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonSeedFilling;
    }
}

