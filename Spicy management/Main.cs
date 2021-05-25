using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spicy_management
{
    public partial class Main : Form
    {


        int p0;
        int x;
        int y;

        PL.FRM_home frm_home = new PL.FRM_home();
        PL.FRM_cat frm_cat = new PL.FRM_cat();
        PL.FRM_suppliers frm_suppliers = new PL.FRM_suppliers();
        PL.FRM_purshases frm_purshase = new PL.FRM_purshases();
        PL.FRM_products frm_products = new PL.FRM_products();
        
        

        DB_SpicyEntities3 db = new DB_SpicyEntities3();

        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            pn_container.Controls.Clear();
            pn_container.Controls.Add(frm_home.pn_home);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_maxmize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void collapse(object sender, EventArgs e)
        {
            if (pn_navbar.Width == 250)
            {
                pn_navbar.Width= 50;
                pn_titlenav.Visible = false;
                header_nav.Height = 50; 
            }
            else
            {
                pn_navbar.Width = 250;
                pn_titlenav.Visible = true;
                header_nav.Height = 258;
            }
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            

        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
         
        }

        private void pn_top_MouseUp(object sender, MouseEventArgs e)
        {
            p0 = 0;
        }

        private void pn_top_MouseDown(object sender, MouseEventArgs e)
        {
            p0 = 1;
            x = e.X;
            y = e.Y;
        }

        private void pn_top_MouseMove(object sender, MouseEventArgs e)
        {
            if (p0 == 1)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            pn_container.Controls.Clear();
            pn_container.Controls.Add(frm_home.pn_home);
            title_label.Text = "الرئيسية";
        }

        private void pn_container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pn_top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            pn_container.Controls.Clear();
            pn_container.Controls.Add(frm_cat.pn_cat);
            db = new DB_SpicyEntities3();
            frm_cat.dataGridView1.DataSource = db.TB_Cat.ToList();
            title_label.Text = "الأصناف";
        }

        private void button_suppliers_Click(object sender, EventArgs e)
        {
            pn_container.Controls.Clear();
            pn_container.Controls.Add(frm_suppliers.pn_sup);
            db = new DB_SpicyEntities3();
            frm_suppliers.dataGridView1.DataSource = db.TB_Supplier.ToList();
            title_label.Text = "الموردين";
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            pn_container.Controls.Clear();
            pn_container.Controls.Add(frm_purshase.pn_pur);
            db = new DB_SpicyEntities3();
            frm_purshase.dataGridView1.DataSource = db.TB_Purchases.ToList();
            title_label.Text = "المشتريات";
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            pn_container.Controls.Clear();
            pn_container.Controls.Add(frm_products.pn_prod);
            db = new DB_SpicyEntities3();
            frm_products.dataGridView1.DataSource = db.TB_Products.ToList();
            title_label.Text = "المنتجات";
        }

        private void simpleButton10_Click(object sender, EventArgs e)
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

        private void simpleButton12_Click(object sender, EventArgs e)
        {
          
        }
    }
}
