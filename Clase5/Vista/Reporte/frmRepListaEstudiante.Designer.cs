namespace Clase5.Vista.Reporte
{
    partial class frmRepListaEstudiante
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsFunciones = new Clase5.Modelo.dsFunciones();
            this.sprListaEstudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sprListaEstudianteTableAdapter = new Clase5.Modelo.dsFuncionesTableAdapters.sprListaEstudianteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsFunciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprListaEstudianteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsReporte";
            reportDataSource1.Value = this.sprListaEstudianteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Clase5.Vista.Reporte.rpListaEstudiante.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(562, 398);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsFunciones
            // 
            this.dsFunciones.DataSetName = "dsFunciones";
            this.dsFunciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sprListaEstudianteBindingSource
            // 
            this.sprListaEstudianteBindingSource.DataMember = "sprListaEstudiante";
            this.sprListaEstudianteBindingSource.DataSource = this.dsFunciones;
            // 
            // sprListaEstudianteTableAdapter
            // 
            this.sprListaEstudianteTableAdapter.ClearBeforeFill = true;
            // 
            // frmRepListaEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 398);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRepListaEstudiante";
            this.Text = "frmRepListaEstudiante";
            this.Load += new System.EventHandler(this.frmRepListaEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsFunciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprListaEstudianteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Modelo.dsFunciones dsFunciones;
        private System.Windows.Forms.BindingSource sprListaEstudianteBindingSource;
        private Modelo.dsFuncionesTableAdapters.sprListaEstudianteTableAdapter sprListaEstudianteTableAdapter;
    }
}