namespace CourseProject.Forms
{
    partial class ContinentInfoForm
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
            continentDescription = new RichTextBox();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            area = new Label();
            population = new Label();
            countryCount = new Label();
            continentName = new Label();
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
            // continentDescription
            // 
            continentDescription.BorderStyle = BorderStyle.None;
            continentDescription.Dock = DockStyle.Fill;
            continentDescription.Location = new Point(0, 0);
            continentDescription.Name = "continentDescription";
            continentDescription.ReadOnly = true;
            continentDescription.Size = new Size(539, 409);
            continentDescription.TabIndex = 0;
            continentDescription.Text = "";
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
            splitContainer1.Panel1.Controls.Add(continentName);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(descriptionTitle);
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(784, 461);
            splitContainer1.SplitterDistance = 239;
            splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(area, 0, 2);
            tableLayoutPanel1.Controls.Add(population, 0, 0);
            tableLayoutPanel1.Controls.Add(countryCount, 0, 1);
            tableLayoutPanel1.Location = new Point(0, 63);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(236, 395);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // area
            // 
            area.AutoSize = true;
            area.Dock = DockStyle.Fill;
            area.Font = new Font("Segoe UI", 12F);
            area.Location = new Point(3, 90);
            area.Name = "area";
            area.Size = new Size(230, 305);
            area.TabIndex = 6;
            area.Text = "Area";
            // 
            // population
            // 
            population.AutoSize = true;
            population.Dock = DockStyle.Fill;
            population.Font = new Font("Segoe UI", 12F);
            population.Location = new Point(3, 0);
            population.Name = "population";
            population.Size = new Size(230, 45);
            population.TabIndex = 3;
            population.Text = "Population";
            // 
            // countryCount
            // 
            countryCount.AutoSize = true;
            countryCount.Dock = DockStyle.Fill;
            countryCount.Font = new Font("Segoe UI", 12F);
            countryCount.Location = new Point(3, 45);
            countryCount.Name = "countryCount";
            countryCount.Size = new Size(230, 45);
            countryCount.TabIndex = 5;
            countryCount.Text = "CountryCount";
            // 
            // continentName
            // 
            continentName.AutoSize = true;
            continentName.Font = new Font("Segoe UI", 20F);
            continentName.Location = new Point(12, 9);
            continentName.Name = "continentName";
            continentName.Size = new Size(105, 37);
            continentName.TabIndex = 0;
            continentName.Text = "CName";
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
            splitContainer2.Panel2.Controls.Add(continentDescription);
            splitContainer2.Size = new Size(539, 459);
            splitContainer2.SplitterDistance = 46;
            splitContainer2.TabIndex = 2;
            // 
            // ContinentInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(splitContainer1);
            MinimumSize = new Size(450, 240);
            Name = "ContinentInfoForm";
            Text = "ContinentInfoForm";
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

        private RichTextBox continentDescription;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label area;
        private Label population;
        private Label countryCount;
        private Label continentName;
        private Label descriptionTitle;
        private SplitContainer splitContainer2;
    }
}