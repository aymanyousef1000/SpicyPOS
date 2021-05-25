namespace Spicy_management.PL
{
    partial class Add_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Product));
            this.label3 = new System.Windows.Forms.Label();
            this.edit_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edit_price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edit_quant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edit_code = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.comboBox_cat = new System.Windows.Forms.ComboBox();
            this.tBCatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_SpicyDataSet = new Spicy_management.DB_SpicyDataSet();
            this.tB_CatTableAdapter = new Spicy_management.DB_SpicyDataSetTableAdapters.TB_CatTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_sup = new System.Windows.Forms.ComboBox();
            this.tBSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_SpicyDataSet2 = new Spicy_management.DB_SpicyDataSet2();
            this.tB_SupplierTableAdapter = new Spicy_management.DB_SpicyDataSet2TableAdapters.TB_SupplierTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tBCatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SpicyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SpicyDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(192, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 50);
            this.label3.TabIndex = 4;
            this.label3.Text = "أسم المنتج";
            // 
            // edit_name
            // 
            this.edit_name.Font = new System.Drawing.Font("Cairo SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_name.Location = new System.Drawing.Point(100, 93);
            this.edit_name.Name = "edit_name";
            this.edit_name.Size = new System.Drawing.Size(332, 43);
            this.edit_name.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(222, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "السعر";
            // 
            // edit_price
            // 
            this.edit_price.Font = new System.Drawing.Font("Cairo SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_price.Location = new System.Drawing.Point(100, 192);
            this.edit_price.Name = "edit_price";
            this.edit_price.Size = new System.Drawing.Size(332, 43);
            this.edit_price.TabIndex = 5;
            this.edit_price.TextChanged += new System.EventHandler(this.edit_price_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(215, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "الكمية";
            // 
            // edit_quant
            // 
            this.edit_quant.Font = new System.Drawing.Font("Cairo SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_quant.Location = new System.Drawing.Point(100, 291);
            this.edit_quant.Name = "edit_quant";
            this.edit_quant.Size = new System.Drawing.Size(332, 43);
            this.edit_quant.TabIndex = 5;
            this.edit_quant.TextChanged += new System.EventHandler(this.edit_quant_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(217, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 50);
            this.label4.TabIndex = 4;
            this.label4.Text = "الصنف";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(224, 545);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 50);
            this.label5.TabIndex = 4;
            this.label5.Text = "الكود";
            // 
            // edit_code
            // 
            this.edit_code.Font = new System.Drawing.Font("Cairo SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_code.Location = new System.Drawing.Point(100, 598);
            this.edit_code.Name = "edit_code";
            this.edit_code.Size = new System.Drawing.Size(332, 43);
            this.edit_code.TabIndex = 5;
            this.edit_code.TextChanged += new System.EventHandler(this.edit_code_TextChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Cairo SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(486, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(34, 27);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.Appearance.Font = new System.Drawing.Font("Cairo SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.Location = new System.Drawing.Point(418, 663);
            this.btn_add.Name = "btn_add";
            this.btn_add.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_add.Size = new System.Drawing.Size(102, 67);
            this.btn_add.TabIndex = 20;
            this.btn_add.Text = "اضافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // comboBox_cat
            // 
            this.comboBox_cat.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tBCatBindingSource, "CAT_Name", true));
            this.comboBox_cat.DataSource = this.tBCatBindingSource;
            this.comboBox_cat.DisplayMember = "CAT_Name";
            this.comboBox_cat.Font = new System.Drawing.Font("Cairo SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_cat.FormattingEnabled = true;
            this.comboBox_cat.Location = new System.Drawing.Point(100, 392);
            this.comboBox_cat.Name = "comboBox_cat";
            this.comboBox_cat.Size = new System.Drawing.Size(332, 47);
            this.comboBox_cat.TabIndex = 21;
            this.comboBox_cat.ValueMember = "CAT_Name";
            this.comboBox_cat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tBCatBindingSource
            // 
            this.tBCatBindingSource.DataMember = "TB_Cat";
            this.tBCatBindingSource.DataSource = this.dB_SpicyDataSet;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cairo SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(219, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 50);
            this.label6.TabIndex = 4;
            this.label6.Text = "المورد";
            // 
            // comboBox_sup
            // 
            this.comboBox_sup.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tBSupplierBindingSource, "Supplier_Name", true));
            this.comboBox_sup.DataSource = this.tBSupplierBindingSource;
            this.comboBox_sup.DisplayMember = "Supplier_Name";
            this.comboBox_sup.Font = new System.Drawing.Font("Cairo SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_sup.FormattingEnabled = true;
            this.comboBox_sup.Location = new System.Drawing.Point(102, 495);
            this.comboBox_sup.Name = "comboBox_sup";
            this.comboBox_sup.Size = new System.Drawing.Size(332, 47);
            this.comboBox_sup.TabIndex = 21;
            this.comboBox_sup.ValueMember = "Supplier_Name";
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
            // tB_SupplierTableAdapter
            // 
            this.tB_SupplierTableAdapter.ClearBeforeFill = true;
            // 
            // Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 742);
            this.Controls.Add(this.comboBox_sup);
            this.Controls.Add(this.comboBox_cat);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.edit_code);
            this.Controls.Add(this.edit_quant);
            this.Controls.Add(this.edit_price);
            this.Controls.Add(this.edit_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Product";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Product";
            this.Load += new System.EventHandler(this.Add_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBCatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SpicyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SpicyDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox edit_name;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox edit_price;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox edit_quant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox edit_code;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        private System.Windows.Forms.ComboBox comboBox_cat;
        private DB_SpicyDataSet dB_SpicyDataSet;
        private System.Windows.Forms.BindingSource tBCatBindingSource;
        private DB_SpicyDataSetTableAdapters.TB_CatTableAdapter tB_CatTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_sup;
        private DB_SpicyDataSet2 dB_SpicyDataSet2;
        private System.Windows.Forms.BindingSource tBSupplierBindingSource;
        private DB_SpicyDataSet2TableAdapters.TB_SupplierTableAdapter tB_SupplierTableAdapter;
    }
}