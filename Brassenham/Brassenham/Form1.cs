using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brassenham
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bressenham(Point desde, Point hacia)
        {
            Bitmap pixel = new Bitmap(Picture.Width, Picture.Height);

            double deltaX = hacia.X - desde.X;
            double deltaY = hacia.Y - desde.Y;
            double deltaErr = Math.Abs(deltaY / deltaX);
            double error = deltaErr - 0.5;
            int y = desde.Y;

            for(int x = desde.X; x <= hacia.X; x++)
            {
                pixel.SetPixel(x, y, Color.DarkCyan);
                error += deltaErr;
                if(error >= 0.5)
                {
                    y += 1;
                    error -= 1.0;
                }
                Picture.Image = pixel;
            }
        }

        //Clickamos para obtener nuestros puntos
        private void button1_Click(object sender, EventArgs e)
        {
              if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text))
              {
                  Point desde = new Point(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                  Point hacia = new Point(Picture.Width - int.Parse(textBox3.Text), Picture.Height - int.Parse(textBox4.Text));
              Bressenham(desde, hacia);
              }
              else
              {
                  Status.Text = "Ingrese correctamente los datos";                
              }




        }

        private void x1_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
