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

        private bool generateActivation = false;
        static private Document[] documentDB =
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

            splitContainer1.SplitterDistance = 40;
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

                int documentWithMarginX = currentDocument.GetDimensionX() - marginX;
                int documentWithMarginY = currentDocument.GetDimensionY() - marginY;

                int documentWithDoubleMarginX = currentDocument.GetDimensionX() - 2 * marginX;
                int documentWithDoubleMarginY = currentDocument.GetDimensionY() - 2 * marginY;

                while (i < control)
                {
                    bezierControl.Add(new Point(random.Next(marginX, documentWithMarginX), random.Next(marginY, documentWithMarginY)));
                    i++;
                }

                Rectangle rect = new Rectangle(0,0,currentDocument.GetDimensionX(), currentDocument.GetDimensionY());
                Rectangle rectMargin = new Rectangle(marginX, marginY, documentWithDoubleMarginX, documentWithDoubleMarginY);
                Point[] bezierPoints = bezierControl.ToArray();

                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.DrawRectangle(rectanglePen, rect);
                e.Graphics.FillRectangle(rectangleBackground, rect);
                e.Graphics.DrawRectangle(marginPen, rectMargin);
                e.Graphics.DrawBeziers(bezierPen, bezierPoints);
            }

            generateActivation = false;

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            GenerateBezier(sender, e);
        }

        private void button_genCurve_Click(object sender, EventArgs e)
        {
            generateActivation = true;
            splitContainer1.Panel2.Refresh();
        }
    }
}
