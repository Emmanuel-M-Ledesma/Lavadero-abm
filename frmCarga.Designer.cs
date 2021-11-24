
namespace Lavadero
{
    partial class frmCarga
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarga));
            this.panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btDel = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.dtpDia = new System.Windows.Forms.DateTimePicker();
            this.cbAuto = new System.Windows.Forms.ComboBox();
            this.cbEmpleado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCarga = new System.Windows.Forms.DataGridView();
            this.panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarga)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.Controls.Add(this.panel2);
            this.panel.Controls.Add(this.panel1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(945, 466);
            this.panel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.btDel);
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Controls.Add(this.txtHora);
            this.panel2.Controls.Add(this.dtpDia);
            this.panel2.Controls.Add(this.cbAuto);
            this.panel2.Controls.Add(this.cbEmpleado);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 374);
            this.panel2.TabIndex = 2;
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(205, 240);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 23);
            this.btDel.TabIndex = 9;
            this.btDel.Text = "Actualizar";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(124, 240);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "Cargar";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(124, 176);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(210, 20);
            this.txtHora.TabIndex = 7;
            // 
            // dtpDia
            // 
            this.dtpDia.Location = new System.Drawing.Point(124, 133);
            this.dtpDia.Name = "dtpDia";
            this.dtpDia.Size = new System.Drawing.Size(210, 20);
            this.dtpDia.TabIndex = 6;
            // 
            // cbAuto
            // 
            this.cbAuto.FormattingEnabled = true;
            this.cbAuto.Location = new System.Drawing.Point(124, 95);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Size = new System.Drawing.Size(210, 21);
            this.cbAuto.TabIndex = 5;
            // 
            // cbEmpleado
            // 
            this.cbEmpleado.FormattingEnabled = true;
            this.cbEmpleado.Location = new System.Drawing.Point(124, 52);
            this.cbEmpleado.Name = "cbEmpleado";
            this.cbEmpleado.Size = new System.Drawing.Size(210, 21);
            this.cbEmpleado.TabIndex = 4;

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Auto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleado";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvCarga);
            this.panel1.Location = new System.Drawing.Point(437, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 442);
            this.panel1.TabIndex = 1;
            // 
            // dgvCarga
            // 
            this.dgvCarga.AllowUserToAddRows = false;
            this.dgvCarga.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCarga.Location = new System.Drawing.Point(0, 0);
            this.dgvCarga.Name = "dgvCarga";
            this.dgvCarga.Size = new System.Drawing.Size(496, 442);
            this.dgvCarga.TabIndex = 0;
            // 
            // frmCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 466);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCarga";
            this.Text = "Form1";
            this.panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.DateTimePicker dtpDia;
        private System.Windows.Forms.ComboBox cbAuto;
        private System.Windows.Forms.ComboBox cbEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCarga;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btAdd;
    }
}