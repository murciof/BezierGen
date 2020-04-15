using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BezierGen
{
    public partial class MainForm : Form
    {
        int magRatio = 1;
        bool isPortrait = true;
        bool isPastPortrait = true;
        private bool generateActivation = false;
        private Document[] documentDB =
        {
            new Document(210, 297, "A4 Paper (210mm x 297mm)"),
            new Document(50, 80, "Business Card (50mm x 80mm)")
        };

        public MainForm()
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            InitializeComponent();
            InitInterface();
        }

        private void InitInterface()
        {
            int i = 0;
            while (i < documentDB.Length)
            {
                comboBox_documentType.Items.Insert(i, documentDB[i].GetDocumentType());
                i++;
            }
            comboBox_documentType.SelectedIndex = 0;
            i = 0;
            while (i < 10)
            {
                comboBox_points.Items.Insert(i, (3 * (i + 1)) + 1);
                i++;
            }
            comboBox_points.SelectedIndex = 0;
            i = 0;
            while (i < 10)
            {
                comboBox_stroke.Items.Insert(i, i + 1);
                i++;
            }
            comboBox_stroke.SelectedIndex = 0;
        }

        private Document SwapDimensions(Document document)
        {
            int dimensionXTemp = document.GetDimensionX();
            document.SetDimensionX(document.GetDimensionY());
            document.SetDimensionY(dimensionXTemp);
            return document;
        }

        private void GenerateBezier(object sender, PaintEventArgs e)
        {
            if (generateActivation == true)
            {
                Pen bezierPen = new Pen(Color.Orange, 1);
                Pen rectanglePen = new Pen(Color.Black, 2);
                Pen marginPen = new Pen(Color.Red, .5F);
                SolidBrush rectangleBackground = new SolidBrush(Color.White);

                int i = 0;
                int control = int.Parse(comboBox_points.SelectedItem.ToString());

                Random random = new Random();

                List<Point> bezierControl = new List<Point>();

                Document currentDocument = documentDB[comboBox_documentType.SelectedIndex];

                int marginX = int.Parse(textBox_marginX.Text);
                int marginY = int.Parse(textBox_marginY.Text);

                if(isPortrait == false)
                {
                    if(isPastPortrait == true)
                    {
                        currentDocument = SwapDimensions(currentDocument);
                        isPastPortrait = false;
                    }
                }
                else
                {
                    if(isPastPortrait == false)
                    {
                        currentDocument = SwapDimensions(currentDocument);
                        isPastPortrait = true;
                    }
                }

                int documentWithMarginX = currentDocument.GetDimensionX() - marginX;
                int documentWithMarginY = currentDocument.GetDimensionY() - marginY;

                int documentWithDoubleMarginX = currentDocument.GetDimensionX() - 2 * marginX;
                int documentWithDoubleMarginY = currentDocument.GetDimensionY() - 2 * marginY;

                while (i < control)
                {
                    bezierControl.Add(new Point(random.Next(marginX * magRatio, documentWithMarginX * magRatio), random.Next(marginY * magRatio, documentWithMarginY * magRatio)));

                    i++;
                }

                Rectangle rect = new Rectangle(0,0,currentDocument.GetDimensionX() * magRatio, currentDocument.GetDimensionY() * magRatio);
                Rectangle rectMargin = new Rectangle(marginX * magRatio, marginY * magRatio, documentWithDoubleMarginX * magRatio, documentWithDoubleMarginY * magRatio);
                Point[] bezierPoints = bezierControl.ToArray();

                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.DrawRectangle(rectanglePen, rect);
                e.Graphics.FillRectangle(rectangleBackground, rect);
                e.Graphics.DrawRectangle(marginPen, rectMargin);
                e.Graphics.DrawBeziers(bezierPen, bezierPoints);
            }

            generateActivation = false;

        }

        private void canvasPanel_Paint(object sender, PaintEventArgs e)
        {
            GenerateBezier(sender, e);
        }

        private void button_genCurve_Click(object sender, EventArgs e)
        {
            generateActivation = true;
            canvasPanel.Refresh();
        }

        private void button_mag1x_Click(object sender, EventArgs e)
        {
            magRatio = 1;
        }

        private void button_mag2x_Click(object sender, EventArgs e)
        {
            magRatio = 2;
        }

        private void button_mag3x_Click(object sender, EventArgs e)
        {
            magRatio = 3;
        }

        private void button_mag4x_Click(object sender, EventArgs e)
        {
            magRatio = 4;
        }

        private void button_mag5x_Click(object sender, EventArgs e)
        {
            magRatio = 5;
        }

        private void button_orientationP_Click(object sender, EventArgs e)
        {
            isPortrait = true;
        }

        private void button_orientationL_Click(object sender, EventArgs e)
        {
            isPortrait = false;
        }

        

        
    }
}
