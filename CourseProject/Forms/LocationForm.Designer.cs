namespace CourseProject.Forms
{
    partial class LocationForm
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
            country = new Label();
            city = new Label();
            SuspendLayout();
            // 
            // country
            // 
            country.Anchor = AnchorStyles.None;
            country.AutoSize = true;
            country.Font = new Font("Segoe UI", 16F);
            country.Location = new Point(124, 40);
            country.Name = "country";
            country.Size = new Size(90, 30);
            country.TabIndex = 0;
            country.Text = "Country";
            // 
            // city
            // 
            city.Anchor = AnchorStyles.None;
            city.AutoSize = true;
            city.Font = new Font("Segoe UI", 16F);
            city.Location = new Point(124, 85);
            city.Name = "city";
            city.Size = new Size(50, 30);
            city.TabIndex = 1;
            city.Text = "City";
            // 
            // LocationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 191);
            Controls.Add(city);
            Controls.Add(country);
            MinimumSize = new Size(200, 180);
            Name = "LocationForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "LocationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label country;
        private Label city;
    }
}