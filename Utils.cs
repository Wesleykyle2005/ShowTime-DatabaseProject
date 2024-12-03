using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowTime_DatabseProject
{
    public class Utils
    {
        public static void AgregarBordeInferiorConHover(Button boton, Color colorBorde, int grosor, Color colorFondoHover, Color colorTextoHover)
        {
            // Variable para guardar el color original del botón
            Color colorOriginal = boton.BackColor;
            Color colorTextoOriginal = boton.ForeColor;

            // Evento Paint para dibujar el borde inferior
            boton.Paint += (sender, e) =>
            {
                int anchoBoton = boton.ClientSize.Width;
                int altoBoton = boton.ClientSize.Height;

                using (Pen pen = new Pen(colorBorde, grosor))
                {
                    e.Graphics.DrawLine(pen, 0, altoBoton - grosor, anchoBoton, altoBoton - grosor);
                }
            };

            // Evento MouseEnter para cambiar los colores en hover
            boton.MouseEnter += (sender, e) =>
            {
                boton.BackColor = colorFondoHover;
                boton.ForeColor = colorTextoHover;
            };

            // Evento MouseLeave para restaurar los colores originales
            boton.MouseLeave += (sender, e) =>
            {
                boton.BackColor = colorOriginal;
                boton.ForeColor = colorTextoOriginal;
            };
        }

    }
}
