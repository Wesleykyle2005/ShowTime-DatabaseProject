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
        public Dashboard(string username)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            // Configurar bordes con hover para los botones del menú
            ConfigurarBotonesMenu();

            // Mostrar el nombre del usuario actual
            UserLabel.Text = username;

            // Cargar el formulario de inicio por defecto en el panel
            CargarFormularioEnCelda(new Inicio(), PanelForm, 0, 1);
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
