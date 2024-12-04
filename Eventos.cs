using System;
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
    public partial class Eventos : Form
    {
        public Eventos()
        {
            InitializeComponent();
        }

        private void registerEvent_Click(object sender, EventArgs e)
        {
            InformacionCliente informacionCliente = new InformacionCliente();
            informacionCliente.ShowDialog(this);
        }

        private void editEvent_Click(object sender, EventArgs e)
        {

        }

        private void payEvent_Click(object sender, EventArgs e)
        {

        }
    }
}
