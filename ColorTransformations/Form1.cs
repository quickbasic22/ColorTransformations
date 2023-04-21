using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace ColorTransformations
{
    public partial class Form1 : Form
    {
        string imagePath = @"C:\Users\quick\source\repos\ColorTransformations\ColorTransformations\roses.jpg";
        Size size;
        public Form1()
        {
            InitializeComponent();
            // Load the image from a file
            Image originalImage = Image.FromFile(imagePath);

            // Calculate the new height while maintaining aspect ratio
            int newHeight = (int)(originalImage.Height * ((float)500 / originalImage.Width));

            // Create the new image with the resized dimensions
            Image resizedImage = originalImage.GetThumbnailImage(500, newHeight, null, IntPtr.Zero);

            // Create a Bitmap object from the resized image
            Bitmap curBitmap = new Bitmap(resizedImage);
            size = resizedImage.Size;

        }

        private void rotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float degrees = 45.0f;
            double r = degrees * System.Math.PI / 180;

            // Create a Graphics object	
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);


            // Create a Bitmap from a file
            Bitmap curBitmap = new Bitmap(imagePath);

            // ColorMatrix elements
            float[][] ptsArray = {
                 new float[] {(float)System.Math.Cos(r),
                             (float)System.Math.Sin(r),
                             0,  0, 0},
                 new float[] {(float)-System.Math.Sin(r),
                              (float)-System.Math.Cos(r),
                                  0,  0, 0},
                 new float[] {.50f,  0,  1,  0, 0},
                 new float[] {0,  0,  0,  1, 0},
                 new float[] {0, 0, 0, 0, 1}
            };
            // Create a ColorMatrix
            ColorMatrix clrMatrix = new ColorMatrix(ptsArray);
            // Create ImageAttributes

            ImageAttributes imgAttribs = new ImageAttributes();
            // Set ColorMatrix to ImageAttributes
            imgAttribs.SetColorMatrix(clrMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Default);
            // Draw image with no affects

            g.DrawImage(curBitmap, 0, 0, size.Width, size.Height);
            // Draw image with ImageAttributes
            g.DrawImage(curBitmap,
                new Rectangle(600, 0, size.Width, size.Height),
                0, 0, curBitmap.Width, curBitmap.Height,
                GraphicsUnit.Pixel, imgAttribs);
            // Dispose
            string firstMatrix = DisplayArray(ptsArray);

            textBox1.Text = firstMatrix;

            curBitmap.Dispose();
            g.Dispose();
        }

        private void translationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a Graphics object
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
            // Create a Bitmap
            Bitmap curBitmap = new Bitmap(imagePath);
            // ColorMatrix elements
            float[][] ptsArray =
            {
                new float[] {1,  0,  0,  0, 0},
                new float[] {0,  1,  0,  0, 0},
                new float[] {0,  0,  1,  0, 0},
                new float[] {0,  0,  0,  1, 0},
                new float[] {.90f, .0f, .0f, .0f, 1}
            };
            // Create a ColorMatrix
            ColorMatrix clrMatrix = new ColorMatrix(ptsArray);
            // Create ImageAttributes
            ImageAttributes imgAttribs = new ImageAttributes();
            // Set color matrix
            imgAttribs.SetColorMatrix(clrMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Default);
            // Draw image with no affects
            g.DrawImage(curBitmap, 0, 0, size.Width, size.Height);
            // Draw image with ImageAttributes
            g.DrawImage(curBitmap,
                new Rectangle(600, 0, size.Width, size.Height),
                0, 0, curBitmap.Width, curBitmap.Height,
                GraphicsUnit.Pixel, imgAttribs);
            // Dispose
            curBitmap.Dispose();
            g.Dispose();
        }

        private void scalingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a Graphics
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
            // Create a Bitmap
            Bitmap curBitmap = new Bitmap(imagePath);
            // ColorMatrix elements
            float[][] ptsArray =
            {
                 new float[] {1,  0,  0,  0, 0},
                 new float[] {0,  0.8f,  0,  0, 0},
                 new float[] {0,  0,  0.5f,  0, 0},
                 new float[] {0,  0,  0,  0.5f, 0},
                 new float[] {0, 0, 0, 0, 1}
            };
            // Create a ColorMatrix
            ColorMatrix clrMatrix = new ColorMatrix(ptsArray);
            // Create ImageAttributes
            ImageAttributes imgAttribs = new ImageAttributes();
            // Set color matrix
            imgAttribs.SetColorMatrix(clrMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Default);
            // Draw an image with no affects
            g.DrawImage(curBitmap, 0, 0, size.Width, size.Height);
            // Draw Image with image attributes
            g.DrawImage(curBitmap,
                new Rectangle(600, 0, size.Width, size.Height),
                0, 0, curBitmap.Width, curBitmap.Height,
                GraphicsUnit.Pixel, imgAttribs);
            // Dispose
            curBitmap.Dispose();
            g.Dispose();
        }

        private void shearingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a Graphics
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
            // Create a Bitmap
            Bitmap curBitmap = new Bitmap(imagePath);
            // ColorMatrix elements
            float[][] ptsArray =
            {
                 new float[] {1,  0,  0,  0, 0},
                 new float[] {0,  1,  0,  0, 0},
                 new float[] {.50f,  0,  1,  0, 0},
                 new float[] {0,  0,  0,  1, 0},
                 new float[] {0, 0, 0, 0, 1}
            };
            // Create ColorMatrix
            ColorMatrix clrMatrix = new ColorMatrix(ptsArray);
            // Create ImageAttributes
            ImageAttributes imgAttribs = new ImageAttributes();
            // Set color matrix
            imgAttribs.SetColorMatrix(clrMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Default);
            // Draw Image with no effects
            g.DrawImage(curBitmap, 0, 0, size.Width, size.Height);
            // Draw Image with image attributes
            g.DrawImage(curBitmap,
                new Rectangle(600, 0, size.Width, size.Height),
                0, 0, curBitmap.Width, curBitmap.Height,
                GraphicsUnit.Pixel, imgAttribs);
            // Dispose
            curBitmap.Dispose();
            g.Dispose();
        }

        string DisplayArray(float[][] matrix)
        {
            string result = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    result += matrix[i][j].ToString("0.00") + "\t";
                }
                result += "\n";
            }
            return result;
        }

        private void translationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /// Create a Graphics object
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
                       
            // ColorMatrix elements
            float[][] ptsArray =
                        {
                new float[] {1,  0,  0,  0, 0},
                new float[] {0,  1,  0,  0, 0},
                new float[] {0,  0,  1,  0, 0},
                new float[] {0,  0,  0,  1, 0},
                new float[] {.90f, .0f, .0f, .0f, 1}
            };

            TransformColor2(Color.Blue, new Matrix());

            // Draw the rectangle with the transformed brush
            g.FillRectangle(new SolidBrush(Color.Blue), new Rectangle(0, 0, 600, 600));

            g.Dispose();
        }

        private void rotationToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            /// Create a Graphics object
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);

            // Create a Bitmap
            Bitmap curBitmap = new Bitmap(imagePath);

            // ColorMatrix elements
            float[][] ptsArray =
                        {
                new float[] {1,  0,  0,  0, 0},
                new float[] {0,  1,  0,  0, 0},
                new float[] {0,  0,  1,  0, 0},
                new float[] {0,  0,  0,  1, 0},
                new float[] {.90f, .0f, .0f, .0f, 1}
            };

            // Create a Matrix and apply the translation
            Matrix translateMatrix = new Matrix();
            translateMatrix.Rotate(90.0f);

            // Apply the translation transformation to the current coordinate system
            g.Transform = translateMatrix;

            // Draw the rectangle with the transformed brush
            g.FillRectangle(new SolidBrush(Color.Blue), new Rectangle(0, 0, 600, 600));

            // Dispose
            curBitmap.Dispose();
            g.Dispose();
        }

        private void scalingToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            /// Create a Graphics object
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);

            // Create a Bitmap
            Bitmap curBitmap = new Bitmap(imagePath);

            // ColorMatrix elements
            float[][] ptsArray =
                        {
                new float[] {1,  0,  0,  0, 0},
                new float[] {0,  1,  0,  0, 0},
                new float[] {0,  0,  1,  0, 0},
                new float[] {0,  0,  0,  1, 0},
                new float[] {.90f, .0f, .0f, .0f, 1}
            };

            // Create a Matrix and apply the translation
            Matrix translateMatrix = new Matrix();
            translateMatrix.Scale(0.75f, 0.75f);

            // Apply the translation transformation to the current coordinate system
            g.Transform = translateMatrix;

            // Draw the rectangle with the transformed brush
            g.FillRectangle(new SolidBrush(Color.Blue), new Rectangle(0, 0, 600, 600));

            // Dispose
            curBitmap.Dispose();
            g.Dispose();
        }

        private void shearingToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            /// Create a Graphics object
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);

            // Create a Bitmap
            Bitmap curBitmap = new Bitmap(imagePath);

            // ColorMatrix elements
            float[][] ptsArray =
                        {
                new float[] {1,  0,  0,  0, 0},
                new float[] {0,  1,  0,  0, 0},
                new float[] {0,  0,  1,  0, 0},
                new float[] {0,  0,  0,  1, 0},
                new float[] {.90f, .0f, .0f, .0f, 1}
            };

            // Create a Matrix and apply the translation
            Matrix translateMatrix = new Matrix();
            translateMatrix.Shear(0.60f, 0.10f);

            // Apply the translation transformation to the current coordinate system
            g.Transform = translateMatrix;

            // Draw the rectangle with the transformed brush
            g.FillRectangle(new SolidBrush(Color.Blue), new Rectangle(0, 0, 600, 600));

            // Dispose
            curBitmap.Dispose();
            g.Dispose();
        }

        private static Color TransformColor1(Color inputColor, Matrix transformMatrix)
        {
                // Convert the input color to a point
                PointF colorPoint = new PointF(inputColor.R, inputColor.G);
                PointF[] transformedPoints = new PointF[1];
                transformMatrix.TransformPoints(new PointF[] { colorPoint });
                
                colorPoint = transformedPoints[0];

                // Clamp the color point values to the range of 0-255
                colorPoint.X = Math.Max(0f, Math.Min(255f, colorPoint.X));
                colorPoint.Y = Math.Max(0f, Math.Min(255f, colorPoint.Y));

                // Convert the transformed point back to a Color object
                Color transformedColor = Color.FromArgb(inputColor.A, (int)colorPoint.X, (int)colorPoint.Y, inputColor.B);

                return transformedColor;
        }
       
        private Color TransformColor2(Color color, Matrix matrix)
        {
            Vector4 colorVector = new Vector4(color.R, color.G, color.B, color.A);
            Matrix4x4 newMatrix = new Matrix4x4()
            Vector4 transformedVector = Vector4.Transform(colorVector, new Matrix4x4());
            return Color.FromArgb(
                (int)transformedVector.W,
                (int)transformedVector.X,
                (int)transformedVector.Y,
                (int)transformedVector.Z
            );
        }

        private string ViewMatrix(Matrix matrix)
        {
            matrix.
        }


    }
}