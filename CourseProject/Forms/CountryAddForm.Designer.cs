namespace CourseProject.Forms
{
    partial class CountryAddForm
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
            splitContainer1 = new SplitContainer();
            label9 = new Label();
            countryCodeBox = new TextBox();
            okButton = new Button();
            continentBox = new ComboBox();
            continentBindingSource = new BindingSource(components);
            label8 = new Label();
            label7 = new Label();
            areaBox = new TextBox();
            label6 = new Label();
            populationBox = new TextBox();
            label5 = new Label();
            languageBox = new TextBox();
            label4 = new Label();
            governmentBox = new TextBox();
            label3 = new Label();
            capitalBox = new TextBox();
            label2 = new Label();
            nameBox = new TextBox();
            label1 = new Label();
            descriptionBox = new RichTextBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)continentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label9);
            splitContainer1.Panel1.Controls.Add(countryCodeBox);
            splitContainer1.Panel1.Controls.Add(okButton);
            splitContainer1.Panel1.Controls.Add(continentBox);
            splitContainer1.Panel1.Controls.Add(label8);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(areaBox);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(populationBox);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(languageBox);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(governmentBox);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(capitalBox);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(nameBox);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(descriptionBox);
            splitContainer1.Panel2.Controls.Add(label10);
            splitContainer1.Size = new Size(784, 461);
            splitContainer1.SplitterDistance = 352;
            splitContainer1.TabIndex = 0;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(45, 117);
            label9.Name = "label9";
            label9.Size = new Size(115, 21);
            label9.TabIndex = 41;
            label9.Text = "Коди ISO 3166";
            // 
            // countryCodeBox
            // 
            countryCodeBox.Anchor = AnchorStyles.Top;
            countryCodeBox.Font = new Font("Segoe UI", 12F);
            countryCodeBox.Location = new Point(166, 110);
            countryCodeBox.MaxLength = 3;
            countryCodeBox.Name = "countryCodeBox";
            countryCodeBox.Size = new Size(157, 29);
            countryCodeBox.TabIndex = 24;
            countryCodeBox.Validating += countryCodeBox_Validating;
            // 
            // okButton
            // 
            okButton.Anchor = AnchorStyles.Top;
            okButton.Location = new Point(233, 399);
            okButton.Name = "okButton";
            okButton.Size = new Size(90, 30);
            okButton.TabIndex = 37;
            okButton.Text = "Додати";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // continentBox
            // 
            continentBox.Anchor = AnchorStyles.Top;
            continentBox.DataSource = continentBindingSource;
            continentBox.DisplayMember = "Name";
            continentBox.Font = new Font("Segoe UI", 12F);
            continentBox.FormattingEnabled = true;
            continentBox.Location = new Point(166, 350);
            continentBox.Name = "continentBox";
            continentBox.Size = new Size(157, 29);
            continentBox.TabIndex = 33;
            // 
            // continentBindingSource
            // 
            continentBindingSource.DataSource = typeof(Models.Continent);
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(87, 351);
            label8.Name = "label8";
            label8.Size = new Size(73, 21);
            label8.TabIndex = 39;
            label8.Text = "Материк";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(58, 312);
            label7.Name = "label7";
            label7.Size = new Size(102, 21);
            label7.TabIndex = 38;
            label7.Text = "Площа км^2";
            // 
            // areaBox
            // 
            areaBox.Anchor = AnchorStyles.Top;
            areaBox.Font = new Font("Segoe UI", 12F);
            areaBox.Location = new Point(166, 310);
            areaBox.Name = "areaBox";
            areaBox.Size = new Size(157, 29);
            areaBox.TabIndex = 32;
            areaBox.Validating += areaBox_Validating;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(74, 273);
            label6.Name = "label6";
            label6.Size = new Size(86, 21);
            label6.TabIndex = 36;
            label6.Text = "Населення";
            // 
            // populationBox
            // 
            populationBox.Anchor = AnchorStyles.Top;
            populationBox.Font = new Font("Segoe UI", 12F);
            populationBox.Location = new Point(166, 270);
            populationBox.Name = "populationBox";
            populationBox.Size = new Size(157, 29);
            populationBox.TabIndex = 30;
            populationBox.Validating += populationBox_Validating;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(111, 234);
            label5.Name = "label5";
            label5.Size = new Size(49, 21);
            label5.TabIndex = 34;
            label5.Text = "Мова";
            // 
            // languageBox
            // 
            languageBox.Anchor = AnchorStyles.Top;
            languageBox.Font = new Font("Segoe UI", 12F);
            languageBox.Location = new Point(166, 230);
            languageBox.Name = "languageBox";
            languageBox.Size = new Size(157, 29);
            languageBox.TabIndex = 29;
            languageBox.Validating += languageBox_Validating;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(26, 195);
            label4.Name = "label4";
            label4.Size = new Size(135, 21);
            label4.TabIndex = 31;
            label4.Text = "Форма правління";
            // 
            // governmentBox
            // 
            governmentBox.Anchor = AnchorStyles.Top;
            governmentBox.Font = new Font("Segoe UI", 12F);
            governmentBox.Location = new Point(166, 190);
            governmentBox.Name = "governmentBox";
            governmentBox.Size = new Size(157, 29);
            governmentBox.TabIndex = 28;
            governmentBox.Validating += governmentBox_Validating;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(89, 156);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 27;
            label3.Text = "Столиця";
            // 
            // capitalBox
            // 
            capitalBox.Anchor = AnchorStyles.Top;
            capitalBox.Font = new Font("Segoe UI", 12F);
            capitalBox.Location = new Point(166, 150);
            capitalBox.Name = "capitalBox";
            capitalBox.Size = new Size(157, 29);
            capitalBox.TabIndex = 26;
            capitalBox.Validating += capitalBox_Validating;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(108, 78);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 25;
            label2.Text = "Назва";
            // 
            // nameBox
            // 
            nameBox.Anchor = AnchorStyles.Top;
            nameBox.Font = new Font("Segoe UI", 12F);
            nameBox.Location = new Point(166, 70);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(157, 29);
            nameBox.TabIndex = 23;
            nameBox.Validating += nameBox_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 37);
            label1.TabIndex = 22;
            label1.Text = "Додати країну";
            // 
            // descriptionBox
            // 
            descriptionBox.Dock = DockStyle.Fill;
            descriptionBox.Font = new Font("Segoe UI", 12F);
            descriptionBox.Location = new Point(0, 25);
            descriptionBox.MaxLength = 1500;
            descriptionBox.Name = "descriptionBox";
            descriptionBox.Size = new Size(426, 434);
            descriptionBox.TabIndex = 35;
            descriptionBox.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Top;
            label10.Font = new Font("Segoe UI", 14F);
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(142, 25);
            label10.TabIndex = 40;
            label10.Text = "Короткий опис";
            // 
            // CountryAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(splitContainer1);
            MinimumSize = new Size(790, 475);
            Name = "CountryAddForm";
            Text = "Додати країну";
            FormClosing += AddCountryForm_FormClosing;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)continentBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label9;
        private TextBox countryCodeBox;
        private Button okButton;
        private ComboBox continentBox;
        private BindingSource continentBindingSource;
        private Label label8;
        private Label label7;
        private TextBox areaBox;
        private Label label6;
        private TextBox populationBox;
        private Label label5;
        private TextBox languageBox;
        private Label label4;
        private TextBox governmentBox;
        private Label label3;
        private TextBox capitalBox;
        private Label label2;
        private TextBox nameBox;
        private Label label1;
        private RichTextBox descriptionBox;
        private Label label10;
    }
}