using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowTime_DatabseProject
{
    public partial class InformacionCliente : Form
    {
        public InformacionCliente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
            string.IsNullOrWhiteSpace(txtApellido.Text) ||
            string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos obligatorios.", "Validación");
                return;
            }

            // Instancia de EventoInfo
            EventoTemporal eventoTemporal= new EventoTemporal
            {
                NombreCliente = txtNombre.Text,
                ApellidoCliente = txtApellido.Text,
                TelefonoCliente = txtTelefono.Text,
                CorreoCliente = txtCorreo.Text
            };

            // Pasar a la siguiente etapa
            DetallesDelEvento detalles = new DetallesDelEvento(eventoTemporal);
            detalles.ShowDialog();
            this.Close();
        }
    }
}
