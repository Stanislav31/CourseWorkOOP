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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            splitContainer1 = new SplitContainer();
            countryBox = new ListBox();
            splitContainer2 = new SplitContainer();
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
            label10 = new Label();
            searchResultBox = new ListBox();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            создатьToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            сохранитькакToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            печатьToolStripMenuItem = new ToolStripMenuItem();
            предварительныйпросмотрToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            выходToolStripMenuItem = new ToolStripMenuItem();
            изменитьToolStripMenuItem = new ToolStripMenuItem();
            отменитьToolStripMenuItem = new ToolStripMenuItem();
            повторитьToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            вырезатьToolStripMenuItem = new ToolStripMenuItem();
            копироватьToolStripMenuItem = new ToolStripMenuItem();
            вставитьToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            выбратьвсеToolStripMenuItem = new ToolStripMenuItem();
            инструментыToolStripMenuItem = new ToolStripMenuItem();
            настройкиToolStripMenuItem = new ToolStripMenuItem();
            параметрыToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            содержимоеToolStripMenuItem = new ToolStripMenuItem();
            индексToolStripMenuItem = new ToolStripMenuItem();
            поискToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            опрограммеToolStripMenuItem = new ToolStripMenuItem();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 24);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label11);
            splitContainer1.Panel1.Controls.Add(countryBox);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(884, 537);
            splitContainer1.SplitterDistance = 300;
            splitContainer1.TabIndex = 0;
            // 
            // countryBox
            // 
            countryBox.Dock = DockStyle.Fill;
            countryBox.Font = new Font("Segoe UI", 12F);
            countryBox.FormattingEnabled = true;
            countryBox.ItemHeight = 21;
            countryBox.Location = new Point(0, 0);
            countryBox.Name = "countryBox";
            countryBox.Size = new Size(298, 535);
            countryBox.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.BorderStyle = BorderStyle.FixedSingle;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
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
            splitContainer2.Panel2.Controls.Add(label10);
            splitContainer2.Panel2.Controls.Add(searchResultBox);
            splitContainer2.Size = new Size(580, 537);
            splitContainer2.SplitterDistance = 328;
            splitContainer2.TabIndex = 21;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(255, 289);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 36;
            searchButton.Text = "Знайти";
            searchButton.UseVisualStyleBackColor = true;
            // 
            // continentBox
            // 
            continentBox.Anchor = AnchorStyles.Top;
            continentBox.Font = new Font("Segoe UI", 12F);
            continentBox.Location = new Point(381, 115);
            continentBox.Name = "continentBox";
            continentBox.Size = new Size(157, 29);
            continentBox.TabIndex = 35;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(302, 115);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 34;
            label4.Text = "Материк";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(381, 226);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 33;
            label5.Text = "Менше ніж:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Location = new Point(381, 169);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 32;
            label8.Text = "Більше ніж:";
            // 
            // populationBoxMax
            // 
            populationBoxMax.Anchor = AnchorStyles.Top;
            populationBoxMax.Font = new Font("Segoe UI", 12F);
            populationBoxMax.Location = new Point(381, 244);
            populationBoxMax.Name = "populationBoxMax";
            populationBoxMax.Size = new Size(157, 29);
            populationBoxMax.TabIndex = 31;
            // 
            // populationBoxMin
            // 
            populationBoxMin.Anchor = AnchorStyles.Top;
            populationBoxMin.Font = new Font("Segoe UI", 12F);
            populationBoxMin.Location = new Point(381, 187);
            populationBoxMin.Name = "populationBoxMin";
            populationBoxMin.Size = new Size(157, 29);
            populationBoxMin.TabIndex = 30;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(289, 164);
            label9.Name = "label9";
            label9.Size = new Size(86, 21);
            label9.TabIndex = 29;
            label9.Text = "Населення";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(99, 227);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 28;
            label7.Text = "Менше ніж:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(99, 170);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 27;
            label6.Text = "Більше ніж:";
            // 
            // areaBoxMax
            // 
            areaBoxMax.Anchor = AnchorStyles.Top;
            areaBoxMax.Font = new Font("Segoe UI", 12F);
            areaBoxMax.Location = new Point(99, 245);
            areaBoxMax.Name = "areaBoxMax";
            areaBoxMax.Size = new Size(157, 29);
            areaBoxMax.TabIndex = 26;
            // 
            // areaBoxMin
            // 
            areaBoxMin.Anchor = AnchorStyles.Top;
            areaBoxMin.Font = new Font("Segoe UI", 12F);
            areaBoxMin.Location = new Point(99, 188);
            areaBoxMin.Name = "areaBoxMin";
            areaBoxMin.Size = new Size(157, 29);
            areaBoxMin.TabIndex = 25;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(34, 164);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 24;
            label3.Text = "Площа";
            // 
            // nameBox
            // 
            nameBox.Anchor = AnchorStyles.Top;
            nameBox.Font = new Font("Segoe UI", 12F);
            nameBox.Location = new Point(99, 115);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(157, 29);
            nameBox.TabIndex = 23;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(41, 115);
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
            label1.Location = new Point(243, 23);
            label1.Name = "label1";
            label1.Size = new Size(100, 37);
            label1.TabIndex = 21;
            label1.Text = "Пошук";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(113, 15);
            label10.TabIndex = 0;
            label10.Text = "Результати пошуку";
            // 
            // searchResultBox
            // 
            searchResultBox.Dock = DockStyle.Fill;
            searchResultBox.Font = new Font("Segoe UI", 12F);
            searchResultBox.FormattingEnabled = true;
            searchResultBox.ItemHeight = 21;
            searchResultBox.Location = new Point(0, 0);
            searchResultBox.Name = "searchResultBox";
            searchResultBox.Size = new Size(578, 203);
            searchResultBox.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, изменитьToolStripMenuItem, инструментыToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(884, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { создатьToolStripMenuItem, открытьToolStripMenuItem, toolStripSeparator, сохранитьToolStripMenuItem, сохранитькакToolStripMenuItem, toolStripSeparator1, печатьToolStripMenuItem, предварительныйпросмотрToolStripMenuItem, toolStripSeparator2, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "&Файл";
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.Image = (Image)resources.GetObject("создатьToolStripMenuItem.Image");
            создатьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            создатьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            создатьToolStripMenuItem.Size = new Size(233, 22);
            создатьToolStripMenuItem.Text = "&Создать";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Image = (Image)resources.GetObject("открытьToolStripMenuItem.Image");
            открытьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            открытьToolStripMenuItem.Size = new Size(233, 22);
            открытьToolStripMenuItem.Text = "&Открыть";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(230, 6);
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Image = (Image)resources.GetObject("сохранитьToolStripMenuItem.Image");
            сохранитьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            сохранитьToolStripMenuItem.Size = new Size(233, 22);
            сохранитьToolStripMenuItem.Text = "&Сохранить";
            // 
            // сохранитькакToolStripMenuItem
            // 
            сохранитькакToolStripMenuItem.Name = "сохранитькакToolStripMenuItem";
            сохранитькакToolStripMenuItem.Size = new Size(233, 22);
            сохранитькакToolStripMenuItem.Text = "Сохранить &как";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(230, 6);
            // 
            // печатьToolStripMenuItem
            // 
            печатьToolStripMenuItem.Image = (Image)resources.GetObject("печатьToolStripMenuItem.Image");
            печатьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            печатьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            печатьToolStripMenuItem.Size = new Size(233, 22);
            печатьToolStripMenuItem.Text = "&Печать";
            // 
            // предварительныйпросмотрToolStripMenuItem
            // 
            предварительныйпросмотрToolStripMenuItem.Image = (Image)resources.GetObject("предварительныйпросмотрToolStripMenuItem.Image");
            предварительныйпросмотрToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            предварительныйпросмотрToolStripMenuItem.Name = "предварительныйпросмотрToolStripMenuItem";
            предварительныйпросмотрToolStripMenuItem.Size = new Size(233, 22);
            предварительныйпросмотрToolStripMenuItem.Text = "Предварительный про&смотр";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(230, 6);
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(233, 22);
            выходToolStripMenuItem.Text = "Вы&ход";
            // 
            // изменитьToolStripMenuItem
            // 
            изменитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { отменитьToolStripMenuItem, повторитьToolStripMenuItem, toolStripSeparator3, вырезатьToolStripMenuItem, копироватьToolStripMenuItem, вставитьToolStripMenuItem, toolStripSeparator4, выбратьвсеToolStripMenuItem });
            изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            изменитьToolStripMenuItem.Size = new Size(73, 20);
            изменитьToolStripMenuItem.Text = "&Изменить";
            // 
            // отменитьToolStripMenuItem
            // 
            отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
            отменитьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            отменитьToolStripMenuItem.Size = new Size(181, 22);
            отменитьToolStripMenuItem.Text = "&Отменить";
            // 
            // повторитьToolStripMenuItem
            // 
            повторитьToolStripMenuItem.Name = "повторитьToolStripMenuItem";
            повторитьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            повторитьToolStripMenuItem.Size = new Size(181, 22);
            повторитьToolStripMenuItem.Text = "&Повторить";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(178, 6);
            // 
            // вырезатьToolStripMenuItem
            // 
            вырезатьToolStripMenuItem.Image = (Image)resources.GetObject("вырезатьToolStripMenuItem.Image");
            вырезатьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            вырезатьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            вырезатьToolStripMenuItem.Size = new Size(181, 22);
            вырезатьToolStripMenuItem.Text = "В&ырезать";
            // 
            // копироватьToolStripMenuItem
            // 
            копироватьToolStripMenuItem.Image = (Image)resources.GetObject("копироватьToolStripMenuItem.Image");
            копироватьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            копироватьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            копироватьToolStripMenuItem.Size = new Size(181, 22);
            копироватьToolStripMenuItem.Text = "&Копировать";
            // 
            // вставитьToolStripMenuItem
            // 
            вставитьToolStripMenuItem.Image = (Image)resources.GetObject("вставитьToolStripMenuItem.Image");
            вставитьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            вставитьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            вставитьToolStripMenuItem.Size = new Size(181, 22);
            вставитьToolStripMenuItem.Text = "&Вставить";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(178, 6);
            // 
            // выбратьвсеToolStripMenuItem
            // 
            выбратьвсеToolStripMenuItem.Name = "выбратьвсеToolStripMenuItem";
            выбратьвсеToolStripMenuItem.Size = new Size(181, 22);
            выбратьвсеToolStripMenuItem.Text = "Выбрать &все";
            // 
            // инструментыToolStripMenuItem
            // 
            инструментыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { настройкиToolStripMenuItem, параметрыToolStripMenuItem });
            инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            инструментыToolStripMenuItem.Size = new Size(95, 20);
            инструментыToolStripMenuItem.Text = "&Инструменты";
            // 
            // настройкиToolStripMenuItem
            // 
            настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            настройкиToolStripMenuItem.Size = new Size(138, 22);
            настройкиToolStripMenuItem.Text = "&Настройки";
            // 
            // параметрыToolStripMenuItem
            // 
            параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            параметрыToolStripMenuItem.Size = new Size(138, 22);
            параметрыToolStripMenuItem.Text = "&Параметры";
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { содержимоеToolStripMenuItem, индексToolStripMenuItem, поискToolStripMenuItem, toolStripSeparator5, опрограммеToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "&Справка";
            // 
            // содержимоеToolStripMenuItem
            // 
            содержимоеToolStripMenuItem.Name = "содержимоеToolStripMenuItem";
            содержимоеToolStripMenuItem.Size = new Size(158, 22);
            содержимоеToolStripMenuItem.Text = "&Содержимое";
            // 
            // индексToolStripMenuItem
            // 
            индексToolStripMenuItem.Name = "индексToolStripMenuItem";
            индексToolStripMenuItem.Size = new Size(158, 22);
            индексToolStripMenuItem.Text = "&Индекс";
            // 
            // поискToolStripMenuItem
            // 
            поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            поискToolStripMenuItem.Size = new Size(158, 22);
            поискToolStripMenuItem.Text = "&Поиск";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(155, 6);
            // 
            // опрограммеToolStripMenuItem
            // 
            опрограммеToolStripMenuItem.Name = "опрограммеToolStripMenuItem";
            опрограммеToolStripMenuItem.Size = new Size(158, 22);
            опрограммеToolStripMenuItem.Text = "&О программе…";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(-1, -1);
            label11.Name = "label11";
            label11.Size = new Size(80, 15);
            label11.TabIndex = 1;
            label11.Text = "Список країн";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(840, 570);
            Name = "MainForm";
            Text = "MainForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private ListBox countryBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem сохранитькакToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem печатьToolStripMenuItem;
        private ToolStripMenuItem предварительныйпросмотрToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem изменитьToolStripMenuItem;
        private ToolStripMenuItem отменитьToolStripMenuItem;
        private ToolStripMenuItem повторитьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem вырезатьToolStripMenuItem;
        private ToolStripMenuItem копироватьToolStripMenuItem;
        private ToolStripMenuItem вставитьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem выбратьвсеToolStripMenuItem;
        private ToolStripMenuItem инструментыToolStripMenuItem;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        private ToolStripMenuItem параметрыToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem содержимоеToolStripMenuItem;
        private ToolStripMenuItem индексToolStripMenuItem;
        private ToolStripMenuItem поискToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem опрограммеToolStripMenuItem;
        private SplitContainer splitContainer2;
        private TextBox continentBox;
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
        private Label label10;
        private ListBox searchResultBox;
        private Button searchButton;
        private Label label11;
    }
}