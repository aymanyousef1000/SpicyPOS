using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spicy_management.PL
{
    public partial class Add_Product : Form
    {
        PL.FRM_products frm_products = new PL.FRM_products();
        TB_Products tb_products = new TB_Products();
        DB_SpicyEntities3 db = new DB_SpicyEntities3();

        

        public Add_Product()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SpicyDataSet2.TB_Supplier' table. You can move, or remove it, as needed.
            this.tB_SupplierTableAdapter.Fill(this.dB_SpicyDataSet2.TB_Supplier);
            // TODO: This line of code loads data into the 'dB_SpicyDataSet.TB_Cat' table. You can move, or remove it, as needed.
            this.tB_CatTableAdapter.Fill(this.dB_SpicyDataSet.TB_Cat);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                if(edit_name.Text != "" && edit_price.Text != "") { 
                    tb_products.product_name = edit_name.Text;
                    tb_products.product_price = Convert.ToDecimal(edit_price.Text);
                }
                else
                {
                    EPL.Dialog dialog = new EPL.Dialog();
                    dialog.Width = this.Width;
                    dialog.txt_message.Text = "يجب ادخال أسم المنتج و سعرة";
                    dialog.Show();
                }

                if (edit_quant.Text != "")
                    {
                        tb_products.product_quantity = Convert.ToInt32(edit_quant.Text);
                    }
                    else
                    {
                        tb_products.product_quantity = 1; 
                    }       
                    tb_products.product_category = comboBox_cat.Text;
                    tb_products.product_supplier = comboBox_sup.Text;
                    if (edit_code.Text != "")
                    {
                        tb_products.product_code = Convert.ToInt32(edit_code.Text);
                    }
                    else {
                        tb_products.product_code = 0;
                    }
                    
                    db.TB_Products.Add(tb_products);
                    db.SaveChanges();

                    EPL.Toast newToast = new EPL.Toast();
                    newToast.txt_caption.Text = "تم الحفظ";
                    newToast.Show();

                    db = new DB_SpicyEntities3();
                    frm_products.dataGridView1.DataSource = db.TB_Products.ToList();
                    edit_name.Text = "";
                    this.Close();
                
            }
            catch
            {
                EPL.Dialog dialog = new EPL.Dialog();
                dialog.Width = this.Width;
                dialog.txt_message.Text = "يجب ادخال أسم الصنف و سعرة";
                dialog.Show();
            }
        }

        private void edit_price_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(edit_price.Text, "[^0-9]"))
            {
                EPL.Dialog dialog = new EPL.Dialog();
                dialog.Width = this.Width;
                dialog.txt_message.Text = "يجب ادخال أرقام فقط";
                dialog.Show();
                edit_price.Text = edit_price.Text.Remove(edit_price.Text.Length - 1);
            }
        }

        private void edit_quant_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(edit_quant.Text, "[^0-9]"))
            {
                EPL.Dialog dialog = new EPL.Dialog();
                dialog.Width = this.Width;
                dialog.txt_message.Text = "يجب ادخال أرقام فقط";
                dialog.Show();
                edit_quant.Text = edit_quant.Text.Remove(edit_quant.Text.Length - 1);
            }
        }

        private void edit_code_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(edit_code.Text, "[^0-9]"))
            {
                EPL.Dialog dialog = new EPL.Dialog();
                dialog.Width = this.Width;
                dialog.txt_message.Text = "يجب ادخال أرقام فقط";
                dialog.Show();
                edit_code.Text = edit_code.Text.Remove(edit_code.Text.Length - 1);
            }
        }
    }
}
