namespace CourseProject.Forms
{
    partial class AddCountryForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            nameBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            capitalBox = new TextBox();
            label4 = new Label();
            governmentBox = new TextBox();
            label5 = new Label();
            languageBox = new TextBox();
            label6 = new Label();
            populationBox = new TextBox();
            label7 = new Label();
            areaBox = new TextBox();
            label8 = new Label();
            continentBox = new ComboBox();
            continentBindingSource = new BindingSource(components);
            descriptionBox = new RichTextBox();
            label10 = new Label();
            okButton = new Button();
            label9 = new Label();
            countryCodeBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)continentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(194, 37);
            label1.TabIndex = 0;
            label1.Text = "Додати країну";
            // 
            // nameBox
            // 
            nameBox.Anchor = AnchorStyles.Top;
            nameBox.Font = new Font("Segoe UI", 12F);
            nameBox.Location = new Point(152, 70);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(134, 29);
            nameBox.TabIndex = 1;
            nameBox.Validating += nameBox_Validating;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(94, 78);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 2;
            label2.Text = "Назва";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(75, 156);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 4;
            label3.Text = "Столиця";
            // 
            // capitalBox
            // 
            capitalBox.Anchor = AnchorStyles.Top;
            capitalBox.Font = new Font("Segoe UI", 12F);
            capitalBox.Location = new Point(152, 150);
            capitalBox.Name = "capitalBox";
            capitalBox.Size = new Size(134, 29);
            capitalBox.TabIndex = 3;
            capitalBox.Validating += capitalBox_Validating;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 195);
            label4.Name = "label4";
            label4.Size = new Size(135, 21);
            label4.TabIndex = 6;
            label4.Text = "Форма правління";
            // 
            // governmentBox
            // 
            governmentBox.Anchor = AnchorStyles.Top;
            governmentBox.Font = new Font("Segoe UI", 12F);
            governmentBox.Location = new Point(152, 190);
            governmentBox.Name = "governmentBox";
            governmentBox.Size = new Size(134, 29);
            governmentBox.TabIndex = 5;
            governmentBox.Validating += governmentBox_Validating;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(97, 234);
            label5.Name = "label5";
            label5.Size = new Size(49, 21);
            label5.TabIndex = 8;
            label5.Text = "Мова";
            // 
            // languageBox
            // 
            languageBox.Anchor = AnchorStyles.Top;
            languageBox.Font = new Font("Segoe UI", 12F);
            languageBox.Location = new Point(152, 230);
            languageBox.Name = "languageBox";
            languageBox.Size = new Size(134, 29);
            languageBox.TabIndex = 7;
            languageBox.Validating += languageBox_Validating;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(60, 273);
            label6.Name = "label6";
            label6.Size = new Size(86, 21);
            label6.TabIndex = 10;
            label6.Text = "Населення";
            // 
            // populationBox
            // 
            populationBox.Anchor = AnchorStyles.Top;
            populationBox.Font = new Font("Segoe UI", 12F);
            populationBox.Location = new Point(152, 270);
            populationBox.Name = "populationBox";
            populationBox.Size = new Size(134, 29);
            populationBox.TabIndex = 9;
            populationBox.Validating += populationBox_Validating;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(44, 312);
            label7.Name = "label7";
            label7.Size = new Size(102, 21);
            label7.TabIndex = 12;
            label7.Text = "Площа км^2";
            // 
            // areaBox
            // 
            areaBox.Anchor = AnchorStyles.Top;
            areaBox.Font = new Font("Segoe UI", 12F);
            areaBox.Location = new Point(152, 310);
            areaBox.Name = "areaBox";
            areaBox.Size = new Size(134, 29);
            areaBox.TabIndex = 11;
            areaBox.Validating += areaBox_Validating;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(73, 351);
            label8.Name = "label8";
            label8.Size = new Size(73, 21);
            label8.TabIndex = 14;
            label8.Text = "Материк";
            // 
            // continentBox
            // 
            continentBox.Anchor = AnchorStyles.Top;
            continentBox.DataSource = continentBindingSource;
            continentBox.DisplayMember = "Name";
            continentBox.Font = new Font("Segoe UI", 12F);
            continentBox.FormattingEnabled = true;
            continentBox.Location = new Point(152, 350);
            continentBox.Name = "continentBox";
            continentBox.Size = new Size(134, 29);
            continentBox.TabIndex = 15;
            // 
            // continentBindingSource
            // 
            continentBindingSource.DataSource = typeof(Models.Continent);
            // 
            // descriptionBox
            // 
            descriptionBox.Anchor = AnchorStyles.Top;
            descriptionBox.Font = new Font("Segoe UI", 12F);
            descriptionBox.Location = new Point(331, 111);
            descriptionBox.MaxLength = 1500;
            descriptionBox.Name = "descriptionBox";
            descriptionBox.Size = new Size(441, 234);
            descriptionBox.TabIndex = 17;
            descriptionBox.Text = "";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(331, 78);
            label10.Name = "label10";
            label10.Size = new Size(117, 21);
            label10.TabIndex = 18;
            label10.Text = "Короткий опис";
            // 
            // okButton
            // 
            okButton.Location = new Point(211, 403);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 30);
            okButton.TabIndex = 19;
            okButton.Text = "Додати";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(31, 117);
            label9.Name = "label9";
            label9.Size = new Size(115, 21);
            label9.TabIndex = 21;
            label9.Text = "Коди ISO 3166";
            // 
            // countryCodeBox
            // 
            countryCodeBox.Anchor = AnchorStyles.Top;
            countryCodeBox.Font = new Font("Segoe UI", 12F);
            countryCodeBox.Location = new Point(152, 110);
            countryCodeBox.MaxLength = 3;
            countryCodeBox.Name = "countryCodeBox";
            countryCodeBox.Size = new Size(134, 29);
            countryCodeBox.TabIndex = 20;
            countryCodeBox.Validating += countryCodeBox_Validating;
            // 
            // AddCountryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(label9);
            Controls.Add(countryCodeBox);
            Controls.Add(okButton);
            Controls.Add(label10);
            Controls.Add(descriptionBox);
            Controls.Add(continentBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(areaBox);
            Controls.Add(label6);
            Controls.Add(populationBox);
            Controls.Add(label5);
            Controls.Add(languageBox);
            Controls.Add(label4);
            Controls.Add(governmentBox);
            Controls.Add(label3);
            Controls.Add(capitalBox);
            Controls.Add(label2);
            Controls.Add(nameBox);
            Controls.Add(label1);
            Name = "AddCountryForm";
            Text = "Додати країну";
            FormClosing += AddCountryForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)continentBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameBox;
        private Label label2;
        private Label label3;
        private TextBox capitalBox;
        private Label label4;
        private TextBox governmentBox;
        private Label label5;
        private TextBox languageBox;
        private Label label6;
        private TextBox populationBox;
        private Label label7;
        private TextBox areaBox;
        private Label label8;
        private ComboBox continentBox;
        private BindingSource continentBindingSource;
        private RichTextBox descriptionBox;
        private Label label10;
        private Button okButton;
        private Label label9;
        private TextBox countryCodeBox;
    }
}