﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowTime_DatabseProject
{
    public partial class Dashboard : Form
    {

        private Form formularioActual; // Para rastrear el formulario actualmente cargado en la celda

        public Dashboard(string username)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Utils.AgregarBordeInferiorConHover(dashboardButton, Color.FromArgb(18, 29, 36), 3, Color.FromArgb(10, 180, 180, 180), Color.Black);
            Utils.AgregarBordeInferiorConHover(eventButton, Color.FromArgb(18, 29, 36), 3, Color.FromArgb(10, 180, 180, 180), Color.Black);
            Utils.AgregarBordeInferiorConHover(utileriaButton, Color.FromArgb(18, 29, 36), 3, Color.FromArgb(10, 180, 180, 180), Color.Black);
            Utils.AgregarBordeInferiorConHover(serviceButton, Color.FromArgb(18, 29, 36), 3, Color.FromArgb(10, 180, 180, 180), Color.Black);
            Utils.AgregarBordeInferiorConHover(paqueteButton, Color.FromArgb(18, 29, 36), 3, Color.FromArgb(10, 180, 180, 180), Color.Black);
            Utils.AgregarBordeInferiorConHover(empleadoButton, Color.FromArgb(18, 29, 36), 3, Color.FromArgb(10, 180, 180, 180), Color.Black);
            UserLabel.Text = username;
        }

        private void CargarFormularioEnCelda(Form nuevoFormulario, TableLayoutPanel tableLayoutPanel, int col, int row)
        {
            // Validar si el formulario ya está cargado
            if (formularioActual != null && formularioActual.GetType() == nuevoFormulario.GetType())
            {
                return; // Si es el mismo formulario, no hace nada
            }

            // Obtener el control actual en la celda
            Control controlExistente = tableLayoutPanel.GetControlFromPosition(col, row);

            // Si hay un control, eliminarlo
            if (controlExistente != null)
            {
                tableLayoutPanel.Controls.Remove(controlExistente);
                controlExistente.Dispose(); // Liberar recursos del control anterior
                formularioActual = null;   // Resetear el formulario actual
            }

            // Crear un panel para la celda específica
            Panel panel = new Panel
            {
                Dock = DockStyle.Fill // Asegura que el panel ocupe toda la celda
            };

            // Agrega el panel al TableLayoutPanel en la celda especificada
            tableLayoutPanel.Controls.Add(panel, col, row);

            // Configura el formulario
            nuevoFormulario.TopLevel = false; // No es de nivel superior
            nuevoFormulario.FormBorderStyle = FormBorderStyle.None; // Sin bordes ni barra de título
            nuevoFormulario.Dock = DockStyle.Fill; // Ocupa todo el espacio del panel

            // Agrega el formulario al panel y lo muestra
            panel.Controls.Add(nuevoFormulario);
            nuevoFormulario.Show();

            // Guardar referencia del formulario actual
            formularioActual = nuevoFormulario;
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            // Cargar el formulario Inicio en la posición (0, 1)
            CargarFormularioEnCelda(new Inicio(), PanelForm, 0, 1);
        }

        private void utileriaButton_Click(object sender, EventArgs e)
        {
            CargarFormularioEnCelda(new Utileria(), PanelForm, 0, 1);
        }

        private void empleadoButton_Click(object sender, EventArgs e)
        {
            CargarFormularioEnCelda(new Empleados(), PanelForm, 0, 1);
        }

        private void serviceButton_Click(object sender, EventArgs e)
        {
            CargarFormularioEnCelda(new Servicios(), PanelForm, 0, 1);
        }

        private void paqueteButton_Click(object sender, EventArgs e)
        {
            CargarFormularioEnCelda(new Paquetes(), PanelForm, 0, 1);
        }

        private void eventButton_Click(object sender, EventArgs e)
        {
            CargarFormularioEnCelda(new Eventos(), PanelForm, 0, 1);

        }

        private void CierreSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
    }
}
