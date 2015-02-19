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

        private void MainWindow_Paint(object sender, PaintEventArgs e) {
            MasterGraphics = e.Graphics;
            MasterGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            
            if (IsMouseDown) {
                CurrentObject = CreateGraphicalObject(SelectedTool, StartX, StartY, EndX, EndY);
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

        private void colorButton_Click(object sender, EventArgs e) {
            colorPicker.ShowDialog();
            colorButton.BackColor = colorPicker.Color;
        }

        private void MainWindow_MouseDown(object sender, MouseEventArgs e) {
            Cursor = Cursors.Cross;
            IsMouseDown = true;
            StartX = e.X;
            StartY = e.Y;
        }

        private void MainWindow_MouseUp(object sender, MouseEventArgs e) {
            Cursor = Cursors.Default;
            IsMouseDown = false;

            Objects.Add(CreateGraphicalObject(SelectedTool, StartX, StartY, e.X, e.Y));

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
