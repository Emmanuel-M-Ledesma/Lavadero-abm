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
    public partial class frmCliente : Form
    {
        public Cliente objECli = new Cliente();
        public Auto objEAuto = new Auto();
        public NegCliente objNegCli = new NegCliente();
        public NegAuto objNegAuto = new NegAuto();
        public NegAll objNegAll = new NegAll();
        public frmCliente()
        {
            InitializeComponent();
            dgvCliente.ColumnCount = 7;
            dgvCliente.Columns[0].HeaderText = "Dni";
            dgvCliente.Columns[1].HeaderText = "Apellido";
            dgvCliente.Columns[2].HeaderText = "Nombre";
            dgvCliente.Columns[3].HeaderText = "Marca del auto";
            dgvCliente.Columns[4].HeaderText = "Modelo";
            dgvCliente.Columns[5].HeaderText = "Año";
            dgvCliente.Columns[6].HeaderText = "Patente";

            Filldgv();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (!(txtDNI.Text==""||txtPat.Text==""||txtNom.Text==""||txtMod.Text==""||txtMar.Text==""||txtAño.Text==""||txtApel.Text==""))
            {
                int nAdd = -1;
                int nAdd1 = -1;
                TxtObj();
                nAdd = objNegCli.abmCliente("alta", objECli);
                nAdd1 = objNegAuto.abmAutos("alta", objEAuto, objECli);
                if (nAdd==-1 && nAdd1 == -1)
                {
                    MessageBox.Show("No se pudo guardar el cliente en el sistema");
                }
                else
                {
                    Filldgv();
                    Clean();
                }
            }
        }

        private void TxtObj()
        {
            objECli.dni = txtDNI.Text;
            objECli.nombre = txtNom.Text;
            objECli.apellido = txtApel.Text;
            objEAuto.patente = txtPat.Text;
            objEAuto.marca = txtMar.Text;
            objEAuto.modelo = txtMod.Text;
            objEAuto.años = int.Parse( txtAño.Text);
        }
        private void Filldgv()
        {
            dgvCliente.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegAll.lista("ClAu");
            if (ds.Tables[0].Rows.Count>0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvCliente.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
                }
            }
        }

        private void Clean()
        {
            txtApel.Clear();
            txtAño.Clear();
            txtDNI.Clear();
            txtMar.Clear();
            txtMod.Clear();
            txtNom.Clear();
            txtPat.Clear();
        }
    }
}
