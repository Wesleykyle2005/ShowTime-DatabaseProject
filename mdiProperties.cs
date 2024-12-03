using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ShowTime_DatabseProject
{
    public static class mdiProperties
    {
        // Importaciones de la API de Windows
        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        private static extern int SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter,
            int X, int Y, int cx, int cy, uint uFlags);

        // Constantes de la API de Windows
        private const int GWL_EXSTYLE = -20;                     // Índice para estilos extendidos de ventana
        private const int WS_EX_CLIENTEDGE = 0x0200;             // Borde extendido para áreas cliente MDI
        private const uint SWP_NOMOVE = 0x0002;                  // No mover la ventana
        private const uint SWP_NOSIZE = 0x0001;                  // No cambiar el tamaño de la ventana
        private const uint SWP_NOZORDER = 0x0004;                // No cambiar el orden Z
        private const uint SWP_NOACTIVATE = 0x0010;              // No activar la ventana
        private const uint SWP_FRAMECHANGED = 0x0020;            // Indica que el marco de la ventana ha cambiado

        /// <summary>
        /// Modifica el borde extendido del área cliente MDI del formulario.
        /// </summary>
        /// <param name="form">Formulario principal que contiene el cliente MDI.</param>
        /// <param name="show">`true` para habilitar el borde, `false` para deshabilitarlo.</param>
        public static void SetBevel(this Form form, bool show)
        {
            bool clientFound = false;

            foreach (Control c in form.Controls)
            {
                if (c is MdiClient client)
                {
                    clientFound = true;

                    // Obtener el estilo extendido de la ventana
                    int windowLong = GetWindowLong(client.Handle, GWL_EXSTYLE);

                    // Habilitar o deshabilitar el borde según el parámetro `show`
                    if (show)
                    {
                        windowLong |= WS_EX_CLIENTEDGE; // Agregar el estilo de borde extendido
                    }
                    else
                    {
                        windowLong &= ~WS_EX_CLIENTEDGE; // Eliminar el estilo de borde extendido
                    }

                    // Aplicar los cambios
                    SetWindowLong(client.Handle, GWL_EXSTYLE, windowLong);
                    SetWindowPos(client.Handle, IntPtr.Zero, 0, 0, 0, 0,
                        SWP_NOMOVE | SWP_NOSIZE | SWP_NOZORDER | SWP_NOACTIVATE | SWP_FRAMECHANGED);

                    // Terminar el bucle una vez modificado el cliente
                    break;
                }
            }

            if (!clientFound)
            {
                throw new InvalidOperationException("No se encontró un control MdiClient en el formulario.");
            }
        }
    }
}
