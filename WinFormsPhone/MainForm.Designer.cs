namespace lab5
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            LastNameTextBox = new TextBox();
            NameTextBox = new TextBox();
            PatronymicTextBox = new TextBox();
            StreetTextBox = new TextBox();
            HouseNumericUpDown = new NumericUpDown();
            FlatNumericUpDown = new NumericUpDown();
            PhoneMaskedTextBox = new MaskedTextBox();
            PreviousButton = new Button();
            NextButton = new Button();
            SaveButton = new Button();
            AddButton = new Button();
            ((System.ComponentModel.ISupportInitialize)HouseNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FlatNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 30);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 0;
            label1.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 82);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 1;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 134);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 2;
            label3.Text = "Отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 189);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 3;
            label4.Text = "Улица";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(25, 255);
            label5.Name = "label5";
            label5.Size = new Size(57, 25);
            label5.TabIndex = 4;
            label5.Text = "Дом";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(25, 314);
            label6.Name = "label6";
            label6.Size = new Size(99, 25);
            label6.TabIndex = 5;
            label6.Text = "Квартира";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(25, 374);
            label7.Name = "label7";
            label7.Size = new Size(99, 25);
            label7.TabIndex = 6;
            label7.Text = "Телефон";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Enabled = false;
            LastNameTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameTextBox.Location = new Point(167, 26);
            LastNameTextBox.Margin = new Padding(3, 4, 3, 4);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(229, 30);
            LastNameTextBox.TabIndex = 7;
            // 
            // NameTextBox
            // 
            NameTextBox.Enabled = false;
            NameTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameTextBox.Location = new Point(167, 79);
            NameTextBox.Margin = new Padding(3, 4, 3, 4);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(229, 30);
            NameTextBox.TabIndex = 8;
            // 
            // PatronymicTextBox
            // 
            PatronymicTextBox.Enabled = false;
            PatronymicTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PatronymicTextBox.Location = new Point(167, 134);
            PatronymicTextBox.Margin = new Padding(3, 4, 3, 4);
            PatronymicTextBox.Name = "PatronymicTextBox";
            PatronymicTextBox.Size = new Size(229, 30);
            PatronymicTextBox.TabIndex = 9;
            // 
            // StreetTextBox
            // 
            StreetTextBox.Enabled = false;
            StreetTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StreetTextBox.Location = new Point(167, 189);
            StreetTextBox.Margin = new Padding(3, 4, 3, 4);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(229, 30);
            StreetTextBox.TabIndex = 10;
            // 
            // HouseNumericUpDown
            // 
            HouseNumericUpDown.Enabled = false;
            HouseNumericUpDown.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HouseNumericUpDown.Location = new Point(167, 254);
            HouseNumericUpDown.Margin = new Padding(3, 4, 3, 4);
            HouseNumericUpDown.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            HouseNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            HouseNumericUpDown.Name = "HouseNumericUpDown";
            HouseNumericUpDown.Size = new Size(229, 30);
            HouseNumericUpDown.TabIndex = 11;
            HouseNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // FlatNumericUpDown
            // 
            FlatNumericUpDown.Enabled = false;
            FlatNumericUpDown.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FlatNumericUpDown.Location = new Point(167, 312);
            FlatNumericUpDown.Margin = new Padding(3, 4, 3, 4);
            FlatNumericUpDown.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            FlatNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            FlatNumericUpDown.Name = "FlatNumericUpDown";
            FlatNumericUpDown.Size = new Size(229, 30);
            FlatNumericUpDown.TabIndex = 12;
            FlatNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // PhoneMaskedTextBox
            // 
            PhoneMaskedTextBox.Enabled = false;
            PhoneMaskedTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneMaskedTextBox.Location = new Point(167, 372);
            PhoneMaskedTextBox.Margin = new Padding(3, 4, 3, 4);
            PhoneMaskedTextBox.Mask = "(999) 000-0000";
            PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            PhoneMaskedTextBox.Size = new Size(229, 30);
            PhoneMaskedTextBox.TabIndex = 13;
            PhoneMaskedTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // PreviousButton
            // 
            PreviousButton.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            PreviousButton.Location = new Point(84, 448);
            PreviousButton.Margin = new Padding(3, 4, 3, 4);
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Size = new Size(65, 48);
            PreviousButton.TabIndex = 0;
            PreviousButton.Text = "<";
            PreviousButton.UseVisualStyleBackColor = true;
            PreviousButton.Click += PreviousButton_Click;
            // 
            // NextButton
            // 
            NextButton.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            NextButton.Location = new Point(174, 448);
            NextButton.Margin = new Padding(3, 4, 3, 4);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(65, 48);
            NextButton.TabIndex = 1;
            NextButton.Text = ">";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.Location = new Point(264, 448);
            SaveButton.Margin = new Padding(3, 4, 3, 4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(65, 48);
            SaveButton.TabIndex = 14;
            SaveButton.Text = "+";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.Location = new Point(130, 512);
            AddButton.Margin = new Padding(3, 4, 3, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(162, 48);
            AddButton.TabIndex = 15;
            AddButton.Text = "Добавить данные";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 606);
            Controls.Add(AddButton);
            Controls.Add(SaveButton);
            Controls.Add(NextButton);
            Controls.Add(PreviousButton);
            Controls.Add(PhoneMaskedTextBox);
            Controls.Add(FlatNumericUpDown);
            Controls.Add(HouseNumericUpDown);
            Controls.Add(StreetTextBox);
            Controls.Add(PatronymicTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Телефонный справочник";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)HouseNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)FlatNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.NumericUpDown HouseNumericUpDown;
        private System.Windows.Forms.NumericUpDown FlatNumericUpDown;
        private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private Button SaveButton;
        private Button AddButton;
    }
}

