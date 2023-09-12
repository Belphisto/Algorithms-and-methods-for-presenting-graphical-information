
namespace WindowsFormsLab1_BlinovaEM_KE_404
{
    partial class BlinovaEM_Lab1_1
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.task2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveName = new System.Windows.Forms.Button();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.panelAboutAuthor = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panelAboutAuthor.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.editToolStripMenuItem.Text = "Редактирование";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // task2ToolStripMenuItem
            // 
            this.task2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.task2ToolStripMenuItem.Name = "task2ToolStripMenuItem";
            this.task2ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.task2ToolStripMenuItem.Text = "Справка";
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.authorToolStripMenuItem.Text = "Автор программы";
            this.authorToolStripMenuItem.Click += new System.EventHandler(this.authorToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.task2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(482, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Автор программы:";
            // 
            // buttonSaveName
            // 
            this.buttonSaveName.Location = new System.Drawing.Point(106, 126);
            this.buttonSaveName.Name = "buttonSaveName";
            this.buttonSaveName.Size = new System.Drawing.Size(240, 32);
            this.buttonSaveName.TabIndex = 5;
            this.buttonSaveName.Text = "Сохранить";
            this.buttonSaveName.UseVisualStyleBackColor = true;
            this.buttonSaveName.Click += new System.EventHandler(this.buttonSaveName_Click);
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(106, 81);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(240, 22);
            this.textBoxAuthor.TabIndex = 6;
            // 
            // panelAboutAuthor
            // 
            this.panelAboutAuthor.Controls.Add(this.textBoxAuthor);
            this.panelAboutAuthor.Controls.Add(this.buttonSaveName);
            this.panelAboutAuthor.Controls.Add(this.label1);
            this.panelAboutAuthor.Location = new System.Drawing.Point(0, 31);
            this.panelAboutAuthor.Name = "panelAboutAuthor";
            this.panelAboutAuthor.Size = new System.Drawing.Size(474, 199);
            this.panelAboutAuthor.TabIndex = 7;
            this.panelAboutAuthor.Visible = false;
            // 
            // BlinovaEM_Lab1_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 233);
            this.Controls.Add(this.panelAboutAuthor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BlinovaEM_Lab1_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlinovaEM_Lab1_1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelAboutAuthor.ResumeLayout(false);
            this.panelAboutAuthor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem task2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveName;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Panel panelAboutAuthor;
    }
}

