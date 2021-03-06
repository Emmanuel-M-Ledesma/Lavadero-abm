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
using Entidades;
using Datos;

namespace Lavadero
{
    public partial class frmCarga : Form
    {
        public NegAll objNegAll = new NegAll();
        public NegLavado objNegLavado = new NegLavado();
        public Auto objEAutos = new Auto();
        public Lavado objELavado = new Lavado();
         
        public TimeSpan hora = new TimeSpan();
        public frmCarga()
        {
            InitializeComponent();
            CargarCBE();
            
            txtHora.Text = DateTime.Now.ToShortTimeString();
            
            dgvCarga.ColumnCount = 4;
            dgvCarga.Columns[0].HeaderText = "Empleado a cargo ";
            dgvCarga.Columns[1].HeaderText = "Patente del auto";
            dgvCarga.Columns[2].HeaderText = "DIa";
            dgvCarga.Columns[3].HeaderText = "Hora";
            //Todo: agregar a la tabla de sql el tipo de lavado que quiera el cliente
            Filldgv();
            cbAuto.Text = "";
            cbEmpleado.Text = "";
            dtpDia.Text = "";
        }


        private void Filldgv()
        {
            dgvCarga.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegLavado.listaTrabajo("listar");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvCarga.Rows.Add(dr[0].ToString(), dr[1].ToString(), Convert.ToDateTime(dr[2]).ToShortDateString(), (dr[3]).ToString());
                }
            }
        }

        private void CargarCBE()
        {
            cbEmpleado.DataSource = objNegAll.Combo("empleado");
            cbEmpleado.DisplayMember = "NombreCompleto";
            cbEmpleado.ValueMember = "DNI";
            cbAuto.DataSource = objNegAll.Combo("auto");
            cbAuto.DisplayMember = "Vehiculo";
            cbAuto.ValueMember = "Patente";
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int nAdd = -1;
           
            TxtObj();
            nAdd = objNegLavado.abmLavado("alta", objELavado, objEAutos);
            if (nAdd == -1)
            {

                MessageBox.Show("No se pudo grabar en el sistema");
            }
            else
            {
                Filldgv();
                Clean();
                txtHora.Text = DateTime.Now.ToShortTimeString();
            }
        }
        private void Clean()
        {
            cbAuto.Text = "";
            cbEmpleado.Text = "";
            txtHora.Clear();
        }

        private void TxtObj()
        {
            
            objEAutos.patente = cbAuto.SelectedValue.ToString();
            objELavado.dni = cbEmpleado.SelectedValue.ToString();
            objELavado.dia = dtpDia.Value;
            objELavado.hora =TimeSpan.Parse(  txtHora.Text);
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            txtHora.Text = DateTime.Now.ToShortTimeString();
            cbAuto.Text = "";
            cbEmpleado.Text = "";
            dtpDia.Text = "";
        }

        
    }
}
