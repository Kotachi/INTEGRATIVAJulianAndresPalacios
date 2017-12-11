namespace INTEGRATIVAJulianAndresPalacios
{
    partial class Buscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscar));
            this.historialMedicoDataSet = new INTEGRATIVAJulianAndresPalacios.HistorialMedicoDataSet();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesTableAdapter = new INTEGRATIVAJulianAndresPalacios.HistorialMedicoDataSetTableAdapters.PacientesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.registroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaExamenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.historialExamenesToolStrip = new System.Windows.Forms.ToolStrip();
            this.rutToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.rutToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.historialExamenesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.historialMedicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource1)).BeginInit();
            this.historialExamenesToolStrip.SuspendLayout();
            this.SuspendLayout();
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registroDataGridViewTextBoxColumn,
            this.rutDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.diagnosticoDataGridViewTextBoxColumn,
            this.fechaExamenDataGridViewTextBoxColumn,
            this.examenDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pacientesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 186);
            this.dataGridView1.TabIndex = 0;
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
            // pacientesBindingSource1
            // 
            this.pacientesBindingSource1.DataMember = "Pacientes";
            this.pacientesBindingSource1.DataSource = this.historialMedicoDataSet;
            // 
            // historialExamenesToolStrip
            // 
            this.historialExamenesToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rutToolStripLabel,
            this.rutToolStripTextBox,
            this.historialExamenesToolStripButton,
            this.toolStripButton1});
            this.historialExamenesToolStrip.Location = new System.Drawing.Point(0, 0);
            this.historialExamenesToolStrip.Name = "historialExamenesToolStrip";
            this.historialExamenesToolStrip.Size = new System.Drawing.Size(853, 25);
            this.historialExamenesToolStrip.TabIndex = 1;
            this.historialExamenesToolStrip.Text = "historialExamenesToolStrip";
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
            // historialExamenesToolStripButton
            // 
            this.historialExamenesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.historialExamenesToolStripButton.Name = "historialExamenesToolStripButton";
            this.historialExamenesToolStripButton.Size = new System.Drawing.Size(107, 22);
            this.historialExamenesToolStripButton.Text = "HistorialExamenes";
            this.historialExamenesToolStripButton.Click += new System.EventHandler(this.historialExamenesToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton1.Text = "Principal";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 361);
            this.Controls.Add(this.historialExamenesToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Buscar";
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.Buscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historialMedicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource1)).EndInit();
            this.historialExamenesToolStrip.ResumeLayout(false);
            this.historialExamenesToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HistorialMedicoDataSet historialMedicoDataSet;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private HistorialMedicoDataSetTableAdapters.PacientesTableAdapter pacientesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosticoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaExamenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examenDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pacientesBindingSource1;
        private System.Windows.Forms.ToolStrip historialExamenesToolStrip;
        private System.Windows.Forms.ToolStripLabel rutToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox rutToolStripTextBox;
        private System.Windows.Forms.ToolStripButton historialExamenesToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}