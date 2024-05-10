namespace pryEstructuraDatos
{
    partial class frmEstucturaListaSimple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstucturaListaSimple));
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbElementoEliminado = new System.Windows.Forms.GroupBox();
            this.cmbLista = new System.Windows.Forms.ComboBox();
            this.lblCodigoEliminado = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.txtTramiteNuevo = new System.Windows.Forms.TextBox();
            this.txtCodigoNuevo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblNombreNuevo = new System.Windows.Forms.Label();
            this.lblTramiteNuevo = new System.Windows.Forms.Label();
            this.lblCodigoNuevo = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.gbElementoEliminado.SuspendLayout();
            this.gbNuevoElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.lstLista);
            this.gbListado.Controls.Add(this.dgvLista);
            this.gbListado.Location = new System.Drawing.Point(12, 263);
            this.gbListado.Margin = new System.Windows.Forms.Padding(4);
            this.gbListado.Name = "gbListado";
            this.gbListado.Padding = new System.Windows.Forms.Padding(4);
            this.gbListado.Size = new System.Drawing.Size(889, 193);
            this.gbListado.TabIndex = 5;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado en una Lista y una Grilla";
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.ItemHeight = 16;
            this.lstLista.Location = new System.Drawing.Point(8, 23);
            this.lstLista.Margin = new System.Windows.Forms.Padding(4);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(311, 164);
            this.lstLista.TabIndex = 3;
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Column1,
            this.Nombre});
            this.dgvLista.Location = new System.Drawing.Point(328, 23);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.Size = new System.Drawing.Size(553, 162);
            this.dgvLista.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Tramite";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // gbElementoEliminado
            // 
            this.gbElementoEliminado.Controls.Add(this.cmbLista);
            this.gbElementoEliminado.Controls.Add(this.lblCodigoEliminado);
            this.gbElementoEliminado.Controls.Add(this.btnEliminar);
            this.gbElementoEliminado.Location = new System.Drawing.Point(615, 14);
            this.gbElementoEliminado.Margin = new System.Windows.Forms.Padding(4);
            this.gbElementoEliminado.Name = "gbElementoEliminado";
            this.gbElementoEliminado.Padding = new System.Windows.Forms.Padding(4);
            this.gbElementoEliminado.Size = new System.Drawing.Size(285, 242);
            this.gbElementoEliminado.TabIndex = 6;
            this.gbElementoEliminado.TabStop = false;
            this.gbElementoEliminado.Text = "Elemento Eliminado";
            // 
            // cmbLista
            // 
            this.cmbLista.FormattingEnabled = true;
            this.cmbLista.Location = new System.Drawing.Point(87, 121);
            this.cmbLista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLista.Name = "cmbLista";
            this.cmbLista.Size = new System.Drawing.Size(176, 24);
            this.cmbLista.TabIndex = 11;
            this.cmbLista.SelectedIndexChanged += new System.EventHandler(this.cmbLista_SelectedIndexChanged);
            // 
            // lblCodigoEliminado
            // 
            this.lblCodigoEliminado.AutoSize = true;
            this.lblCodigoEliminado.Location = new System.Drawing.Point(25, 121);
            this.lblCodigoEliminado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoEliminado.Name = "lblCodigoEliminado";
            this.lblCodigoEliminado.Size = new System.Drawing.Size(54, 16);
            this.lblCodigoEliminado.TabIndex = 7;
            this.lblCodigoEliminado.Text = "Codigo:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(28, 164);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(235, 46);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gbNuevoElemento
            // 
            this.gbNuevoElemento.Controls.Add(this.txtNombreNuevo);
            this.gbNuevoElemento.Controls.Add(this.txtTramiteNuevo);
            this.gbNuevoElemento.Controls.Add(this.txtCodigoNuevo);
            this.gbNuevoElemento.Controls.Add(this.btnAgregar);
            this.gbNuevoElemento.Controls.Add(this.lblNombreNuevo);
            this.gbNuevoElemento.Controls.Add(this.lblTramiteNuevo);
            this.gbNuevoElemento.Controls.Add(this.lblCodigoNuevo);
            this.gbNuevoElemento.Location = new System.Drawing.Point(307, 14);
            this.gbNuevoElemento.Margin = new System.Windows.Forms.Padding(4);
            this.gbNuevoElemento.Name = "gbNuevoElemento";
            this.gbNuevoElemento.Padding = new System.Windows.Forms.Padding(4);
            this.gbNuevoElemento.Size = new System.Drawing.Size(289, 242);
            this.gbNuevoElemento.TabIndex = 4;
            this.gbNuevoElemento.TabStop = false;
            this.gbNuevoElemento.Text = "Nuevo Elemento";
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.Location = new System.Drawing.Point(93, 68);
            this.txtNombreNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.Size = new System.Drawing.Size(165, 22);
            this.txtNombreNuevo.TabIndex = 6;
            // 
            // txtTramiteNuevo
            // 
            this.txtTramiteNuevo.Location = new System.Drawing.Point(93, 100);
            this.txtTramiteNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTramiteNuevo.Name = "txtTramiteNuevo";
            this.txtTramiteNuevo.Size = new System.Drawing.Size(165, 22);
            this.txtTramiteNuevo.TabIndex = 5;
            // 
            // txtCodigoNuevo
            // 
            this.txtCodigoNuevo.Location = new System.Drawing.Point(93, 36);
            this.txtCodigoNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoNuevo.Name = "txtCodigoNuevo";
            this.txtCodigoNuevo.Size = new System.Drawing.Size(165, 22);
            this.txtCodigoNuevo.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(35, 160);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(235, 49);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblNombreNuevo
            // 
            this.lblNombreNuevo.AutoSize = true;
            this.lblNombreNuevo.Location = new System.Drawing.Point(28, 71);
            this.lblNombreNuevo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreNuevo.Name = "lblNombreNuevo";
            this.lblNombreNuevo.Size = new System.Drawing.Size(59, 16);
            this.lblNombreNuevo.TabIndex = 2;
            this.lblNombreNuevo.Text = "Nombre:";
            // 
            // lblTramiteNuevo
            // 
            this.lblTramiteNuevo.AutoSize = true;
            this.lblTramiteNuevo.Location = new System.Drawing.Point(28, 103);
            this.lblTramiteNuevo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramiteNuevo.Name = "lblTramiteNuevo";
            this.lblTramiteNuevo.Size = new System.Drawing.Size(56, 16);
            this.lblTramiteNuevo.TabIndex = 1;
            this.lblTramiteNuevo.Text = "Tramite:";
            // 
            // lblCodigoNuevo
            // 
            this.lblCodigoNuevo.AutoSize = true;
            this.lblCodigoNuevo.Location = new System.Drawing.Point(28, 39);
            this.lblCodigoNuevo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoNuevo.Name = "lblCodigoNuevo";
            this.lblCodigoNuevo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigoNuevo.TabIndex = 0;
            this.lblCodigoNuevo.Text = "Codigo:";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(20, 466);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryEstructuraDatos.Properties.Resources.lista_simple;
            this.pictureBox1.Location = new System.Drawing.Point(11, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmEstucturaListaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(919, 501);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.gbElementoEliminado);
            this.Controls.Add(this.gbNuevoElemento);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEstucturaListaSimple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Lista Simple";
            this.Load += new System.EventHandler(this.frmEstucturaListaSimple_Load);
            this.gbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.gbElementoEliminado.ResumeLayout(false);
            this.gbElementoEliminado.PerformLayout();
            this.gbNuevoElemento.ResumeLayout(false);
            this.gbNuevoElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.GroupBox gbElementoEliminado;
        private System.Windows.Forms.Label lblCodigoEliminado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbNuevoElemento;
        private System.Windows.Forms.TextBox txtNombreNuevo;
        private System.Windows.Forms.TextBox txtTramiteNuevo;
        private System.Windows.Forms.TextBox txtCodigoNuevo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNombreNuevo;
        private System.Windows.Forms.Label lblTramiteNuevo;
        private System.Windows.Forms.Label lblCodigoNuevo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbLista;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.Button btnVolver;
    }
}