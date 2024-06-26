﻿namespace CourseProject.Forms
{
    partial class CountryInfoForm
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
            splitContainer1 = new SplitContainer();
            deleteButton = new Button();
            addCitiesButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            continent = new Label();
            countryCode = new Label();
            area = new Label();
            population = new Label();
            language = new Label();
            government = new Label();
            capital = new Label();
            countryName = new Label();
            descriptionTitle = new Label();
            splitContainer2 = new SplitContainer();
            countryDescription = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(deleteButton);
            splitContainer1.Panel1.Controls.Add(addCitiesButton);
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(descriptionTitle);
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(784, 461);
            splitContainer1.SplitterDistance = 286;
            splitContainer1.TabIndex = 0;
            // 
            // deleteButton
            // 
            deleteButton.Dock = DockStyle.Top;
            deleteButton.Location = new Point(0, 392);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(284, 23);
            deleteButton.TabIndex = 10;
            deleteButton.Text = "Видалити";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // addCitiesButton
            // 
            addCitiesButton.Dock = DockStyle.Top;
            addCitiesButton.Location = new Point(0, 369);
            addCitiesButton.Name = "addCitiesButton";
            addCitiesButton.Size = new Size(284, 23);
            addCitiesButton.TabIndex = 9;
            addCitiesButton.Text = "Змінити міста";
            addCitiesButton.UseVisualStyleBackColor = true;
            addCitiesButton.Click += changeButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(continent, 0, 7);
            tableLayoutPanel1.Controls.Add(countryCode, 0, 6);
            tableLayoutPanel1.Controls.Add(area, 0, 5);
            tableLayoutPanel1.Controls.Add(population, 0, 4);
            tableLayoutPanel1.Controls.Add(language, 0, 3);
            tableLayoutPanel1.Controls.Add(government, 0, 2);
            tableLayoutPanel1.Controls.Add(capital, 0, 1);
            tableLayoutPanel1.Controls.Add(countryName, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.Size = new Size(284, 369);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // continent
            // 
            continent.AutoSize = true;
            continent.Dock = DockStyle.Fill;
            continent.Font = new Font("Segoe UI", 12F);
            continent.Location = new Point(3, 315);
            continent.Name = "continent";
            continent.Size = new Size(278, 54);
            continent.TabIndex = 6;
            continent.Text = "Continent";
            // 
            // countryCode
            // 
            countryCode.AutoSize = true;
            countryCode.Dock = DockStyle.Fill;
            countryCode.Font = new Font("Segoe UI", 12F);
            countryCode.Location = new Point(3, 270);
            countryCode.Name = "countryCode";
            countryCode.Size = new Size(278, 45);
            countryCode.TabIndex = 5;
            countryCode.Text = "CountryCode";
            // 
            // area
            // 
            area.AutoSize = true;
            area.Dock = DockStyle.Fill;
            area.Font = new Font("Segoe UI", 12F);
            area.Location = new Point(3, 225);
            area.Name = "area";
            area.Size = new Size(278, 45);
            area.TabIndex = 4;
            area.Text = "Area";
            // 
            // population
            // 
            population.AutoSize = true;
            population.Dock = DockStyle.Fill;
            population.Font = new Font("Segoe UI", 12F);
            population.Location = new Point(3, 180);
            population.Name = "population";
            population.Size = new Size(278, 45);
            population.TabIndex = 3;
            population.Text = "Population";
            // 
            // language
            // 
            language.AutoSize = true;
            language.Dock = DockStyle.Fill;
            language.Font = new Font("Segoe UI", 12F);
            language.Location = new Point(3, 135);
            language.Name = "language";
            language.Size = new Size(278, 45);
            language.TabIndex = 2;
            language.Text = "Language";
            // 
            // government
            // 
            government.AutoSize = true;
            government.Dock = DockStyle.Fill;
            government.Font = new Font("Segoe UI", 12F);
            government.Location = new Point(3, 90);
            government.Name = "government";
            government.Size = new Size(278, 45);
            government.TabIndex = 1;
            government.Text = "Government";
            // 
            // capital
            // 
            capital.AutoSize = true;
            capital.Dock = DockStyle.Fill;
            capital.Font = new Font("Segoe UI", 12F);
            capital.Location = new Point(3, 45);
            capital.Name = "capital";
            capital.Size = new Size(278, 45);
            capital.TabIndex = 8;
            capital.Text = "Capital";
            // 
            // countryName
            // 
            countryName.AutoSize = true;
            countryName.Dock = DockStyle.Fill;
            countryName.Font = new Font("Segoe UI", 20F);
            countryName.Location = new Point(3, 0);
            countryName.Name = "countryName";
            countryName.Size = new Size(278, 45);
            countryName.TabIndex = 0;
            countryName.Text = "CName";
            // 
            // descriptionTitle
            // 
            descriptionTitle.AutoSize = true;
            descriptionTitle.Font = new Font("Segoe UI", 18F);
            descriptionTitle.Location = new Point(5, 6);
            descriptionTitle.Name = "descriptionTitle";
            descriptionTitle.Size = new Size(181, 32);
            descriptionTitle.TabIndex = 1;
            descriptionTitle.Text = "DescriptionTitle";
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.FixedPanel = FixedPanel.Panel1;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(countryDescription);
            splitContainer2.Size = new Size(492, 459);
            splitContainer2.SplitterDistance = 46;
            splitContainer2.TabIndex = 2;
            // 
            // countryDescription
            // 
            countryDescription.BorderStyle = BorderStyle.None;
            countryDescription.Dock = DockStyle.Fill;
            countryDescription.Location = new Point(0, 0);
            countryDescription.Name = "countryDescription";
            countryDescription.ReadOnly = true;
            countryDescription.Size = new Size(492, 409);
            countryDescription.TabIndex = 0;
            countryDescription.Text = "";
            // 
            // CountryInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(splitContainer1);
            MinimumSize = new Size(450, 450);
            Name = "CountryInfoForm";
            Text = "CountyInfoForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label countryName;
        private TableLayoutPanel tableLayoutPanel1;
        private Label government;
        private Label language;
        private Label population;
        private Label area;
        private Label countryCode;
        private RichTextBox countryDescription;
        private Label descriptionTitle;
        private SplitContainer splitContainer2;
        private Label continent;
        private Label capital;
        private Button addCitiesButton;
        private Button deleteButton;
    }
}