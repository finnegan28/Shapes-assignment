//Neil Finnegan / Angela Lavery
//Shape Application
//29/02/16
//Program to calculate the area & circumference of rectangles, ellipses and right angle triangles.

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        private double Circumference;
        private double Area;
        private double Major;
        private double Minor;
        private System.Drawing.Bitmap myBitmap;
        private Color lineColor = Color.Black;

        public Form1()
        {
            InitializeComponent();
            myBitmap = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height, PixelFormat.Format24bppRgb);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pen myPen = new Pen(lineColor, 5);

            Graphics g = Graphics.FromImage(myBitmap);
            g.Clear(Color.White);
            g.Dispose();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(myBitmap, 0, 0, myBitmap.Width, myBitmap.Height);
            g.Dispose();
        }

        //Draw Button
        private void drawButton_Click(object sender, EventArgs e)
        {
            if (rectangleBtn.Checked)
            {
                drawRectangle();
            }
            else if (ellipseBtn.Checked)
            {
                drawEllipse();
            }

            else if (triangleBtn.Checked)
            {
                drawTriangle();
            }
        this.Invalidate();
        }

        //Rectangle
        public void drawRectangle()

        {
            Bitmap drawingSurface = new Bitmap(200, 200);
            Graphics GFX = Graphics.FromImage(drawingSurface);

            GFX.FillRectangle(Brushes.Black, 20, 40, widthBar.Value, heightBar.Value);

            pictureBox1.Image = drawingSurface;

            areaTxt.Text = Convert.ToString((double)widthBar.Value * (double)heightBar.Value);

            widthLbl.Text = "Width";
            heightLbl.Text = "Height";

            widthTxt.Text = "" + widthBar.Value;
            Area = (widthBar.Value * heightBar.Value);
            Circumference = ((2 * heightBar.Value) + (2 * widthBar.Value));
            areaTxt.Text = Area.ToString();
            circumTxt.Text = Circumference.ToString();
        }

        //Ellipse
        public void drawEllipse()
        {
            Bitmap drawingSurface = new Bitmap(200, 200);
            Graphics GFX = Graphics.FromImage(drawingSurface);

            GFX.FillEllipse(Brushes.Black, 20, 40, widthBar.Value, heightBar.Value);

            pictureBox1.Image = drawingSurface;

            widthLbl.Text = "Major Axis";
            heightLbl.Text = "Minor Axis";

            widthTxt.Text = Convert.ToString(0.5 * (widthBar.Value));
            heightTxt.Text = Convert.ToString(0.5 * (heightBar.Value));

            Major = widthBar.Value;
            Minor = heightBar.Value;
            Circumference = Math.PI * Math.Sqrt((Major * Major + Minor * Minor) / 2);   //calculates the circumference of an ellipse using both axis.
            areaTxt.Text = "" + ((0.5 * Major) * (0.5 * Minor) * Math.PI); //calculates area of an ellipse using both axis
            circumTxt.Text = Circumference.ToString();
        }

        //Triangle
        public void drawTriangle()
        {
            Bitmap drawingSurface = new Bitmap(200, 200);
            Graphics GFX = Graphics.FromImage(drawingSurface);

            Point[] points = { new Point(20, 40), new Point(20, (40 + heightBar.Value)), new Point((20 + widthBar.Value), (40 + heightBar.Value)) };

            GFX.FillPolygon(Brushes.Black, points);

            pictureBox1.Image = drawingSurface;

            widthLbl.Text = "Width";
            heightLbl.Text = "Height";

            widthTxt.Text = "" + widthBar.Value;
            Area = (0.5 * (widthBar.Value * heightBar.Value));
            Circumference = widthBar.Value + heightBar.Value + (Math.Sqrt((heightBar.Value * heightBar.Value) + (widthBar.Value * widthBar.Value)));  //finds the hypoteneuse and adds it to the x and y heights
            areaTxt.Text = Area.ToString();
            circumTxt.Text = Circumference.ToString();
        }

        //Code for automating the height and width trackbars complete with error handling

        private void heightBar_Scroll(object sender, EventArgs e)
        {
            heightTxt.Text = "" + heightBar.Value;

            if (rectangleBtn.Checked)
            {
                drawRectangle();
            }
            else if (ellipseBtn.Checked)
            {
                drawEllipse();
            }

            else if (triangleBtn.Checked)
            {
                drawTriangle();
            }

            else if (rectangleBtn.Checked == false || triangleBtn.Checked == false || ellipseBtn.Checked == false)         //error handling for no shape selected

                try { }

                catch (Exception ex)
                {
                    throw new Exception("Error Please Select A Shape", ex);
                }
                finally
                {
                    heightBar.Value = 100;
                    widthBar.Value = 100;
                    MessageBox.Show("Please select your shape", "Shape Selection Error");
                }

        }

        private void widthBar_Scroll(object sender, EventArgs e)
        {
            // Display the trackbar value in the text box.
            widthTxt.Text = "" + widthBar.Value;

            if (rectangleBtn.Checked)
            {
                drawRectangle();
            }
            else if (ellipseBtn.Checked)
            {
                drawEllipse();
            }

            else if (triangleBtn.Checked)
            {
                drawTriangle();
            }

            else if (rectangleBtn.Checked == false || triangleBtn.Checked == false || ellipseBtn.Checked == false)          //error handling for no shape selected

                try { }

                catch (Exception ex)
                {
                    throw new Exception("Error Please Select A Shape", ex);
                }
                finally
                {
                    heightBar.Value = 100;
                    widthBar.Value = 100;
                    MessageBox.Show("Please select your shape", "Shape Selection Error");
                }

        }

        //Colour changer

        private void LineColourButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            pictureBox1.BackColor = colorDialog1.Color;
        }


        //radio button controls

        private void RadioButtons_OnChange(object sender, EventArgs e)
        {

            if (twoplaces.Checked)
            {
                areaTxt.Text = Area.ToString("#,0.00");
                circumTxt.Text = Circumference.ToString("#,0.00");
            }

            if (threeplaces.Checked)
            {
                areaTxt.Text = Area.ToString("#,0.000");
                circumTxt.Text = Circumference.ToString("#,0.000");
            }

            if (fourplaces.Checked)
            {
                areaTxt.Text = Area.ToString("#,0.0000");
                circumTxt.Text = Circumference.ToString("#,0.0000");
            }

        }

        //menu strip buttons and error handling

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.ShowDialog();
        }


        private void ellipseStripMenu_Click(object sender, EventArgs e)
        {
            ellipseBtn.Checked = true;          // checks the radio button as each menu item is selected
            drawEllipse();
        }

        private void rectangleStripMenu_Click(object sender, EventArgs e)
        {
            rectangleBtn.Checked = true;
            drawRectangle();
        }

        private void triangleStripMenu_Click(object sender, EventArgs e)
        {
            triangleBtn.Checked = true;
            drawTriangle();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)  //print shape information
        {
            string s = (("Height - " + heightTxt.Text) + ("Width - " + widthTxt.Text) + ("Area - " + areaTxt.Text) + ("Circumference - " + circumTxt.Text));

            PrintDocument p = new PrintDocument();
            p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
            {
                e1.Graphics.DrawString(s, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));

            };
            try
            {
                p.Print();
            }
            catch (Exception ex)
            {
                throw new Exception("Exception Occured While Printing", ex);
            }
        }
    }
}