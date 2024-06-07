namespace CourseProject.Forms
{
    partial class CityInfoForm
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
            cityDescription = new RichTextBox();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            deleteButton = new Button();
            coordinates = new Label();
            continent = new Label();
            population = new Label();
            country = new Label();
            cityName = new Label();
            descriptionTitle = new Label();
            splitContainer2 = new SplitContainer();
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
            // cityDescription
            // 
            cityDescription.BorderStyle = BorderStyle.None;
            cityDescription.Dock = DockStyle.Fill;
            cityDescription.Location = new Point(0, 0);
            cityDescription.Name = "cityDescription";
            cityDescription.ReadOnly = true;
            cityDescription.Size = new Size(489, 409);
            cityDescription.TabIndex = 0;
            cityDescription.Text = "";
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
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            splitContainer1.Panel1.Controls.Add(cityName);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(descriptionTitle);
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(784, 461);
            splitContainer1.SplitterDistance = 289;
            splitContainer1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(deleteButton, 0, 4);
            tableLayoutPanel1.Controls.Add(coordinates, 0, 3);
            tableLayoutPanel1.Controls.Add(continent, 0, 2);
            tableLayoutPanel1.Controls.Add(population, 0, 0);
            tableLayoutPanel1.Controls.Add(country, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 64);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.Size = new Size(287, 395);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // deleteButton
            // 
            deleteButton.Dock = DockStyle.Top;
            deleteButton.Location = new Point(3, 248);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(281, 23);
            deleteButton.TabIndex = 11;
            deleteButton.Text = "Видалити";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // coordinates
            // 
            coordinates.AutoSize = true;
            coordinates.Dock = DockStyle.Fill;
            coordinates.Font = new Font("Segoe UI", 12F);
            coordinates.Location = new Point(3, 135);
            coordinates.Name = "coordinates";
            coordinates.Size = new Size(281, 110);
            coordinates.TabIndex = 7;
            coordinates.Text = "Coordinates";
            // 
            // continent
            // 
            continent.AutoSize = true;
            continent.Dock = DockStyle.Fill;
            continent.Font = new Font("Segoe UI", 12F);
            continent.Location = new Point(3, 90);
            continent.Name = "continent";
            continent.Size = new Size(281, 45);
            continent.TabIndex = 6;
            continent.Text = "Continent";
            // 
            // population
            // 
            population.AutoSize = true;
            population.Dock = DockStyle.Fill;
            population.Font = new Font("Segoe UI", 12F);
            population.Location = new Point(3, 0);
            population.Name = "population";
            population.Size = new Size(281, 45);
            population.TabIndex = 3;
            population.Text = "Population";
            // 
            // country
            // 
            country.AutoSize = true;
            country.Dock = DockStyle.Fill;
            country.Font = new Font("Segoe UI", 12F);
            country.Location = new Point(3, 45);
            country.Name = "country";
            country.Size = new Size(281, 45);
            country.TabIndex = 5;
            country.Text = "Country";
            // 
            // cityName
            // 
            cityName.AutoSize = true;
            cityName.Font = new Font("Segoe UI", 20F);
            cityName.Location = new Point(12, 9);
            cityName.Name = "cityName";
            cityName.Size = new Size(105, 37);
            cityName.TabIndex = 0;
            cityName.Text = "CName";
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
            splitContainer2.Panel2.Controls.Add(cityDescription);
            splitContainer2.Size = new Size(489, 459);
            splitContainer2.SplitterDistance = 46;
            splitContainer2.TabIndex = 2;
            // 
            // CityInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(splitContainer1);
            MinimumSize = new Size(450, 360);
            Name = "CityInfoForm";
            Text = "CityInfoForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
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

        private RichTextBox cityDescription;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label continent;
        private Label country;
        private Label cityName;
        private Label descriptionTitle;
        private SplitContainer splitContainer2;
        private Label population;
        private Label coordinates;
        private Button deleteButton;
    }
}