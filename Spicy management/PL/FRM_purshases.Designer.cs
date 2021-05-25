﻿namespace Spicy_management.PL
{
    partial class FRM_purshases
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_purshases));
            this.pn_pur = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchases_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchases_supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchases_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasesquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBPurchasesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dB_SpicyDataSet4 = new Spicy_management.DB_SpicyDataSet4();
            this.panel2 = new System.Windows.Forms.Panel();
            this.edit_search = new System.Windows.Forms.TextBox();
            this.button_search = new DevExpress.XtraEditors.SimpleButton();
            this.btn_refresh = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.tBSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_SpicyDataSet2 = new Spicy_management.DB_SpicyDataSet2();
            this.tBCatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBSpicyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_SpicyDataSet = new Spicy_management.DB_SpicyDataSet();
            this.tB_CatTableAdapter = new Spicy_management.DB_SpicyDataSetTableAdapters.TB_CatTableAdapter();
            this.tBCatBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dB_SpicyDataSet1 = new Spicy_management.DB_SpicyDataSet1();
            this.tBCatBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tB_CatTableAdapter1 = new Spicy_management.DB_SpicyDataSet1TableAdapters.TB_CatTableAdapter();
            this.tB_SupplierTableAdapter = new Spicy_management.DB_SpicyDataSet2TableAdapters.TB_SupplierTableAdapter();
            this.dB_SpicyDataSet3 = new Spicy_management.DB_SpicyDataSet3();
            this.tBPurchasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_PurchasesTableAdapter = new Spicy_management.DB_SpicyDataSet3TableAdapters.TB_PurchasesTableAdapter();
            this.tB_PurchasesTableAdapter1 = new Spicy_management.DB_SpicyDataSet4TableAdapters.TB_PurchasesTableAdapter();
            this.pn_pur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPurchasesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SpicyDataSet4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SpicyDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSpicyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SpicyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCatBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SpicyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCatBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SpicyDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPurchasesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_pur
            // 
            this.pn_pur.Controls.Add(this.dataGridView1);
            this.pn_pur.Controls.Add(this.panel2);
            this.pn_pur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_pur.Location = new System.Drawing.Point(0, 0);
            this.pn_pur.Name = "pn_pur";
            this.pn_pur.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.pn_pur.Size = new System.Drawing.Size(1030, 670);
            this.pn_pur.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cairo SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.purchases_name,
            this.purchases_supplier,
            this.purchases_price,
            this.purchasesquantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBPurchasesBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cairo SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Cairo SemiBold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.Height = 60;
            this.dataGridView1.Size = new System.Drawing.Size(1030, 520);
            this.dataGridView1.TabIndex = 1;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // purchases_name
            // 
            this.purchases_name.DataPropertyName = "purchases_name";
            this.purchases_name.FillWeight = 350F;
            this.purchases_name.HeaderText = "Name";
            this.purchases_name.Name = "purchases_name";
            this.purchases_name.Width = 350;
            // 
            // purchases_supplier
            // 
            this.purchases_supplier.DataPropertyName = "purchases_supplier";
            this.purchases_supplier.FillWeight = 250F;
            this.purchases_supplier.HeaderText = "Supplier";
            this.purchases_supplier.Name = "purchases_supplier";
            this.purchases_supplier.Width = 250;
            // 
            // purchases_price
            // 
            this.purchases_price.DataPropertyName = "purchases_price";
            this.purchases_price.FillWeight = 150F;
            this.purchases_price.HeaderText = "Price";
            this.purchases_price.Name = "purchases_price";
            this.purchases_price.Width = 150;
            // 
            // purchasesquantityDataGridViewTextBoxColumn
            // 
            this.purchasesquantityDataGridViewTextBoxColumn.DataPropertyName = "purchases_quantity";
            this.purchasesquantityDataGridViewTextBoxColumn.FillWeight = 150F;
            this.purchasesquantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.purchasesquantityDataGridViewTextBoxColumn.Name = "purchasesquantityDataGridViewTextBoxColumn";
            this.purchasesquantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // tBPurchasesBindingSource1
            // 
            this.tBPurchasesBindingSource1.DataMember = "TB_Purchases";
            this.tBPurchasesBindingSource1.DataSource = this.dB_SpicyDataSet4;
            // 
            // dB_SpicyDataSet4
            // 
            this.dB_SpicyDataSet4.DataSetName = "DB_SpicyDataSet4";
            this.dB_SpicyDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel2.Controls.Add(this.edit_search);
            this.panel2.Controls.Add(this.button_search);
            this.panel2.Controls.Add(this.btn_refresh);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 570);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 100);
            this.panel2.TabIndex = 0;
            // 
            // edit_search
            // 
            this.edit_search.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.edit_search.Font = new System.Drawing.Font("Cairo SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_search.Location = new System.Drawing.Point(399, 26);
            this.edit_search.Name = "edit_search";
            this.edit_search.Size = new System.Drawing.Size(343, 42);
            this.edit_search.TabIndex = 19;
            this.edit_search.TextChanged += new System.EventHandler(this.edit_search_TextChanged);
            // 
            // button_search
            // 
            this.button_search.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_search.Appearance.Font = new System.Drawing.Font("Cairo SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.Appearance.Options.UseFont = true;
            this.button_search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_search.ImageOptions.Image")));
            this.button_search.Location = new System.Drawing.Point(738, 26);
            this.button_search.Name = "button_search";
            this.button_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_search.Size = new System.Drawing.Size(44, 42);
            this.button_search.TabIndex = 14;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_refresh.Appearance.Font = new System.Drawing.Font("Cairo SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Appearance.Options.UseFont = true;
            this.btn_refresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.ImageOptions.Image")));
            this.btn_refresh.Location = new System.Drawing.Point(127, 15);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_refresh.Size = new System.Drawing.Size(102, 67);
            this.btn_refresh.TabIndex = 15;
            this.btn_refresh.Text = "تحديث";
            this.btn_refresh.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Cairo SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.Location = new System.Drawing.Point(19, 15);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_delete.Size = new System.Drawing.Size(102, 67);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.Text = "حذف";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.Appearance.Font = new System.Drawing.Font("Cairo SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.Location = new System.Drawing.Point(-90, 15);
            this.btn_add.Name = "btn_add";
            this.btn_add.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_add.Size = new System.Drawing.Size(102, 67);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "اضافة";
            this.btn_add.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // tBSupplierBindingSource
            // 
            this.tBSupplierBindingSource.DataMember = "TB_Supplier";
            this.tBSupplierBindingSource.DataSource = this.dB_SpicyDataSet2;
            // 
            // dB_SpicyDataSet2
            // 
            this.dB_SpicyDataSet2.DataSetName = "DB_SpicyDataSet2";
            this.dB_SpicyDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBCatBindingSource
            // 
            this.tBCatBindingSource.DataMember = "TB_Cat";
            this.tBCatBindingSource.DataSource = this.dBSpicyDataSetBindingSource;
            // 
            // dBSpicyDataSetBindingSource
            // 
            this.dBSpicyDataSetBindingSource.DataSource = this.dB_SpicyDataSet;
            this.dBSpicyDataSetBindingSource.Position = 0;
            // 
            // dB_SpicyDataSet
            // 
            this.dB_SpicyDataSet.DataSetName = "DB_SpicyDataSet";
            this.dB_SpicyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tB_CatTableAdapter
            // 
            this.tB_CatTableAdapter.ClearBeforeFill = true;
            // 
            // tBCatBindingSource1
            // 
            this.tBCatBindingSource1.DataMember = "TB_Cat";
            this.tBCatBindingSource1.DataSource = this.dBSpicyDataSetBindingSource;
            // 
            // dB_SpicyDataSet1
            // 
            this.dB_SpicyDataSet1.DataSetName = "DB_SpicyDataSet1";
            this.dB_SpicyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBCatBindingSource2
            // 
            this.tBCatBindingSource2.DataMember = "TB_Cat";
            this.tBCatBindingSource2.DataSource = this.dB_SpicyDataSet1;
            // 
            // tB_CatTableAdapter1
            // 
            this.tB_CatTableAdapter1.ClearBeforeFill = true;
            // 
            // tB_SupplierTableAdapter
            // 
            this.tB_SupplierTableAdapter.ClearBeforeFill = true;
            // 
            // dB_SpicyDataSet3
            // 
            this.dB_SpicyDataSet3.DataSetName = "DB_SpicyDataSet3";
            this.dB_SpicyDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBPurchasesBindingSource
            // 
            this.tBPurchasesBindingSource.DataMember = "TB_Purchases";
            this.tBPurchasesBindingSource.DataSource = this.dB_SpicyDataSet3;
            // 
            // tB_PurchasesTableAdapter
            // 
            this.tB_PurchasesTableAdapter.ClearBeforeFill = true;
            // 
            // tB_PurchasesTableAdapter1
            // 
            this.tB_PurchasesTableAdapter1.ClearBeforeFill = true;
            // 
            // FRM_purshases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 60F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 670);
            this.Controls.Add(this.pn_pur);
            this.Font = new System.Drawing.Font("Cairo SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 14, 8, 14);
            this.Name = "FRM_purshases";
            this.Text = "FRM_cat";
            this.Load += new System.EventHandler(this.FRM_cat_Load);
            this.pn_pur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPurchasesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SpicyDataSet4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SpicyDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSpicyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SpicyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCatBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SpicyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCatBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SpicyDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPurchasesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pn_pur;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton button_search;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        public DevExpress.XtraEditors.SimpleButton btn_refresh;
        private System.Windows.Forms.BindingSource dBSpicyDataSetBindingSource;
        private DB_SpicyDataSet dB_SpicyDataSet;
        private System.Windows.Forms.BindingSource tBCatBindingSource;
        private DB_SpicyDataSetTableAdapters.TB_CatTableAdapter tB_CatTableAdapter;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox edit_search;
        private System.Windows.Forms.BindingSource tBCatBindingSource1;
        private DB_SpicyDataSet1 dB_SpicyDataSet1;
        private System.Windows.Forms.BindingSource tBCatBindingSource2;
        private DB_SpicyDataSet1TableAdapters.TB_CatTableAdapter tB_CatTableAdapter1;
        private DB_SpicyDataSet2 dB_SpicyDataSet2;
        private System.Windows.Forms.BindingSource tBSupplierBindingSource;
        private DB_SpicyDataSet2TableAdapters.TB_SupplierTableAdapter tB_SupplierTableAdapter;
        private DB_SpicyDataSet3 dB_SpicyDataSet3;
        private System.Windows.Forms.BindingSource tBPurchasesBindingSource;
        private DB_SpicyDataSet3TableAdapters.TB_PurchasesTableAdapter tB_PurchasesTableAdapter;
        private DB_SpicyDataSet4 dB_SpicyDataSet4;
        private System.Windows.Forms.BindingSource tBPurchasesBindingSource1;
        private DB_SpicyDataSet4TableAdapters.TB_PurchasesTableAdapter tB_PurchasesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchases_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchases_supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchases_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasesquantityDataGridViewTextBoxColumn;
    }
}