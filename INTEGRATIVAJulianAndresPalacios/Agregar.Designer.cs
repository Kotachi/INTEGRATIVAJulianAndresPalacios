namespace INTEGRATIVAJulianAndresPalacios
{
    partial class Agregar
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
            this.txtIngRut = new System.Windows.Forms.TextBox();
            this.txtIngNombre = new System.Windows.Forms.TextBox();
            this.txtIngMail = new System.Windows.Forms.TextBox();
            this.txtIngExamen = new System.Windows.Forms.TextBox();
            this.lbIngRut = new System.Windows.Forms.Label();
            this.lbIngNombre = new System.Windows.Forms.Label();
            this.lbIngMail = new System.Windows.Forms.Label();
            this.lbIngDiagnostico = new System.Windows.Forms.Label();
            this.dtpIngFecha = new System.Windows.Forms.DateTimePicker();
            this.lbIngFecha = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.dgvAgregarPacientes = new System.Windows.Forms.DataGridView();
            this.dgvAgregarDiagn = new System.Windows.Forms.DataGridView();
            this.cbbIngDiagnostico = new System.Windows.Forms.ComboBox();
            this.lbIngExamen = new System.Windows.Forms.Label();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historialMedicoDataSet = new INTEGRATIVAJulianAndresPalacios.HistorialMedicoDataSet();
            this.registroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaExamenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesTableAdapter = new INTEGRATIVAJulianAndresPalacios.HistorialMedicoDataSetTableAdapters.PacientesTableAdapter();
            this.diagnosticoTableAdapter = new INTEGRATIVAJulianAndresPalacios.HistorialMedicoDataSetTableAdapters.DiagnosticoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarDiagn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialMedicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIngRut
            // 
            this.txtIngRut.Location = new System.Drawing.Point(34, 60);
            this.txtIngRut.Name = "txtIngRut";
            this.txtIngRut.Size = new System.Drawing.Size(100, 20);
            this.txtIngRut.TabIndex = 0;
            // 
            // txtIngNombre
            // 
            this.txtIngNombre.Location = new System.Drawing.Point(175, 60);
            this.txtIngNombre.Name = "txtIngNombre";
            this.txtIngNombre.Size = new System.Drawing.Size(100, 20);
            this.txtIngNombre.TabIndex = 1;
            // 
            // txtIngMail
            // 
            this.txtIngMail.Location = new System.Drawing.Point(322, 60);
            this.txtIngMail.Name = "txtIngMail";
            this.txtIngMail.Size = new System.Drawing.Size(100, 20);
            this.txtIngMail.TabIndex = 2;
            // 
            // txtIngExamen
            // 
            this.txtIngExamen.Location = new System.Drawing.Point(470, 60);
            this.txtIngExamen.MaxLength = 30000;
            this.txtIngExamen.Name = "txtIngExamen";
            this.txtIngExamen.Size = new System.Drawing.Size(165, 20);
            this.txtIngExamen.TabIndex = 3;
            // 
            // lbIngRut
            // 
            this.lbIngRut.AutoSize = true;
            this.lbIngRut.Location = new System.Drawing.Point(31, 44);
            this.lbIngRut.Name = "lbIngRut";
            this.lbIngRut.Size = new System.Drawing.Size(68, 13);
            this.lbIngRut.TabIndex = 4;
            this.lbIngRut.Text = "Ingreso RUT";
            // 
            // lbIngNombre
            // 
            this.lbIngNombre.AutoSize = true;
            this.lbIngNombre.Location = new System.Drawing.Point(172, 44);
            this.lbIngNombre.Name = "lbIngNombre";
            this.lbIngNombre.Size = new System.Drawing.Size(82, 13);
            this.lbIngNombre.TabIndex = 5;
            this.lbIngNombre.Text = "Ingrese Nombre";
            // 
            // lbIngMail
            // 
            this.lbIngMail.AutoSize = true;
            this.lbIngMail.Location = new System.Drawing.Point(319, 44);
            this.lbIngMail.Name = "lbIngMail";
            this.lbIngMail.Size = new System.Drawing.Size(64, 13);
            this.lbIngMail.TabIndex = 6;
            this.lbIngMail.Text = "Ingrese Mail";
            // 
            // lbIngDiagnostico
            // 
            this.lbIngDiagnostico.AutoSize = true;
            this.lbIngDiagnostico.Location = new System.Drawing.Point(697, 45);
            this.lbIngDiagnostico.Name = "lbIngDiagnostico";
            this.lbIngDiagnostico.Size = new System.Drawing.Size(101, 13);
            this.lbIngDiagnostico.TabIndex = 7;
            this.lbIngDiagnostico.Text = "Ingrese Diagnostico";
            // 
            // dtpIngFecha
            // 
            this.dtpIngFecha.CustomFormat = "yyyy-MM-dd";
            this.dtpIngFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIngFecha.Location = new System.Drawing.Point(855, 60);
            this.dtpIngFecha.Name = "dtpIngFecha";
            this.dtpIngFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpIngFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpIngFecha.TabIndex = 8;
            // 
            // lbIngFecha
            // 
            this.lbIngFecha.AutoSize = true;
            this.lbIngFecha.Location = new System.Drawing.Point(852, 44);
            this.lbIngFecha.Name = "lbIngFecha";
            this.lbIngFecha.Size = new System.Drawing.Size(116, 13);
            this.lbIngFecha.TabIndex = 9;
            this.lbIngFecha.Text = "Ingrese Fecha Examen";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(347, 122);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.Location = new System.Drawing.Point(589, 122);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(75, 23);
            this.btnPrincipal.TabIndex = 11;
            this.btnPrincipal.Text = "Principal";
            this.btnPrincipal.UseVisualStyleBackColor = true;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // dgvAgregarPacientes
            // 
            this.dgvAgregarPacientes.AutoGenerateColumns = false;
            this.dgvAgregarPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAgregarPacientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAgregarPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregarPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registroDataGridViewTextBoxColumn,
            this.rutDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.diagnosticoDataGridViewTextBoxColumn,
            this.fechaExamenDataGridViewTextBoxColumn});
            this.dgvAgregarPacientes.DataSource = this.pacientesBindingSource;
            this.dgvAgregarPacientes.Location = new System.Drawing.Point(12, 196);
            this.dgvAgregarPacientes.Name = "dgvAgregarPacientes";
            this.dgvAgregarPacientes.Size = new System.Drawing.Size(591, 240);
            this.dgvAgregarPacientes.TabIndex = 12;
            // 
            // dgvAgregarDiagn
            // 
            this.dgvAgregarDiagn.AutoGenerateColumns = false;
            this.dgvAgregarDiagn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAgregarDiagn.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAgregarDiagn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregarDiagn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.dgvAgregarDiagn.DataSource = this.diagnosticoBindingSource;
            this.dgvAgregarDiagn.Location = new System.Drawing.Point(678, 196);
            this.dgvAgregarDiagn.Name = "dgvAgregarDiagn";
            this.dgvAgregarDiagn.Size = new System.Drawing.Size(331, 240);
            this.dgvAgregarDiagn.TabIndex = 13;
            // 
            // cbbIngDiagnostico
            // 
            this.cbbIngDiagnostico.FormattingEnabled = true;
            this.cbbIngDiagnostico.Location = new System.Drawing.Point(700, 60);
            this.cbbIngDiagnostico.Name = "cbbIngDiagnostico";
            this.cbbIngDiagnostico.Size = new System.Drawing.Size(98, 21);
            this.cbbIngDiagnostico.TabIndex = 14;
            this.cbbIngDiagnostico.Text = "Seleccione";
            // 
            // lbIngExamen
            // 
            this.lbIngExamen.AutoSize = true;
            this.lbIngExamen.Location = new System.Drawing.Point(467, 44);
            this.lbIngExamen.Name = "lbIngExamen";
            this.lbIngExamen.Size = new System.Drawing.Size(83, 13);
            this.lbIngExamen.TabIndex = 15;
            this.lbIngExamen.Text = "Ingrese Examen";
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.Width = 65;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 88;
            // 
            // diagnosticoBindingSource
            // 
            this.diagnosticoBindingSource.DataMember = "Diagnostico";
            this.diagnosticoBindingSource.DataSource = this.historialMedicoDataSet;
            // 
            // historialMedicoDataSet
            // 
            this.historialMedicoDataSet.DataSetName = "HistorialMedicoDataSet";
            this.historialMedicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registroDataGridViewTextBoxColumn
            // 
            this.registroDataGridViewTextBoxColumn.DataPropertyName = "Registro";
            this.registroDataGridViewTextBoxColumn.HeaderText = "Registro";
            this.registroDataGridViewTextBoxColumn.Name = "registroDataGridViewTextBoxColumn";
            this.registroDataGridViewTextBoxColumn.ReadOnly = true;
            this.registroDataGridViewTextBoxColumn.Width = 71;
            // 
            // rutDataGridViewTextBoxColumn
            // 
            this.rutDataGridViewTextBoxColumn.DataPropertyName = "Rut";
            this.rutDataGridViewTextBoxColumn.HeaderText = "Rut";
            this.rutDataGridViewTextBoxColumn.Name = "rutDataGridViewTextBoxColumn";
            this.rutDataGridViewTextBoxColumn.Width = 49;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 69;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.Width = 51;
            // 
            // diagnosticoDataGridViewTextBoxColumn
            // 
            this.diagnosticoDataGridViewTextBoxColumn.DataPropertyName = "Diagnostico";
            this.diagnosticoDataGridViewTextBoxColumn.HeaderText = "Diagnostico";
            this.diagnosticoDataGridViewTextBoxColumn.Name = "diagnosticoDataGridViewTextBoxColumn";
            this.diagnosticoDataGridViewTextBoxColumn.Width = 88;
            // 
            // fechaExamenDataGridViewTextBoxColumn
            // 
            this.fechaExamenDataGridViewTextBoxColumn.DataPropertyName = "FechaExamen";
            this.fechaExamenDataGridViewTextBoxColumn.HeaderText = "FechaExamen";
            this.fechaExamenDataGridViewTextBoxColumn.Name = "fechaExamenDataGridViewTextBoxColumn";
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
            // diagnosticoTableAdapter
            // 
            this.diagnosticoTableAdapter.ClearBeforeFill = true;
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 474);
            this.Controls.Add(this.lbIngExamen);
            this.Controls.Add(this.cbbIngDiagnostico);
            this.Controls.Add(this.dgvAgregarDiagn);
            this.Controls.Add(this.dgvAgregarPacientes);
            this.Controls.Add(this.btnPrincipal);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lbIngFecha);
            this.Controls.Add(this.dtpIngFecha);
            this.Controls.Add(this.lbIngDiagnostico);
            this.Controls.Add(this.lbIngMail);
            this.Controls.Add(this.lbIngNombre);
            this.Controls.Add(this.lbIngRut);
            this.Controls.Add(this.txtIngExamen);
            this.Controls.Add(this.txtIngMail);
            this.Controls.Add(this.txtIngNombre);
            this.Controls.Add(this.txtIngRut);
            this.Name = "Agregar";
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.Agregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarDiagn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialMedicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIngRut;
        private System.Windows.Forms.TextBox txtIngNombre;
        private System.Windows.Forms.TextBox txtIngMail;
        private System.Windows.Forms.TextBox txtIngExamen;
        private System.Windows.Forms.Label lbIngRut;
        private System.Windows.Forms.Label lbIngNombre;
        private System.Windows.Forms.Label lbIngMail;
        private System.Windows.Forms.Label lbIngDiagnostico;
        private System.Windows.Forms.DateTimePicker dtpIngFecha;
        private System.Windows.Forms.Label lbIngFecha;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.DataGridView dgvAgregarPacientes;
        private HistorialMedicoDataSet historialMedicoDataSet;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private HistorialMedicoDataSetTableAdapters.PacientesTableAdapter pacientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosticoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaExamenDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource diagnosticoBindingSource;
        private HistorialMedicoDataSetTableAdapters.DiagnosticoTableAdapter diagnosticoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbIngExamen;
        public System.Windows.Forms.ComboBox cbbIngDiagnostico;
        public System.Windows.Forms.DataGridView dgvAgregarDiagn;
    }
}