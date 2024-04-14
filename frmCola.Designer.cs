namespace pryEstructuraDatos
{
    partial class frmCola
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.txtTramiteNuevo = new System.Windows.Forms.TextBox();
            this.txtCodigoNuevo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblNombreNuevo = new System.Windows.Forms.Label();
            this.lblTramiteNuevo = new System.Windows.Forms.Label();
            this.lblCodigoNuevo = new System.Windows.Forms.Label();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbElementoEliminado = new System.Windows.Forms.GroupBox();
            this.txtNombreEliminado = new System.Windows.Forms.TextBox();
            this.lblCodigoEliminado = new System.Windows.Forms.Label();
            this.txtTramiteEliminado = new System.Windows.Forms.TextBox();
            this.lblTraminteEliminado = new System.Windows.Forms.Label();
            this.txtCodigoEliminado = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbNuevoElemento.SuspendLayout();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.gbElementoEliminado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryEstructuraDatos.Properties.Resources.cola;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.gbNuevoElemento.Location = new System.Drawing.Point(311, 15);
            this.gbNuevoElemento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbNuevoElemento.Name = "gbNuevoElemento";
            this.gbNuevoElemento.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbNuevoElemento.Size = new System.Drawing.Size(289, 242);
            this.gbNuevoElemento.TabIndex = 1;
            this.gbNuevoElemento.TabStop = false;
            this.gbNuevoElemento.Text = "Nuevo Elemento";
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.Location = new System.Drawing.Point(93, 68);
            this.txtNombreNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.Size = new System.Drawing.Size(165, 22);
            this.txtNombreNuevo.TabIndex = 6;
            // 
            // txtTramiteNuevo
            // 
            this.txtTramiteNuevo.Location = new System.Drawing.Point(93, 100);
            this.txtTramiteNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTramiteNuevo.Name = "txtTramiteNuevo";
            this.txtTramiteNuevo.Size = new System.Drawing.Size(165, 22);
            this.txtTramiteNuevo.TabIndex = 5;
            // 
            // txtCodigoNuevo
            // 
            this.txtCodigoNuevo.Location = new System.Drawing.Point(93, 36);
            this.txtCodigoNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoNuevo.Name = "txtCodigoNuevo";
            this.txtCodigoNuevo.Size = new System.Drawing.Size(165, 22);
            this.txtCodigoNuevo.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(35, 160);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // gbListado
            // 
            this.gbListado.Controls.Add(this.lstCola);
            this.gbListado.Controls.Add(this.dgvLista);
            this.gbListado.Location = new System.Drawing.Point(17, 265);
            this.gbListado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbListado.Name = "gbListado";
            this.gbListado.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbListado.Size = new System.Drawing.Size(889, 193);
            this.gbListado.TabIndex = 2;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado en una Lista y una Grilla";
            this.gbListado.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.ItemHeight = 16;
            this.lstCola.Location = new System.Drawing.Point(8, 27);
            this.lstCola.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(311, 148);
            this.lstCola.TabIndex = 2;
            this.lstCola.SelectedIndexChanged += new System.EventHandler(this.lstCola_SelectedIndexChanged);
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Column1,
            this.Nombre});
            this.dgvLista.Location = new System.Drawing.Point(328, 23);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.gbElementoEliminado.Controls.Add(this.txtNombreEliminado);
            this.gbElementoEliminado.Controls.Add(this.lblCodigoEliminado);
            this.gbElementoEliminado.Controls.Add(this.txtTramiteEliminado);
            this.gbElementoEliminado.Controls.Add(this.lblTraminteEliminado);
            this.gbElementoEliminado.Controls.Add(this.txtCodigoEliminado);
            this.gbElementoEliminado.Controls.Add(this.lblNombre);
            this.gbElementoEliminado.Controls.Add(this.btnEliminar);
            this.gbElementoEliminado.Location = new System.Drawing.Point(620, 15);
            this.gbElementoEliminado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbElementoEliminado.Name = "gbElementoEliminado";
            this.gbElementoEliminado.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbElementoEliminado.Size = new System.Drawing.Size(285, 242);
            this.gbElementoEliminado.TabIndex = 2;
            this.gbElementoEliminado.TabStop = false;
            this.gbElementoEliminado.Text = "Elemento Eliminado";
            // 
            // txtNombreEliminado
            // 
            this.txtNombreEliminado.Location = new System.Drawing.Point(89, 66);
            this.txtNombreEliminado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreEliminado.Name = "txtNombreEliminado";
            this.txtNombreEliminado.Size = new System.Drawing.Size(165, 22);
            this.txtNombreEliminado.TabIndex = 13;
            // 
            // lblCodigoEliminado
            // 
            this.lblCodigoEliminado.AutoSize = true;
            this.lblCodigoEliminado.Location = new System.Drawing.Point(24, 44);
            this.lblCodigoEliminado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoEliminado.Name = "lblCodigoEliminado";
            this.lblCodigoEliminado.Size = new System.Drawing.Size(54, 16);
            this.lblCodigoEliminado.TabIndex = 7;
            this.lblCodigoEliminado.Text = "Codigo:";
            // 
            // txtTramiteEliminado
            // 
            this.txtTramiteEliminado.Location = new System.Drawing.Point(89, 100);
            this.txtTramiteEliminado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTramiteEliminado.Name = "txtTramiteEliminado";
            this.txtTramiteEliminado.Size = new System.Drawing.Size(165, 22);
            this.txtTramiteEliminado.TabIndex = 12;
            // 
            // lblTraminteEliminado
            // 
            this.lblTraminteEliminado.AutoSize = true;
            this.lblTraminteEliminado.Location = new System.Drawing.Point(24, 103);
            this.lblTraminteEliminado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTraminteEliminado.Name = "lblTraminteEliminado";
            this.lblTraminteEliminado.Size = new System.Drawing.Size(56, 16);
            this.lblTraminteEliminado.TabIndex = 8;
            this.lblTraminteEliminado.Text = "Tramite:";
            this.lblTraminteEliminado.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCodigoEliminado
            // 
            this.txtCodigoEliminado.Location = new System.Drawing.Point(89, 36);
            this.txtCodigoEliminado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoEliminado.Name = "txtCodigoEliminado";
            this.txtCodigoEliminado.Size = new System.Drawing.Size(165, 22);
            this.txtCodigoEliminado.TabIndex = 11;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 75);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(28, 164);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(235, 46);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(17, 465);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 496);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.gbElementoEliminado);
            this.Controls.Add(this.gbNuevoElemento);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Dinamica no Lineal - Cola";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbNuevoElemento.ResumeLayout(false);
            this.gbNuevoElemento.PerformLayout();
            this.gbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.gbElementoEliminado.ResumeLayout(false);
            this.gbElementoEliminado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbNuevoElemento;
        private System.Windows.Forms.TextBox txtNombreNuevo;
        private System.Windows.Forms.TextBox txtTramiteNuevo;
        private System.Windows.Forms.TextBox txtCodigoNuevo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNombreNuevo;
        private System.Windows.Forms.Label lblTramiteNuevo;
        private System.Windows.Forms.Label lblCodigoNuevo;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.GroupBox gbElementoEliminado;
        private System.Windows.Forms.TextBox txtNombreEliminado;
        private System.Windows.Forms.Label lblCodigoEliminado;
        private System.Windows.Forms.TextBox txtTramiteEliminado;
        private System.Windows.Forms.Label lblTraminteEliminado;
        private System.Windows.Forms.TextBox txtCodigoEliminado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.Button btnVolver;
    }
}