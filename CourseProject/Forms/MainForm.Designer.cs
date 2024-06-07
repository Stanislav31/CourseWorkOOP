namespace CourseProject.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            splitContainer1 = new SplitContainer();
            dataView = new TreeView();
            splitContainer2 = new SplitContainer();
            toolStrip1 = new ToolStrip();
            addCountryButton = new ToolStripButton();
            getLocationButton = new ToolStripButton();
            helpButton = new ToolStripButton();
            clearButton = new Button();
            label11 = new Label();
            searchType = new ComboBox();
            searchButton = new Button();
            continentBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            populationBoxMax = new TextBox();
            populationBoxMin = new TextBox();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            areaBoxMax = new TextBox();
            areaBoxMin = new TextBox();
            label3 = new Label();
            nameBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            searchResultBoxCities = new ListBox();
            cityBindingSource = new BindingSource(components);
            searchResultBoxCountries = new ListBox();
            countryBindingSource = new BindingSource(components);
            searchResultBoxContinents = new ListBox();
            continentBindingSource = new BindingSource(components);
            searchResultBox = new ListBox();
            typeSearchBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cityBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)continentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)typeSearchBindingSource).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(dataView);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(884, 561);
            splitContainer1.SplitterDistance = 260;
            splitContainer1.TabIndex = 0;
            // 
            // dataView
            // 
            dataView.Dock = DockStyle.Fill;
            dataView.Location = new Point(0, 0);
            dataView.Name = "dataView";
            dataView.Size = new Size(258, 559);
            dataView.TabIndex = 10;
            dataView.DoubleClick += countryView_DoubleClick;
            // 
            // splitContainer2
            // 
            splitContainer2.BorderStyle = BorderStyle.FixedSingle;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(toolStrip1);
            splitContainer2.Panel1.Controls.Add(clearButton);
            splitContainer2.Panel1.Controls.Add(label11);
            splitContainer2.Panel1.Controls.Add(searchType);
            splitContainer2.Panel1.Controls.Add(searchButton);
            splitContainer2.Panel1.Controls.Add(continentBox);
            splitContainer2.Panel1.Controls.Add(label4);
            splitContainer2.Panel1.Controls.Add(label5);
            splitContainer2.Panel1.Controls.Add(label8);
            splitContainer2.Panel1.Controls.Add(populationBoxMax);
            splitContainer2.Panel1.Controls.Add(populationBoxMin);
            splitContainer2.Panel1.Controls.Add(label9);
            splitContainer2.Panel1.Controls.Add(label7);
            splitContainer2.Panel1.Controls.Add(label6);
            splitContainer2.Panel1.Controls.Add(areaBoxMax);
            splitContainer2.Panel1.Controls.Add(areaBoxMin);
            splitContainer2.Panel1.Controls.Add(label3);
            splitContainer2.Panel1.Controls.Add(nameBox);
            splitContainer2.Panel1.Controls.Add(label2);
            splitContainer2.Panel1.Controls.Add(label1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(label14);
            splitContainer2.Panel2.Controls.Add(label13);
            splitContainer2.Panel2.Controls.Add(label12);
            splitContainer2.Panel2.Controls.Add(searchResultBoxCities);
            splitContainer2.Panel2.Controls.Add(searchResultBoxCountries);
            splitContainer2.Panel2.Controls.Add(searchResultBoxContinents);
            splitContainer2.Panel2.Controls.Add(searchResultBox);
            splitContainer2.Size = new Size(620, 561);
            splitContainer2.SplitterDistance = 342;
            splitContainer2.TabIndex = 21;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { addCountryButton, getLocationButton, helpButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(618, 25);
            toolStrip1.TabIndex = 40;
            toolStrip1.Text = "toolStrip1";
            // 
            // addCountryButton
            // 
            addCountryButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            addCountryButton.Image = Properties.Resources.plusIcon;
            addCountryButton.ImageTransparentColor = Color.Magenta;
            addCountryButton.Name = "addCountryButton";
            addCountryButton.Size = new Size(23, 22);
            addCountryButton.Text = "Додати країну";
            addCountryButton.Click += addCountryButton_Click;
            // 
            // getLocationButton
            // 
            getLocationButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            getLocationButton.Image = Properties.Resources.locationIcon;
            getLocationButton.ImageTransparentColor = Color.Magenta;
            getLocationButton.Name = "getLocationButton";
            getLocationButton.Size = new Size(23, 22);
            getLocationButton.Text = "Визначити місцезнаходження";
            getLocationButton.Click += getLocationButton_Click;
            // 
            // helpButton
            // 
            helpButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            helpButton.Image = (Image)resources.GetObject("helpButton.Image");
            helpButton.ImageTransparentColor = Color.Magenta;
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(23, 22);
            helpButton.Text = "Довідка";
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.Top;
            clearButton.Location = new Point(489, 291);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 30);
            clearButton.TabIndex = 9;
            clearButton.Text = "Очистити";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(20, 289);
            label11.Name = "label11";
            label11.Size = new Size(99, 21);
            label11.TabIndex = 38;
            label11.Text = "Що шукати?";
            // 
            // searchType
            // 
            searchType.Anchor = AnchorStyles.Top;
            searchType.Font = new Font("Segoe UI", 12F);
            searchType.FormattingEnabled = true;
            searchType.Items.AddRange(new object[] { "-", "Материк", "Країна", "Місто" });
            searchType.Location = new Point(125, 289);
            searchType.Name = "searchType";
            searchType.Size = new Size(157, 29);
            searchType.TabIndex = 7;
            searchType.SelectedIndexChanged += searchType_SelectedIndexChanged;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top;
            searchButton.Location = new Point(407, 291);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 30);
            searchButton.TabIndex = 8;
            searchButton.Text = "Знайти";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // continentBox
            // 
            continentBox.Anchor = AnchorStyles.Top;
            continentBox.Font = new Font("Segoe UI", 12F);
            continentBox.Location = new Point(407, 115);
            continentBox.Name = "continentBox";
            continentBox.Size = new Size(157, 29);
            continentBox.TabIndex = 2;
            continentBox.Validating += continentBox_Validating;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(328, 115);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 34;
            label4.Text = "Материк";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(407, 226);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 33;
            label5.Text = "Менше ніж:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Location = new Point(407, 169);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 32;
            label8.Text = "Більше ніж:";
            // 
            // populationBoxMax
            // 
            populationBoxMax.Anchor = AnchorStyles.Top;
            populationBoxMax.Font = new Font("Segoe UI", 12F);
            populationBoxMax.Location = new Point(407, 244);
            populationBoxMax.Name = "populationBoxMax";
            populationBoxMax.Size = new Size(157, 29);
            populationBoxMax.TabIndex = 6;
            populationBoxMax.Validating += populationBoxMax_Validating;
            // 
            // populationBoxMin
            // 
            populationBoxMin.Anchor = AnchorStyles.Top;
            populationBoxMin.Font = new Font("Segoe UI", 12F);
            populationBoxMin.Location = new Point(407, 187);
            populationBoxMin.Name = "populationBoxMin";
            populationBoxMin.Size = new Size(157, 29);
            populationBoxMin.TabIndex = 5;
            populationBoxMin.Validating += populationBoxMin_Validating;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(315, 164);
            label9.Name = "label9";
            label9.Size = new Size(86, 21);
            label9.TabIndex = 29;
            label9.Text = "Населення";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(125, 227);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 28;
            label7.Text = "Менше ніж:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(125, 170);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 27;
            label6.Text = "Більше ніж:";
            // 
            // areaBoxMax
            // 
            areaBoxMax.Anchor = AnchorStyles.Top;
            areaBoxMax.Font = new Font("Segoe UI", 12F);
            areaBoxMax.Location = new Point(125, 245);
            areaBoxMax.Name = "areaBoxMax";
            areaBoxMax.Size = new Size(157, 29);
            areaBoxMax.TabIndex = 4;
            areaBoxMax.Validating += areaBoxMax_Validating;
            // 
            // areaBoxMin
            // 
            areaBoxMin.Anchor = AnchorStyles.Top;
            areaBoxMin.Font = new Font("Segoe UI", 12F);
            areaBoxMin.Location = new Point(125, 188);
            areaBoxMin.Name = "areaBoxMin";
            areaBoxMin.Size = new Size(157, 29);
            areaBoxMin.TabIndex = 3;
            areaBoxMin.Validating += areaBoxMin_Validating;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(7, 164);
            label3.Name = "label3";
            label3.Size = new Size(112, 21);
            label3.TabIndex = 24;
            label3.Text = "Площа (км^2)";
            // 
            // nameBox
            // 
            nameBox.Anchor = AnchorStyles.Top;
            nameBox.Font = new Font("Segoe UI", 12F);
            nameBox.Location = new Point(125, 115);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(157, 29);
            nameBox.TabIndex = 1;
            nameBox.Validating += nameBox_Validating;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(67, 115);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 22;
            label2.Text = "Назва";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(269, 23);
            label1.Name = "label1";
            label1.Size = new Size(100, 37);
            label1.TabIndex = 21;
            label1.Text = "Пошук";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top;
            label14.AutoSize = true;
            label14.Location = new Point(425, 19);
            label14.Name = "label14";
            label14.Size = new Size(38, 15);
            label14.TabIndex = 7;
            label14.Text = "Міста";
            label14.Visible = false;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.Location = new Point(218, 19);
            label13.Name = "label13";
            label13.Size = new Size(44, 15);
            label13.TabIndex = 6;
            label13.Text = "Країни";
            label13.Visible = false;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Location = new Point(11, 19);
            label12.Name = "label12";
            label12.Size = new Size(62, 15);
            label12.TabIndex = 5;
            label12.Text = "Материки";
            label12.Visible = false;
            // 
            // searchResultBoxCities
            // 
            searchResultBoxCities.Anchor = AnchorStyles.Top;
            searchResultBoxCities.DataSource = cityBindingSource;
            searchResultBoxCities.DisplayMember = "Name";
            searchResultBoxCities.Font = new Font("Segoe UI", 12F);
            searchResultBoxCities.FormattingEnabled = true;
            searchResultBoxCities.ItemHeight = 21;
            searchResultBoxCities.Location = new Point(425, 37);
            searchResultBoxCities.Name = "searchResultBoxCities";
            searchResultBoxCities.Size = new Size(190, 151);
            searchResultBoxCities.TabIndex = 14;
            searchResultBoxCities.Visible = false;
            searchResultBoxCities.DoubleClick += searchResultBoxCities_DoubleClick;
            // 
            // cityBindingSource
            // 
            cityBindingSource.DataSource = typeof(Models.City);
            // 
            // searchResultBoxCountries
            // 
            searchResultBoxCountries.Anchor = AnchorStyles.Top;
            searchResultBoxCountries.DataSource = countryBindingSource;
            searchResultBoxCountries.DisplayMember = "Name";
            searchResultBoxCountries.Font = new Font("Segoe UI", 12F);
            searchResultBoxCountries.FormattingEnabled = true;
            searchResultBoxCountries.ItemHeight = 21;
            searchResultBoxCountries.Location = new Point(218, 37);
            searchResultBoxCountries.Name = "searchResultBoxCountries";
            searchResultBoxCountries.Size = new Size(190, 151);
            searchResultBoxCountries.TabIndex = 13;
            searchResultBoxCountries.Visible = false;
            searchResultBoxCountries.DoubleClick += searchResultBoxCountries_DoubleClick;
            // 
            // countryBindingSource
            // 
            countryBindingSource.DataSource = typeof(Models.Country);
            // 
            // searchResultBoxContinents
            // 
            searchResultBoxContinents.Anchor = AnchorStyles.Top;
            searchResultBoxContinents.DataSource = continentBindingSource;
            searchResultBoxContinents.DisplayMember = "Name";
            searchResultBoxContinents.Font = new Font("Segoe UI", 12F);
            searchResultBoxContinents.FormattingEnabled = true;
            searchResultBoxContinents.ItemHeight = 21;
            searchResultBoxContinents.Location = new Point(11, 37);
            searchResultBoxContinents.Name = "searchResultBoxContinents";
            searchResultBoxContinents.Size = new Size(190, 151);
            searchResultBoxContinents.TabIndex = 12;
            searchResultBoxContinents.Visible = false;
            searchResultBoxContinents.DoubleClick += searchResultBoxContinents_DoubleClick;
            // 
            // continentBindingSource
            // 
            continentBindingSource.DataSource = typeof(Models.Continent);
            // 
            // searchResultBox
            // 
            searchResultBox.DataSource = typeSearchBindingSource;
            searchResultBox.DisplayMember = "Name";
            searchResultBox.Dock = DockStyle.Fill;
            searchResultBox.Font = new Font("Segoe UI", 12F);
            searchResultBox.FormattingEnabled = true;
            searchResultBox.ItemHeight = 21;
            searchResultBox.Location = new Point(0, 0);
            searchResultBox.Name = "searchResultBox";
            searchResultBox.Size = new Size(618, 213);
            searchResultBox.TabIndex = 11;
            searchResultBox.MouseDoubleClick += searchResultBox_MouseDoubleClick;
            // 
            // typeSearchBindingSource
            // 
            typeSearchBindingSource.DataSource = typeof(Models.Country);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(splitContainer1);
            MinimumSize = new Size(900, 570);
            Name = "MainForm";
            Text = "Довідник географа";
            FormClosing += MainForm_FormClosing;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cityBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)continentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)typeSearchBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Label label4;
        private Label label5;
        private Label label8;
        private TextBox populationBoxMax;
        private TextBox populationBoxMin;
        private Label label9;
        private Label label7;
        private Label label6;
        private TextBox areaBoxMax;
        private TextBox areaBoxMin;
        private Label label3;
        private TextBox nameBox;
        private Label label2;
        private Label label1;
        private ListBox searchResultBox;
        private Button searchButton;
        private TreeView dataView;
        private ComboBox searchType;
        private TextBox continentBox;
        private Label label11;
        private Button clearButton;
        private ToolStrip toolStrip1;
        private ToolStripButton getLocationButton;
        private ToolStripButton helpButton;
        private ListBox searchResultBoxCities;
        private ListBox searchResultBoxCountries;
        private ListBox searchResultBoxContinents;
        private Label label14;
        private Label label13;
        private Label label12;
        private BindingSource typeSearchBindingSource;
        private BindingSource cityBindingSource;
        private BindingSource countryBindingSource;
        private BindingSource continentBindingSource;
        private ToolStripButton addCountryButton;
    }
}