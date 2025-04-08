using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace MAD.Clases
{
    internal class Buttons : Button
    {
        private int borderSize = 0;
        private int borderRadius = 30;
        private Color borderColor = Color.PaleVioletRed;

        //inicilizar propiedades default del button
        public Buttons() { 
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            
            this.BackColor = Color.AliceBlue;
            this.ForeColor = Color.White;
        }

        //obtener los gráficos para la forma del botón
        private GraphicsPath GetButtonPath(RectangleF rect, float radio) {
            GraphicsPath path= new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y,radio,radio,180,99);
            path.AddArc(rect.Width-radio, rect.Y, radio, radio, 270, 90);
            path.AddArc(rect.Width - radio, rect.Height-radio, radio, radio, 0, 90);
            path.AddArc(rect.X, rect.Height - radio, radio, radio, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.0F, this.Height - 1);

            if (borderRadius > 2)
            { //button con rouded corners
                using (GraphicsPath pathSurface = GetButtonPath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetButtonPath(rectBorder, borderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region=new Region(pathSurface);
                    //HD reult
                    e.Graphics.DrawPath(penSurface, pathSurface);

                    //dibujar el borde
                    if(borderSize>=1)
                        e.Graphics.DrawPath(penBorder, pathBorder);
                }

            }
            else { //otherwise rectagular
                this.Region = new Region(rectSurface);

                if(borderSize >= 1)
                {
                    using (Pen penBorder= new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment=PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorder,0,0,this.Width-1,this.Height-1);
                    }
                }
            }
        }
        //similar al load event of the form/user control, se ejecuta cuando el handle se crea
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);

        }
        private void Container_BackColorChanged(object sender, EventArgs e) { 
            if(this.DesignMode) this.Invalidate();
        }
    }
}
