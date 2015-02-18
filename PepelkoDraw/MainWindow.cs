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

        public MainWindow() {
            InitializeComponent();
            InitSettings();
        }

        private void MainWindow_Paint(object sender, PaintEventArgs e) {
            MasterGraphics = e.Graphics;

            if (IsMouseDown) {
                CurrentObject = new Line(StartX, StartY, EndX, EndY, colorPicker.Color, PenWidth);
                CurrentObject.Draw(MasterGraphics);
            }

            foreach (GraphicalObject go in Objects) {
                go.Draw(MasterGraphics);
            }

            if (Objects.Count == 0) {
                undoActionButton.Enabled = false;
            } else {
                undoActionButton.Enabled = true;
            }

            if (RedoBuffer.Count == 0) {
                redoActionButton.Enabled = false;
                RedoEnabled = false;
            } else {
                redoActionButton.Enabled = true;
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void InitSettings() {
            colorButton.BackColor = colorPicker.Color;
            penWidthBox.Text = PenWidth.ToString();

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

        private void colorButton_Click(object sender, EventArgs e) {
            colorPicker.ShowDialog();
            colorButton.BackColor = colorPicker.Color;
        }

        private void MainWindow_MouseDown(object sender, MouseEventArgs e) {
            IsMouseDown = true;
            StartX = e.X;
            StartY = e.Y;
        }

        private void MainWindow_MouseUp(object sender, MouseEventArgs e) {
            IsMouseDown = false;

            Objects.Add(new Line(StartX, StartY, e.X, e.Y, colorPicker.Color, PenWidth));

            RedoEnabled = false;
            RedoBuffer.Clear();
            Refresh();
        }


        private void MainWindow_MouseMove(object sender, MouseEventArgs e) {
            EndX = e.X;
            EndY = e.Y;
            Refresh();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e) {
            if (undoActionButton.Enabled) {
                RedoBuffer.Add(Objects.Last());
                Objects.Remove(Objects.Last());
                RedoEnabled = true;
                Refresh();
            }
        }

        private void redoActionButton_Click(object sender, EventArgs e) {
            if (redoActionButton.Enabled && RedoEnabled) {
                Objects.Add(RedoBuffer.Last());
                RedoBuffer.Remove(RedoBuffer.Last());
                Refresh();
            }
        }

    }
}
