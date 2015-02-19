using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml;

namespace PepelkoDraw {
    abstract class GraphicalObject {

        protected int StartX {
            get;
            set;
        }

        protected int StartY {
            get;
            set;
        }

        protected int EndX {
            get;
            set;
        }

        protected int EndY {
            get;
            set;
        }

        protected Pen p;

        public GraphicalObject(int sx, int sy, int ex, int ey, Color c, int penw) {
            StartX = sx;
            StartY = sy;
            EndX = ex;
            EndY = ey;
            p = new Pen(c, penw);
        }

        public abstract void Draw(Graphics g);

        public XmlElement GetExportElement() {
            XmlDocument doc = new XmlDocument();

            string type = this.GetType().ToString();

            XmlElement obj = doc.CreateElement(type);

            obj.SetAttribute("startx", StartX.ToString());
            obj.SetAttribute("starty", StartY.ToString());
            obj.SetAttribute("endx", EndX.ToString());
            obj.SetAttribute("endy", EndY.ToString());
            obj.SetAttribute("color-a", p.Color.A.ToString());
            obj.SetAttribute("color-r", p.Color.R.ToString());
            obj.SetAttribute("color-g", p.Color.G.ToString());
            obj.SetAttribute("color-b", p.Color.B.ToString());
            obj.SetAttribute("width", p.Width.ToString());

            return obj;
        }

    }
}
