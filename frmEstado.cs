using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocios;

namespace Lavadero
{
    public partial class frmEstado : Form
    {
        public NegAll objNegAll = new NegAll();
        string OrdenCb = "";

        public frmEstado()
        {
            InitializeComponent();
            dgvEstado.ColumnCount = 5;
            dgvEstado.Columns[0].HeaderText = "Datos del cliente";
            dgvEstado.Columns[1].HeaderText = "Vehiculo ";
            dgvEstado.Columns[2].HeaderText = "Dia";
            dgvEstado.Columns[3].HeaderText = "Hora";
            dgvEstado.Columns[4].HeaderText = "Datos del empleado";
            //dgvEstado.Columns[5].HeaderText = "Año";
            //dgvEstado.Columns[6].HeaderText = "Patente";
            //dgvEstado.Columns[7].HeaderText = "Dia de Ingreso";
            //dgvEstado.Columns[8].HeaderText = "Hora de Ingreso";
            //dgvEstado.Columns[9].HeaderText = "Dni Empleado a cargo";
            OrdenCb = "todos";
            Filldgv();
            Orden();
            
        }

        private void Filldgv()
        {
            dgvEstado.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegAll.lista(OrdenCb);
            if (ds.Tables[0].Rows.Count>0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    //dgvEstado.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), Convert.ToDateTime(dr[7]).ToShortDateString(), dr[8].ToString(), dr[9].ToString());
                    dgvEstado.Rows.Add(dr[0].ToString(), dr[1].ToString(), Convert.ToDateTime(dr[2]).ToShortDateString(), dr[3].ToString(), dr[4].ToString());

                }

            }
            else
            {
                MessageBox.Show("Error al cargar", "Error");
            }
        }

        private void Orden()
        { 
            cbOrden.Items.Add("Hora ascendente");
            cbOrden.Items.Add("Hora descendente");
            cbOrden.Items.Add("Fecha ascendente");
            cbOrden.Items.Add("Fecha descendente");
            cbOrden.Items.Add("Dni propietario");
            cbOrden.Items.Add("Apellido descendente");
            cbOrden.Items.Add("Apellido ascendente");

        }
        private void frmEstado_Load(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + .10;
            if (this.Opacity==1)
            {
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void cbOrden_TextChanged(object sender, EventArgs e)
        {
            if (cbOrden.Text== "Hora ascendente")
            {
                OrdenCb = "HA";
                Filldgv();
            }
            if (cbOrden.Text == "Hora descendente")
            {
                OrdenCb = "HD";
                Filldgv();
            }
            if (cbOrden.Text == "Fecha ascendente")
            {
                OrdenCb = "FA";
                Filldgv();
            }
            if (cbOrden.Text == "Fecha descendente")
            {
                OrdenCb = "FD";
                Filldgv();
            }
            if (cbOrden.Text == "Dni propietario")
            {
                OrdenCb = "DP";
                Filldgv();
            }
            if (cbOrden.Text == "Apellido descendente")
            {
                OrdenCb = "AD";
                Filldgv();
            }
            if (cbOrden.Text == "Apellido ascendente")
            {
                OrdenCb = "AA";
                Filldgv();
            }
        }
    }
}
