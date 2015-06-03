namespace Productivity_Report
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ExcelLoad_Label = new System.Windows.Forms.Label();
            this.textBox_ExcelFileName = new System.Windows.Forms.TextBox();
            this.button_ExcelFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(435, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(165, 27);
            this.comboBox1.MaxDropDownItems = 26;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose Pay Period to Run:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose Fiscal Year:";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(13, 27);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(124, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // ExcelLoad_Label
            // 
            this.ExcelLoad_Label.AutoSize = true;
            this.ExcelLoad_Label.Location = new System.Drawing.Point(16, 66);
            this.ExcelLoad_Label.Name = "ExcelLoad_Label";
            this.ExcelLoad_Label.Size = new System.Drawing.Size(63, 13);
            this.ExcelLoad_Label.TabIndex = 6;
            this.ExcelLoad_Label.Text = "Load Excel:";
            // 
            // textBox_ExcelFileName
            // 
            this.textBox_ExcelFileName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Productivity_Report.Properties.Settings.Default, "ExcelFilePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_ExcelFileName.Location = new System.Drawing.Point(19, 83);
            this.textBox_ExcelFileName.Name = "textBox_ExcelFileName";
            this.textBox_ExcelFileName.Size = new System.Drawing.Size(392, 20);
            this.textBox_ExcelFileName.TabIndex = 7;
            // 
            // button_ExcelFile
            // 
            this.button_ExcelFile.Location = new System.Drawing.Point(426, 81);
            this.button_ExcelFile.Name = "button_ExcelFile";
            this.button_ExcelFile.Size = new System.Drawing.Size(25, 23);
            this.button_ExcelFile.TabIndex = 8;
            this.button_ExcelFile.Text = "...";
            this.button_ExcelFile.UseVisualStyleBackColor = true;
            this.button_ExcelFile.Click += new System.EventHandler(this.button_ExcelFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Facility:";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(330, 27);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 190);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_ExcelFile);
            this.Controls.Add(this.textBox_ExcelFileName);
            this.Controls.Add(this.ExcelLoad_Label);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Productivity Report";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label ExcelLoad_Label;
        private System.Windows.Forms.TextBox textBox_ExcelFileName;
        private System.Windows.Forms.Button button_ExcelFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}

