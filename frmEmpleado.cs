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
            brDel.Enabled = false;
            btMod.Enabled = false;
            btAdd.Enabled = true;
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

        //Modificar
        private void btMod_Click(object sender, EventArgs e)
        {
            {
                if (txtDni.Text == "" ||
               txtApellido.Text == "" ||
               txtNombre.Text == "")
                {
                    MessageBox.Show("Los espacios no pueden estar en blanco", "ERROR");
                }
                else
                {

                    int nmod = -1;
                    TxtObj();


                    nmod = objNegEmpleado.abmEmpleado("Modificar", objEEmpleado);// invoco la capa negocio

                    if (nmod == -1)
                    {
                        MessageBox.Show("No se pudo modificar los datos del Empleado.");

                    }
                    else
                    {
                        MessageBox.Show("Los datos del Empleado fueron modificados con exito.");

                        Filldgv();
                        Clean();
                        btMod.Enabled = false;
                        brDel.Enabled = false;
                        btAdd.Enabled = true;
                        txtDni.Enabled = true;
                    }
                }

            }

        }

       

        //borrar
        private void brDel_Click(object sender, EventArgs e)
        {
            if (txtDni.Text == "" ||
           txtApellido.Text == "" ||
           txtNombre.Text == "")
            {
                MessageBox.Show("Los espacios no pueden estar en blanco", "ERROR");
            }
            else
            {

                int nmod = -1;
                TxtObj();


                nmod = objNegEmpleado.abmEmpleado("Borrar", objEEmpleado);// invoco la capa negocio

                if (nmod == -1)
                {
                    MessageBox.Show("No se pudo borrar los datos del Empleado.");

                }
                else
                {
                    MessageBox.Show("Los datos del Empleado fueron borrados con exito.");

                    Filldgv();
                    Clean();
                    btMod.Enabled = false;
                    brDel.Enabled = false;
                    btAdd.Enabled = true;
                    txtDni.Enabled = false;
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Clean();
            btMod.Enabled = false;
            brDel.Enabled = false;
            btAdd.Enabled = true;
            txtDni.Enabled = true;
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtDni, "Solo se admiten numeros");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtApellido, "No se admiten numeros");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) )
            {
                e.Handled = true;
                errorProvider1.SetError(txtNombre, "No se admiten numeros");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void dgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = dgvEmpleado.CurrentRow.Index;

            if (dgvEmpleado[1, posicion].Value == null)
            {
                MessageBox.Show("Las filas no pueden estar vacias", "ERROR");
            }

            else
            {
                txtDni.Text = dgvEmpleado[0, posicion].Value.ToString();
                txtNombre.Text = dgvEmpleado[1, posicion].Value.ToString();
                txtApellido.Text = dgvEmpleado[2, posicion].Value.ToString();
                brDel.Enabled = true;
                btMod.Enabled = true;
                btAdd.Enabled = false;
                txtDni.Enabled = false;

            }
        }
    }
}
    

