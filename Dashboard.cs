using ShowTime_DatabseProject.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShowTime_DatabseProject
{
    /// <summary>
    /// Formulario principal que actúa como un panel de control para la aplicación.
    /// </summary>
    public partial class Dashboard : Form
    {
        /// <summary>
        /// Rastrea el formulario actualmente cargado en el panel.
        /// </summary>
        private Form formularioActual;

        /// <summary>
        /// Inicializa una nueva instancia de <see cref="Dashboard"/> y configura los botones y paneles iniciales.
        /// </summary>
        /// <param name="username">Nombre del usuario que inició sesión.</param>
        public Dashboard(string username, string Cargo)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            // Configurar bordes con hover para los botones del menú
            ConfigurarBotonesMenu();

            // Mostrar el nombre del usuario actual
            UserLabel.Text = username;

            // Cargar el formulario de inicio por defecto en el panel
            CargarFormularioEnCelda(new Inicio(), PanelForm, 0, 1);
           
            
            ConfigurarBotonesSegunRol(Cargo, sidebarPanel);

        }

        /// <summary>
        /// Configura los bordes y estilos de los botones del menú.
        /// </summary>
        private void ConfigurarBotonesMenu()
        {
            Color colorBase = Color.FromArgb(18, 29, 36);
            Color colorHover = Color.FromArgb(10, 180, 180, 180);

            Utils.AgregarBordeInferiorConHover(dashboardButton, colorBase, 3, colorHover, Color.Black);
            Utils.AgregarBordeInferiorConHover(eventButton, colorBase, 3, colorHover, Color.Black);
            Utils.AgregarBordeInferiorConHover(utileriaButton, colorBase, 3, colorHover, Color.Black);
            Utils.AgregarBordeInferiorConHover(serviceButton, colorBase, 3, colorHover, Color.Black);
            Utils.AgregarBordeInferiorConHover(paqueteButton, colorBase, 3, colorHover, Color.Black);
            Utils.AgregarBordeInferiorConHover(empleadoButton, colorBase, 3, colorHover, Color.Black);
            Utils.AgregarBordeInferiorConHover(btnClientes, colorBase, 3, colorHover, Color.Black);
        }

        /// <summary>
        /// Carga un formulario en una celda específica de un <see cref="TableLayoutPanel"/>.
        /// </summary>
        /// <param name="nuevoFormulario">Formulario que se desea cargar.</param>
        /// <param name="tableLayoutPanel">Panel donde se cargará el formulario.</param>
        /// <param name="col">Columna de la celda.</param>
        /// <param name="row">Fila de la celda.</param>
        private void CargarFormularioEnCelda(Form nuevoFormulario, TableLayoutPanel tableLayoutPanel, int col, int row)
        {
            // Verificar si el formulario ya está cargado
            if (formularioActual != null && formularioActual.GetType() == nuevoFormulario.GetType())
            {
                return; // No cargar nuevamente el mismo formulario
            }

            // Remover y liberar el control existente en la celda
            Control controlExistente = tableLayoutPanel.GetControlFromPosition(col, row);
            if (controlExistente != null)
            {
                tableLayoutPanel.Controls.Remove(controlExistente);
                controlExistente.Dispose();
                formularioActual = null;
            }

            // Crear un panel para alojar el nuevo formulario
            Panel panel = new Panel
            {
                Dock = DockStyle.Fill // Asegurar que el panel ocupe toda la celda
            };
            tableLayoutPanel.Controls.Add(panel, col, row);

            // Configurar el formulario
            nuevoFormulario.TopLevel = false;
            nuevoFormulario.FormBorderStyle = FormBorderStyle.None;
            nuevoFormulario.Dock = DockStyle.Fill;

            // Añadir el formulario al panel y mostrarlo
            panel.Controls.Add(nuevoFormulario);
            nuevoFormulario.Show();

            // Guardar referencia al formulario actual
            formularioActual = nuevoFormulario;
        }

        /// <summary>
        /// Maneja el clic en el botón del tablero de inicio.
        /// </summary>
        private void dashboardButton_Click(object sender, EventArgs e)
        {
            CargarFormularioEnCelda(new Inicio(), PanelForm, 0, 1);
        }


        // Diccionario de permisos, donde la clave es el nombre del botón y el valor son los roles que pueden acceder.
        private Dictionary<string, List<string>> permisosPorBoton = new Dictionary<string, List<string>>()
        {
            { "dashboardButton", new List<string> { "Gerente", "Empleado", "Bodeguero", "Recursos Humanos" } },
            { "eventButton", new List<string> { "Gerente", "Empleado" } },
            { "utileriaButton", new List<string> { "Gerente", "Bodeguero" } },
            { "serviceButton", new List<string> { "Gerente"  } },
            { "paqueteButton", new List<string> { "Gerente" } },
            { "empleadoButton", new List<string> { "Gerente", "Recursos Humanos" } },
            { "btnClientes", new List<string> { "Gerente", "Recursos Humanos" } }
         };

        private void ConfigurarBotonesSegunRol(string rolActual, TableLayoutPanel tableLayoutPanel)
        {
            // Lista para almacenar los botones accesibles
            List<Control> botonesAccesibles = new List<Control>();

            // Mantener la referencia a la imagen en la fila 0
            Control imagenEncabezado = tableLayoutPanel.GetControlFromPosition(1, 0);

            // Iteramos sobre los controles del TableLayoutPanel desde la fila 1
            foreach (Control control in tableLayoutPanel.Controls.OfType<Button>().ToList())
            {
                // Verificamos si el botón tiene permisos para el rol actual
                if (permisosPorBoton.ContainsKey(control.Name) && permisosPorBoton[control.Name].Contains(rolActual))
                {
                    botonesAccesibles.Add(control); // Botón accesible
                }
                else
                {
                    tableLayoutPanel.Controls.Remove(control); // Botón eliminado
                }
            }

            // Reorganizamos los botones accesibles
            ReorganizarBotones(botonesAccesibles, tableLayoutPanel, imagenEncabezado);
        }

        private void ReorganizarBotones(List<Control> botonesAccesibles, TableLayoutPanel tableLayoutPanel, Control imagenEncabezado)
        {
            // Limpiamos los botones del TableLayoutPanel pero dejamos la imagen intacta
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.Controls.Add(imagenEncabezado, 1, 0); // Reasignar la imagen en la fila 0, columna 1

            // Reasignamos los botones accesibles, avanzando de 2 en 2 filas
            int fila = 2; // Comenzamos en la fila 2 (después de la imagen)
            for (int i = 0; i < botonesAccesibles.Count; i++)
            {
                Control boton = botonesAccesibles[i];
                tableLayoutPanel.Controls.Add(boton, 1, fila);  // Colocamos el botón en la columna 1 y fila 'fila'
                fila += 2; // Aumentamos la fila en 2 para que el siguiente botón se coloque 2 filas más abajo
            }
        }






        /// <summary>
        /// Maneja el clic en el botón de utilería.
        /// </summary>
        private void utileriaButton_Click(object sender, EventArgs e)
        {
            CargarFormularioEnCelda(new Utileria(), PanelForm, 0, 1);
        }

        /// <summary>
        /// Maneja el clic en el botón de empleados.
        /// </summary>
        private void empleadoButton_Click(object sender, EventArgs e)
        {
            CargarFormularioEnCelda(new Empleados(), PanelForm, 0, 1);
        }

        /// <summary>
        /// Maneja el clic en el botón de servicios.
        /// </summary>
        private void serviceButton_Click(object sender, EventArgs e)
        {
            CargarFormularioEnCelda(new Servicios(), PanelForm, 0, 1);
        }

        /// <summary>
        /// Maneja el clic en el botón de paquetes.
        /// </summary>
        private void paqueteButton_Click(object sender, EventArgs e)
        {
            CargarFormularioEnCelda(new Paquetes(), PanelForm, 0, 1);
        }

        /// <summary>
        /// Maneja el clic en el botón de eventos.
        /// </summary>
        private void eventButton_Click(object sender, EventArgs e)
        {
            CargarFormularioEnCelda(new Eventos(), PanelForm, 0, 1);
        }

        /// <summary>
        /// Maneja el clic en el botón de cierre de sesión.
        /// Cierra el formulario actual y muestra el formulario de inicio de sesión.
        /// </summary>
        private void CierreSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            CargarFormularioEnCelda(new Clientes(), PanelForm, 0, 1);
        }
    }
}
