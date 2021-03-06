using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Spicy_management.EPL;

namespace Spicy_management.PL
{
    public partial class FRM_purshases : Form
    {
        DB_SpicyEntities3 db = new DB_SpicyEntities3();
        TB_Cat tb_cat = new TB_Cat();
        TB_Supplier tb_suppliers = new TB_Supplier();
        //int idd;
        string txt_search;

        public FRM_purshases()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            Spicy_management.DB_SpicyEntities3 dbContext = new Spicy_management.DB_SpicyEntities3();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_Cat.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    //gridControl1.DataSource = dbContext.TB_Cat.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            PL.FRM_addpurshase frm_addpurshase = new PL.FRM_addpurshase();
            frm_addpurshase.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            update_data();
            edit_search.Text = "";
            dataGridView1.DataSource = db.TB_Purchases.Where(x => x.purchases_name.Contains("")).ToList();
        }

        private void update_data()
        {
            db = new DB_SpicyEntities3();
            dataGridView1.DataSource = db.TB_Purchases.ToList();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            
            Dialog dialog0;
            try
            {

               
                var rs = MessageBox.Show("حذف", "تاكيد الحذف", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    
                    int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    var r = db.TB_Purchases.Find(id);
                    db.TB_Purchases.Remove(r);

                    db.SaveChanges();
                    
                    Toast newToast = new Toast();
                    newToast.txt_caption.Text = "تم الحذف بنجاح";
                    newToast.Show();
                    dataGridView1.DataSource = db.TB_Purchases.ToList();
                }
            }
            catch
            {
                dialog0 = new Dialog();
                dialog0.txt_message.Text = "قم بتحديد العنصر";
                dialog0.Show();
            }


        }

        private void FRM_cat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SpicyDataSet4.TB_Purchases' table. You can move, or remove it, as needed.
            this.tB_PurchasesTableAdapter1.Fill(this.dB_SpicyDataSet4.TB_Purchases);
            // TODO: This line of code loads data into the 'dB_SpicyDataSet3.TB_Purchases' table. You can move, or remove it, as needed.
            this.tB_PurchasesTableAdapter.Fill(this.dB_SpicyDataSet3.TB_Purchases);
            // TODO: This line of code loads data into the 'dB_SpicyDataSet2.TB_Supplier' table. You can move, or remove it, as needed.
            this.tB_SupplierTableAdapter.Fill(this.dB_SpicyDataSet2.TB_Supplier);
            // TODO: This line of code loads data into the 'dB_SpicyDataSet1.TB_Cat' table. You can move, or remove it, as needed.
            this.tB_CatTableAdapter1.Fill(this.dB_SpicyDataSet1.TB_Cat);
            // TODO: This line of code loads data into the 'dB_SpicyDataSet.TB_Cat' table. You can move, or remove it, as needed.
            this.tB_CatTableAdapter.Fill(this.dB_SpicyDataSet.TB_Cat);
            // TODO: This line of code loads data into the 'dB_SpicyDataSet.TB_Cat' table. You can move, or remove it, as needed.
            this.tB_CatTableAdapter.Fill(this.dB_SpicyDataSet.TB_Cat);

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //get data from data base
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var r = db.TB_Cat.Find(id);
            PL.FRM_addcat edit = new PL.FRM_addcat();
            edit.Show();
            edit.edit_name.Text = r.CAT_Name;
            
            //edit data after getting it
            FRM_addcat addcat = new FRM_addcat();
            edit.btn_add.Text = "تعديل";
            



        }

        private void button_search_Click(object sender, EventArgs e)
        {
            txt_search = edit_search.Text;
            dataGridView1.DataSource = db.TB_Purchases.Where(x => x.purchases_name.Contains(txt_search)).ToList();

        }

        private void edit_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
