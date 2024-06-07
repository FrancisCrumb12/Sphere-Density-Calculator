namespace HW_PROG1103
{
    partial class Form1
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
            this.Sphere_Groupbox = new System.Windows.Forms.GroupBox();
            this.SphereCalculateButton = new System.Windows.Forms.Button();
            this.Sphere_ResetButtonOnClick = new System.Windows.Forms.Button();
            this.Sphere_RadiusTextbox = new System.Windows.Forms.TextBox();
            this.Sphere_richTextBox = new System.Windows.Forms.RichTextBox();
            this.Sphere_trackBar = new System.Windows.Forms.TrackBar();
            this.SphereDensity_textBox = new System.Windows.Forms.TextBox();
            this.RadiusLabelSphere = new System.Windows.Forms.Label();
            this.DensityLabelSphere = new System.Windows.Forms.Label();
            this.Sphere_Groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sphere_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Sphere_Groupbox
            // 
            this.Sphere_Groupbox.Controls.Add(this.SphereCalculateButton);
            this.Sphere_Groupbox.Controls.Add(this.Sphere_ResetButtonOnClick);
            this.Sphere_Groupbox.Controls.Add(this.Sphere_RadiusTextbox);
            this.Sphere_Groupbox.Controls.Add(this.Sphere_richTextBox);
            this.Sphere_Groupbox.Controls.Add(this.Sphere_trackBar);
            this.Sphere_Groupbox.Controls.Add(this.SphereDensity_textBox);
            this.Sphere_Groupbox.Controls.Add(this.RadiusLabelSphere);
            this.Sphere_Groupbox.Controls.Add(this.DensityLabelSphere);
            this.Sphere_Groupbox.Location = new System.Drawing.Point(51, 46);
            this.Sphere_Groupbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sphere_Groupbox.Name = "Sphere_Groupbox";
            this.Sphere_Groupbox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sphere_Groupbox.Size = new System.Drawing.Size(543, 732);
            this.Sphere_Groupbox.TabIndex = 0;
            this.Sphere_Groupbox.TabStop = false;
            this.Sphere_Groupbox.Text = "Sphere";
            // 
            // SphereCalculateButton
            // 
            this.SphereCalculateButton.Location = new System.Drawing.Point(249, 171);
            this.SphereCalculateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SphereCalculateButton.Name = "SphereCalculateButton";
            this.SphereCalculateButton.Size = new System.Drawing.Size(268, 55);
            this.SphereCalculateButton.TabIndex = 7;
            this.SphereCalculateButton.Text = "Calculate";
            this.SphereCalculateButton.UseVisualStyleBackColor = true;
            this.SphereCalculateButton.Click += new System.EventHandler(this.SphereCalculateButton_Click);
            // 
            // Sphere_ResetButtonOnClick
            // 
            this.Sphere_ResetButtonOnClick.Location = new System.Drawing.Point(86, 171);
            this.Sphere_ResetButtonOnClick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sphere_ResetButtonOnClick.Name = "Sphere_ResetButtonOnClick";
            this.Sphere_ResetButtonOnClick.Size = new System.Drawing.Size(124, 55);
            this.Sphere_ResetButtonOnClick.TabIndex = 6;
            this.Sphere_ResetButtonOnClick.Text = "Clear";
            this.Sphere_ResetButtonOnClick.UseVisualStyleBackColor = true;
            this.Sphere_ResetButtonOnClick.Click += new System.EventHandler(this.Sphere_ResetButtonOnClick_Click);
            // 
            // Sphere_RadiusTextbox
            // 
            this.Sphere_RadiusTextbox.Location = new System.Drawing.Point(86, 103);
            this.Sphere_RadiusTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sphere_RadiusTextbox.Name = "Sphere_RadiusTextbox";
            this.Sphere_RadiusTextbox.Size = new System.Drawing.Size(55, 26);
            this.Sphere_RadiusTextbox.TabIndex = 5;
            this.Sphere_RadiusTextbox.Text = "1";
            // 
            // Sphere_richTextBox
            // 
            this.Sphere_richTextBox.Location = new System.Drawing.Point(84, 262);
            this.Sphere_richTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sphere_richTextBox.Name = "Sphere_richTextBox";
            this.Sphere_richTextBox.Size = new System.Drawing.Size(432, 379);
            this.Sphere_richTextBox.TabIndex = 4;
            this.Sphere_richTextBox.Text = "";
            // 
            // Sphere_trackBar
            // 
            this.Sphere_trackBar.Location = new System.Drawing.Point(152, 102);
            this.Sphere_trackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sphere_trackBar.Maximum = 20;
            this.Sphere_trackBar.Minimum = 1;
            this.Sphere_trackBar.Name = "Sphere_trackBar";
            this.Sphere_trackBar.Size = new System.Drawing.Size(366, 69);
            this.Sphere_trackBar.TabIndex = 3;
            this.Sphere_trackBar.Value = 1;
            this.Sphere_trackBar.Scroll += new System.EventHandler(this.Sphere_trackBar_Scroll);
            // 
            // SphereDensity_textBox
            // 
            this.SphereDensity_textBox.Location = new System.Drawing.Point(84, 48);
            this.SphereDensity_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SphereDensity_textBox.Name = "SphereDensity_textBox";
            this.SphereDensity_textBox.Size = new System.Drawing.Size(432, 26);
            this.SphereDensity_textBox.TabIndex = 2;
            this.SphereDensity_textBox.TextChanged += new System.EventHandler(this.SphereDensity_textBox_TextChanged);
            // 
            // RadiusLabelSphere
            // 
            this.RadiusLabelSphere.AutoSize = true;
            this.RadiusLabelSphere.Location = new System.Drawing.Point(15, 103);
            this.RadiusLabelSphere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RadiusLabelSphere.Name = "RadiusLabelSphere";
            this.RadiusLabelSphere.Size = new System.Drawing.Size(59, 20);
            this.RadiusLabelSphere.TabIndex = 1;
            this.RadiusLabelSphere.Text = "Radius";
            // 
            // DensityLabelSphere
            // 
            this.DensityLabelSphere.AutoSize = true;
            this.DensityLabelSphere.Location = new System.Drawing.Point(10, 48);
            this.DensityLabelSphere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DensityLabelSphere.Name = "DensityLabelSphere";
            this.DensityLabelSphere.Size = new System.Drawing.Size(62, 20);
            this.DensityLabelSphere.TabIndex = 0;
            this.DensityLabelSphere.Text = "Density";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 826);
            this.Controls.Add(this.Sphere_Groupbox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Sphere_Groupbox.ResumeLayout(false);
            this.Sphere_Groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sphere_trackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Sphere_Groupbox;
        private System.Windows.Forms.TrackBar Sphere_trackBar;
        private System.Windows.Forms.TextBox SphereDensity_textBox;
        private System.Windows.Forms.Label RadiusLabelSphere;
        private System.Windows.Forms.Label DensityLabelSphere;
        private System.Windows.Forms.TextBox Sphere_RadiusTextbox;
        private System.Windows.Forms.RichTextBox Sphere_richTextBox;
        private System.Windows.Forms.Button Sphere_ResetButtonOnClick;
        private System.Windows.Forms.Button SphereCalculateButton;
    }
}

