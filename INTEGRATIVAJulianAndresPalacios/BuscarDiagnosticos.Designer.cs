namespace INTEGRATIVAJulianAndresPalacios
{
    partial class BuscarDiagnosticos
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
            this.dgvHisDiagn = new System.Windows.Forms.DataGridView();
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
            this.historialDiagnosticosToolStrip = new System.Windows.Forms.ToolStrip();
            this.rutToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.rutToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fecha1ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.fecha1ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fecha2ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.fecha2ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.historialDiagnosticosToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.cbbDiagnBus = new System.Windows.Forms.ToolStripComboBox();
            this.lbDiagnostico = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHisDiagn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialMedicoDataSet)).BeginInit();
            this.historialDiagnosticosToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHisDiagn
            // 
            this.dgvHisDiagn.AutoGenerateColumns = false;
            this.dgvHisDiagn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHisDiagn.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHisDiagn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHisDiagn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registroDataGridViewTextBoxColumn,
            this.rutDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.diagnosticoDataGridViewTextBoxColumn,
            this.fechaExamenDataGridViewTextBoxColumn,
            this.examenDataGridViewTextBoxColumn});
            this.dgvHisDiagn.DataSource = this.pacientesBindingSource;
            this.dgvHisDiagn.Location = new System.Drawing.Point(34, 112);
            this.dgvHisDiagn.Name = "dgvHisDiagn";
            this.dgvHisDiagn.Size = new System.Drawing.Size(744, 150);
            this.dgvHisDiagn.TabIndex = 0;
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
            // historialDiagnosticosToolStrip
            // 
            this.historialDiagnosticosToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rutToolStripLabel,
            this.rutToolStripTextBox,
            this.lbDiagnostico,
            this.cbbDiagnBus,
            this.fecha1ToolStripLabel,
            this.fecha1ToolStripTextBox,
            this.fecha2ToolStripLabel,
            this.fecha2ToolStripTextBox,
            this.historialDiagnosticosToolStripButton});
            this.historialDiagnosticosToolStrip.Location = new System.Drawing.Point(0, 0);
            this.historialDiagnosticosToolStrip.Name = "historialDiagnosticosToolStrip";
            this.historialDiagnosticosToolStrip.Size = new System.Drawing.Size(814, 25);
            this.historialDiagnosticosToolStrip.TabIndex = 1;
            this.historialDiagnosticosToolStrip.Text = "historialDiagnosticosToolStrip";
            // 
            // rutToolStripLabel
            // 
            this.rutToolStripLabel.Name = "rutToolStripLabel";
            this.rutToolStripLabel.Size = new System.Drawing.Size(25, 22);
            this.rutToolStripLabel.Text = "rut:";
            // 
            // rutToolStripTextBox
            // 
            this.rutToolStripTextBox.Name = "rutToolStripTextBox";
            this.rutToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fecha1ToolStripLabel
            // 
            this.fecha1ToolStripLabel.Name = "fecha1ToolStripLabel";
            this.fecha1ToolStripLabel.Size = new System.Drawing.Size(45, 22);
            this.fecha1ToolStripLabel.Text = "fecha1:";
            // 
            // fecha1ToolStripTextBox
            // 
            this.fecha1ToolStripTextBox.Name = "fecha1ToolStripTextBox";
            this.fecha1ToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fecha2ToolStripLabel
            // 
            this.fecha2ToolStripLabel.Name = "fecha2ToolStripLabel";
            this.fecha2ToolStripLabel.Size = new System.Drawing.Size(45, 22);
            this.fecha2ToolStripLabel.Text = "fecha2:";
            // 
            // fecha2ToolStripTextBox
            // 
            this.fecha2ToolStripTextBox.Name = "fecha2ToolStripTextBox";
            this.fecha2ToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // historialDiagnosticosToolStripButton
            // 
            this.historialDiagnosticosToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.historialDiagnosticosToolStripButton.Name = "historialDiagnosticosToolStripButton";
            this.historialDiagnosticosToolStripButton.Size = new System.Drawing.Size(123, 22);
            this.historialDiagnosticosToolStripButton.Text = "HistorialDiagnosticos";
            this.historialDiagnosticosToolStripButton.Click += new System.EventHandler(this.historialDiagnosticosToolStripButton_Click);
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.Location = new System.Drawing.Point(367, 342);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(75, 23);
            this.btnPrincipal.TabIndex = 2;
            this.btnPrincipal.Text = "Principal";
            this.btnPrincipal.UseVisualStyleBackColor = true;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // cbbDiagnBus
            // 
            this.cbbDiagnBus.Items.AddRange(new object[] {
            "I",
            "H",
            "G",
            "A",
            "B",
            "D",
            "E"});
            this.cbbDiagnBus.Name = "cbbDiagnBus";
            this.cbbDiagnBus.Size = new System.Drawing.Size(121, 25);
            // 
            // lbDiagnostico
            // 
            this.lbDiagnostico.Name = "lbDiagnostico";
            this.lbDiagnostico.Size = new System.Drawing.Size(73, 22);
            this.lbDiagnostico.Text = "Diagnostico:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "dd-mm-yyyy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "dd-mm-yyyy";
            // 
            // BuscarDiagnosticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 407);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrincipal);
            this.Controls.Add(this.historialDiagnosticosToolStrip);
            this.Controls.Add(this.dgvHisDiagn);
            this.Name = "BuscarDiagnosticos";
            this.Text = "BuscarDiagnosticos";
            this.Load += new System.EventHandler(this.BuscarDiagnosticos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHisDiagn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialMedicoDataSet)).EndInit();
            this.historialDiagnosticosToolStrip.ResumeLayout(false);
            this.historialDiagnosticosToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHisDiagn;
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
        private System.Windows.Forms.ToolStrip historialDiagnosticosToolStrip;
        private System.Windows.Forms.ToolStripLabel rutToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox rutToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel fecha1ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox fecha1ToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel fecha2ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox fecha2ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton historialDiagnosticosToolStripButton;
        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.ToolStripLabel lbDiagnostico;
        private System.Windows.Forms.ToolStripComboBox cbbDiagnBus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}