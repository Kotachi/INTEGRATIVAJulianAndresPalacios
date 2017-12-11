namespace INTEGRATIVAJulianAndresPalacios
{
    partial class Modificar
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
            this.txtModRegistro = new System.Windows.Forms.TextBox();
            this.txtModRut = new System.Windows.Forms.TextBox();
            this.txtModNombre = new System.Windows.Forms.TextBox();
            this.txtModMail = new System.Windows.Forms.TextBox();
            this.txtModDiagnostico = new System.Windows.Forms.TextBox();
            this.dtpModificarFecha = new System.Windows.Forms.DateTimePicker();
            this.lbModRegistro = new System.Windows.Forms.Label();
            this.lbModRut = new System.Windows.Forms.Label();
            this.lbModNombre = new System.Windows.Forms.Label();
            this.lbModMail = new System.Windows.Forms.Label();
            this.lbModDiagnostico = new System.Windows.Forms.Label();
            this.lbModFecha = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.historialMedicoDataSet = new INTEGRATIVAJulianAndresPalacios.HistorialMedicoDataSet();
            this.pacientesTableAdapter = new INTEGRATIVAJulianAndresPalacios.HistorialMedicoDataSetTableAdapters.PacientesTableAdapter();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lbModExamen = new System.Windows.Forms.Label();
            this.txtModExamen = new System.Windows.Forms.TextBox();
            this.cbbModDiagnostico = new System.Windows.Forms.ComboBox();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaExamenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialMedicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtModRegistro
            // 
            this.txtModRegistro.Location = new System.Drawing.Point(25, 54);
            this.txtModRegistro.Name = "txtModRegistro";
            this.txtModRegistro.Size = new System.Drawing.Size(100, 20);
            this.txtModRegistro.TabIndex = 0;
            // 
            // txtModRut
            // 
            this.txtModRut.Location = new System.Drawing.Point(176, 54);
            this.txtModRut.Name = "txtModRut";
            this.txtModRut.Size = new System.Drawing.Size(100, 20);
            this.txtModRut.TabIndex = 1;
            // 
            // txtModNombre
            // 
            this.txtModNombre.Location = new System.Drawing.Point(357, 54);
            this.txtModNombre.Name = "txtModNombre";
            this.txtModNombre.Size = new System.Drawing.Size(100, 20);
            this.txtModNombre.TabIndex = 2;
            // 
            // txtModMail
            // 
            this.txtModMail.Location = new System.Drawing.Point(81, 108);
            this.txtModMail.Name = "txtModMail";
            this.txtModMail.Size = new System.Drawing.Size(100, 20);
            this.txtModMail.TabIndex = 3;
            // 
            // txtModDiagnostico
            // 
            this.txtModDiagnostico.Location = new System.Drawing.Point(265, 168);
            this.txtModDiagnostico.Name = "txtModDiagnostico";
            this.txtModDiagnostico.Size = new System.Drawing.Size(100, 20);
            this.txtModDiagnostico.TabIndex = 4;
            this.txtModDiagnostico.Visible = false;
            // 
            // dtpModificarFecha
            // 
            this.dtpModificarFecha.CustomFormat = "yyyy-MM-dd";
            this.dtpModificarFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpModificarFecha.Location = new System.Drawing.Point(449, 108);
            this.dtpModificarFecha.Name = "dtpModificarFecha";
            this.dtpModificarFecha.Size = new System.Drawing.Size(123, 20);
            this.dtpModificarFecha.TabIndex = 5;
            // 
            // lbModRegistro
            // 
            this.lbModRegistro.AutoSize = true;
            this.lbModRegistro.Location = new System.Drawing.Point(22, 38);
            this.lbModRegistro.Name = "lbModRegistro";
            this.lbModRegistro.Size = new System.Drawing.Size(124, 13);
            this.lbModRegistro.TabIndex = 6;
            this.lbModRegistro.Text = "Ingrese Numero Registro";
            // 
            // lbModRut
            // 
            this.lbModRut.AutoSize = true;
            this.lbModRut.Location = new System.Drawing.Point(173, 38);
            this.lbModRut.Name = "lbModRut";
            this.lbModRut.Size = new System.Drawing.Size(73, 13);
            this.lbModRut.TabIndex = 7;
            this.lbModRut.Text = "Modifique Rut";
            // 
            // lbModNombre
            // 
            this.lbModNombre.AutoSize = true;
            this.lbModNombre.Location = new System.Drawing.Point(354, 38);
            this.lbModNombre.Name = "lbModNombre";
            this.lbModNombre.Size = new System.Drawing.Size(93, 13);
            this.lbModNombre.TabIndex = 8;
            this.lbModNombre.Text = "Modifique Nombre";
            // 
            // lbModMail
            // 
            this.lbModMail.AutoSize = true;
            this.lbModMail.Location = new System.Drawing.Point(78, 92);
            this.lbModMail.Name = "lbModMail";
            this.lbModMail.Size = new System.Drawing.Size(75, 13);
            this.lbModMail.TabIndex = 9;
            this.lbModMail.Text = "Modifique Mail";
            // 
            // lbModDiagnostico
            // 
            this.lbModDiagnostico.AutoSize = true;
            this.lbModDiagnostico.Location = new System.Drawing.Point(265, 92);
            this.lbModDiagnostico.Name = "lbModDiagnostico";
            this.lbModDiagnostico.Size = new System.Drawing.Size(109, 13);
            this.lbModDiagnostico.TabIndex = 10;
            this.lbModDiagnostico.Text = "Modificar Diagnostico";
            // 
            // lbModFecha
            // 
            this.lbModFecha.AutoSize = true;
            this.lbModFecha.Location = new System.Drawing.Point(446, 92);
            this.lbModFecha.Name = "lbModFecha";
            this.lbModFecha.Size = new System.Drawing.Size(124, 13);
            this.lbModFecha.TabIndex = 11;
            this.lbModFecha.Text = "Modificar Fecha Examen";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(175, 166);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.Location = new System.Drawing.Point(371, 166);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(75, 23);
            this.btnPrincipal.TabIndex = 13;
            this.btnPrincipal.Text = "Principal";
            this.btnPrincipal.UseVisualStyleBackColor = true;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AutoGenerateColumns = false;
            this.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPacientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registroDataGridViewTextBoxColumn,
            this.rutDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.diagnosticoDataGridViewTextBoxColumn,
            this.fechaExamenDataGridViewTextBoxColumn,
            this.examenDataGridViewTextBoxColumn});
            this.dgvPacientes.DataSource = this.pacientesBindingSource;
            this.dgvPacientes.Location = new System.Drawing.Point(-1, 236);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.Size = new System.Drawing.Size(668, 150);
            this.dgvPacientes.TabIndex = 14;
            // 
            // historialMedicoDataSet
            // 
            this.historialMedicoDataSet.DataSetName = "HistorialMedicoDataSet";
            this.historialMedicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(293, 404);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lbModExamen
            // 
            this.lbModExamen.AutoSize = true;
            this.lbModExamen.Location = new System.Drawing.Point(514, 38);
            this.lbModExamen.Name = "lbModExamen";
            this.lbModExamen.Size = new System.Drawing.Size(93, 13);
            this.lbModExamen.TabIndex = 16;
            this.lbModExamen.Text = "Modifique examen";
            // 
            // txtModExamen
            // 
            this.txtModExamen.Location = new System.Drawing.Point(517, 54);
            this.txtModExamen.Name = "txtModExamen";
            this.txtModExamen.Size = new System.Drawing.Size(100, 20);
            this.txtModExamen.TabIndex = 17;
            // 
            // cbbModDiagnostico
            // 
            this.cbbModDiagnostico.FormattingEnabled = true;
            this.cbbModDiagnostico.Items.AddRange(new object[] {
            "I",
            "H",
            "G",
            "A",
            "B",
            "D",
            "E"});
            this.cbbModDiagnostico.Location = new System.Drawing.Point(268, 107);
            this.cbbModDiagnostico.Name = "cbbModDiagnostico";
            this.cbbModDiagnostico.Size = new System.Drawing.Size(81, 21);
            this.cbbModDiagnostico.TabIndex = 18;
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.historialMedicoDataSet;
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
            // examenDataGridViewTextBoxColumn
            // 
            this.examenDataGridViewTextBoxColumn.DataPropertyName = "Examen";
            this.examenDataGridViewTextBoxColumn.HeaderText = "Examen";
            this.examenDataGridViewTextBoxColumn.Name = "examenDataGridViewTextBoxColumn";
            this.examenDataGridViewTextBoxColumn.Width = 70;
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 492);
            this.Controls.Add(this.cbbModDiagnostico);
            this.Controls.Add(this.txtModExamen);
            this.Controls.Add(this.lbModExamen);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.btnPrincipal);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lbModFecha);
            this.Controls.Add(this.lbModDiagnostico);
            this.Controls.Add(this.lbModMail);
            this.Controls.Add(this.lbModNombre);
            this.Controls.Add(this.lbModRut);
            this.Controls.Add(this.lbModRegistro);
            this.Controls.Add(this.dtpModificarFecha);
            this.Controls.Add(this.txtModDiagnostico);
            this.Controls.Add(this.txtModMail);
            this.Controls.Add(this.txtModNombre);
            this.Controls.Add(this.txtModRut);
            this.Controls.Add(this.txtModRegistro);
            this.Name = "Modificar";
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.Modificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialMedicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModRegistro;
        private System.Windows.Forms.TextBox txtModRut;
        private System.Windows.Forms.TextBox txtModNombre;
        private System.Windows.Forms.TextBox txtModMail;
        private System.Windows.Forms.TextBox txtModDiagnostico;
        private System.Windows.Forms.DateTimePicker dtpModificarFecha;
        private System.Windows.Forms.Label lbModRegistro;
        private System.Windows.Forms.Label lbModRut;
        private System.Windows.Forms.Label lbModNombre;
        private System.Windows.Forms.Label lbModMail;
        private System.Windows.Forms.Label lbModDiagnostico;
        private System.Windows.Forms.Label lbModFecha;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private HistorialMedicoDataSet historialMedicoDataSet;
        private HistorialMedicoDataSetTableAdapters.PacientesTableAdapter pacientesTableAdapter;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lbModExamen;
        private System.Windows.Forms.TextBox txtModExamen;
        private System.Windows.Forms.ComboBox cbbModDiagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosticoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaExamenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examenDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
    }
}