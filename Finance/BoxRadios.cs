using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Finance
{
    public class BoxRadio : Panel
    {
        public int BorderRadius { get; set; } = 40; // Define o raio da borda

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (GraphicsPath path = new GraphicsPath())
            {
                // Cria um caminho arredondado
                path.AddArc(0, 0, BorderRadius, BorderRadius, 180, 90);
                path.AddArc(Width - BorderRadius, 0, BorderRadius, BorderRadius, 270, 90);
                path.AddArc(Width - BorderRadius, Height - BorderRadius, BorderRadius, BorderRadius, 0, 90);
                path.AddArc(0, Height - BorderRadius, BorderRadius, BorderRadius, 90, 90);
                path.CloseFigure();

                // Aplica o caminho como a região do painel
                this.Region = new Region(path);

                // Desenha a borda
                using (Pen pen = new Pen(Color.White, 1)) // Altere a cor e a espessura conforme necessário
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
    }

}
