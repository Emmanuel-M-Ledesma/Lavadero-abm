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
    public partial class frmEmpleado : Form
    {
        public NegEmpleado objNegEmpleado = new NegEmpleado();
        public Empleado objEEmpleado = new Empleado();
        public frmEmpleado()
        {
            InitializeComponent();
            dgvEmpleado.ColumnCount = 3;
            dgvEmpleado.Columns[0].HeaderText = "Dni";
            dgvEmpleado.Columns[1].HeaderText = "Nombre";
            dgvEmpleado.Columns[2].HeaderText = "Apeliido";


            Filldgv();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (!(txtNombre.Text==""||txtDni.Text==""||txtApellido.Text==""))
            {
                int nAdd = -1;
               
                TxtObj();
                nAdd = objNegEmpleado.abmEmpleado("alta", objEEmpleado);
                
                if (nAdd == -1 )
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



        private void Filldgv()
        {
            dgvEmpleado.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegEmpleado.listaEmpleado("listar");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvEmpleado.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
                }
            }
        }


        private void TxtObj()
        {
            objEEmpleado.dni = txtDni.Text;
            objEEmpleado.apellido = txtApellido.Text;
            objEEmpleado.nombre = txtNombre.Text;
            
        }

        private void Clean()
        {
            txtApellido.Clear();
            txtDni.Clear();
            txtNombre.Clear();
        }
    }
}
