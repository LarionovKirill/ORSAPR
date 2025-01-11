namespace orsapr
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.SeatLengthTextBox = new System.Windows.Forms.TextBox();
            this.SeatWidthTextBox = new System.Windows.Forms.TextBox();
            this.SeatThicknessTextBox = new System.Windows.Forms.TextBox();
            this.LegsHeightTextBox = new System.Windows.Forms.TextBox();
            this.LegsLengthAndWidthTextBox = new System.Windows.Forms.TextBox();
            this.SeatLengthLabel = new System.Windows.Forms.Label();
            this.LegsLengthLabel = new System.Windows.Forms.Label();
            this.SeatThicknessLabel = new System.Windows.Forms.Label();
            this.LegsHeighLabel = new System.Windows.Forms.Label();
            this.SeatWidthLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.WarningsGroupBox = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SeatParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.SeatFormLabel = new System.Windows.Forms.Label();
            this.SeatFormsСomboBox = new System.Windows.Forms.ComboBox();
            this.LegsParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.LegsFormLabel = new System.Windows.Forms.Label();
            this.LegsParametersComboBox = new System.Windows.Forms.ComboBox();
            this.WarningsGroupBox.SuspendLayout();
            this.SeatParametersGroupBox.SuspendLayout();
            this.LegsParametersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 318);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Построить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Build_Button_Click);
            // 
            // SeatLengthTextBox
            // 
            this.SeatLengthTextBox.BackColor = System.Drawing.Color.White;
            this.SeatLengthTextBox.Location = new System.Drawing.Point(169, 40);
            this.SeatLengthTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.SeatLengthTextBox.Name = "SeatLengthTextBox";
            this.SeatLengthTextBox.Size = new System.Drawing.Size(85, 20);
            this.SeatLengthTextBox.TabIndex = 1;
            this.SeatLengthTextBox.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.SeatLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_OnlyDigitKeyPress);
            // 
            // SeatWidthTextBox
            // 
            this.SeatWidthTextBox.Location = new System.Drawing.Point(169, 61);
            this.SeatWidthTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.SeatWidthTextBox.Name = "SeatWidthTextBox";
            this.SeatWidthTextBox.Size = new System.Drawing.Size(85, 20);
            this.SeatWidthTextBox.TabIndex = 2;
            this.SeatWidthTextBox.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.SeatWidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_OnlyDigitKeyPress);
            // 
            // SeatThicknessTextBox
            // 
            this.SeatThicknessTextBox.BackColor = System.Drawing.Color.White;
            this.SeatThicknessTextBox.Location = new System.Drawing.Point(169, 82);
            this.SeatThicknessTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.SeatThicknessTextBox.Name = "SeatThicknessTextBox";
            this.SeatThicknessTextBox.Size = new System.Drawing.Size(85, 20);
            this.SeatThicknessTextBox.TabIndex = 3;
            this.SeatThicknessTextBox.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.SeatThicknessTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_OnlyDigitKeyPress);
            // 
            // LegsHeightTextBox
            // 
            this.LegsHeightTextBox.BackColor = System.Drawing.Color.White;
            this.LegsHeightTextBox.Location = new System.Drawing.Point(169, 43);
            this.LegsHeightTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.LegsHeightTextBox.Name = "LegsHeightTextBox";
            this.LegsHeightTextBox.Size = new System.Drawing.Size(85, 20);
            this.LegsHeightTextBox.TabIndex = 4;
            this.LegsHeightTextBox.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.LegsHeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_OnlyDigitKeyPress);
            // 
            // LegsLengthAndWidthTextBox
            // 
            this.LegsLengthAndWidthTextBox.Location = new System.Drawing.Point(169, 64);
            this.LegsLengthAndWidthTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.LegsLengthAndWidthTextBox.Name = "LegsLengthAndWidthTextBox";
            this.LegsLengthAndWidthTextBox.Size = new System.Drawing.Size(85, 20);
            this.LegsLengthAndWidthTextBox.TabIndex = 5;
            this.LegsLengthAndWidthTextBox.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.LegsLengthAndWidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_OnlyDigitKeyPress);
            // 
            // SeatLengthLabel
            // 
            this.SeatLengthLabel.AutoSize = true;
            this.SeatLengthLabel.Location = new System.Drawing.Point(58, 43);
            this.SeatLengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SeatLengthLabel.Name = "SeatLengthLabel";
            this.SeatLengthLabel.Size = new System.Drawing.Size(40, 13);
            this.SeatLengthLabel.TabIndex = 6;
            this.SeatLengthLabel.Text = "Длина";
            // 
            // LegsLengthLabel
            // 
            this.LegsLengthLabel.AutoSize = true;
            this.LegsLengthLabel.Location = new System.Drawing.Point(58, 67);
            this.LegsLengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LegsLengthLabel.Name = "LegsLengthLabel";
            this.LegsLengthLabel.Size = new System.Drawing.Size(88, 13);
            this.LegsLengthLabel.TabIndex = 7;
            this.LegsLengthLabel.Text = "Ширина и длина";
            // 
            // SeatThicknessLabel
            // 
            this.SeatThicknessLabel.AutoSize = true;
            this.SeatThicknessLabel.Location = new System.Drawing.Point(58, 85);
            this.SeatThicknessLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SeatThicknessLabel.Name = "SeatThicknessLabel";
            this.SeatThicknessLabel.Size = new System.Drawing.Size(53, 13);
            this.SeatThicknessLabel.TabIndex = 8;
            this.SeatThicknessLabel.Text = "Толщина";
            // 
            // LegsHeighLabel
            // 
            this.LegsHeighLabel.AutoSize = true;
            this.LegsHeighLabel.Location = new System.Drawing.Point(58, 46);
            this.LegsHeighLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LegsHeighLabel.Name = "LegsHeighLabel";
            this.LegsHeighLabel.Size = new System.Drawing.Size(45, 13);
            this.LegsHeighLabel.TabIndex = 9;
            this.LegsHeighLabel.Text = "Высота";
            // 
            // SeatWidthLabel
            // 
            this.SeatWidthLabel.AutoSize = true;
            this.SeatWidthLabel.Location = new System.Drawing.Point(58, 64);
            this.SeatWidthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SeatWidthLabel.Name = "SeatWidthLabel";
            this.SeatWidthLabel.Size = new System.Drawing.Size(46, 13);
            this.SeatWidthLabel.TabIndex = 10;
            this.SeatWidthLabel.Text = "Ширина";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "от 300 до 400 мм";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 64);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "от 300 до 600 мм";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 85);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "от 20 до 35 мм";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(258, 46);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "от 300 до 400 мм";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(258, 67);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "от 25 до 35 мм";
            // 
            // WarningsGroupBox
            // 
            this.WarningsGroupBox.Controls.Add(this.label11);
            this.WarningsGroupBox.Location = new System.Drawing.Point(7, 228);
            this.WarningsGroupBox.MaximumSize = new System.Drawing.Size(417, 85);
            this.WarningsGroupBox.MinimumSize = new System.Drawing.Size(417, 85);
            this.WarningsGroupBox.Name = "WarningsGroupBox";
            this.WarningsGroupBox.Size = new System.Drawing.Size(417, 85);
            this.WarningsGroupBox.TabIndex = 17;
            this.WarningsGroupBox.TabStop = false;
            this.WarningsGroupBox.Text = "Предупреждения";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 16);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 0;
            // 
            // SeatParametersGroupBox
            // 
            this.SeatParametersGroupBox.Controls.Add(this.SeatFormLabel);
            this.SeatParametersGroupBox.Controls.Add(this.SeatFormsСomboBox);
            this.SeatParametersGroupBox.Controls.Add(this.SeatLengthLabel);
            this.SeatParametersGroupBox.Controls.Add(this.SeatLengthTextBox);
            this.SeatParametersGroupBox.Controls.Add(this.SeatWidthTextBox);
            this.SeatParametersGroupBox.Controls.Add(this.SeatThicknessTextBox);
            this.SeatParametersGroupBox.Controls.Add(this.label8);
            this.SeatParametersGroupBox.Controls.Add(this.SeatThicknessLabel);
            this.SeatParametersGroupBox.Controls.Add(this.label7);
            this.SeatParametersGroupBox.Controls.Add(this.SeatWidthLabel);
            this.SeatParametersGroupBox.Controls.Add(this.label6);
            this.SeatParametersGroupBox.Location = new System.Drawing.Point(7, 12);
            this.SeatParametersGroupBox.Name = "SeatParametersGroupBox";
            this.SeatParametersGroupBox.Size = new System.Drawing.Size(417, 110);
            this.SeatParametersGroupBox.TabIndex = 18;
            this.SeatParametersGroupBox.TabStop = false;
            this.SeatParametersGroupBox.Text = "Параметры сиденья";
            // 
            // SeatFormLabel
            // 
            this.SeatFormLabel.AutoSize = true;
            this.SeatFormLabel.Location = new System.Drawing.Point(58, 22);
            this.SeatFormLabel.Name = "SeatFormLabel";
            this.SeatFormLabel.Size = new System.Drawing.Size(44, 13);
            this.SeatFormLabel.TabIndex = 19;
            this.SeatFormLabel.Text = "Форма";
            // 
            // SeatFormsСomboBox
            // 
            this.SeatFormsСomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeatFormsСomboBox.FormattingEnabled = true;
            this.SeatFormsСomboBox.Items.AddRange(new object[] {
            "Прямоугольная",
            "Круглая"});
            this.SeatFormsСomboBox.Location = new System.Drawing.Point(169, 19);
            this.SeatFormsСomboBox.Name = "SeatFormsСomboBox";
            this.SeatFormsСomboBox.Size = new System.Drawing.Size(183, 21);
            this.SeatFormsСomboBox.TabIndex = 19;
            this.SeatFormsСomboBox.SelectedIndexChanged += new System.EventHandler(this.SeatTypeComboBox_SelectedIndexChanged);
            // 
            // LegsParametersGroupBox
            // 
            this.LegsParametersGroupBox.Controls.Add(this.LegsFormLabel);
            this.LegsParametersGroupBox.Controls.Add(this.LegsParametersComboBox);
            this.LegsParametersGroupBox.Controls.Add(this.label9);
            this.LegsParametersGroupBox.Controls.Add(this.LegsHeightTextBox);
            this.LegsParametersGroupBox.Controls.Add(this.LegsLengthAndWidthTextBox);
            this.LegsParametersGroupBox.Controls.Add(this.label10);
            this.LegsParametersGroupBox.Controls.Add(this.LegsLengthLabel);
            this.LegsParametersGroupBox.Controls.Add(this.LegsHeighLabel);
            this.LegsParametersGroupBox.Location = new System.Drawing.Point(7, 129);
            this.LegsParametersGroupBox.Name = "LegsParametersGroupBox";
            this.LegsParametersGroupBox.Size = new System.Drawing.Size(417, 93);
            this.LegsParametersGroupBox.TabIndex = 20;
            this.LegsParametersGroupBox.TabStop = false;
            this.LegsParametersGroupBox.Text = "Параметры ножек";
            // 
            // LegsFormLabel
            // 
            this.LegsFormLabel.AutoSize = true;
            this.LegsFormLabel.Location = new System.Drawing.Point(58, 25);
            this.LegsFormLabel.Name = "LegsFormLabel";
            this.LegsFormLabel.Size = new System.Drawing.Size(44, 13);
            this.LegsFormLabel.TabIndex = 17;
            this.LegsFormLabel.Text = "Форма";
            // 
            // LegsParametersComboBox
            // 
            this.LegsParametersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LegsParametersComboBox.FormattingEnabled = true;
            this.LegsParametersComboBox.Items.AddRange(new object[] {
            "Квадратные",
            "Круглые"});
            this.LegsParametersComboBox.Location = new System.Drawing.Point(169, 22);
            this.LegsParametersComboBox.Name = "LegsParametersComboBox";
            this.LegsParametersComboBox.Size = new System.Drawing.Size(183, 21);
            this.LegsParametersComboBox.TabIndex = 16;
            this.LegsParametersComboBox.SelectedIndexChanged += new System.EventHandler(this.LegsTypeComboBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 349);
            this.Controls.Add(this.LegsParametersGroupBox);
            this.Controls.Add(this.SeatParametersGroupBox);
            this.Controls.Add(this.WarningsGroupBox);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximumSize = new System.Drawing.Size(452, 388);
            this.MinimumSize = new System.Drawing.Size(452, 388);
            this.Name = "MainForm";
            this.Text = "Табурет";
            this.WarningsGroupBox.ResumeLayout(false);
            this.WarningsGroupBox.PerformLayout();
            this.SeatParametersGroupBox.ResumeLayout(false);
            this.SeatParametersGroupBox.PerformLayout();
            this.LegsParametersGroupBox.ResumeLayout(false);
            this.LegsParametersGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SeatWidthTextBox;
        private System.Windows.Forms.TextBox SeatThicknessTextBox;
        private System.Windows.Forms.TextBox LegsHeightTextBox;
        private System.Windows.Forms.TextBox LegsLengthAndWidthTextBox;
        private System.Windows.Forms.Label SeatLengthLabel;
        private System.Windows.Forms.Label LegsLengthLabel;
        private System.Windows.Forms.Label SeatThicknessLabel;
        private System.Windows.Forms.Label LegsHeighLabel;
        private System.Windows.Forms.Label SeatWidthLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox WarningsGroupBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox SeatParametersGroupBox;
        private System.Windows.Forms.Label SeatFormLabel;
        private System.Windows.Forms.ComboBox SeatFormsСomboBox;
        private System.Windows.Forms.GroupBox LegsParametersGroupBox;
        private System.Windows.Forms.ComboBox LegsParametersComboBox;
        private System.Windows.Forms.Label LegsFormLabel;
        internal System.Windows.Forms.TextBox SeatLengthTextBox;
    }
}

