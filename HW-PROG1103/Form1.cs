using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_PROG1103
{
    public partial class Form1 : Form
    {
        private const double Pi = 3.14159265359;

        public Form1()
        {
            InitializeComponent();
        }

        private void Sphere_trackBar_Scroll(object sender, EventArgs e)
        {
            Sphere_RadiusTextbox.Text = Sphere_trackBar.Value.ToString();
        }

        private void Cube_trackBar_Scroll(object sender, EventArgs e)
        {

        }

        private void SphereDensity_textBox_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void SphereCalculateButton_Click(object sender, EventArgs e)
        {
            var isValidDensity = Double.TryParse(this.SphereDensity_textBox.Text, out var Density);
            if (!isValidDensity)
            {
                MessageBox.Show("Density value given is not valid",
                    "Invalid input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.SphereDensity_textBox.Clear();
                this.SphereDensity_textBox.Focus();

                return;
            }


            Double SphereDensity = double.Parse(SphereDensity_textBox.Text);
            int SphereRadius = Sphere_trackBar.Value;
            // I want to calculate the volume
            var VolumeSphere = 4.0 / 3 * Pi * SphereRadius * SphereRadius * SphereRadius;
            // Here i want to calculate the surface area
            var SphereSurfaceA = 4 * Pi * SphereRadius * SphereRadius;
            //
            var MassSphere = SphereDensity * VolumeSphere;

            // Density
            this.Sphere_richTextBox.AppendText($"Density is {SphereDensity} g/cm^3");
            this.Sphere_richTextBox.AppendText(Environment.NewLine);

            // Radius
            this.Sphere_richTextBox.AppendText($"Radius is {SphereRadius} g/cm^3");
            this.Sphere_richTextBox.AppendText(Environment.NewLine);

            // Volume
            this.Sphere_richTextBox.AppendText($"Volume is {VolumeSphere}");
            this.Sphere_richTextBox.AppendText(Environment.NewLine);

            // Surface area
            this.Sphere_richTextBox.AppendText($"Surface area is {SphereSurfaceA}");
            this.Sphere_richTextBox.AppendText(Environment.NewLine);

            // Mass
            this.Sphere_richTextBox.AppendText($"Mass is {MassSphere}");
            this.Sphere_richTextBox.AppendText(Environment.NewLine);

        }

        private void Sphere_ResetButtonOnClick_Click(object sender, EventArgs e)
        {
            this.Sphere_richTextBox.Clear();
            this.SphereDensity_textBox.Clear();
            this.Sphere_trackBar.Value = Sphere_trackBar.Minimum;
            this.Sphere_RadiusTextbox.Text = "1";
        }

        private void Cube_Groupbox_Enter(object sender, EventArgs e)
        {

        }
    }
}
