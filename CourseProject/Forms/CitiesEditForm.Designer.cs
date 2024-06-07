namespace CourseProject.Forms
{
    partial class CitiesEditForm
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
            label8 = new Label();
            descriptionBox = new RichTextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            longtitudeBox = new TextBox();
            latitudeBox = new TextBox();
            populationBox = new TextBox();
            nameBox = new TextBox();
            label1 = new Label();
            splitContainer2 = new SplitContainer();
            citiesBox = new ListBox();
            cityBindingSource = new BindingSource(components);
            label2 = new Label();
            saveButton = new Button();
            deleteButton = new Button();
            addButton = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cityBindingSource).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label8);
            splitContainer1.Panel1.Controls.Add(descriptionBox);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(longtitudeBox);
            splitContainer1.Panel1.Controls.Add(latitudeBox);
            splitContainer1.Panel1.Controls.Add(populationBox);
            splitContainer1.Panel1.Controls.Add(nameBox);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(784, 461);
            splitContainer1.SplitterDistance = 337;
            splitContainer1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(3, 339);
            label8.Name = "label8";
            label8.Size = new Size(117, 21);
            label8.TabIndex = 11;
            label8.Text = "Короткий опис";
            // 
            // descriptionBox
            // 
            descriptionBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descriptionBox.Location = new Point(3, 363);
            descriptionBox.Name = "descriptionBox";
            descriptionBox.Size = new Size(329, 93);
            descriptionBox.TabIndex = 10;
            descriptionBox.Text = "";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(7, 263);
            label7.Name = "label7";
            label7.Size = new Size(209, 15);
            label7.TabIndex = 9;
            label7.Text = "Довгота (зі знаком \"-\", якщо західна)";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(7, 192);
            label6.Name = "label6";
            label6.Size = new Size(217, 15);
            label6.TabIndex = 8;
            label6.Text = "Широта (зі знаком \"-\", якщо південна)";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(7, 155);
            label5.Name = "label5";
            label5.Size = new Size(185, 21);
            label5.TabIndex = 7;
            label5.Text = "Географічні координати";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(28, 107);
            label4.Name = "label4";
            label4.Size = new Size(86, 21);
            label4.TabIndex = 6;
            label4.Text = "Населення";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(62, 58);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 5;
            label3.Text = "Назва";
            // 
            // longtitudeBox
            // 
            longtitudeBox.Anchor = AnchorStyles.None;
            longtitudeBox.Font = new Font("Segoe UI", 12F);
            longtitudeBox.Location = new Point(120, 294);
            longtitudeBox.Name = "longtitudeBox";
            longtitudeBox.Size = new Size(127, 29);
            longtitudeBox.TabIndex = 4;
            longtitudeBox.Validating += longtitudeBox_Validating;
            // 
            // latitudeBox
            // 
            latitudeBox.Anchor = AnchorStyles.None;
            latitudeBox.Font = new Font("Segoe UI", 12F);
            latitudeBox.Location = new Point(120, 221);
            latitudeBox.Name = "latitudeBox";
            latitudeBox.Size = new Size(127, 29);
            latitudeBox.TabIndex = 3;
            latitudeBox.Validating += latitudeBox_Validating;
            // 
            // populationBox
            // 
            populationBox.Anchor = AnchorStyles.None;
            populationBox.Font = new Font("Segoe UI", 12F);
            populationBox.Location = new Point(120, 107);
            populationBox.Name = "populationBox";
            populationBox.Size = new Size(127, 29);
            populationBox.TabIndex = 2;
            populationBox.Validating += populationBox_Validating;
            // 
            // nameBox
            // 
            nameBox.Anchor = AnchorStyles.None;
            nameBox.Font = new Font("Segoe UI", 12F);
            nameBox.Location = new Point(120, 58);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(127, 29);
            nameBox.TabIndex = 1;
            nameBox.Validating += nameBox_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(181, 37);
            label1.TabIndex = 0;
            label1.Text = "Міста країни ";
            // 
            // splitContainer2
            // 
            splitContainer2.BorderStyle = BorderStyle.FixedSingle;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.FixedPanel = FixedPanel.Panel2;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(citiesBox);
            splitContainer2.Panel1.Controls.Add(label2);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(saveButton);
            splitContainer2.Panel2.Controls.Add(deleteButton);
            splitContainer2.Panel2.Controls.Add(addButton);
            splitContainer2.Size = new Size(443, 461);
            splitContainer2.SplitterDistance = 364;
            splitContainer2.TabIndex = 2;
            // 
            // citiesBox
            // 
            citiesBox.DataSource = cityBindingSource;
            citiesBox.DisplayMember = "Name";
            citiesBox.Dock = DockStyle.Fill;
            citiesBox.FormattingEnabled = true;
            citiesBox.ItemHeight = 15;
            citiesBox.Location = new Point(0, 25);
            citiesBox.Name = "citiesBox";
            citiesBox.Size = new Size(441, 337);
            citiesBox.TabIndex = 3;
            citiesBox.DoubleClick += citiesBox_DoubleClick;
            // 
            // cityBindingSource
            // 
            cityBindingSource.DataSource = typeof(Models.City);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 2;
            label2.Text = "Список міст";
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.None;
            saveButton.Location = new Point(20, 24);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(100, 30);
            saveButton.TabIndex = 2;
            saveButton.Text = "Зберегти зміни";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.None;
            deleteButton.Location = new Point(320, 24);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(100, 30);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Видалити місто";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.None;
            addButton.Location = new Point(170, 24);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 30);
            addButton.TabIndex = 0;
            addButton.Text = "Додати місто";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // CitiesEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(splitContainer1);
            MinimumSize = new Size(770, 460);
            Name = "CitiesEditForm";
            Text = "CityAddForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cityBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private SplitContainer splitContainer2;
        private ListBox citiesBox;
        private Label label2;
        private Button addButton;
        private BindingSource cityBindingSource;
        private Button deleteButton;
        private TextBox populationBox;
        private TextBox nameBox;
        private TextBox latitudeBox;
        private TextBox longtitudeBox;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label8;
        private RichTextBox descriptionBox;
        private Button saveButton;
    }
}