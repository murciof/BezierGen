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

        bool generateActivation = false;

        public MainForm()
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            InitializeComponent();
        }

        private void GenerateBezier(object sender, PaintEventArgs e)
        {
            if (generateActivation == true)
            {
                Pen blackPen = new Pen(Color.Yellow, 2);

                int i = 0;
                int control = 13;
                Random random = new Random();
                List<Point> bezierControl = new List<Point>();
                while (i < control)
                {
                    bezierControl.Add(new Point(random.Next(0, 400), random.Next(0, 400)));
                    i++;
                }

                Point[] bezierPoints = bezierControl.ToArray();

                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.DrawBeziers(blackPen, bezierPoints);
            }

            generateActivation = false;

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            GenerateBezier(sender, e);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button_genCurve_Click(object sender, EventArgs e)
        {
            generateActivation = true;
            splitContainer1.Panel2.Refresh();
        }
    }
}
