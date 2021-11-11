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

namespace Lavadero
{
    public partial class frmAddAuto : Form
    {
        public NegAll objNegAll = new NegAll();
        public NegAuto objNegAuto = new NegAuto();
        public Auto objEAuto = new Auto();
        public Cliente objECli = new Cliente();
        public frmAddAuto()
        {
            InitializeComponent();
            CargarCBE();
            dgvAuto.ColumnCount = 5;
            dgvAuto.Columns[0].HeaderText = "DNI del propietario ";
            dgvAuto.Columns[1].HeaderText = "Patente  ";
            dgvAuto.Columns[2].HeaderText = "Marca ";
            dgvAuto.Columns[3].HeaderText = "Modelo ";
            dgvAuto.Columns[4].HeaderText = "Año ";

            Filldgv();
        }

        private void CargarCBE()
        {
            cbCliente.DataSource = objNegAll.Combo("cliente");
            cbCliente.DisplayMember = "DNI";
            cbCliente.ValueMember = "DNI";
            
        }


        private void Filldgv()
        {
            dgvAuto.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegAuto.listaAutos("listar");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvAuto.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(),dr[3].ToString(), dr[4].ToString());
                }
            }
        }

        private void TxtObj()
        {
            objECli.dni = cbCliente.Text;
            objEAuto.patente = txtPat.Text;
            objEAuto.marca = txtMarca.Text;
            objEAuto.modelo = txtMod.Text;
            objEAuto.años =int.Parse( txtAño.Text);
        }

        private void Clean()
        {
            txtAño.Clear();
            txtMarca.Clear();
            txtMod.Clear();
            txtPat.Clear();
            cbCliente.Text = "";
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int nAdd = -1;
            TxtObj();
            nAdd = objNegAuto.abmAutos("alta",objEAuto,objECli);
            if (nAdd == -1)
            {

                MessageBox.Show("No se pudo grabar en el sistema");
            }
            else
            {
                Filldgv();
                Clean();
               
            }
        }
    }
}
