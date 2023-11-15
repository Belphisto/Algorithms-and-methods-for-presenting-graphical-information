
namespace Tree_rendering
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
            this.trackBarWindF = new System.Windows.Forms.TrackBar();
            this.trackBarRainfall = new System.Windows.Forms.TrackBar();
            this.trackBarTemp = new System.Windows.Forms.TrackBar();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.labelRainfall = new System.Windows.Forms.Label();
            this.labelRainfall1 = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelWindF = new System.Windows.Forms.Label();
            this.labelRainfall2 = new System.Windows.Forms.Label();
            this.labelTemp2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWindF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRainfall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarWindF
            // 
            this.trackBarWindF.Location = new System.Drawing.Point(30, 37);
            this.trackBarWindF.Maximum = 25;
            this.trackBarWindF.Name = "trackBarWindF";
            this.trackBarWindF.Size = new System.Drawing.Size(221, 45);
            this.trackBarWindF.TabIndex = 0;
            this.trackBarWindF.Scroll += new System.EventHandler(this.trackBarWindF_Scroll);
            // 
            // trackBarRainfall
            // 
            this.trackBarRainfall.Location = new System.Drawing.Point(30, 111);
            this.trackBarRainfall.Maximum = 100;
            this.trackBarRainfall.Name = "trackBarRainfall";
            this.trackBarRainfall.Size = new System.Drawing.Size(221, 45);
            this.trackBarRainfall.TabIndex = 1;
            this.trackBarRainfall.Scroll += new System.EventHandler(this.trackBarRainfall_Scroll);
            // 
            // trackBarTemp
            // 
            this.trackBarTemp.Location = new System.Drawing.Point(30, 186);
            this.trackBarTemp.Maximum = 50;
            this.trackBarTemp.Minimum = -50;
            this.trackBarTemp.Name = "trackBarTemp";
            this.trackBarTemp.Size = new System.Drawing.Size(221, 45);
            this.trackBarTemp.TabIndex = 2;
            this.trackBarTemp.Scroll += new System.EventHandler(this.trackBarTemp_Scroll);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(30, 251);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(221, 36);
            this.ApplyButton.TabIndex = 3;
            this.ApplyButton.Text = "Применить новые параметры";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Интенсивность ветра (м/с) =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Интенсивность осадков (%) =";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(30, 168);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(153, 15);
            this.label.TabIndex = 7;
            this.label.Text = "Температура воздуха (С) =";
            // 
            // labelRainfall
            // 
            this.labelRainfall.Location = new System.Drawing.Point(0, 0);
            this.labelRainfall.Name = "labelRainfall";
            this.labelRainfall.Size = new System.Drawing.Size(100, 23);
            this.labelRainfall.TabIndex = 19;
            // 
            // labelRainfall1
            // 
            this.labelRainfall1.Location = new System.Drawing.Point(0, 0);
            this.labelRainfall1.Name = "labelRainfall1";
            this.labelRainfall1.Size = new System.Drawing.Size(100, 23);
            this.labelRainfall1.TabIndex = 18;
            // 
            // labelTemp
            // 
            this.labelTemp.Location = new System.Drawing.Point(0, 0);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(100, 23);
            this.labelTemp.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "25";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "-50";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "+50";
            // 
            // labelWindF
            // 
            this.labelWindF.AutoSize = true;
            this.labelWindF.Location = new System.Drawing.Point(190, 19);
            this.labelWindF.Name = "labelWindF";
            this.labelWindF.Size = new System.Drawing.Size(38, 15);
            this.labelWindF.TabIndex = 20;
            this.labelWindF.Text = "label9";
            // 
            // labelRainfall2
            // 
            this.labelRainfall2.AutoSize = true;
            this.labelRainfall2.Location = new System.Drawing.Point(206, 93);
            this.labelRainfall2.Name = "labelRainfall2";
            this.labelRainfall2.Size = new System.Drawing.Size(38, 15);
            this.labelRainfall2.TabIndex = 21;
            this.labelRainfall2.Text = "label9";
            // 
            // labelTemp2
            // 
            this.labelTemp2.AutoSize = true;
            this.labelTemp2.Location = new System.Drawing.Point(179, 168);
            this.labelTemp2.Name = "labelTemp2";
            this.labelTemp2.Size = new System.Drawing.Size(38, 15);
            this.labelTemp2.TabIndex = 22;
            this.labelTemp2.Text = "label9";
            // 
            // UserInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 304);
            this.Controls.Add(this.labelTemp2);
            this.Controls.Add(this.labelRainfall2);
            this.Controls.Add(this.labelWindF);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.labelRainfall1);
            this.Controls.Add(this.labelRainfall);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.trackBarTemp);
            this.Controls.Add(this.trackBarRainfall);
            this.Controls.Add(this.trackBarWindF);
            this.Name = "UserInputForm";
            this.Text = "Задать параметры погодных условий";
            this.Load += new System.EventHandler(this.UserInputForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWindF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRainfall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarWindF;
        private System.Windows.Forms.TrackBar trackBarRainfall;
        private System.Windows.Forms.TrackBar trackBarTemp;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelRainfall;
        private System.Windows.Forms.Label labelRainfall1;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelWindF;
        private System.Windows.Forms.Label labelRainfall2;
        private System.Windows.Forms.Label labelTemp2;
    }
}