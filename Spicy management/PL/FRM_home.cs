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
    public partial class FRM_home : Form
    {
        //PL.FRM_home frm_home = new PL.FRM_home();
        PL.FRM_cat frm_cat = new PL.FRM_cat();
        PL.FRM_suppliers frm_suppliers = new PL.FRM_suppliers();
        PL.FRM_purshases frm_purshase = new PL.FRM_purshases();
        PL.FRM_products frm_products = new PL.FRM_products();
        PL.FRM_sales frm_sales = new PL.FRM_sales();

        DB_SpicyEntities3 db = new DB_SpicyEntities3();

        public FRM_home()
        {
            InitializeComponent();

            //salesNum.Text = (frm_sales.billNum.Text);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {


        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        {
            PL.FRM_addsupplier frm_addsupplier = new PL.FRM_addsupplier();
            frm_addsupplier.Show();
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            PL.Add_Product frm_addprod = new PL.Add_Product();
            frm_addprod.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();

            main.pn_container.Controls.Clear();
            main.pn_container.Controls.Add(frm_cat.pn_cat);
            db = new DB_SpicyEntities3();
            frm_cat.dataGridView1.DataSource = db.TB_Cat.ToList();
            main.title_label.Text = "الأصناف";

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            PL.FRM_addcat frm_addcat = new PL.FRM_addcat();
            frm_addcat.Show();
        }

       


        

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();

            main.pn_container.Controls.Clear();
            main.pn_container.Controls.Add(frm_suppliers.pn_sup);
            db = new DB_SpicyEntities3();
            frm_suppliers.dataGridView1.DataSource = db.TB_Supplier.ToList();
            main.title_label.Text = "الموردين";
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            PL.FRM_addpurshase frm_addpurshase = new PL.FRM_addpurshase();
            frm_addpurshase.Show();
        }

      

        private void purshase_click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();

            main.pn_container.Controls.Clear();
            main.pn_container.Controls.Add(frm_purshase.pn_pur);
            db = new DB_SpicyEntities3();
            frm_purshase.dataGridView1.DataSource = db.TB_Purchases.ToList();
            main.title_label.Text = "المشتريات";
        }

        private void products_click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();

            main.pn_container.Controls.Clear();
            main.pn_container.Controls.Add(frm_products.pn_prod);
            db = new DB_SpicyEntities3();
            frm_products.dataGridView1.DataSource = db.TB_Products.ToList();
            main.title_label.Text = "المنتجات";
        }

        private void simpleButton5_Click_1(object sender, EventArgs e)
        {
            try
            {
                PL.FRM_sales frm_sales = new PL.FRM_sales();
                frm_sales.Show();
            }
            catch
            {
                PL.FRM_sales frm_sales2 = new PL.FRM_sales();
                frm_sales2.Show();
            }
        }

        private void toSales(object sender, EventArgs e)
        {
            try
            {
                PL.FRM_sales frm_sales = new PL.FRM_sales();
                frm_sales.Show();
            }
            catch
            {
                PL.FRM_sales frm_sales2 = new PL.FRM_sales();
                frm_sales2.Show();
            }
        }

        private void toSettings(object sender, EventArgs e)
        {

          
        }
    }
}
