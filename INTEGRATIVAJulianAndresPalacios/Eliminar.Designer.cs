namespace INTEGRATIVAJulianAndresPalacios
{
    partial class Eliminar
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
            this.dtpEliminarFecha = new System.Windows.Forms.DateTimePicker();
            this.txtEliRut = new System.Windows.Forms.TextBox();
            this.txtEliDiagnostico = new System.Windows.Forms.TextBox();
            this.lbEliRut = new System.Windows.Forms.Label();
            this.lbEliDiagnostico = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.dgvEliRegistros = new System.Windows.Forms.DataGridView();
            this.historialMedicoDataSet = new INTEGRATIVAJulianAndresPalacios.HistorialMedicoDataSet();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesTableAdapter = new INTEGRATIVAJulianAndresPalacios.HistorialMedicoDataSetTableAdapters.PacientesTableAdapter();
            this.registroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaExamenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialMedicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpEliminarFecha
            // 
            this.dtpEliminarFecha.CustomFormat = "yyyy-MM-dd";
            this.dtpEliminarFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEliminarFecha.Location = new System.Drawing.Point(572, 48);
            this.dtpEliminarFecha.Name = "dtpEliminarFecha";
            this.dtpEliminarFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpEliminarFecha.TabIndex = 0;
            this.dtpEliminarFecha.Visible = false;
            // 
            // txtEliRut
            // 
            this.txtEliRut.Location = new System.Drawing.Point(76, 48);
            this.txtEliRut.MaxLength = 13;
            this.txtEliRut.Name = "txtEliRut";
            this.txtEliRut.Size = new System.Drawing.Size(92, 20);
            this.txtEliRut.TabIndex = 1;
            // 
            // txtEliDiagnostico
            // 
            this.txtEliDiagnostico.Location = new System.Drawing.Point(444, 48);
            this.txtEliDiagnostico.MaxLength = 1;
            this.txtEliDiagnostico.Name = "txtEliDiagnostico";
            this.txtEliDiagnostico.Size = new System.Drawing.Size(54, 20);
            this.txtEliDiagnostico.TabIndex = 2;
            this.txtEliDiagnostico.Visible = false;
            // 
            // lbEliRut
            // 
            this.lbEliRut.AutoSize = true;
            this.lbEliRut.Location = new System.Drawing.Point(73, 32);
            this.lbEliRut.Name = "lbEliRut";
            this.lbEliRut.Size = new System.Drawing.Size(84, 13);
            this.lbEliRut.TabIndex = 3;
            this.lbEliRut.Text = "Ingrese Registro";
            // 
            // lbEliDiagnostico
            // 
            this.lbEliDiagnostico.AutoSize = true;
            this.lbEliDiagnostico.Location = new System.Drawing.Point(441, 32);
            this.lbEliDiagnostico.Name = "lbEliDiagnostico";
            this.lbEliDiagnostico.Size = new System.Drawing.Size(101, 13);
            this.lbEliDiagnostico.TabIndex = 4;
            this.lbEliDiagnostico.Text = "Ingrese Diagnostico";
            this.lbEliDiagnostico.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese Fecha";
            this.label3.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(269, 346);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.Location = new System.Drawing.Point(467, 346);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(75, 23);
            this.btnPrincipal.TabIndex = 7;
            this.btnPrincipal.Text = "Principal";
            this.btnPrincipal.UseVisualStyleBackColor = true;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // dgvEliRegistros
            // 
            this.dgvEliRegistros.AutoGenerateColumns = false;
            this.dgvEliRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registroDataGridViewTextBoxColumn,
            this.rutDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.diagnosticoDataGridViewTextBoxColumn,
            this.fechaExamenDataGridViewTextBoxColumn,
            this.examenDataGridViewTextBoxColumn});
            this.dgvEliRegistros.DataSource = this.pacientesBindingSource;
            this.dgvEliRegistros.Location = new System.Drawing.Point(12, 83);
            this.dgvEliRegistros.Name = "dgvEliRegistros";
            this.dgvEliRegistros.Size = new System.Drawing.Size(765, 218);
            this.dgvEliRegistros.TabIndex = 8;
            // 
            // historialMedicoDataSet
            // 
            this.historialMedicoDataSet.DataSetName = "HistorialMedicoDataSet";
            this.historialMedicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.historialMedicoDataSet;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
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
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 381);
            this.Controls.Add(this.dgvEliRegistros);
            this.Controls.Add(this.btnPrincipal);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbEliDiagnostico);
            this.Controls.Add(this.lbEliRut);
            this.Controls.Add(this.txtEliDiagnostico);
            this.Controls.Add(this.txtEliRut);
            this.Controls.Add(this.dtpEliminarFecha);
            this.Name = "Eliminar";
            this.Text = "Eliminar";
            this.Load += new System.EventHandler(this.Eliminar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialMedicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpEliminarFecha;
        private System.Windows.Forms.TextBox txtEliRut;
        private System.Windows.Forms.TextBox txtEliDiagnostico;
        private System.Windows.Forms.Label lbEliRut;
        private System.Windows.Forms.Label lbEliDiagnostico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.DataGridView dgvEliRegistros;
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
    }
}