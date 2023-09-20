
namespace WindowsFormsLab1_BlinovaEM_KE_404
{
    partial class FormCreateObject
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
            this.labelTypeObj = new System.Windows.Forms.Label();
            this.comboBoxFigure = new System.Windows.Forms.ComboBox();
            this.labelCoordinate = new System.Windows.Forms.Label();
            this.labelWeignt = new System.Windows.Forms.Label();
            this.buttonCreateObj = new System.Windows.Forms.Button();
            this.textBoxCoordinate = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTypeObj
            // 
            this.labelTypeObj.AutoSize = true;
            this.labelTypeObj.Location = new System.Drawing.Point(108, 25);
            this.labelTypeObj.Name = "labelTypeObj";
            this.labelTypeObj.Size = new System.Drawing.Size(73, 13);
            this.labelTypeObj.TabIndex = 0;
            this.labelTypeObj.Text = "Тип Объекта";
            // 
            // comboBoxFigure
            // 
            this.comboBoxFigure.FormattingEnabled = true;
            this.comboBoxFigure.Location = new System.Drawing.Point(36, 51);
            this.comboBoxFigure.Name = "comboBoxFigure";
            this.comboBoxFigure.Size = new System.Drawing.Size(215, 21);
            this.comboBoxFigure.TabIndex = 1;
            // 
            // labelCoordinate
            // 
            this.labelCoordinate.AutoSize = true;
            this.labelCoordinate.Location = new System.Drawing.Point(83, 91);
            this.labelCoordinate.Name = "labelCoordinate";
            this.labelCoordinate.Size = new System.Drawing.Size(136, 13);
            this.labelCoordinate.TabIndex = 2;
            this.labelCoordinate.Text = "Координаты объекта (x;y)";
            // 
            // labelWeignt
            // 
            this.labelWeignt.AutoSize = true;
            this.labelWeignt.Location = new System.Drawing.Point(65, 162);
            this.labelWeignt.Name = "labelWeignt";
            this.labelWeignt.Size = new System.Drawing.Size(167, 13);
            this.labelWeignt.TabIndex = 3;
            this.labelWeignt.Text = "Размеры объекта (width;Height)";
            // 
            // buttonCreateObj
            // 
            this.buttonCreateObj.Location = new System.Drawing.Point(68, 232);
            this.buttonCreateObj.Name = "buttonCreateObj";
            this.buttonCreateObj.Size = new System.Drawing.Size(151, 37);
            this.buttonCreateObj.TabIndex = 4;
            this.buttonCreateObj.Text = "Нарисовать! :)";
            this.buttonCreateObj.UseVisualStyleBackColor = true;
            this.buttonCreateObj.Click += new System.EventHandler(this.ButtonCreateObj_Click);
            // 
            // textBoxCoordinate
            // 
            this.textBoxCoordinate.Location = new System.Drawing.Point(36, 117);
            this.textBoxCoordinate.Name = "textBoxCoordinate";
            this.textBoxCoordinate.Size = new System.Drawing.Size(215, 20);
            this.textBoxCoordinate.TabIndex = 5;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(36, 188);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(215, 20);
            this.textBoxWeight.TabIndex = 6;
            // 
            // FormCreateObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 317);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxCoordinate);
            this.Controls.Add(this.buttonCreateObj);
            this.Controls.Add(this.labelWeignt);
            this.Controls.Add(this.labelCoordinate);
            this.Controls.Add(this.comboBoxFigure);
            this.Controls.Add(this.labelTypeObj);
            this.Name = "FormCreateObject";
            this.Text = "Форма создания объекта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTypeObj;
        private System.Windows.Forms.ComboBox comboBoxFigure;
        private System.Windows.Forms.Label labelCoordinate;
        private System.Windows.Forms.Label labelWeignt;
        private System.Windows.Forms.Button buttonCreateObj;
        private System.Windows.Forms.TextBox textBoxCoordinate;
        private System.Windows.Forms.TextBox textBoxWeight;
    }
}