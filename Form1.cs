using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Encerder_pixel
{
    public partial class Form1 : Form
    {
        static readonly int width = 700;
        static readonly int height = 550;

        Color[] paleta = new Color[16];

        Color[] paleta0 = new[]
        {
                Color.Black,        //0
                Color.Navy,         //1
                Color.Green,        //2
                Color.Aqua,         //3
                Color.Red,          //4
                Color.Purple,       //5
                Color.Maroon,       //6
                Color.LightGray,    //7
                Color.DarkGray,     //8
                Color.Blue,         //9
                Color.Lime,         //10
                Color.Silver,       //11
                Color.Teal,         //12
                Color.Fuchsia,      //13
                Color.Yellow,       //14
                Color.White         //15
            };

        Bitmap pixelVextor = new Bitmap(width, height);

        public double x,y;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Vector V = new Vector();
            x = 0;
            V.y0 = 1;

            do
            {
                V.x0 = x;
                V.color0 = Color.Red;
                V.Encender(pixelVextor);
                x += 0.1;
            }
            while (x <= 2);

            y = 0;
            V.x0 = 1;
            do
            {
                V.y0 = y;
                V.color0 = Color.Blue;
                V.Encender(pixelVextor);
                y += 0.1;
            } while (y <= 2);
            pictureBox.Image = pixelVextor; // Asigna los valores del píxel al objeto imagen de la GUI
        }
        

        private void button2_Click(object sender, EventArgs e)
        {

            Circunferencia c = new Circunferencia();
            c.rd = 2;
            c.x0 = 2;
            c.y0 = 4;
            c.color0 = Color.Blue;
            c.Encender(pixelVextor);

            pictureBox.Image = pixelVextor; // Asigna los valores del píxel al objeto imagen de la GUI

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PintarFondoEjes();

            Circunferencia c = new Circunferencia();
            c.rd = 3;
            c.x0 = -3;
            c.y0 = -1;
            c.color0 = Color.Blue;
            c.Encender(pixelVextor);

            Circunferencia c1 = new Circunferencia();
            c1.rd = 2;
            c1.x0 = -6;
            c1.y0 = 4;
            c1.color0 = Color.Red;
            c1.Encender(pixelVextor);

            pictureBox.Image = pixelVextor;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ApagarPixel();
            pictureBox.Image = pixelVextor;
        }

        private void ApagarPixel()
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    pixelVextor.SetPixel(i, j, Color.White);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vector vec = new Vector();
            double X;
            X = -9;

            do
            {
                vec.x0 = X;
                vec.y0 = 2 * Math.Exp(-2 * X) + ((3) * Math.Exp(X));
                vec.color0 = Color.Red;
                vec.Encender(pixelVextor);
                vec.y0 = 2 * Math.Exp(-2 * X) + ((-2) * Math.Exp(X));
                vec.color0 = Color.DarkBlue;
                vec.Encender(pixelVextor);
                vec.y0 = 2 * Math.Exp(-2 * X) + ((2.5) * Math.Exp(X));
                vec.color0 = Color.YellowGreen;
                vec.Encender(pixelVextor);
                vec.y0 = 2 * Math.Exp(-2 * X) + ((3.3) * Math.Exp(X));
                vec.color0 = Color.Green;
                vec.Encender(pixelVextor);
                X = X + 0.001;

            } while (X <= 9);
            pictureBox.Image = pixelVextor; ;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PintarFondoEjes();
            Circunferencia vec = new Circunferencia();
            double t = -8;
            vec.rd = 0.2;

            do
            {
                vec.x0 = t;
                vec.y0 = -(Math.Pow(t, 2) + (10 * t) + 16) / 2.25;
                vec.color0 = Color.Red;
                vec.Encender(pixelVextor);

                pictureBox.Image = pixelVextor;

                pictureBox.Refresh();
                Thread.Sleep(10);

                t += 0.3;

            } while (t <= -2);

            pictureBox.Image = pixelVextor;

            do
            {
                vec.x0 = t;
                vec.y0 = (4 - Math.Pow(t, 2)) / 1.333;
                vec.color0 = Color.Black;
                vec.Encender(pixelVextor);

                pictureBox.Image = pixelVextor;

                pictureBox.Refresh();
                Thread.Sleep(10);


                t += 0.3;

            } while (t <= 2);

            pictureBox.Image = pixelVextor;

            do
            {
                vec.x0 = t;
                vec.y0 = -(Math.Pow(t, 2) + (-7 * t) + 10) / 1.2;
                vec.color0 = Color.Blue;
                vec.Encender(pixelVextor);

                pictureBox.Image = pixelVextor;

                Thread.Sleep(10);

                t += 0.3;

            } while (t <= 5);

            pictureBox.Image = pixelVextor;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PintarFondoEjes();

            Vector v = new Vector();
            double x = -9;
            do
            {
                v.x0 = x;
                v.y0 = -((x + 9) * (x + 5)) * 1.4;
                v.color0 = Color.Red;
                x = x + 0.001;
                v.Encender(pixelVextor);

            } while (x <= -5);
            pictureBox.Image = pixelVextor;

            x = -5;
            do
            {
                v.x0 = x;
                v.y0 = -((x + 5) * (x + 1)) * 1; // Proporcionalidad ajustada
                v.color0 = Color.Black;
                x = x + 0.001;
                v.Encender(pixelVextor);

            } while (x <= -1);
            pictureBox.Image = pixelVextor;

            x = -1;
            do
            {
                v.x0 = x;
                v.y0 = -((x + 1) * (x - 3)) * 0.6; // Proporcionalidad ajustada
                v.color0 = Color.BlueViolet;
                x = x + 0.001;
                v.Encender(pixelVextor);


            } while (x <= 3);
            pictureBox.Image = pixelVextor;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PintarFondoEjes();
            Vector v = new Vector();
            double x=-9;

            do
            {
                v.x0 = x;
                v.y0 = Math.Pow(3, x);
                v.color0 = Color.Blue;
                v.Encender(pixelVextor);

                v.y0 = 1 + Math.Log(3) * x + (Math.Pow(Math.Log(3), 2) / 2) * Math.Pow(x, 2);
                v.color0 = Color.Green;
                v.Encender(pixelVextor);

                v.y0 = 1 + Math.Log(3) * x + ((Math.Pow(Math.Log(3), 2)) * Math.Pow(x, 2) / 2) + (Math.Pow(Math.Log(3), 3) * Math.Pow(x, 3) / 6);
                v.color0 = Color.Red;
                v.Encender(pixelVextor);

                v.y0 = 1+Math.Log(3) * x + (Math.Pow(Math.Log(3), 2) * Math.Pow(x, 2) / 2) + (Math.Pow(Math.Log(3), 3) * Math.Pow(x, 3) / 6) + (Math.Pow(Math.Log(3), 4) * Math.Pow(x, 4) / 8); ;
                v.color0 = Color.Black;
                v.Encender(pixelVextor);

                x += 0.001;
            }while (x <= 9);

            pictureBox.Image = pixelVextor;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PintarFondoEjes();

            Circunferencia vec = new Circunferencia();
            double t = -8, dt = 0.1;
            vec.rd = 0.25;

            do
            {
                vec.x0 = t;
                vec.y0 = -(Math.Pow(t, 2) + (10 * t) + 16) / 2.25;
                vec.color0 = Color.Black;
                vec.Encender(pixelVextor);

                pictureBox.Image = pixelVextor;

                pictureBox.Refresh();
                Thread.Sleep(10);

                vec.apagar(pixelVextor);

                t = t + dt;

            } while (t <= -2);

            pictureBox.Image = pixelVextor;

            do
            {
                vec.x0 = t;
                vec.y0 = (4 - Math.Pow(t, 2)) / 1.333;
                vec.color0 = Color.Black;
                vec.Encender(pixelVextor);

                pictureBox.Image = pixelVextor;

                pictureBox.Refresh();
                Thread.Sleep(10);

                vec.apagar(pixelVextor);

                t = t + dt;

            } while (t <= 2);

            pictureBox.Image = pixelVextor;

            do
            {
                vec.x0 = t;
                vec.y0 = -(Math.Pow(t, 2) + (-7 * t) + 10) / 1.2;
                vec.color0 = Color.Black;
                vec.Encender(pixelVextor);

                pictureBox.Image = pixelVextor;

                pictureBox.Refresh();
                Thread.Sleep(10);

                vec.apagar(pixelVextor);

                t = t + dt;

            } while (t <= 5);

            pictureBox.Image = pixelVextor;
        
    }

        private void button10_Click(object sender, EventArgs e)
        {
            PintarFondoEjes();
            Circunferencia cir = new Circunferencia();
            cir.rd = 0.3;
            cir.color0 = Color.Black;

            cir.x0 = 1; cir.y0 = 5;
            cir.Encender(pixelVextor);

            cir.x0 = 3; cir.y0 = 7;
            cir.Encender(pixelVextor);

            cir.x0 = 4; cir.y0 = 6;
            cir.Encender(pixelVextor);

            Vector vec = new Vector();
            x = 0;

            do
            {
                vec.x0 = x;
                vec.y0 = ((-2*(Math.Pow(x,2))+11*x+6)/3);
                vec.Encender(pixelVextor);
                vec.color0= Color.Blue;
                x += 0.001;
            } while (x <= 8);

            pictureBox.Image = pixelVextor;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 233; i++)
{
                for (int j = 0; j < height; j++)
                {
                    int r = 255 - (int)(255.0 / 233 * i);
                    int g = (int)(255.0 / 233 * i);
                    int b = 0;
                    pixelVextor.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }

            for (int i = 233; i < 466; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    int r = 0;
                    int g = 255 - (int)(255.0 / 233 * (i - 233));
                    int b = (int)(255.0 / 233 * (i - 233));
                    pixelVextor.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }

            for (int i = 466; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    int r = (int)(255.0 / 233 * (i - 466));
                    int g = 0;
                    int b = 255 - (int)(255.0 / 233 * (i - 466));
                    pixelVextor.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }

            pictureBox.Image = pixelVextor;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            int colorT;
            Color c;


            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {;
                    colorT = (int)(Math.Pow(i,2) * i/5 + Math.Pow(j,2)*j/10) % 15;
                    c = paleta0[colorT];
                    pixelVextor.SetPixel(i, j, c);
                }
            }

            pictureBox.Image = pixelVextor;
        }

        private void TiposTapetes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = TiposTapetes.SelectedItem.ToString();
            int colorT;
            Color c;

            switch (selectedItem)
            {
                case "Tapete1":
                    for (int i = 0; i < width; i++)
                    {
                        for (int j = 0; j < height; j++)
                        {
                            colorT = (int)(Math.Pow(i, 2) + Math.Pow(j, 2)) % 15;
                            c = paleta0[colorT];
                            pixelVextor.SetPixel(i, j, c);
                        }
                    }
                    break;
                case "Tapete2":
                    for (int i = 0; i < width; i++)
                    {
                        for (int j = 0; j < height; j++)
                        {
                            colorT = (int)(Math.Pow(i, 2) * i/5 + Math.Pow(j, 2) * j/10) % 15;
                            c = paleta0[colorT];
                            pixelVextor.SetPixel(i, j, c);
                        }
                    }
                    break;
                case "Tapete3":
                    for (int i = 0; i < width; i++)
                    {
                        for (int j = 0; j < height; j++)
                        {
                            colorT = (int)(Math.Sin(i * 0.1) * Math.Cos(j * 0.1) * 7.5 + 7.5) % 15;
                            c = paleta0[colorT];
                            pixelVextor.SetPixel(i, j, c);
                        }
                    }
                    break;
                case "Tapete4":
                    for (int i = 0; i < width; i++)
                    {
                        for (int j = 0; j < height; j++)
                        {
                            colorT = (int)(Math.Sqrt(i * j) % 15);
                            c = paleta0[colorT];
                            pixelVextor.SetPixel(i, j, c);
                        }
                    }
                    break;
                case "Tapete5":
                    for (int i = 0; i < width; i++)
                    {
                        for (int j = 0; j < height; j++)
                        {
                            colorT = (int)((i * i + j * j) % 15);
                            c = paleta0[colorT];
                            pixelVextor.SetPixel(i, j, c);
                        }
                    }
                    break;
                // Agrega más casos según tus necesidades
                default:
                    for (int i = 0; i < width; i++)
                    {
                        for (int j = 0; j < height; j++)
                        {
                            colorT = (int)((Math.Abs(Math.Sin(i * 0.1) * 10) + Math.Abs(Math.Cos(j * 0.1) * 10)) % 15);
                            c = paleta0[colorT];
                            pixelVextor.SetPixel(i, j, c);
                        }
                    }
                    break;
            }
                pictureBox.Image = pixelVextor;
        }
        private void PintarFondoEjes()
        {
            Color fondo = Color.White;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    pixelVextor.SetPixel(i, j, fondo);
                }
            }

            Segmento sy = new Segmento();
            sy.x0 = 0;
            sy.y0 = 8.75;
            sy.xf = 0;
            sy.yf = -8.75;
            sy.color0 = Color.Gray;
            sy.Encender(pixelVextor);

            Segmento sx = new Segmento();
            sx.x0 = -10;
            sx.y0 = 0;
            sx.xf = 10;
            sx.yf = 0;
            sx.color0 = Color.Gray;
            sx.Encender(pixelVextor);

        }
    }

}
