using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace Lavadero
{
    public partial class frmCarga : Form
    {
        public NegAll objNegAll = new NegAll();
        public TimeSpan hora = new TimeSpan();
        public frmCarga()
        {
            InitializeComponent();
            CargarCBE();
            
            txtHora.Text = DateTime.Now.ToShortTimeString();
            dgvCarga.ColumnCount = 4;
            dgvCarga.Columns[0].HeaderText = "DNi empleado a cargo ";
            dgvCarga.Columns[1].HeaderText = "Patente del auto";
            dgvCarga.Columns[2].HeaderText = "DIa";
            dgvCarga.Columns[3].HeaderText = "Hora";
            //Todo: agregar a la tabla de sql el tipo de lavado que quiera el cliente
        }


        private void Filldgv()
        {
            dgvCarga.Rows.Clear();
            DataSet ds = new DataSet();
            
        }

        private void CargarCBE()
        {
            cbEmpleado.DataSource = objNegAll.Combo("empleado");
            cbEmpleado.DisplayMember = "Apellido";
            cbEmpleado.ValueMember = "DNI";
            cbAuto.DataSource = objNegAll.Combo("auto");
            cbAuto.DisplayMember = "Patente";
            cbAuto.ValueMember = "Patente";
        }
    }
}
