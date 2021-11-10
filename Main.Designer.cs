
namespace Lavadero
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.paChild = new System.Windows.Forms.Panel();
            this.paMenu = new System.Windows.Forms.Panel();
            this.btMainMenu = new System.Windows.Forms.Button();
            this.paSubMenu = new System.Windows.Forms.Panel();
            this.btAuto = new System.Windows.Forms.Button();
            this.btEmpleado = new System.Windows.Forms.Button();
            this.btCliente = new System.Windows.Forms.Button();
            this.btInicio = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.paChildForm = new System.Windows.Forms.Panel();
            this.paChild.SuspendLayout();
            this.paMenu.SuspendLayout();
            this.paSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // paChild
            // 
            this.paChild.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.paChild.Controls.Add(this.paMenu);
            this.paChild.Controls.Add(this.paChildForm);
            this.paChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paChild.Location = new System.Drawing.Point(0, 0);
            this.paChild.Name = "paChild";
            this.paChild.Size = new System.Drawing.Size(1111, 469);
            this.paChild.TabIndex = 0;
            // 
            // paMenu
            // 
            this.paMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.paMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paMenu.BackgroundImage")));
            this.paMenu.Controls.Add(this.btMainMenu);
            this.paMenu.Controls.Add(this.paSubMenu);
            this.paMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.paMenu.Location = new System.Drawing.Point(0, 0);
            this.paMenu.Name = "paMenu";
            this.paMenu.Size = new System.Drawing.Size(145, 469);
            this.paMenu.TabIndex = 0;
            // 
            // btMainMenu
            // 
            this.btMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.btMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btMainMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btMainMenu.FlatAppearance.BorderSize = 0;
            this.btMainMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btMainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMainMenu.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMainMenu.ForeColor = System.Drawing.Color.Black;
            this.btMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("btMainMenu.Image")));
            this.btMainMenu.Location = new System.Drawing.Point(0, 0);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(145, 40);
            this.btMainMenu.TabIndex = 1;
            this.btMainMenu.Text = "Menu";
            this.btMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btMainMenu.UseVisualStyleBackColor = false;
            this.btMainMenu.Click += new System.EventHandler(this.btMainMenu_Click);
            // 
            // paSubMenu
            // 
            this.paSubMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paSubMenu.BackgroundImage")));
            this.paSubMenu.Controls.Add(this.btAuto);
            this.paSubMenu.Controls.Add(this.btEmpleado);
            this.paSubMenu.Controls.Add(this.btCliente);
            this.paSubMenu.Controls.Add(this.btInicio);
            this.paSubMenu.Controls.Add(this.btNew);
            this.paSubMenu.Location = new System.Drawing.Point(0, 46);
            this.paSubMenu.Name = "paSubMenu";
            this.paSubMenu.Size = new System.Drawing.Size(145, 195);
            this.paSubMenu.TabIndex = 0;
            // 
            // btAuto
            // 
            this.btAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btAuto.BackColor = System.Drawing.Color.Transparent;
            this.btAuto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAuto.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btAuto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btAuto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAuto.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAuto.ForeColor = System.Drawing.Color.Black;
            this.btAuto.Image = ((System.Drawing.Image)(resources.GetObject("btAuto.Image")));
            this.btAuto.Location = new System.Drawing.Point(0, 149);
            this.btAuto.Name = "btAuto";
            this.btAuto.Size = new System.Drawing.Size(145, 33);
            this.btAuto.TabIndex = 5;
            this.btAuto.Text = "Autos";
            this.btAuto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAuto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAuto.UseVisualStyleBackColor = false;
            this.btAuto.Click += new System.EventHandler(this.button5_Click);
            // 
            // btEmpleado
            // 
            this.btEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEmpleado.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmpleado.ForeColor = System.Drawing.Color.Black;
            this.btEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btEmpleado.Image")));
            this.btEmpleado.Location = new System.Drawing.Point(0, 77);
            this.btEmpleado.Name = "btEmpleado";
            this.btEmpleado.Size = new System.Drawing.Size(145, 33);
            this.btEmpleado.TabIndex = 3;
            this.btEmpleado.Text = "Empleados";
            this.btEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEmpleado.UseVisualStyleBackColor = false;
            this.btEmpleado.Click += new System.EventHandler(this.button3_Click);
            // 
            // btCliente
            // 
            this.btCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btCliente.BackColor = System.Drawing.Color.Transparent;
            this.btCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCliente.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCliente.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCliente.ForeColor = System.Drawing.Color.Black;
            this.btCliente.Image = ((System.Drawing.Image)(resources.GetObject("btCliente.Image")));
            this.btCliente.Location = new System.Drawing.Point(0, 113);
            this.btCliente.Name = "btCliente";
            this.btCliente.Size = new System.Drawing.Size(145, 33);
            this.btCliente.TabIndex = 4;
            this.btCliente.Text = "Cliente";
            this.btCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCliente.UseVisualStyleBackColor = false;
            this.btCliente.Click += new System.EventHandler(this.button4_Click);
            // 
            // btInicio
            // 
            this.btInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btInicio.BackColor = System.Drawing.Color.Transparent;
            this.btInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btInicio.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInicio.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInicio.ForeColor = System.Drawing.Color.Black;
            this.btInicio.Image = ((System.Drawing.Image)(resources.GetObject("btInicio.Image")));
            this.btInicio.Location = new System.Drawing.Point(0, 5);
            this.btInicio.Name = "btInicio";
            this.btInicio.Size = new System.Drawing.Size(145, 33);
            this.btInicio.TabIndex = 2;
            this.btInicio.Text = "Inicio";
            this.btInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btInicio.UseVisualStyleBackColor = false;
            this.btInicio.Click += new System.EventHandler(this.button2_Click);
            // 
            // btNew
            // 
            this.btNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btNew.BackColor = System.Drawing.Color.Transparent;
            this.btNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btNew.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNew.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNew.ForeColor = System.Drawing.Color.Black;
            this.btNew.Image = ((System.Drawing.Image)(resources.GetObject("btNew.Image")));
            this.btNew.Location = new System.Drawing.Point(0, 41);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(145, 33);
            this.btNew.TabIndex = 6;
            this.btNew.Text = "Nueva Carga";
            this.btNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btNew.UseVisualStyleBackColor = false;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // paChildForm
            // 
            this.paChildForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paChildForm.BackgroundImage")));
            this.paChildForm.Location = new System.Drawing.Point(146, 0);
            this.paChildForm.Name = "paChildForm";
            this.paChildForm.Size = new System.Drawing.Size(965, 466);
            this.paChildForm.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 469);
            this.Controls.Add(this.paChild);
            this.MinimumSize = new System.Drawing.Size(1050, 500);
            this.Name = "Main";
            this.Text = "Form1";
            this.paChild.ResumeLayout(false);
            this.paMenu.ResumeLayout(false);
            this.paSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paChild;
        private System.Windows.Forms.Panel paMenu;
        private System.Windows.Forms.Panel paSubMenu;
        private System.Windows.Forms.Button btAuto;
        private System.Windows.Forms.Button btCliente;
        private System.Windows.Forms.Button btEmpleado;
        private System.Windows.Forms.Button btInicio;
        private System.Windows.Forms.Panel paChildForm;
        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.Button btNew;
    }
}

