namespace Spicy_management.PL
{
    partial class FRM_addpurshase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_addpurshase));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.edit_name = new System.Windows.Forms.TextBox();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.edit_price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edit_combo = new System.Windows.Forms.ComboBox();
            this.tBSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_SpicyDataSet2 = new Spicy_management.DB_SpicyDataSet2();
            this.tB_SupplierTableAdapter = new Spicy_management.DB_SpicyDataSet2TableAdapters.TB_SupplierTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.edit_quan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tBSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SpicyDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(486, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(34, 27);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(190, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 50);
            this.label3.TabIndex = 3;
            this.label3.Text = "أسم الصنف";
            // 
            // edit_name
            // 
            this.edit_name.Font = new System.Drawing.Font("Cairo SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_name.Location = new System.Drawing.Point(100, 123);
            this.edit_name.Name = "edit_name";
            this.edit_name.Size = new System.Drawing.Size(332, 43);
            this.edit_name.TabIndex = 4;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.Appearance.Font = new System.Drawing.Font("Cairo SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.Location = new System.Drawing.Point(418, 551);
            this.btn_add.Name = "btn_add";
            this.btn_add.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_add.Size = new System.Drawing.Size(102, 67);
            this.btn_add.TabIndex = 19;
            this.btn_add.Text = "اضافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(222, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "السعر";
            // 
            // edit_price
            // 
            this.edit_price.Font = new System.Drawing.Font("Cairo SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_price.Location = new System.Drawing.Point(100, 240);
            this.edit_price.Name = "edit_price";
            this.edit_price.Size = new System.Drawing.Size(332, 43);
            this.edit_price.TabIndex = 4;
            this.edit_price.TextChanged += new System.EventHandler(this.edit_price_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(192, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "أسم المورد";
            // 
            // edit_combo
            // 
            this.edit_combo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tBSupplierBindingSource, "Supplier_Name", true));
            this.edit_combo.DataSource = this.tBSupplierBindingSource;
            this.edit_combo.DisplayMember = "Supplier_Name";
            this.edit_combo.Font = new System.Drawing.Font("Cairo SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_combo.FormattingEnabled = true;
            this.edit_combo.Location = new System.Drawing.Point(100, 357);
            this.edit_combo.Name = "edit_combo";
            this.edit_combo.Size = new System.Drawing.Size(332, 47);
            this.edit_combo.TabIndex = 22;
            this.edit_combo.ValueMember = "Supplier_Name";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(215, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 50);
            this.label4.TabIndex = 3;
            this.label4.Text = "الكمية";
            // 
            // edit_quan
            // 
            this.edit_quan.Font = new System.Drawing.Font("Cairo SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_quan.Location = new System.Drawing.Point(100, 478);
            this.edit_quan.Name = "edit_quan";
            this.edit_quan.Size = new System.Drawing.Size(332, 43);
            this.edit_quan.TabIndex = 4;
            this.edit_quan.TextChanged += new System.EventHandler(this.edit_quan_TextChanged);
            // 
            // FRM_addpurshase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(532, 630);
            this.Controls.Add(this.edit_combo);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.edit_quan);
            this.Controls.Add(this.edit_price);
            this.Controls.Add(this.edit_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.simpleButton1);
            this.Font = new System.Drawing.Font("Cairo SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.Name = "FRM_addpurshase";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FRM_addcat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SpicyDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label3;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        public System.Windows.Forms.TextBox edit_name;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox edit_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox edit_combo;
        private DB_SpicyDataSet2 dB_SpicyDataSet2;
        private System.Windows.Forms.BindingSource tBSupplierBindingSource;
        private DB_SpicyDataSet2TableAdapters.TB_SupplierTableAdapter tB_SupplierTableAdapter;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox edit_quan;
    }
}