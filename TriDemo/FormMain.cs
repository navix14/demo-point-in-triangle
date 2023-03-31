using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriDemo
{
    public partial class formMain : Form
    {
        private Triangle tri;

        // Canvas-related
        private Font consolasFont;
        private PointF canvasTopRight;
        private int countPaintCalled;

        private List<Point> points;
        private Size logTextSize;

        private double pointSize;

        public formMain()
        {
            InitializeComponent();

            tri = null;
            consolasFont = new Font("Consolas", 10);
            canvasTopRight = new PointF(drawingCanvas.Width, 0);
            countPaintCalled = 0;

            points = new List<Point>();
            pointSize = 3;
        }

        private void DrawCanvasLog(Graphics g)
        {
            countPaintCalled += 1;

            string text = "onPaint called: " + countPaintCalled;
            logTextSize = TextRenderer.MeasureText(text, consolasFont);

            PointF position = canvasTopRight;
            position.X -= logTextSize.Width + 5;

            g.DrawString(text, consolasFont, Brushes.Red, position);
        }

        private void drawingCanvas_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            // Draw canvas logging
            DrawCanvasLog(g);

            if (tri != null)
            {
                // Draw triangle
                PointF[] vertices = new PointF[]
                {
                    tri.A.ToPoint(),
                    tri.B.ToPoint(),
                    tri.C.ToPoint()
                };

                g.DrawPolygon(new Pen(Brushes.Blue), vertices);
            }

            foreach (var point in points)
            {
                var brush = Brushes.Red;

                if (tri != null && tri.Contains(new Vector2D(point.X, point.Y)))
                    brush = Brushes.Green;

                var boundingRect = new RectangleF((float)point.X - (float)pointSize, (float)point.Y - (float)pointSize, 2 * (float)pointSize, 2 * (float)pointSize);
                g.FillEllipse(brush, boundingRect);
            }
        }

        private void buttonCreateTriangle_Click(object sender, EventArgs e)
        {
            // Extract vertices
            List<double> coordinatesA = null;
            List<double> coordinatesB = null;
            List<double> coordinatesC = null;

            try
            {
                coordinatesA = textVertexA.Text.Split(",").Select(coordinate => Convert.ToDouble(coordinate.Trim())).ToList();
                coordinatesB = textVertexB.Text.Split(",").Select(coordinate => Convert.ToDouble(coordinate.Trim())).ToList();
                coordinatesC = textVertexC.Text.Split(",").Select(coordinate => Convert.ToDouble(coordinate.Trim())).ToList();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid coordinates. Make sure to use \"x, y\" as the format.\nFor example: \"1, 2\" would be a valid input.", "Error");
                return;
            }

            if (coordinatesA.Count != 2 || coordinatesB.Count != 2 || coordinatesC.Count != 2)
            {
                MessageBox.Show("Coordinates need to be 2-dimensional.", "Error");
                return;
            }

            tri = new Triangle(new Vector2D(coordinatesA[0], coordinatesA[1]),
                               new Vector2D(coordinatesB[0], coordinatesB[1]),
                               new Vector2D(coordinatesC[0], coordinatesC[1]));

            points.Clear();

            drawingCanvas.Invalidate();
        }

        private void drawingCanvas_Click(object sender, EventArgs e)
        {
            Point relativeMousePos = drawingCanvas.PointToClient(MousePosition);
            points.Add(relativeMousePos);

            drawingCanvas.Invalidate();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Generate 10 new random points per second
            Random random = new Random();

            double[] rX = new double[1000];
            double[] rY = new double[1000];

            double maxX = drawingCanvas.Width;
            double maxY = drawingCanvas.Height;

            for (int i = 0; i < 1000; i++)
            {
                rX[i] = random.NextDouble();
                rY[i] = random.NextDouble();

                Point randomPoint = new Point(Convert.ToInt32(rX[i] * maxX), Convert.ToInt32(rY[i] * maxY));

                points.Add(randomPoint);
            }

            drawingCanvas.Invalidate();
        }

        private void buttonStartGen_Click(object sender, EventArgs e)
        {
            if (tri == null)
            {
                MessageBox.Show("Create a triangle first.", "Error");
                return;
            }

            int interval = 1;

            try
            {
                interval = Convert.ToInt32(textInterval.Text);
            } catch (Exception)
            {
                MessageBox.Show("Give a valid number for the interval in ms", "Error");
                return;
            }

            timer.Interval = interval;
            timer.Start();

            buttonStartGen.Enabled = false;
            buttonStopGen.Enabled = true;
        }

        private void buttonStopGen_Click(object sender, EventArgs e)
        {
            timer.Stop();

            buttonStartGen.Enabled = true;
            buttonStopGen.Enabled = false;
        }

        private void buttonGenerateTriangle_Click(object sender, EventArgs e)
        {
            tri = new Triangle(new Vector2D(100, 300), new Vector2D(500, 200), new Vector2D(300, 350));
            points.Clear();

            drawingCanvas.Invalidate();
        }

        private void textPointSize_TextChanged(object sender, EventArgs e)
        {
            double newSize = 1;

            try
            {
                newSize = Convert.ToDouble(textPointSize.Text);
            } catch (Exception)
            {

            }

            pointSize = newSize;
        }
    }
}
