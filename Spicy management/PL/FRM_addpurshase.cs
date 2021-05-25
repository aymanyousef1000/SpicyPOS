using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spicy_management.EPL;
using System.IO;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace Spicy_management.PL
{
    public partial class FRM_addpurshase : Form
    {

        DB_SpicyEntities3 db = new DB_SpicyEntities3();
        PL.FRM_cat frm = new PL.FRM_cat();
        PL.FRM_purshases frm_pur = new PL.FRM_purshases();
        TB_Cat tb_cat = new TB_Cat();
        TB_Purchases tb_purshase = new TB_Purchases();
        BL.methods methods = new BL.methods();

        public Dialog dialog = new Dialog();

        public static int id = 0;
        public string imagePath;

        public FRM_addpurshase()
        {
            InitializeComponent();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_addcat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SpicyDataSet2.TB_Supplier' table. You can move, or remove it, as needed.
            this.tB_SupplierTableAdapter.Fill(this.dB_SpicyDataSet2.TB_Supplier);

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            try
            {
                if (edit_name.Text != "")
                {
                    tb_purshase.purchases_name = edit_name.Text;
                    if(edit_price.Text != "") {
                        tb_purshase.purchases_price = Convert.ToDecimal(edit_price.Text);
                    }
                    else { tb_purshase.purchases_price = 0;  }
                    
                    tb_purshase.purchases_supplier = edit_combo.Text;
                    if(edit_quan.Text != "") {
                        tb_purshase.purchases_quantity = Convert.ToInt32(edit_quan.Text);
                    } else {
                        tb_purshase.purchases_quantity = 1;
                    }
                    
                    db.TB_Purchases.Add(tb_purshase);
                    db.SaveChanges();

                    Toast newToast = new Toast();
                    newToast.txt_caption.Text = "تم الحفظ";
                    newToast.Show();

                    db = new DB_SpicyEntities3();
                    frm_pur.dataGridView1.DataSource = db.TB_Purchases.ToList();
                    edit_name.Text = "";
                    this.Close();
                }
                else
                {
                    Dialog dialog = new Dialog();
                    dialog.Width = this.Width;
                    dialog.txt_message.Text = "يجب ادخال أسم الصنف";
                    dialog.Show();
                }
            }
            catch
            {
                Dialog dialog = new Dialog();
                dialog.Width = this.Width;
                dialog.txt_message.Text = "يجب ادخال أسم الصنف";
                dialog.Show();
            }

            //private void pictureBox1_Click(object sender, EventArgs e)
            //{
            //    //OpenFileDialog ofd = new OpenFileDialog();
            //    //if (ofd.ShowDialog() == DialogResult.OK)
            //    //{
            //    //    imagePath = ofd.FileName;
            //    //    pictureBox1.ImageLocation = ofd.FileName;
            //    //}

            //}
        }

        private void edit_price_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(edit_price.Text, "[^0-9]"))
            {
                Dialog dialog = new Dialog();
                dialog.Width = this.Width;
                dialog.txt_message.Text = "يجب ادخال أرقام فقط";
                dialog.Show();
                edit_price.Text = edit_price.Text.Remove(edit_price.Text.Length - 1);
            }
        }

        private void edit_quan_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(edit_quan.Text, "[^0-9]"))
            {
                Dialog dialog = new Dialog();
                dialog.Width = this.Width;
                dialog.txt_message.Text = "يجب ادخال أرقام فقط";
                dialog.Show();
                edit_quan.Text = edit_quan.Text.Remove(edit_quan.Text.Length - 1);
            }
        }
    }
}
