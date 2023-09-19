
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
            this.refToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveName = new System.Windows.Forms.Button();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.panelAboutAuthor = new System.Windows.Forms.Panel();
            this.buttonLab1_2 = new System.Windows.Forms.Button();
            this.buttonLab1_3 = new System.Windows.Forms.Button();
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.editToolStripMenuItem.Text = "Редактирование";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // refToolStripMenuItem
            // 
            this.refToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.refToolStripMenuItem.Name = "refToolStripMenuItem";
            this.refToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.refToolStripMenuItem.Text = "Справка";
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.authorToolStripMenuItem.Text = "Автор программы";
            this.authorToolStripMenuItem.Click += new System.EventHandler(this.authorToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.refToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(362, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Автор программы:";
            // 
            // buttonSaveName
            // 
            this.buttonSaveName.Location = new System.Drawing.Point(80, 102);
            this.buttonSaveName.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSaveName.Name = "buttonSaveName";
            this.buttonSaveName.Size = new System.Drawing.Size(180, 26);
            this.buttonSaveName.TabIndex = 5;
            this.buttonSaveName.Text = "Сохранить";
            this.buttonSaveName.UseVisualStyleBackColor = true;
            this.buttonSaveName.Click += new System.EventHandler(this.buttonSaveName_Click);
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(80, 66);
            this.textBoxAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(181, 20);
            this.textBoxAuthor.TabIndex = 6;
            // 
            // panelAboutAuthor
            // 
            this.panelAboutAuthor.Controls.Add(this.textBoxAuthor);
            this.panelAboutAuthor.Controls.Add(this.buttonSaveName);
            this.panelAboutAuthor.Controls.Add(this.label1);
            this.panelAboutAuthor.Location = new System.Drawing.Point(0, 25);
            this.panelAboutAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.panelAboutAuthor.Name = "panelAboutAuthor";
            this.panelAboutAuthor.Size = new System.Drawing.Size(356, 162);
            this.panelAboutAuthor.TabIndex = 7;
            this.panelAboutAuthor.Visible = false;
            // 
            // buttonLab1_2
            // 
            this.buttonLab1_2.Location = new System.Drawing.Point(80, 201);
            this.buttonLab1_2.Name = "buttonLab1_2";
            this.buttonLab1_2.Size = new System.Drawing.Size(180, 30);
            this.buttonLab1_2.TabIndex = 8;
            this.buttonLab1_2.Text = "Лабораторная работа 2";
            this.buttonLab1_2.UseVisualStyleBackColor = true;
            this.buttonLab1_2.Click += new System.EventHandler(this.buttonLab1_2_Click);
            // 
            // buttonLab1_3
            // 
            this.buttonLab1_3.Location = new System.Drawing.Point(80, 237);
            this.buttonLab1_3.Name = "buttonLab1_3";
            this.buttonLab1_3.Size = new System.Drawing.Size(180, 30);
            this.buttonLab1_3.TabIndex = 9;
            this.buttonLab1_3.Text = "Лабораторная работа 3";
            this.buttonLab1_3.UseVisualStyleBackColor = true;
            this.buttonLab1_3.Click += new System.EventHandler(this.buttonLab1_3_Click);
            // 
            // BlinovaEM_Lab1_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 320);
            this.Controls.Add(this.buttonLab1_3);
            this.Controls.Add(this.buttonLab1_2);
            this.Controls.Add(this.panelAboutAuthor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ToolStripMenuItem refToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveName;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Panel panelAboutAuthor;
        private System.Windows.Forms.Button buttonLab1_2;
        private System.Windows.Forms.Button buttonLab1_3;
    }
}

