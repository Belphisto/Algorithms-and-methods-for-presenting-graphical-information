
namespace Tree_rendering
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.DrawToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.UserInputToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.RainfallToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.RainfallProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.WindToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.WindFProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.TempToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TempProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.ClearToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DrawToolStripButton,
            this.ClearToolStripButton1,
            this.toolStripSeparator6,
            this.UserInputToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(844, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // DrawToolStripButton
            // 
            this.DrawToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DrawToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("DrawToolStripButton.Image")));
            this.DrawToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrawToolStripButton.Name = "DrawToolStripButton";
            this.DrawToolStripButton.Size = new System.Drawing.Size(76, 22);
            this.DrawToolStripButton.Text = "Нарисовать";
            this.DrawToolStripButton.Click += new System.EventHandler(this.ResetToolStripButton_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // UserInputToolStripButton
            // 
            this.UserInputToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UserInputToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("UserInputToolStripButton.Image")));
            this.UserInputToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UserInputToolStripButton.Name = "UserInputToolStripButton";
            this.UserInputToolStripButton.Size = new System.Drawing.Size(112, 22);
            this.UserInputToolStripButton.Text = "Задать параметры";
            this.UserInputToolStripButton.Click += new System.EventHandler(this.UserInputToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            this.helpToolStripButton.Click += new System.EventHandler(this.HelpToolStripButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(15, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(816, 480);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RainfallToolStripStatusLabel,
            this.RainfallProgressBar,
            this.WindToolStripStatusLabel,
            this.WindFProgressBar,
            this.TempToolStripStatusLabel,
            this.TempProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 519);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(844, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // RainfallToolStripStatusLabel
            // 
            this.RainfallToolStripStatusLabel.AutoSize = false;
            this.RainfallToolStripStatusLabel.Name = "RainfallToolStripStatusLabel";
            this.RainfallToolStripStatusLabel.Size = new System.Drawing.Size(160, 17);
            this.RainfallToolStripStatusLabel.Text = "Интенсивность осадков в %";
            this.RainfallToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RainfallProgressBar
            // 
            this.RainfallProgressBar.Name = "RainfallProgressBar";
            this.RainfallProgressBar.Size = new System.Drawing.Size(100, 16);
            this.RainfallProgressBar.Step = 1;
            // 
            // WindToolStripStatusLabel
            // 
            this.WindToolStripStatusLabel.AutoSize = false;
            this.WindToolStripStatusLabel.Name = "WindToolStripStatusLabel";
            this.WindToolStripStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WindToolStripStatusLabel.Size = new System.Drawing.Size(120, 17);
            this.WindToolStripStatusLabel.Text = "Сила ветра в м/с";
            this.WindToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WindFProgressBar
            // 
            this.WindFProgressBar.Maximum = 25;
            this.WindFProgressBar.Name = "WindFProgressBar";
            this.WindFProgressBar.Size = new System.Drawing.Size(100, 16);
            this.WindFProgressBar.Step = 1;
            // 
            // TempToolStripStatusLabel
            // 
            this.TempToolStripStatusLabel.AutoSize = false;
            this.TempToolStripStatusLabel.Name = "TempToolStripStatusLabel";
            this.TempToolStripStatusLabel.Size = new System.Drawing.Size(109, 17);
            this.TempToolStripStatusLabel.Text = "Температура С";
            this.TempToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TempProgressBar
            // 
            this.TempProgressBar.Name = "TempProgressBar";
            this.TempProgressBar.Size = new System.Drawing.Size(100, 16);
            this.TempProgressBar.Step = 1;
            // 
            // ClearToolStripButton1
            // 
            this.ClearToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ClearToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("ClearToolStripButton1.Image")));
            this.ClearToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearToolStripButton1.Name = "ClearToolStripButton1";
            this.ClearToolStripButton1.Size = new System.Drawing.Size(97, 22);
            this.ClearToolStripButton1.Text = "Очистить холст";
            this.ClearToolStripButton1.ToolTipText = "Очистить холст";
            this.ClearToolStripButton1.Click += new System.EventHandler(this.ClearToolStripButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 541);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Вариант 1 \"Дерево\"/Блинова Елена КЭ-404";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton DrawToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton UserInputToolStripButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel RainfallToolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar RainfallProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel WindToolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar WindFProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel TempToolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar TempProgressBar;
        private System.Windows.Forms.ToolStripButton ClearToolStripButton1;
    }
}

