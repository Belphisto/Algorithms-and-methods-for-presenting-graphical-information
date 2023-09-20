
namespace WindowsFormsLab1_BlinovaEM_KE_404
{
    partial class FormLab1_3
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
            this.components = new System.ComponentModel.Container();
            this.panelFigure = new System.Windows.Forms.Panel();
            this.contextMenuStripRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.typeLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neprerivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.punctirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thicknessLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.contextMenuStripRightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFigure
            // 
            this.panelFigure.BackColor = System.Drawing.Color.AliceBlue;
            this.panelFigure.Location = new System.Drawing.Point(2, -1);
            this.panelFigure.Name = "panelFigure";
            this.panelFigure.Size = new System.Drawing.Size(801, 452);
            this.panelFigure.TabIndex = 0;
            this.panelFigure.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelFigure_MouseClick);
            this.panelFigure.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelFigure_MouseDown);
            this.panelFigure.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelFigure_MouseMove);
            this.panelFigure.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelFigure_MouseUp);
            // 
            // contextMenuStripRightClick
            // 
            this.contextMenuStripRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typeLineToolStripMenuItem,
            this.thicknessLineToolStripMenuItem,
            this.colorLineToolStripMenuItem,
            this.colorBackgroundToolStripMenuItem});
            this.contextMenuStripRightClick.Name = "contextMenuStripRightClick";
            this.contextMenuStripRightClick.Size = new System.Drawing.Size(164, 92);
            // 
            // typeLineToolStripMenuItem
            // 
            this.typeLineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neprerivToolStripMenuItem,
            this.punctirToolStripMenuItem});
            this.typeLineToolStripMenuItem.Name = "typeLineToolStripMenuItem";
            this.typeLineToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.typeLineToolStripMenuItem.Text = "Тип линии";
            // 
            // neprerivToolStripMenuItem
            // 
            this.neprerivToolStripMenuItem.Name = "neprerivToolStripMenuItem";
            this.neprerivToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.neprerivToolStripMenuItem.Text = "Непрерывная";
            this.neprerivToolStripMenuItem.Click += new System.EventHandler(this.NeprerivToolStripMenuItem_Click);
            // 
            // punctirToolStripMenuItem
            // 
            this.punctirToolStripMenuItem.Name = "punctirToolStripMenuItem";
            this.punctirToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.punctirToolStripMenuItem.Text = "Пунктирная";
            this.punctirToolStripMenuItem.Click += new System.EventHandler(this.PunctirToolStripMenuItem_Click);
            // 
            // thicknessLineToolStripMenuItem
            // 
            this.thicknessLineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem10,
            this.toolStripMenuItem15});
            this.thicknessLineToolStripMenuItem.Name = "thicknessLineToolStripMenuItem";
            this.thicknessLineToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.thicknessLineToolStripMenuItem.Text = "Толщина линии";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem5.Text = "5";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.ToolStripMenuItem5_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem10.Text = "10";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.ToolStripMenuItem10_Click);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem15.Text = "15";
            this.toolStripMenuItem15.Click += new System.EventHandler(this.ToolStripMenuItem15_Click);
            // 
            // colorLineToolStripMenuItem
            // 
            this.colorLineToolStripMenuItem.Name = "colorLineToolStripMenuItem";
            this.colorLineToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.colorLineToolStripMenuItem.Text = "Цвет линии";
            this.colorLineToolStripMenuItem.Click += new System.EventHandler(this.ColorLineToolStripMenuItem_Click);
            // 
            // colorBackgroundToolStripMenuItem
            // 
            this.colorBackgroundToolStripMenuItem.Name = "colorBackgroundToolStripMenuItem";
            this.colorBackgroundToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.colorBackgroundToolStripMenuItem.Text = "Цвет фона";
            this.colorBackgroundToolStripMenuItem.Click += new System.EventHandler(this.ColorBackgroundToolStripMenuItem_Click);
            // 
            // FormLab1_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFigure);
            this.Name = "FormLab1_3";
            this.Text = "Блинова Елена, Задание 3 Лабораторной работы №1";
            this.contextMenuStripRightClick.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFigure;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRightClick;
        private System.Windows.Forms.ToolStripMenuItem typeLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neprerivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem punctirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thicknessLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem colorLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorBackgroundToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}