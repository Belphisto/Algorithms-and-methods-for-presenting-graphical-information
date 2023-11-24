
namespace FractalsRenderer
{
    partial class UserInputForm
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.AngleTrackBar = new System.Windows.Forms.TrackBar();
            this.LenghtTrackBar = new System.Windows.Forms.TrackBar();
            this.DepthTrackBar = new System.Windows.Forms.TrackBar();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ColorButton = new System.Windows.Forms.Button();
            this.labelAngle = new System.Windows.Forms.Label();
            this.labelLenght = new System.Windows.Forms.Label();
            this.labelDepth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AngleTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LenghtTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // AngleTrackBar
            // 
            this.AngleTrackBar.Location = new System.Drawing.Point(31, 54);
            this.AngleTrackBar.Maximum = 50;
            this.AngleTrackBar.Minimum = 40;
            this.AngleTrackBar.Name = "AngleTrackBar";
            this.AngleTrackBar.Size = new System.Drawing.Size(201, 45);
            this.AngleTrackBar.TabIndex = 0;
            this.AngleTrackBar.Value = 40;
            this.AngleTrackBar.Scroll += new System.EventHandler(this.AngleTrackBar_Scroll);
            // 
            // LenghtTrackBar
            // 
            this.LenghtTrackBar.Location = new System.Drawing.Point(31, 108);
            this.LenghtTrackBar.Maximum = 6;
            this.LenghtTrackBar.Minimum = 1;
            this.LenghtTrackBar.Name = "LenghtTrackBar";
            this.LenghtTrackBar.Size = new System.Drawing.Size(201, 45);
            this.LenghtTrackBar.TabIndex = 1;
            this.LenghtTrackBar.Value = 1;
            this.LenghtTrackBar.Scroll += new System.EventHandler(this.LenghtTrackBar_Scroll);
            // 
            // DepthTrackBar
            // 
            this.DepthTrackBar.Location = new System.Drawing.Point(31, 176);
            this.DepthTrackBar.Maximum = 16;
            this.DepthTrackBar.Minimum = 2;
            this.DepthTrackBar.Name = "DepthTrackBar";
            this.DepthTrackBar.Size = new System.Drawing.Size(201, 45);
            this.DepthTrackBar.TabIndex = 2;
            this.DepthTrackBar.Value = 2;
            this.DepthTrackBar.Scroll += new System.EventHandler(this.DepthTrackBar_Scroll);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(82, 279);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(110, 35);
            this.ConfirmButton.TabIndex = 3;
            this.ConfirmButton.Text = "Нарисовать";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "40";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "16";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Глубина рекурсии";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Длина шага";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(96, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Угол наклона";
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(65, 227);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(140, 23);
            this.ColorButton.TabIndex = 13;
            this.ColorButton.Text = "Выбрать цвет";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // labelAngle
            // 
            this.labelAngle.AutoSize = true;
            this.labelAngle.Location = new System.Drawing.Point(184, 36);
            this.labelAngle.Name = "labelAngle";
            this.labelAngle.Size = new System.Drawing.Size(15, 15);
            this.labelAngle.TabIndex = 14;
            this.labelAngle.Text = "=";
            // 
            // labelLenght
            // 
            this.labelLenght.AutoSize = true;
            this.labelLenght.Location = new System.Drawing.Point(184, 94);
            this.labelLenght.Name = "labelLenght";
            this.labelLenght.Size = new System.Drawing.Size(15, 15);
            this.labelLenght.TabIndex = 15;
            this.labelLenght.Text = "=";
            // 
            // labelDepth
            // 
            this.labelDepth.AutoSize = true;
            this.labelDepth.Location = new System.Drawing.Point(198, 156);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(15, 15);
            this.labelDepth.TabIndex = 16;
            this.labelDepth.Text = "=";
            // 
            // UserInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 335);
            this.Controls.Add(this.labelDepth);
            this.Controls.Add(this.labelLenght);
            this.Controls.Add(this.labelAngle);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.DepthTrackBar);
            this.Controls.Add(this.LenghtTrackBar);
            this.Controls.Add(this.AngleTrackBar);
            this.Name = "UserInputForm";
            this.Text = "UserInputForm";
            ((System.ComponentModel.ISupportInitialize)(this.AngleTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LenghtTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar AngleTrackBar;
        private System.Windows.Forms.TrackBar LenghtTrackBar;
        private System.Windows.Forms.TrackBar DepthTrackBar;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Label labelAngle;
        private System.Windows.Forms.Label labelLenght;
        private System.Windows.Forms.Label labelDepth;
    }
}