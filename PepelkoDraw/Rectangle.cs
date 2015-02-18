using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PepelkoDraw {
    class Rectangle : GraphicalObject {

        public Rectangle(int sx, int sy, int ex, int ey, Color c, int penw)
            : base(sx, sy, ex, ey, c, penw) {
        }

        public override void Draw(Graphics g) {
            int w = EndX - StartX;
            int h = EndY - StartY;

            if (StartX < EndX) {
                if (StartY < EndY)
                    g.DrawRectangle(p, StartX, StartY, w, h);
                else if (EndY < StartY)
                    g.DrawRectangle(p, StartX, EndY, w, -h);
            } else if (EndX < StartX) {
                if (StartY < EndY)
                    g.DrawRectangle(p, EndX, StartY, -w, h);
                else if (EndY < StartY)
                    g.DrawRectangle(p, EndX, EndY, -w, -h);
            }

        }
    }
}
