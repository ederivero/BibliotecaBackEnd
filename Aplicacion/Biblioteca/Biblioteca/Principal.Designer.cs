namespace Biblioteca
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.prestar = new System.Windows.Forms.TabPage();
            this.panelLibro = new System.Windows.Forms.Panel();
            this.btnPrestar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscarLi = new System.Windows.Forms.Button();
            this.txtCodLi = new System.Windows.Forms.TextBox();
            this.txtCatLi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAutLi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNomLi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.devolver = new System.Windows.Forms.TabPage();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.listaLibros = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.btnBuscarCli = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomCli = new System.Windows.Forms.TextBox();
            this.txtApeCli = new System.Windows.Forms.TextBox();
            this.txtDirCli = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.dGVCliente = new System.Windows.Forms.DataGridView();
            this.btnCrear = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.prestar.SuspendLayout();
            this.panelLibro.SuspendLayout();
            this.devolver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(66, 13);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(15, 13);
            this.lbUser.TabIndex = 1;
            this.lbUser.Text = "la";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.prestar);
            this.tabControl1.Controls.Add(this.devolver);
            this.tabControl1.Location = new System.Drawing.Point(369, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(306, 177);
            this.tabControl1.TabIndex = 3;
            // 
            // prestar
            // 
            this.prestar.Controls.Add(this.panelLibro);
            this.prestar.Location = new System.Drawing.Point(4, 22);
            this.prestar.Name = "prestar";
            this.prestar.Padding = new System.Windows.Forms.Padding(3);
            this.prestar.Size = new System.Drawing.Size(298, 151);
            this.prestar.TabIndex = 0;
            this.prestar.Text = "Prestar Libro";
            this.prestar.UseVisualStyleBackColor = true;
            // 
            // panelLibro
            // 
            this.panelLibro.Controls.Add(this.btnPrestar);
            this.panelLibro.Controls.Add(this.label8);
            this.panelLibro.Controls.Add(this.btnBuscarLi);
            this.panelLibro.Controls.Add(this.txtCodLi);
            this.panelLibro.Controls.Add(this.txtCatLi);
            this.panelLibro.Controls.Add(this.label9);
            this.panelLibro.Controls.Add(this.txtAutLi);
            this.panelLibro.Controls.Add(this.label10);
            this.panelLibro.Controls.Add(this.txtNomLi);
            this.panelLibro.Controls.Add(this.label11);
            this.panelLibro.Location = new System.Drawing.Point(6, 6);
            this.panelLibro.Name = "panelLibro";
            this.panelLibro.Size = new System.Drawing.Size(285, 139);
            this.panelLibro.TabIndex = 24;
            this.panelLibro.Visible = false;
            // 
            // btnPrestar
            // 
            this.btnPrestar.Location = new System.Drawing.Point(189, 109);
            this.btnPrestar.Name = "btnPrestar";
            this.btnPrestar.Size = new System.Drawing.Size(75, 23);
            this.btnPrestar.TabIndex = 6;
            this.btnPrestar.Text = "Prestar Libro";
            this.btnPrestar.UseVisualStyleBackColor = true;
            this.btnPrestar.Visible = false;
            this.btnPrestar.Click += new System.EventHandler(this.btnPrestar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Codigo Libro";
            // 
            // btnBuscarLi
            // 
            this.btnBuscarLi.Location = new System.Drawing.Point(189, 1);
            this.btnBuscarLi.Name = "btnBuscarLi";
            this.btnBuscarLi.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarLi.TabIndex = 5;
            this.btnBuscarLi.Text = "Buscar Libro";
            this.btnBuscarLi.UseVisualStyleBackColor = true;
            this.btnBuscarLi.Click += new System.EventHandler(this.btnBuscarLi_Click);
            // 
            // txtCodLi
            // 
            this.txtCodLi.Location = new System.Drawing.Point(83, 4);
            this.txtCodLi.Name = "txtCodLi";
            this.txtCodLi.Size = new System.Drawing.Size(100, 20);
            this.txtCodLi.TabIndex = 4;
            // 
            // txtCatLi
            // 
            this.txtCatLi.Location = new System.Drawing.Point(105, 83);
            this.txtCatLi.Name = "txtCatLi";
            this.txtCatLi.ReadOnly = true;
            this.txtCatLi.Size = new System.Drawing.Size(100, 20);
            this.txtCatLi.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nombre";
            // 
            // txtAutLi
            // 
            this.txtAutLi.Location = new System.Drawing.Point(105, 57);
            this.txtAutLi.Name = "txtAutLi";
            this.txtAutLi.ReadOnly = true;
            this.txtAutLi.Size = new System.Drawing.Size(100, 20);
            this.txtAutLi.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Autor";
            // 
            // txtNomLi
            // 
            this.txtNomLi.Location = new System.Drawing.Point(105, 31);
            this.txtNomLi.Name = "txtNomLi";
            this.txtNomLi.ReadOnly = true;
            this.txtNomLi.Size = new System.Drawing.Size(100, 20);
            this.txtNomLi.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Categoria";
            // 
            // devolver
            // 
            this.devolver.Controls.Add(this.btnDevolver);
            this.devolver.Controls.Add(this.listaLibros);
            this.devolver.Location = new System.Drawing.Point(4, 22);
            this.devolver.Name = "devolver";
            this.devolver.Size = new System.Drawing.Size(298, 151);
            this.devolver.TabIndex = 2;
            this.devolver.Text = "Devolver Libro";
            this.devolver.UseVisualStyleBackColor = true;
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(3, 125);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(292, 23);
            this.btnDevolver.TabIndex = 11;
            this.btnDevolver.Text = "Devolver Libro";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // listaLibros
            // 
            this.listaLibros.FormattingEnabled = true;
            this.listaLibros.Location = new System.Drawing.Point(3, 3);
            this.listaLibros.Name = "listaLibros";
            this.listaLibros.Size = new System.Drawing.Size(292, 121);
            this.listaLibros.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo Cliente";
            // 
            // txtCodCli
            // 
            this.txtCodCli.Location = new System.Drawing.Point(94, 63);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(100, 20);
            this.txtCodCli.TabIndex = 1;
            // 
            // btnBuscarCli
            // 
            this.btnBuscarCli.Location = new System.Drawing.Point(200, 61);
            this.btnBuscarCli.Name = "btnBuscarCli";
            this.btnBuscarCli.Size = new System.Drawing.Size(54, 23);
            this.btnBuscarCli.TabIndex = 2;
            this.btnBuscarCli.Text = "Buscar";
            this.btnBuscarCli.UseVisualStyleBackColor = true;
            this.btnBuscarCli.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Direccion";
            // 
            // txtNomCli
            // 
            this.txtNomCli.Location = new System.Drawing.Point(74, 117);
            this.txtNomCli.Name = "txtNomCli";
            this.txtNomCli.ReadOnly = true;
            this.txtNomCli.Size = new System.Drawing.Size(180, 20);
            this.txtNomCli.TabIndex = 13;
            // 
            // txtApeCli
            // 
            this.txtApeCli.Location = new System.Drawing.Point(74, 143);
            this.txtApeCli.Name = "txtApeCli";
            this.txtApeCli.ReadOnly = true;
            this.txtApeCli.Size = new System.Drawing.Size(180, 20);
            this.txtApeCli.TabIndex = 14;
            // 
            // txtDirCli
            // 
            this.txtDirCli.Location = new System.Drawing.Point(74, 169);
            this.txtDirCli.Name = "txtDirCli";
            this.txtDirCli.ReadOnly = true;
            this.txtDirCli.Size = new System.Drawing.Size(246, 20);
            this.txtDirCli.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(74, 91);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.ReadOnly = true;
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 12;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Prestamos";
            // 
            // dGVCliente
            // 
            this.dGVCliente.AllowUserToAddRows = false;
            this.dGVCliente.AllowUserToDeleteRows = false;
            this.dGVCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCliente.Location = new System.Drawing.Point(19, 227);
            this.dGVCliente.Name = "dGVCliente";
            this.dGVCliente.ReadOnly = true;
            this.dGVCliente.RowHeadersWidth = 10;
            this.dGVCliente.Size = new System.Drawing.Size(656, 118);
            this.dGVCliente.TabIndex = 13;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(260, 61);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(60, 23);
            this.btnCrear.TabIndex = 16;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 397);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dGVCliente);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarCli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDirCli);
            this.Controls.Add(this.txtCodCli);
            this.Controls.Add(this.txtApeCli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomCli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.prestar.ResumeLayout(false);
            this.panelLibro.ResumeLayout(false);
            this.panelLibro.PerformLayout();
            this.devolver.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage prestar;
        private System.Windows.Forms.TabPage devolver;
        private System.Windows.Forms.TextBox txtDirCli;
        private System.Windows.Forms.TextBox txtApeCli;
        private System.Windows.Forms.TextBox txtNomCli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarCli;
        private System.Windows.Forms.TextBox txtCodCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCatLi;
        private System.Windows.Forms.TextBox txtAutLi;
        private System.Windows.Forms.TextBox txtNomLi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBuscarLi;
        private System.Windows.Forms.TextBox txtCodLi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelLibro;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnPrestar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dGVCliente;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.ListBox listaLibros;
        private System.Windows.Forms.Button btnCrear;
    }
}