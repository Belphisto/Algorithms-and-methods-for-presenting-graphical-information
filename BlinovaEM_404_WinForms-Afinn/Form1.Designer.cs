
namespace BlinovaEM_404_WinForms_Afinn
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
            this.panel = new System.Windows.Forms.Panel();
            this.ButtonMove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMoveX = new System.Windows.Forms.TextBox();
            this.textBoxMoveY = new System.Windows.Forms.TextBox();
            this.textBoxRotate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonRotate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxReSizeY = new System.Windows.Forms.TextBox();
            this.buttonReSize = new System.Windows.Forms.Button();
            this.textBoxReSizeX = new System.Windows.Forms.TextBox();
            this.ButtonCreateFigure = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel.Location = new System.Drawing.Point(217, 56);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(901, 600);
            this.panel.TabIndex = 0;
            // 
            // ButtonMove
            // 
            this.ButtonMove.Location = new System.Drawing.Point(21, 255);
            this.ButtonMove.Name = "ButtonMove";
            this.ButtonMove.Size = new System.Drawing.Size(152, 39);
            this.ButtonMove.TabIndex = 1;
            this.ButtonMove.Text = "Переместить";
            this.ButtonMove.UseVisualStyleBackColor = true;
            this.ButtonMove.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Смещение по x (целое)\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Смещение по у (целое)\r\n";
            // 
            // textBoxMoveX
            // 
            this.textBoxMoveX.Location = new System.Drawing.Point(47, 163);
            this.textBoxMoveX.Name = "textBoxMoveX";
            this.textBoxMoveX.Size = new System.Drawing.Size(97, 27);
            this.textBoxMoveX.TabIndex = 4;
            // 
            // textBoxMoveY
            // 
            this.textBoxMoveY.Location = new System.Drawing.Point(47, 219);
            this.textBoxMoveY.Name = "textBoxMoveY";
            this.textBoxMoveY.Size = new System.Drawing.Size(97, 27);
            this.textBoxMoveY.TabIndex = 5;
            // 
            // textBoxRotate
            // 
            this.textBoxRotate.Location = new System.Drawing.Point(47, 381);
            this.textBoxRotate.Name = "textBoxRotate";
            this.textBoxRotate.Size = new System.Drawing.Size(97, 27);
            this.textBoxRotate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "Угол поворота\r\n(0-360)\r\n";
            // 
            // ButtonRotate
            // 
            this.ButtonRotate.Location = new System.Drawing.Point(21, 417);
            this.ButtonRotate.Name = "ButtonRotate";
            this.ButtonRotate.Size = new System.Drawing.Size(152, 39);
            this.ButtonRotate.TabIndex = 8;
            this.ButtonRotate.Text = "Повернуть";
            this.ButtonRotate.UseVisualStyleBackColor = true;
            this.ButtonRotate.Click += new System.EventHandler(this.ButtonRotate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 488);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 40);
            this.label4.TabIndex = 9;
            this.label4.Text = "Коэффициент\r\nмастшабирования по оси х";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 564);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 40);
            this.label5.TabIndex = 10;
            this.label5.Text = "Коэффициент \r\nмастшабирования по оси у";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(477, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 11;
            // 
            // textBoxReSizeY
            // 
            this.textBoxReSizeY.Location = new System.Drawing.Point(49, 607);
            this.textBoxReSizeY.Name = "textBoxReSizeY";
            this.textBoxReSizeY.Size = new System.Drawing.Size(97, 27);
            this.textBoxReSizeY.TabIndex = 13;
            // 
            // buttonReSize
            // 
            this.buttonReSize.Location = new System.Drawing.Point(21, 643);
            this.buttonReSize.Name = "buttonReSize";
            this.buttonReSize.Size = new System.Drawing.Size(152, 39);
            this.buttonReSize.TabIndex = 14;
            this.buttonReSize.Text = "Изменить размер\r\n";
            this.buttonReSize.UseVisualStyleBackColor = true;
            this.buttonReSize.Click += new System.EventHandler(this.ButtonReSize_Click);
            // 
            // textBoxReSizeX
            // 
            this.textBoxReSizeX.Location = new System.Drawing.Point(49, 531);
            this.textBoxReSizeX.Name = "textBoxReSizeX";
            this.textBoxReSizeX.Size = new System.Drawing.Size(97, 27);
            this.textBoxReSizeX.TabIndex = 15;
            // 
            // ButtonCreateFigure
            // 
            this.ButtonCreateFigure.Location = new System.Drawing.Point(21, 56);
            this.ButtonCreateFigure.Name = "ButtonCreateFigure";
            this.ButtonCreateFigure.Size = new System.Drawing.Size(152, 39);
            this.ButtonCreateFigure.TabIndex = 16;
            this.ButtonCreateFigure.Text = "Создать фигуру";
            this.ButtonCreateFigure.UseVisualStyleBackColor = true;
            this.ButtonCreateFigure.Click += new System.EventHandler(this.ButtonCreateFigure_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(263, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 46);
            this.label7.TabIndex = 17;
            this.label7.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(179, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 46);
            this.label8.TabIndex = 18;
            this.label8.Text = "Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(194, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 46);
            this.label9.TabIndex = 19;
            this.label9.Text = "0,0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 717);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.ButtonCreateFigure);
            this.Controls.Add(this.textBoxReSizeX);
            this.Controls.Add(this.buttonReSize);
            this.Controls.Add(this.textBoxReSizeY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonRotate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxRotate);
            this.Controls.Add(this.textBoxMoveY);
            this.Controls.Add(this.textBoxMoveX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonMove);
            this.Name = "Form1";
            this.Text = "Blinova EM, KE-404";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button ButtonMove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMoveX;
        private System.Windows.Forms.TextBox textBoxMoveY;
        private System.Windows.Forms.TextBox textBoxRotate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonRotate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxReSizeY;
        private System.Windows.Forms.Button buttonReSize;
        private System.Windows.Forms.TextBox textBoxReSizeX;
        private System.Windows.Forms.Button ButtonCreateFigure;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

