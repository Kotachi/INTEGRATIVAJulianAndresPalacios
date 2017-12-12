namespace INTEGRATIVAJulianAndresPalacios
{
    partial class FrecuenciaDiagnosticos
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
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.dgvFrecuenciaDiagn = new System.Windows.Forms.DataGridView();
            this.registroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaExamenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historialMedicoDataSet = new INTEGRATIVAJulianAndresPalacios.HistorialMedicoDataSet();
            this.pacientesTableAdapter = new INTEGRATIVAJulianAndresPalacios.HistorialMedicoDataSetTableAdapters.PacientesTableAdapter();
            this.btnFrecuencia = new System.Windows.Forms.Button();
            this.txtFrecFecha1 = new System.Windows.Forms.TextBox();
            this.txtFrecFecha2 = new System.Windows.Forms.TextBox();
            this.cbbFrecDiagn = new System.Windows.Forms.ComboBox();
            this.lbFrecDiagn = new System.Windows.Forms.Label();
            this.lbFrecFecha1 = new System.Windows.Forms.Label();
            this.lbFrecFecha2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuenciaDiagn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialMedicoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.Location = new System.Drawing.Point(161, 344);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(75, 23);
            this.btnPrincipal.TabIndex = 0;
            this.btnPrincipal.Text = "Principal";
            this.btnPrincipal.UseVisualStyleBackColor = true;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // dgvFrecuenciaDiagn
            // 
            this.dgvFrecuenciaDiagn.AutoGenerateColumns = false;
            this.dgvFrecuenciaDiagn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFrecuenciaDiagn.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFrecuenciaDiagn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrecuenciaDiagn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registroDataGridViewTextBoxColumn,
            this.rutDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.diagnosticoDataGridViewTextBoxColumn,
            this.fechaExamenDataGridViewTextBoxColumn,
            this.examenDataGridViewTextBoxColumn});
            this.dgvFrecuenciaDiagn.DataSource = this.pacientesBindingSource;
            this.dgvFrecuenciaDiagn.Location = new System.Drawing.Point(31, 75);
            this.dgvFrecuenciaDiagn.Name = "dgvFrecuenciaDiagn";
            this.dgvFrecuenciaDiagn.Size = new System.Drawing.Size(746, 214);
            this.dgvFrecuenciaDiagn.TabIndex = 1;
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
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // btnFrecuencia
            // 
            this.btnFrecuencia.Location = new System.Drawing.Point(468, 344);
            this.btnFrecuencia.Name = "btnFrecuencia";
            this.btnFrecuencia.Size = new System.Drawing.Size(75, 23);
            this.btnFrecuencia.TabIndex = 2;
            this.btnFrecuencia.Text = "Frecuencia";
            this.btnFrecuencia.UseVisualStyleBackColor = true;
            this.btnFrecuencia.Click += new System.EventHandler(this.btnFrecuencia_Click);
            // 
            // txtFrecFecha1
            // 
            this.txtFrecFecha1.Location = new System.Drawing.Point(308, 31);
            this.txtFrecFecha1.Name = "txtFrecFecha1";
            this.txtFrecFecha1.Size = new System.Drawing.Size(100, 20);
            this.txtFrecFecha1.TabIndex = 4;
            // 
            // txtFrecFecha2
            // 
            this.txtFrecFecha2.Location = new System.Drawing.Point(455, 31);
            this.txtFrecFecha2.Name = "txtFrecFecha2";
            this.txtFrecFecha2.Size = new System.Drawing.Size(100, 20);
            this.txtFrecFecha2.TabIndex = 5;
            // 
            // cbbFrecDiagn
            // 
            this.cbbFrecDiagn.FormattingEnabled = true;
            this.cbbFrecDiagn.Items.AddRange(new object[] {
            "I",
            "H",
            "G",
            "A",
            "B",
            "D",
            "E"});
            this.cbbFrecDiagn.Location = new System.Drawing.Point(99, 30);
            this.cbbFrecDiagn.Name = "cbbFrecDiagn";
            this.cbbFrecDiagn.Size = new System.Drawing.Size(76, 21);
            this.cbbFrecDiagn.TabIndex = 6;
            // 
            // lbFrecDiagn
            // 
            this.lbFrecDiagn.AutoSize = true;
            this.lbFrecDiagn.Location = new System.Drawing.Point(96, 14);
            this.lbFrecDiagn.Name = "lbFrecDiagn";
            this.lbFrecDiagn.Size = new System.Drawing.Size(119, 13);
            this.lbFrecDiagn.TabIndex = 7;
            this.lbFrecDiagn.Text = "Seleccione Diagnostico";
            // 
            // lbFrecFecha1
            // 
            this.lbFrecFecha1.AutoSize = true;
            this.lbFrecFecha1.Location = new System.Drawing.Point(305, 15);
            this.lbFrecFecha1.Name = "lbFrecFecha1";
            this.lbFrecFecha1.Size = new System.Drawing.Size(109, 13);
            this.lbFrecFecha1.TabIndex = 8;
            this.lbFrecFecha1.Text = "Fecha 1 (dd-mm-yyyy)";
            // 
            // lbFrecFecha2
            // 
            this.lbFrecFecha2.AutoSize = true;
            this.lbFrecFecha2.Location = new System.Drawing.Point(452, 15);
            this.lbFrecFecha2.Name = "lbFrecFecha2";
            this.lbFrecFecha2.Size = new System.Drawing.Size(109, 13);
            this.lbFrecFecha2.TabIndex = 9;
            this.lbFrecFecha2.Text = "Fecha 2 (dd-mm-yyyy)";
            // 
            // FrecuenciaDiagnosticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 401);
            this.Controls.Add(this.lbFrecFecha2);
            this.Controls.Add(this.lbFrecFecha1);
            this.Controls.Add(this.lbFrecDiagn);
            this.Controls.Add(this.cbbFrecDiagn);
            this.Controls.Add(this.txtFrecFecha2);
            this.Controls.Add(this.txtFrecFecha1);
            this.Controls.Add(this.btnFrecuencia);
            this.Controls.Add(this.dgvFrecuenciaDiagn);
            this.Controls.Add(this.btnPrincipal);
            this.Name = "FrecuenciaDiagnosticos";
            this.Text = "FrecuenciaDiagnosticos";
            this.Load += new System.EventHandler(this.FrecuenciaDiagnosticos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuenciaDiagn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialMedicoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.DataGridView dgvFrecuenciaDiagn;
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
        private System.Windows.Forms.Button btnFrecuencia;
        private System.Windows.Forms.TextBox txtFrecFecha1;
        private System.Windows.Forms.TextBox txtFrecFecha2;
        private System.Windows.Forms.ComboBox cbbFrecDiagn;
        private System.Windows.Forms.Label lbFrecDiagn;
        private System.Windows.Forms.Label lbFrecFecha1;
        private System.Windows.Forms.Label lbFrecFecha2;
    }
}