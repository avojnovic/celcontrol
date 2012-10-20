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
            this.txtSheet = new System.Windows.Forms.TextBox();
            this.BtnImportar = new System.Windows.Forms.Button();
            this.dataGridViewLiquidaciones = new System.Windows.Forms.DataGridView();
            this.BtnSave = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.liquidacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.celControlDataSet = new CelControl.CelControlDataSet();
            this.celControlDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.liquidacionesTableAdapter = new CelControl.CelControlDataSetTableAdapters.liquidacionesTableAdapter();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.LayoutPanelImportar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLiquidaciones)).BeginInit();
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
            this.tabPage1.Text = "Importar";
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
            this.LayoutPanelImportar.Controls.Add(this.txtSheet, 3, 0);
            this.LayoutPanelImportar.Controls.Add(this.BtnImportar, 4, 0);
            this.LayoutPanelImportar.Controls.Add(this.dataGridViewLiquidaciones, 0, 4);
            this.LayoutPanelImportar.Controls.Add(this.txtSearch, 1, 2);
            this.LayoutPanelImportar.Controls.Add(this.BtnSave, 4, 1);
            this.LayoutPanelImportar.Controls.Add(this.BtnRefresh, 4, 2);
            this.LayoutPanelImportar.Controls.Add(this.label2, 0, 2);
            this.LayoutPanelImportar.Controls.Add(this.btnSearch, 2, 2);
            this.LayoutPanelImportar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPanelImportar.Location = new System.Drawing.Point(3, 3);
            this.LayoutPanelImportar.Name = "LayoutPanelImportar";
            this.LayoutPanelImportar.RowCount = 5;
            this.LayoutPanelImportar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.LayoutPanelImportar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.LayoutPanelImportar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.LayoutPanelImportar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.LayoutPanelImportar.RowStyles.Add(new System.Windows.Forms.RowStyle());
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
            // txtSheet
            // 
            this.txtSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSheet.Location = new System.Drawing.Point(457, 5);
            this.txtSheet.Name = "txtSheet";
            this.txtSheet.Size = new System.Drawing.Size(69, 20);
            this.txtSheet.TabIndex = 4;
            this.txtSheet.Text = "Hoja1";
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(685, 295);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(115, 65);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(274, 20);
            this.txtSearch.TabIndex = 8;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 526);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.LayoutPanelImportar.ResumeLayout(false);
            this.LayoutPanelImportar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLiquidaciones)).EndInit();
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
        private System.Windows.Forms.TextBox txtSheet;
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

    }
}

