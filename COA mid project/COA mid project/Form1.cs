using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_mid_project
{
    public partial class Form1 : Form
    {
        public Point latest = new Point();
        public Point last = new Point();
        public Graphics graph;
        public Graphics drawGraph;

        public Pen pencil = new Pen(Color.Black,3);
        Bitmap paper;

        private Point mousePosition;
        private Boolean mouseDown = false;

        public Form1()
        {
            InitializeComponent();
            drawGraph = drawingPanel.CreateGraphics();
            drawGraph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pencil.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);

            paper = new Bitmap(drawingPanel.Width, drawingPanel.Height);
            graph = Graphics.FromImage(paper);
            drawingPanel.BackgroundImage = paper;
            drawingPanel.BackgroundImageLayout = ImageLayout.None;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void draw_MouseDown(object sender, MouseEventArgs e)
        {
            last = e.Location;
        }

        private void draw_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                latest = e.Location;
                drawGraph.DrawLine(pencil, last, latest);
                graph.DrawLine(pencil, last, latest);
                last = latest;
            }
        }

        private void eraserBrush_Click(object sender, EventArgs e)
        {
            pencil.Color = Color.White;

        }

        private void pencilBrush_Click(object sender, EventArgs e)
        {
            pencil.Color = colorBox.BackColor;

        }

        private void colorBox_Click(object sender, EventArgs e)
        {
            ColorDialog colorPick = new ColorDialog();
            if(colorPick.ShowDialog() == DialogResult.OK)
            {
                pencil.Color = colorPick.Color;
                colorBox.BackColor = colorPick.Color;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            graph.Clear(Color.White);
            drawingPanel.Invalidate();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Save this file as (*png) | *.png";
            saveFileDialog.DefaultExt = "png";
            saveFileDialog.AddExtension = true;
            
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                paper.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);

            } 

        }

        private void pencilBrushSize(object sender, EventArgs e)
        {
            pencil.Width = (float)pencilBrush_size.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
