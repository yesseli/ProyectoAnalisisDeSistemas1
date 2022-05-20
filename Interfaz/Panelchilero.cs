using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;


namespace interfazServicios
{
    public class Panelchilero: Panel
    {
        // Valores
        private int radiodelborde = 30;
        private float degradado = 30F;
        private Color Colordearriba = Color.Red;
        private Color colorDeAbajo = Color.Blue;

        //Constructor
        public Panelchilero ()
        {
            this.BackColor = Color.White;   
            this.ForeColor = Color.Black;
            this.Size = new Size(350,200);
        }

        //Propiedades
        public int Radiodelborde 
        {
            get => radiodelborde;
            set { radiodelborde = value; this.Invalidate(); }
        }
        public float Degradado 
        {
            get => degradado;
            set { degradado = value; this.Invalidate(); }
        }
        public Color Colordearriba1 
        {
            get => Colordearriba;
            set { Colordearriba = value; this.Invalidate(); }
        }
        public Color ColorDeAbajo
        {
            get => colorDeAbajo;
            set { colorDeAbajo = value; this.Invalidate(); }

        }

        //Metodos
        private GraphicsPath GetPanelChileroPath(RectangleF rectangle, float radius )
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();
            graphicsPath.AddArc(rectangle.Width-radius, rectangle.Height-radius, radius,radius,0,90);
            graphicsPath.AddArc(rectangle.X,rectangle.Height - radius, radius, radius, 90, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            graphicsPath.CloseFigure();
            return graphicsPath;

        }

        //Metodos overide

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //gradiente 
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            LinearGradientBrush brushArtan = new LinearGradientBrush(this.ClientRectangle, this.Colordearriba, this.colorDeAbajo, this.degradado );
            Graphics graphicsPanelChilero = e.Graphics;
            graphicsPanelChilero.FillRectangle(brushArtan,ClientRectangle);

            //RadiodelBorde
            RectangleF rectangleF = new  RectangleF(0,0, this.Width, this.Height);

            if (Radiodelborde > 2)
            {
                using (GraphicsPath graphicsPath = GetPanelChileroPath(rectangleF, Radiodelborde))
                using (Pen pen = new Pen(this.Parent.BackColor, 2))
                {
                    this.Region = new Region(graphicsPath);
                    e.Graphics.DrawPath(pen, graphicsPath);
                }
            }
            else this.Region = new Region(rectangleF);
        }

    }
}
