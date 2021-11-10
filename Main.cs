using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lavadero
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            designmenu();
            AbrirFormHijo(new frmEstado());
            paMenu.Width = 48;
            btMainMenu.Width = 48;
            btMainMenu.Text = "";
        }




        #region Metodos

        private void designmenu()
        {
            paSubMenu.Visible = false;


        }
        private void showsubmenu()
        {
            if (paSubMenu.Visible == false)
            {
                paSubMenu.Visible = true;
            }
            else
            {
                paSubMenu.Visible = false;
            }
     
        }
        private Form Activo = null;
        private void AbrirFormHijo(Form ChildForm)
        {
            if (Activo != null)
            {
                Activo.Close();
            }
            Activo = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            paChild.Controls.Add(ChildForm);
            paChild.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();

        }

        private void Comportamiento()
        {
            //animacion();
            //paMenu.Width = 48;
            
            //btMainMenu.Width = 48;
            //btMainMenu.Text = "";
            //showsubmenu();
        }


        #endregion

        private void btMainMenu_Click(object sender, EventArgs e)
        {
            animacion();                    

        }
        private void animacion()
        {
            if (paMenu.Width == 145)
            {
                for (int i = 145; i > 45; i--)
                {
                    paMenu.Width = paMenu.Width - 20;
                    btMainMenu.Width = btMainMenu.Width - 20;
                    i -= 19;
                }
                btMainMenu.ImageAlign = ContentAlignment.MiddleCenter;
                showsubmenu();
                paMenu.Width = 48;
                btMainMenu.Width = 48;
                btMainMenu.Text = "";

            }
            else if (paMenu.Width == 48)
            {
                for (int i = 48; i < 145; i++)
                {
                    paMenu.Width = paMenu.Width + 20;
                    btMainMenu.Width = btMainMenu.Width + 20;
                    i += 19;
                }

                btMainMenu.Width = 145;
                btMainMenu.Text = "Menu";
                paMenu.Width = 145;
                showsubmenu();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmEstado());
            Comportamiento();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmEmpleado());
            Comportamiento();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmCliente());
            Comportamiento();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmAddAuto());
            Comportamiento();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmCarga());
            Comportamiento();
        }
    }
}
