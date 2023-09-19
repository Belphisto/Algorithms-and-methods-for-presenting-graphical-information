
namespace WindowsFormsLab1_BlinovaEM_KE_404
{
    partial class FormLab1_2
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
            this.labelTypeLine = new System.Windows.Forms.Label();
            this.textBoxInputLine = new System.Windows.Forms.TextBox();
            this.buttonAddTypeLine = new System.Windows.Forms.Button();
            this.labelListTypes = new System.Windows.Forms.Label();
            this.listBoxTypes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxListFigures = new System.Windows.Forms.ComboBox();
            this.labelYourChose = new System.Windows.Forms.Label();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonShowChose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTypeLine
            // 
            this.labelTypeLine.AutoSize = true;
            this.labelTypeLine.Location = new System.Drawing.Point(186, 37);
            this.labelTypeLine.Name = "labelTypeLine";
            this.labelTypeLine.Size = new System.Drawing.Size(59, 13);
            this.labelTypeLine.TabIndex = 0;
            this.labelTypeLine.Text = "Тип линии";
            // 
            // textBoxInputLine
            // 
            this.textBoxInputLine.Location = new System.Drawing.Point(85, 53);
            this.textBoxInputLine.Name = "textBoxInputLine";
            this.textBoxInputLine.Size = new System.Drawing.Size(260, 20);
            this.textBoxInputLine.TabIndex = 1;
            this.textBoxInputLine.Text = "Введите тип линии";
            // 
            // buttonAddTypeLine
            // 
            this.buttonAddTypeLine.Location = new System.Drawing.Point(85, 79);
            this.buttonAddTypeLine.Name = "buttonAddTypeLine";
            this.buttonAddTypeLine.Size = new System.Drawing.Size(260, 32);
            this.buttonAddTypeLine.TabIndex = 2;
            this.buttonAddTypeLine.Text = "Добавить";
            this.buttonAddTypeLine.UseVisualStyleBackColor = true;
            this.buttonAddTypeLine.Click += new System.EventHandler(this.buttonAddTypeLine_Click);
            // 
            // labelListTypes
            // 
            this.labelListTypes.AutoSize = true;
            this.labelListTypes.Location = new System.Drawing.Point(145, 144);
            this.labelListTypes.Name = "labelListTypes";
            this.labelListTypes.Size = new System.Drawing.Size(130, 13);
            this.labelListTypes.TabIndex = 3;
            this.labelListTypes.Text = "Список типов для линии";
            // 
            // listBoxTypes
            // 
            this.listBoxTypes.FormattingEnabled = true;
            this.listBoxTypes.Location = new System.Drawing.Point(85, 160);
            this.listBoxTypes.Name = "listBoxTypes";
            this.listBoxTypes.Size = new System.Drawing.Size(260, 95);
            this.listBoxTypes.TabIndex = 4;
            this.listBoxTypes.SelectedIndexChanged += new System.EventHandler(this.listBoxTypes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Список видов геометрических фигур";
            // 
            // comboBoxListFigures
            // 
            this.comboBoxListFigures.FormattingEnabled = true;
            this.comboBoxListFigures.Location = new System.Drawing.Point(85, 316);
            this.comboBoxListFigures.Name = "comboBoxListFigures";
            this.comboBoxListFigures.Size = new System.Drawing.Size(260, 21);
            this.comboBoxListFigures.TabIndex = 6;
            this.comboBoxListFigures.SelectedIndexChanged += new System.EventHandler(this.comboBoxListFigures_SelectedIndexChanged);
            // 
            // labelYourChose
            // 
            this.labelYourChose.AutoSize = true;
            this.labelYourChose.Location = new System.Drawing.Point(182, 391);
            this.labelYourChose.Name = "labelYourChose";
            this.labelYourChose.Size = new System.Drawing.Size(63, 13);
            this.labelYourChose.TabIndex = 7;
            this.labelYourChose.Text = "Ваш выбор";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Enabled = false;
            this.textBoxOutput.Location = new System.Drawing.Point(85, 407);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(260, 88);
            this.textBoxOutput.TabIndex = 8;
            // 
            // buttonShowChose
            // 
            this.buttonShowChose.Location = new System.Drawing.Point(85, 513);
            this.buttonShowChose.Name = "buttonShowChose";
            this.buttonShowChose.Size = new System.Drawing.Size(260, 32);
            this.buttonShowChose.TabIndex = 9;
            this.buttonShowChose.Text = "Посмотреть";
            this.buttonShowChose.UseVisualStyleBackColor = true;
            this.buttonShowChose.Click += new System.EventHandler(this.buttonShowChose_Click);
            // 
            // FormLab1_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 601);
            this.Controls.Add(this.buttonShowChose);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.labelYourChose);
            this.Controls.Add(this.comboBoxListFigures);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxTypes);
            this.Controls.Add(this.labelListTypes);
            this.Controls.Add(this.buttonAddTypeLine);
            this.Controls.Add(this.textBoxInputLine);
            this.Controls.Add(this.labelTypeLine);
            this.Name = "FormLab1_2";
            this.Text = "FormLab1_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTypeLine;
        private System.Windows.Forms.TextBox textBoxInputLine;
        private System.Windows.Forms.Button buttonAddTypeLine;
        private System.Windows.Forms.Label labelListTypes;
        private System.Windows.Forms.ListBox listBoxTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxListFigures;
        private System.Windows.Forms.Label labelYourChose;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonShowChose;
    }
}