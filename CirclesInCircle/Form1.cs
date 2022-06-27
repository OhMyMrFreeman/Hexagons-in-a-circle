using System;
using System.Drawing;
using System.Windows.Forms;

namespace CirclesInCircle
{
    public partial class Form1 : Form
    {

        static Bitmap bmp;
        static Figures.Circle circle;
        static Figures.Hexagon hexagon;

        public Form1()
        {
            InitializeComponent();
            circle = new Figures.Circle();
            hexagon = new Figures.Hexagon();
        }

        private void DrawHexagonMap()
        {
            int count = 1;
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                circle.Diametr = 800;
                circle.Draw(g, pictureBox1.Width / 2, pictureBox1.Height / 2);

                hexagon.Diametr = trackBarSmallDiametr.Value;


                for (int j = 1; j < circle.Diametr / hexagon.Diametr; j++)
                {
                    for (float i = 0; i < Math.PI * 2; i += (float)(2 * Math.PI / 6))
                    {
                        float qx = (float)(pictureBox1.Width / 2 + Math.Sin(i) * hexagon.Diametr * Math.Cos(Math.PI / 6) * j);
                        float qy = (float)(pictureBox1.Height / 2 + Math.Cos(i) * hexagon.Diametr * Math.Cos(Math.PI / 6) * j);

                        float q2x = pictureBox1.Width / 2 - qx;
                        float q2y = pictureBox1.Height / 2 - qy;

                        for (int k = 0; k < j; k++)
                        {
                            float qxRotate = (float)(qx + k * (q2x * Math.Cos(2 * Math.PI / 6) + q2y * Math.Sin(2 * Math.PI / 6)) / j);
                            float qyRotate = (float)(qy + k * (q2y * Math.Cos(2 * Math.PI / 6) - q2x * Math.Sin(2 * Math.PI / 6)) / j);

                            float eq1 = (float)Math.Pow(qxRotate - pictureBox1.Width / 2, 2);
                            float eq2 = (float)Math.Pow(qyRotate - pictureBox1.Height / 2, 2);
                            if (Math.Sqrt(eq1 + eq2) + hexagon.Diametr / 2.2 < circle.Diametr / 2)
                            {
                                hexagon.Draw(g, qxRotate, qyRotate, hexagon.Diametr);
                                count++;
                            }
                        }
                    }
                }
                pictureBox1.Image = bmp;
            }
            labelCountHex.Text = $"Количество гексагонов: {count}";
            labelDiametrRatio.Text = $"Соотношение диаметров: {circle.Diametr / hexagon.Diametr}";
        }
        private void trackBarSmallDiametr_Scroll(object sender, EventArgs e)
        {
            labelSmallDiametr.Text = trackBarSmallDiametr.Value.ToString();
            DrawHexagonMap();
        }

    }
}
