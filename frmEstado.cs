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

        public frmEstado()
        {
            InitializeComponent();
            dgvEstado.ColumnCount = 10;
            dgvEstado.Columns[0].HeaderText = "Dni Dueño";
            dgvEstado.Columns[1].HeaderText = "Apellido ";
            dgvEstado.Columns[2].HeaderText = "Nombre ";
            dgvEstado.Columns[3].HeaderText = "Marca";
            dgvEstado.Columns[4].HeaderText = "Modelo";
            dgvEstado.Columns[5].HeaderText = "Año";
            dgvEstado.Columns[6].HeaderText = "Patente";
            dgvEstado.Columns[7].HeaderText = "Dia de Ingreso";
            dgvEstado.Columns[8].HeaderText = "Hora de Ingreso";
            dgvEstado.Columns[9].HeaderText = "Dni Empleado a cargo";

            Filldgv();
        }

        private void Filldgv()
        {
            dgvEstado.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegAll.lista("todos");
            if (ds.Tables[0].Rows.Count>0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvEstado.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), Convert.ToDateTime(dr[7]).ToShortDateString(), dr[8].ToString(), dr[9].ToString());
                }
                
            }
            else
            {
                MessageBox.Show("Error al cargar", "Errpr");
            }
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
    }
}
