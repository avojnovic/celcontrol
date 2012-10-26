namespace CelControl
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LayoutPanelImportar = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSelectFileImport = new System.Windows.Forms.Button();
            this.txtFileImport = new System.Windows.Forms.TextBox();
            this.BtnImportar = new System.Windows.Forms.Button();
            this.dataGridViewLiquidaciones = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbSheets1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSelectFileImport2 = new System.Windows.Forms.Button();
            this.BtnImportar2 = new System.Windows.Forms.Button();
            this.txtFileImport2 = new System.Windows.Forms.TextBox();
            this.cmbSheets2 = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BtnGenerarReporte = new System.Windows.Forms.Button();
            this.liquidacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.celControlDataSet = new CelControl.CelControlDataSet();
            this.celControlDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.liquidacionesTableAdapter = new CelControl.CelControlDataSetTableAdapters.liquidacionesTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.LayoutPanelImportar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLiquidaciones)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celControlDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celControlDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(656, 526);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LayoutPanelImportar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(648, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Liquidaciones";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LayoutPanelImportar
            // 
            this.LayoutPanelImportar.ColumnCount = 5;
            this.LayoutPanelImportar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.LayoutPanelImportar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutPanelImportar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.LayoutPanelImportar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.LayoutPanelImportar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.LayoutPanelImportar.Controls.Add(this.label1, 0, 0);
            this.LayoutPanelImportar.Controls.Add(this.BtnSelectFileImport, 2, 0);
            this.LayoutPanelImportar.Controls.Add(this.txtFileImport, 1, 0);
            this.LayoutPanelImportar.Controls.Add(this.BtnImportar, 4, 0);
            this.LayoutPanelImportar.Controls.Add(this.dataGridViewLiquidaciones, 0, 4);
            this.LayoutPanelImportar.Controls.Add(this.txtSearch, 1, 2);
            this.LayoutPanelImportar.Controls.Add(this.BtnSave, 4, 1);
            this.LayoutPanelImportar.Controls.Add(this.BtnRefresh, 4, 2);
            this.LayoutPanelImportar.Controls.Add(this.label2, 0, 2);
            this.LayoutPanelImportar.Controls.Add(this.btnSearch, 2, 2);
            this.LayoutPanelImportar.Controls.Add(this.cmbSheets1, 3, 0);
            this.LayoutPanelImportar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPanelImportar.Location = new System.Drawing.Point(3, 3);
            this.LayoutPanelImportar.Name = "LayoutPanelImportar";
            this.LayoutPanelImportar.RowCount = 5;
            this.LayoutPanelImportar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.LayoutPanelImportar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.LayoutPanelImportar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.LayoutPanelImportar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.LayoutPanelImportar.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutPanelImportar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LayoutPanelImportar.Size = new System.Drawing.Size(642, 494);
            this.LayoutPanelImportar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccionar archivo:";
            // 
            // BtnSelectFileImport
            // 
            this.BtnSelectFileImport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnSelectFileImport.Location = new System.Drawing.Point(395, 5);
            this.BtnSelectFileImport.Name = "BtnSelectFileImport";
            this.BtnSelectFileImport.Size = new System.Drawing.Size(25, 20);
            this.BtnSelectFileImport.TabIndex = 0;
            this.BtnSelectFileImport.Text = "...";
            this.BtnSelectFileImport.UseVisualStyleBackColor = true;
            this.BtnSelectFileImport.Click += new System.EventHandler(this.BtnSelectFileImport_Click);
            // 
            // txtFileImport
            // 
            this.txtFileImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileImport.Location = new System.Drawing.Point(115, 5);
            this.txtFileImport.Name = "txtFileImport";
            this.txtFileImport.ReadOnly = true;
            this.txtFileImport.Size = new System.Drawing.Size(274, 20);
            this.txtFileImport.TabIndex = 2;
            // 
            // BtnImportar
            // 
            this.BtnImportar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnImportar.Location = new System.Drawing.Point(532, 3);
            this.BtnImportar.Name = "BtnImportar";
            this.BtnImportar.Size = new System.Drawing.Size(78, 23);
            this.BtnImportar.TabIndex = 3;
            this.BtnImportar.Text = "Importar";
            this.BtnImportar.UseVisualStyleBackColor = true;
            this.BtnImportar.Click += new System.EventHandler(this.BtnImportar_Click);
            // 
            // dataGridViewLiquidaciones
            // 
            this.dataGridViewLiquidaciones.AllowUserToOrderColumns = true;
            this.dataGridViewLiquidaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LayoutPanelImportar.SetColumnSpan(this.dataGridViewLiquidaciones, 5);
            this.dataGridViewLiquidaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLiquidaciones.Location = new System.Drawing.Point(3, 123);
            this.dataGridViewLiquidaciones.Name = "dataGridViewLiquidaciones";
            this.dataGridViewLiquidaciones.Size = new System.Drawing.Size(636, 368);
            this.dataGridViewLiquidaciones.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(115, 65);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(274, 20);
            this.txtSearch.TabIndex = 8;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(532, 33);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(107, 23);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "Guardar Cambios";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(532, 63);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(75, 23);
            this.BtnRefresh.TabIndex = 7;
            this.BtnRefresh.Text = "Traer Todos";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Buscar:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(395, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbSheets1
            // 
            this.cmbSheets1.FormattingEnabled = true;
            this.cmbSheets1.Location = new System.Drawing.Point(457, 3);
            this.cmbSheets1.Name = "cmbSheets1";
            this.cmbSheets1.Size = new System.Drawing.Size(69, 21);
            this.cmbSheets1.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(648, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Etiquetas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.16704F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.83296F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnSelectFileImport2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnImportar2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFileImport2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbSheets2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnGenerarReporte, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.70861F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.29139F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(642, 494);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seleccionar archivo:";
            // 
            // BtnSelectFileImport2
            // 
            this.BtnSelectFileImport2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnSelectFileImport2.Location = new System.Drawing.Point(450, 23);
            this.BtnSelectFileImport2.Name = "BtnSelectFileImport2";
            this.BtnSelectFileImport2.Size = new System.Drawing.Size(25, 20);
            this.BtnSelectFileImport2.TabIndex = 5;
            this.BtnSelectFileImport2.Text = "...";
            this.BtnSelectFileImport2.UseVisualStyleBackColor = true;
            this.BtnSelectFileImport2.Click += new System.EventHandler(this.BtnSelectFileImport2_Click);
            // 
            // BtnImportar2
            // 
            this.BtnImportar2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnImportar2.Location = new System.Drawing.Point(571, 21);
            this.BtnImportar2.Name = "BtnImportar2";
            this.BtnImportar2.Size = new System.Drawing.Size(66, 23);
            this.BtnImportar2.TabIndex = 8;
            this.BtnImportar2.Text = "Importar";
            this.BtnImportar2.UseVisualStyleBackColor = true;
            this.BtnImportar2.Click += new System.EventHandler(this.BtnImportar2_Click);
            // 
            // txtFileImport2
            // 
            this.txtFileImport2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileImport2.Location = new System.Drawing.Point(115, 23);
            this.txtFileImport2.Name = "txtFileImport2";
            this.txtFileImport2.ReadOnly = true;
            this.txtFileImport2.Size = new System.Drawing.Size(329, 20);
            this.txtFileImport2.TabIndex = 7;
            // 
            // cmbSheets2
            // 
            this.cmbSheets2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSheets2.FormattingEnabled = true;
            this.cmbSheets2.Location = new System.Drawing.Point(486, 22);
            this.cmbSheets2.Name = "cmbSheets2";
            this.cmbSheets2.Size = new System.Drawing.Size(79, 21);
            this.cmbSheets2.TabIndex = 9;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(115, 249);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(329, 23);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Visible = false;
            // 
            // BtnGenerarReporte
            // 
            this.BtnGenerarReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGenerarReporte.Location = new System.Drawing.Point(115, 421);
            this.BtnGenerarReporte.Name = "BtnGenerarReporte";
            this.BtnGenerarReporte.Size = new System.Drawing.Size(329, 23);
            this.BtnGenerarReporte.TabIndex = 0;
            this.BtnGenerarReporte.Text = "Generar Etiquetas";
            this.BtnGenerarReporte.UseVisualStyleBackColor = true;
            this.BtnGenerarReporte.Click += new System.EventHandler(this.BtnGenerarReporte_Click);
            // 
            // liquidacionesBindingSource
            // 
            this.liquidacionesBindingSource.DataMember = "liquidaciones";
            this.liquidacionesBindingSource.DataSource = this.celControlDataSet;
            // 
            // celControlDataSet
            // 
            this.celControlDataSet.DataSetName = "CelControlDataSet";
            this.celControlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // celControlDataSetBindingSource
            // 
            this.celControlDataSetBindingSource.DataSource = this.celControlDataSet;
            this.celControlDataSetBindingSource.Position = 0;
            // 
            // liquidacionesTableAdapter
            // 
            this.liquidacionesTableAdapter.ClearBeforeFill = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 526);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "CelControl V 1.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.LayoutPanelImportar.ResumeLayout(false);
            this.LayoutPanelImportar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLiquidaciones)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celControlDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celControlDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel LayoutPanelImportar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSelectFileImport;
        private System.Windows.Forms.TextBox txtFileImport;
        private System.Windows.Forms.Button BtnImportar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewLiquidaciones;
        private System.Windows.Forms.BindingSource celControlDataSetBindingSource;
        private CelControlDataSet celControlDataSet;
        private System.Windows.Forms.BindingSource liquidacionesBindingSource;
        private CelControlDataSetTableAdapters.liquidacionesTableAdapter liquidacionesTableAdapter;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnGenerarReporte;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSelectFileImport2;
        private System.Windows.Forms.Button BtnImportar2;
        private System.Windows.Forms.TextBox txtFileImport2;
        private System.Windows.Forms.ComboBox cmbSheets2;
        private System.Windows.Forms.ComboBox cmbSheets1;

    }
}

