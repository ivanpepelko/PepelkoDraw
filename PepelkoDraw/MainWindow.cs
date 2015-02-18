using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PepelkoDraw {
    public partial class MainWindow : Form {

        int PenWidth = 1;
        bool IsMouseDown = false;
        bool RedoEnabled = false;
        int StartX;
        int StartY;
        int EndX;
        int EndY;
        List<GraphicalObject> Objects = new List<GraphicalObject>();
        List<GraphicalObject> RedoBuffer = new List<GraphicalObject>();
        GraphicalObject CurrentObject;
        Graphics MasterGraphics;
        Tools SelectedTool = Tools.Line;

        enum Tools {
            Line,
            Ellipse,
            Rectangle,
            Exception
        }

        public MainWindow() {
            InitializeComponent();
            InitSettings();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void buttonWidthUp_Click(object sender, EventArgs e) {
            int pw = PenWidth;

            if (int.TryParse(penWidthBox.Text, out pw) && pw < 20) {
                PenWidth++;
                penWidthBox.Text = PenWidth.ToString();
            }

        }

        private void buttonWidthDown_Click(object sender, EventArgs e) {
            int pw = PenWidth;

            if (int.TryParse(penWidthBox.Text, out pw) && pw > 1) {
                PenWidth--;
                penWidthBox.Text = PenWidth.ToString();
            }
        }

        private void InitSettings() {
            colorButton.BackColor = colorPicker.Color;
            penWidthBox.Text = PenWidth.ToString();
        }

        private GraphicalObject CreateObject(Tools st, int sx, int sy, int ex, int ey) {
            switch (st) {
                default:
                case Tools.Line:
                    return new Line(sx, sy, ex, ey, colorPicker.Color, PenWidth);
                case Tools.Ellipse:
                    return new Ellipse(sx, sy, ex, ey, colorPicker.Color, PenWidth);
                case Tools.Rectangle:
                    return new Rectangle(sx, sy, ex, ey, colorPicker.Color, PenWidth);
            }
        }

        private void buttonLine_Click(object sender, EventArgs e) {
            SelectedTool = Tools.Line;
        }

        private void buttonEllipse_Click(object sender, EventArgs e) {
            SelectedTool = Tools.Ellipse;
        }

        private void buttonRectangle_Click(object sender, EventArgs e) {
            SelectedTool = Tools.Rectangle;
        }
        
    }
}
