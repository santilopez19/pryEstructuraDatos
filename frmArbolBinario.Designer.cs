namespace pryEstructuraDatos
{
    partial class frmArbolBinario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArbolBinario));
            this.btnVolver = new System.Windows.Forms.Button();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.optPostOrden = new System.Windows.Forms.RadioButton();
            this.optPreOrden = new System.Windows.Forms.RadioButton();
            this.optInOrdenDesc = new System.Windows.Forms.RadioButton();
            this.optInOrdenAsc = new System.Windows.Forms.RadioButton();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbElementoEliminado = new System.Windows.Forms.GroupBox();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
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
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.trvArbol = new System.Windows.Forms.TreeView();
            this.lstArbolBinario = new System.Windows.Forms.ListBox();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.gbElementoEliminado.SuspendLayout();
            this.gbNuevoElemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(19, 463);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 20;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.optPostOrden);
            this.gbListado.Controls.Add(this.optPreOrden);
            this.gbListado.Controls.Add(this.optInOrdenDesc);
            this.gbListado.Controls.Add(this.optInOrdenAsc);
            this.gbListado.Controls.Add(this.dgvLista);
            this.gbListado.Location = new System.Drawing.Point(19, 263);
            this.gbListado.Margin = new System.Windows.Forms.Padding(4);
            this.gbListado.Name = "gbListado";
            this.gbListado.Padding = new System.Windows.Forms.Padding(4);
            this.gbListado.Size = new System.Drawing.Size(889, 193);
            this.gbListado.TabIndex = 17;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado en una Lista y una Grilla";
            // 
            // optPostOrden
            // 
            this.optPostOrden.AutoSize = true;
            this.optPostOrden.Location = new System.Drawing.Point(8, 157);
            this.optPostOrden.Margin = new System.Windows.Forms.Padding(4);
            this.optPostOrden.Name = "optPostOrden";
            this.optPostOrden.Size = new System.Drawing.Size(96, 20);
            this.optPostOrden.TabIndex = 9;
            this.optPostOrden.TabStop = true;
            this.optPostOrden.Text = "Post-Orden";
            this.optPostOrden.UseVisualStyleBackColor = true;
            this.optPostOrden.CheckedChanged += new System.EventHandler(this.optPostOrden_CheckedChanged);
            // 
            // optPreOrden
            // 
            this.optPreOrden.AutoSize = true;
            this.optPreOrden.Location = new System.Drawing.Point(8, 116);
            this.optPreOrden.Margin = new System.Windows.Forms.Padding(4);
            this.optPreOrden.Name = "optPreOrden";
            this.optPreOrden.Size = new System.Drawing.Size(90, 20);
            this.optPreOrden.TabIndex = 8;
            this.optPreOrden.TabStop = true;
            this.optPreOrden.Text = "Pre-Orden";
            this.optPreOrden.UseVisualStyleBackColor = true;
            this.optPreOrden.CheckedChanged += new System.EventHandler(this.optPreOrden_CheckedChanged);
            // 
            // optInOrdenDesc
            // 
            this.optInOrdenDesc.AutoSize = true;
            this.optInOrdenDesc.Location = new System.Drawing.Point(8, 75);
            this.optInOrdenDesc.Margin = new System.Windows.Forms.Padding(4);
            this.optInOrdenDesc.Name = "optInOrdenDesc";
            this.optInOrdenDesc.Size = new System.Drawing.Size(163, 20);
            this.optInOrdenDesc.TabIndex = 7;
            this.optInOrdenDesc.TabStop = true;
            this.optInOrdenDesc.Text = "In-Orden Descendente";
            this.optInOrdenDesc.UseVisualStyleBackColor = true;
            this.optInOrdenDesc.CheckedChanged += new System.EventHandler(this.optInOrdenDesc_CheckedChanged);
            // 
            // optInOrdenAsc
            // 
            this.optInOrdenAsc.AutoSize = true;
            this.optInOrdenAsc.Location = new System.Drawing.Point(8, 35);
            this.optInOrdenAsc.Margin = new System.Windows.Forms.Padding(4);
            this.optInOrdenAsc.Name = "optInOrdenAsc";
            this.optInOrdenAsc.Size = new System.Drawing.Size(154, 20);
            this.optInOrdenAsc.TabIndex = 6;
            this.optInOrdenAsc.TabStop = true;
            this.optInOrdenAsc.Text = "In-Orden Ascendente";
            this.optInOrdenAsc.UseVisualStyleBackColor = true;
            this.optInOrdenAsc.CheckedChanged += new System.EventHandler(this.optInOrdenAsc_CheckedChanged);
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
            this.gbElementoEliminado.Controls.Add(this.cmbCodigo);
            this.gbElementoEliminado.Controls.Add(this.lblCodigoEliminado);
            this.gbElementoEliminado.Controls.Add(this.btnEliminar);
            this.gbElementoEliminado.Location = new System.Drawing.Point(623, 15);
            this.gbElementoEliminado.Margin = new System.Windows.Forms.Padding(4);
            this.gbElementoEliminado.Name = "gbElementoEliminado";
            this.gbElementoEliminado.Padding = new System.Windows.Forms.Padding(4);
            this.gbElementoEliminado.Size = new System.Drawing.Size(285, 133);
            this.gbElementoEliminado.TabIndex = 18;
            this.gbElementoEliminado.TabStop = false;
            this.gbElementoEliminado.Text = "Elemento Eliminado";
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(87, 34);
            this.cmbCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(176, 24);
            this.cmbCodigo.TabIndex = 11;
            this.cmbCodigo.SelectedIndexChanged += new System.EventHandler(this.cmbCodigo_SelectedIndexChanged);
            // 
            // lblCodigoEliminado
            // 
            this.lblCodigoEliminado.AutoSize = true;
            this.lblCodigoEliminado.Location = new System.Drawing.Point(25, 34);
            this.lblCodigoEliminado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoEliminado.Name = "lblCodigoEliminado";
            this.lblCodigoEliminado.Size = new System.Drawing.Size(54, 16);
            this.lblCodigoEliminado.TabIndex = 7;
            this.lblCodigoEliminado.Text = "Codigo:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(28, 71);
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
            this.gbNuevoElemento.Location = new System.Drawing.Point(315, 15);
            this.gbNuevoElemento.Margin = new System.Windows.Forms.Padding(4);
            this.gbNuevoElemento.Name = "gbNuevoElemento";
            this.gbNuevoElemento.Padding = new System.Windows.Forms.Padding(4);
            this.gbNuevoElemento.Size = new System.Drawing.Size(289, 242);
            this.gbNuevoElemento.TabIndex = 16;
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
            this.txtNombreNuevo.TextChanged += new System.EventHandler(this.txtNombreNuevo_TextChanged);
            // 
            // txtTramiteNuevo
            // 
            this.txtTramiteNuevo.Location = new System.Drawing.Point(93, 100);
            this.txtTramiteNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTramiteNuevo.Name = "txtTramiteNuevo";
            this.txtTramiteNuevo.Size = new System.Drawing.Size(165, 22);
            this.txtTramiteNuevo.TabIndex = 5;
            this.txtTramiteNuevo.TextChanged += new System.EventHandler(this.txtTramiteNuevo_TextChanged);
            // 
            // txtCodigoNuevo
            // 
            this.txtCodigoNuevo.Location = new System.Drawing.Point(93, 36);
            this.txtCodigoNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoNuevo.Name = "txtCodigoNuevo";
            this.txtCodigoNuevo.Size = new System.Drawing.Size(165, 22);
            this.txtCodigoNuevo.TabIndex = 4;
            this.txtCodigoNuevo.TextChanged += new System.EventHandler(this.txtCodigoNuevo_TextChanged);
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
            // btnEquilibrar
            // 
            this.btnEquilibrar.Location = new System.Drawing.Point(651, 178);
            this.btnEquilibrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(235, 46);
            this.btnEquilibrar.TabIndex = 12;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            this.btnEquilibrar.Click += new System.EventHandler(this.btnEquilibrar_Click);
            // 
            // trvArbol
            // 
            this.trvArbol.Location = new System.Drawing.Point(19, 15);
            this.trvArbol.Name = "trvArbol";
            this.trvArbol.Size = new System.Drawing.Size(289, 241);
            this.trvArbol.TabIndex = 21;
            // 
            // lstArbolBinario
            // 
            this.lstArbolBinario.FormattingEnabled = true;
            this.lstArbolBinario.ItemHeight = 16;
            this.lstArbolBinario.Location = new System.Drawing.Point(916, 20);
            this.lstArbolBinario.Margin = new System.Windows.Forms.Padding(4);
            this.lstArbolBinario.Name = "lstArbolBinario";
            this.lstArbolBinario.Size = new System.Drawing.Size(193, 436);
            this.lstArbolBinario.TabIndex = 22;
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1121, 492);
            this.Controls.Add(this.lstArbolBinario);
            this.Controls.Add(this.trvArbol);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.gbElementoEliminado);
            this.Controls.Add(this.gbNuevoElemento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmArbolBinario";
            this.gbListado.ResumeLayout(false);
            this.gbListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.gbElementoEliminado.ResumeLayout(false);
            this.gbElementoEliminado.PerformLayout();
            this.gbNuevoElemento.ResumeLayout(false);
            this.gbNuevoElemento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.GroupBox gbElementoEliminado;
        private System.Windows.Forms.ComboBox cmbCodigo;
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
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.TreeView trvArbol;
        private System.Windows.Forms.ListBox lstArbolBinario;
        private System.Windows.Forms.RadioButton optPostOrden;
        private System.Windows.Forms.RadioButton optPreOrden;
        private System.Windows.Forms.RadioButton optInOrdenDesc;
        private System.Windows.Forms.RadioButton optInOrdenAsc;
    }
}