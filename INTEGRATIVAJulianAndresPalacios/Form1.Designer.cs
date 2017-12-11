namespace INTEGRATIVAJulianAndresPalacios
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.hISTORIALDEEXAMENESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBuscarDiagnostico = new System.Windows.Forms.ToolStripMenuItem();
            this.fRECUENCIADIAGNOSTICOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvPrpal = new System.Windows.Forms.DataGridView();
            this.registroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaExamenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historialMedicoDataSet = new INTEGRATIVAJulianAndresPalacios.HistorialMedicoDataSet();
            this.bUSCARToolStrip = new System.Windows.Forms.ToolStrip();
            this.rUTToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.txtMNBuscarRut = new System.Windows.Forms.ToolStripTextBox();
            this.btnBuscarRut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.pacientesTableAdapter = new INTEGRATIVAJulianAndresPalacios.HistorialMedicoDataSetTableAdapters.PacientesTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrpal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialMedicoDataSet)).BeginInit();
            this.bUSCARToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnAgregar,
            this.mnEliminar,
            this.mnModificar,
            this.mnBuscar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnAgregar
            // 
            this.mnAgregar.Name = "mnAgregar";
            this.mnAgregar.Size = new System.Drawing.Size(71, 20);
            this.mnAgregar.Text = "AGREGAR";
            this.mnAgregar.Click += new System.EventHandler(this.mnAgregar_Click);
            // 
            // mnEliminar
            // 
            this.mnEliminar.Name = "mnEliminar";
            this.mnEliminar.Size = new System.Drawing.Size(72, 20);
            this.mnEliminar.Text = "ELIMINAR";
            this.mnEliminar.Click += new System.EventHandler(this.mnEliminar_Click);
            // 
            // mnModificar
            // 
            this.mnModificar.Name = "mnModificar";
            this.mnModificar.Size = new System.Drawing.Size(82, 20);
            this.mnModificar.Text = "MODIFICAR";
            this.mnModificar.Click += new System.EventHandler(this.mnModificar_Click);
            // 
            // mnBuscar
            // 
            this.mnBuscar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hISTORIALDEEXAMENESToolStripMenuItem,
            this.mnBuscarDiagnostico,
            this.fRECUENCIADIAGNOSTICOSToolStripMenuItem});
            this.mnBuscar.Name = "mnBuscar";
            this.mnBuscar.Size = new System.Drawing.Size(89, 20);
            this.mnBuscar.Text = "BUSCAR POR";
            // 
            // hISTORIALDEEXAMENESToolStripMenuItem
            // 
            this.hISTORIALDEEXAMENESToolStripMenuItem.Name = "hISTORIALDEEXAMENESToolStripMenuItem";
            this.hISTORIALDEEXAMENESToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.hISTORIALDEEXAMENESToolStripMenuItem.Text = "HISTORIAL DE EXAMENES";
            this.hISTORIALDEEXAMENESToolStripMenuItem.Click += new System.EventHandler(this.hISTORIALDEEXAMENESToolStripMenuItem_Click);
            // 
            // mnBuscarDiagnostico
            // 
            this.mnBuscarDiagnostico.Name = "mnBuscarDiagnostico";
            this.mnBuscarDiagnostico.Size = new System.Drawing.Size(230, 22);
            this.mnBuscarDiagnostico.Text = "DIAGNOSTICOS";
            this.mnBuscarDiagnostico.Click += new System.EventHandler(this.mnBuscarDiagnostico_Click);
            // 
            // fRECUENCIADIAGNOSTICOSToolStripMenuItem
            // 
            this.fRECUENCIADIAGNOSTICOSToolStripMenuItem.Name = "fRECUENCIADIAGNOSTICOSToolStripMenuItem";
            this.fRECUENCIADIAGNOSTICOSToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.fRECUENCIADIAGNOSTICOSToolStripMenuItem.Text = "FRECUENCIA DIAGNOSTICOS";
            this.fRECUENCIADIAGNOSTICOSToolStripMenuItem.Click += new System.EventHandler(this.fRECUENCIADIAGNOSTICOSToolStripMenuItem_Click);
            // 
            // dgvPrpal
            // 
            this.dgvPrpal.AutoGenerateColumns = false;
            this.dgvPrpal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrpal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registroDataGridViewTextBoxColumn,
            this.rutDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.diagnosticoDataGridViewTextBoxColumn,
            this.fechaExamenDataGridViewTextBoxColumn,
            this.examenDataGridViewTextBoxColumn});
            this.dgvPrpal.DataSource = this.pacientesBindingSource;
            this.dgvPrpal.Location = new System.Drawing.Point(38, 67);
            this.dgvPrpal.Name = "dgvPrpal";
            this.dgvPrpal.Size = new System.Drawing.Size(771, 339);
            this.dgvPrpal.TabIndex = 1;
            // 
            // registroDataGridViewTextBoxColumn
            // 
            this.registroDataGridViewTextBoxColumn.DataPropertyName = "Registro";
            this.registroDataGridViewTextBoxColumn.HeaderText = "Registro";
            this.registroDataGridViewTextBoxColumn.Name = "registroDataGridViewTextBoxColumn";
            this.registroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rutDataGridViewTextBoxColumn
            // 
            this.rutDataGridViewTextBoxColumn.DataPropertyName = "Rut";
            this.rutDataGridViewTextBoxColumn.HeaderText = "Rut";
            this.rutDataGridViewTextBoxColumn.Name = "rutDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // diagnosticoDataGridViewTextBoxColumn
            // 
            this.diagnosticoDataGridViewTextBoxColumn.DataPropertyName = "Diagnostico";
            this.diagnosticoDataGridViewTextBoxColumn.HeaderText = "Diagnostico";
            this.diagnosticoDataGridViewTextBoxColumn.Name = "diagnosticoDataGridViewTextBoxColumn";
            // 
            // fechaExamenDataGridViewTextBoxColumn
            // 
            this.fechaExamenDataGridViewTextBoxColumn.DataPropertyName = "FechaExamen";
            this.fechaExamenDataGridViewTextBoxColumn.HeaderText = "FechaExamen";
            this.fechaExamenDataGridViewTextBoxColumn.Name = "fechaExamenDataGridViewTextBoxColumn";
            // 
            // examenDataGridViewTextBoxColumn
            // 
            this.examenDataGridViewTextBoxColumn.DataPropertyName = "Examen";
            this.examenDataGridViewTextBoxColumn.HeaderText = "Examen";
            this.examenDataGridViewTextBoxColumn.Name = "examenDataGridViewTextBoxColumn";
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.historialMedicoDataSet;
            // 
            // historialMedicoDataSet
            // 
            this.historialMedicoDataSet.DataSetName = "HistorialMedicoDataSet";
            this.historialMedicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bUSCARToolStrip
            // 
            this.bUSCARToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rUTToolStripLabel,
            this.txtMNBuscarRut,
            this.btnBuscarRut,
            this.toolStripSeparator1,
            this.btnActualizar});
            this.bUSCARToolStrip.Location = new System.Drawing.Point(0, 24);
            this.bUSCARToolStrip.Name = "bUSCARToolStrip";
            this.bUSCARToolStrip.Size = new System.Drawing.Size(900, 25);
            this.bUSCARToolStrip.TabIndex = 2;
            this.bUSCARToolStrip.Text = "bUSCARToolStrip";
            // 
            // rUTToolStripLabel
            // 
            this.rUTToolStripLabel.Name = "rUTToolStripLabel";
            this.rUTToolStripLabel.Size = new System.Drawing.Size(32, 22);
            this.rUTToolStripLabel.Text = "RUT:";
            // 
            // txtMNBuscarRut
            // 
            this.txtMNBuscarRut.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMNBuscarRut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMNBuscarRut.Name = "txtMNBuscarRut";
            this.txtMNBuscarRut.Size = new System.Drawing.Size(100, 25);
            // 
            // btnBuscarRut
            // 
            this.btnBuscarRut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBuscarRut.Name = "btnBuscarRut";
            this.btnBuscarRut.Size = new System.Drawing.Size(55, 22);
            this.btnBuscarRut.Text = "BUSCAR";
            this.btnBuscarRut.Click += new System.EventHandler(this.btnBuscarRut_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnActualizar
            // 
            this.btnActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(81, 22);
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 506);
            this.Controls.Add(this.bUSCARToolStrip);
            this.Controls.Add(this.dgvPrpal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrpal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialMedicoDataSet)).EndInit();
            this.bUSCARToolStrip.ResumeLayout(false);
            this.bUSCARToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnBuscar;
        private System.Windows.Forms.ToolStripMenuItem mnAgregar;
        private System.Windows.Forms.ToolStripMenuItem mnEliminar;
        private System.Windows.Forms.ToolStripMenuItem mnModificar;
        private System.Windows.Forms.ToolStripMenuItem hISTORIALDEEXAMENESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnBuscarDiagnostico;
        private System.Windows.Forms.ToolStripMenuItem fRECUENCIADIAGNOSTICOSToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvPrpal;
        private HistorialMedicoDataSet historialMedicoDataSet;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private HistorialMedicoDataSetTableAdapters.PacientesTableAdapter pacientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosticoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaExamenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examenDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip bUSCARToolStrip;
        private System.Windows.Forms.ToolStripLabel rUTToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox txtMNBuscarRut;
        private System.Windows.Forms.ToolStripButton btnBuscarRut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnActualizar;
    }
}

