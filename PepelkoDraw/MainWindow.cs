using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
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
            Rectangle
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

        private GraphicalObject CreateGraphicalObject(Tools st, int sx, int sy, int ex, int ey) {
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

        private void MainWindow_KeyPress(object sender, KeyPressEventArgs e) {

            switch (e.KeyChar) {
                case (char)26:
                    if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift) {
                        redoActionButton.PerformClick();
                    } else if (Control.ModifierKeys != Keys.Shift && Control.ModifierKeys == Keys.Control) {
                        undoActionButton.PerformClick();
                    }
                    break;

                case (char)19:
                    saveFileDialog.ShowDialog();
                    break;

                case (char)15:
                    openFileDialog.ShowDialog();
                    break;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            saveFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e) {

            string filename = saveFileDialog.FileName;
            
            XmlDocument doc = new XmlDocument();
            XmlWriter xw = XmlWriter.Create(filename);

            xw.WriteStartElement("PepelkoDrawFile");

            foreach (GraphicalObject o in Objects) {
                xw.WriteRaw(o.GetExportElement().OuterXml);
            }

            xw.WriteEndElement();

            doc.WriteContentTo(xw);
            xw.Flush();

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e) {
            int sx, sy, ex, ey, penw;
            int col_a, col_r, col_g, col_b;
            bool err = true;

            XmlReader xr = XmlReader.Create(openFileDialog.OpenFile());

            Objects.Clear();

            while (xr.Read()) {
                if (xr.Name == "PepelkoDrawFile")
                    err = false;

                switch (xr.Name) {
                    case "PepelkoDraw.Line":
                        getAttributesValues(xr, out sx, out sy, out ex, out ey, out penw, out col_a, out col_r, out col_g, out col_b);
                        Objects.Add(new Line(sx, sy, ex, ey, Color.FromArgb(col_a, col_r, col_g, col_b), penw));
                        break;
                    case "PepelkoDraw.Ellipse":
                        getAttributesValues(xr, out sx, out sy, out ex, out ey, out penw, out col_a, out col_r, out col_g, out col_b);
                        Objects.Add(new Ellipse(sx, sy, ex, ey, Color.FromArgb(col_a, col_r, col_g, col_b), penw));
                        break;
                    case "PepelkoDraw.Rectangle":
                        getAttributesValues(xr, out sx, out sy, out ex, out ey, out penw, out col_a, out col_r, out col_g, out col_b);
                        Objects.Add(new Rectangle(sx, sy, ex, ey, Color.FromArgb(col_a, col_r, col_g, col_b), penw));
                        break;
                }
            }

            if (err) {
                MessageBox.Show("Error parsing file!");
            }

        }

        private void getAttributesValues(XmlReader xr, out int sx, out int sy, out int ex, out int ey, out int penw, out int col_a, out int col_r, out int col_g, out int col_b) {
            int.TryParse(xr.GetAttribute("startx"), out sx);
            int.TryParse(xr.GetAttribute("starty"), out sy);
            int.TryParse(xr.GetAttribute("endx"), out ex);
            int.TryParse(xr.GetAttribute("endy"), out ey);
            int.TryParse(xr.GetAttribute("width"), out penw);

            int.TryParse(xr.GetAttribute("color-a"), out col_a);
            int.TryParse(xr.GetAttribute("color-r"), out col_r);
            int.TryParse(xr.GetAttribute("color-g"), out col_g);
            int.TryParse(xr.GetAttribute("color-b"), out col_b);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {
            Objects.Clear();
            Refresh();
        }
    }
}
