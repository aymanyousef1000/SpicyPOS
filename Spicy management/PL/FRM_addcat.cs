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
    public partial class FRM_addcat : Form
    {

        DB_SpicyEntities3 db = new DB_SpicyEntities3();
        PL.FRM_cat frm = new PL.FRM_cat();
        TB_Cat tb_cat = new TB_Cat();
        BL.methods methods = new BL.methods();
        
        public Dialog dialog = new Dialog();

        public static int id =0;
        public string imagePath;

        public FRM_addcat()
        {
            InitializeComponent();
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_addcat_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (edit_name.Text != "")
                {
                    tb_cat.CAT_Name = edit_name.Text;
                    db.TB_Cat.Add(tb_cat);
                    db.SaveChanges();

                    Toast newToast = new Toast();
                    newToast.txt_caption.Text = "تم الحفظ";
                    newToast.Show();

                    db = new DB_SpicyEntities3();
                    frm.dataGridView1.DataSource = db.TB_Cat.ToList();
                    edit_name.Text = "";
                    this.Close();
                }
                else
                {
                    Dialog dialog = new Dialog();
                    dialog.Width = this.Width;
                    dialog.txt_message.Text = "يجب ادخال أسم المورد";
                    dialog.Show();
                }



                //else if(btn_add.Text == "تعديل")
                //{
                //    //tb_cat.CAT_Name = edit_name.Text;


                //    ////db.TB_Cat.Add(tb_cat);
                //    ////db.Entry(tb_cat).State = System.Data.Entity.EntityState.Modified;
                //    //db.SaveChanges();
                //    //FRM_cat frm_cat = new FRM_cat();
                //    int id = int.Parse(frm.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                //    var result = db.TB_Cat.SingleOrDefault(x => x.id == id);
                //    result.CAT_Name = edit_name.Text;
                //    db.SaveChanges();
                //    frm.dataGridView1.DataSource = db.TB_Cat.ToList();
                //    //db = new DB_SpicyEntities3();
                //    //frm.dataGridView1.DataSource = db.TB_Cat.ToList();
                //    Toast newToast2 = new Toast();
                //    newToast2.txt_caption.Text = "تم التعديل";
                //    newToast2.Show();
                //    this.Close();
                //}
            }
            catch
            {
                Dialog dialog = new Dialog();
                dialog.Width = this.Width;
                dialog.txt_message.Text = "يجب ادخال أسم المورد";
                dialog.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();
            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    imagePath = ofd.FileName;
            //    pictureBox1.ImageLocation = ofd.FileName;
            //}

        }
    }
}
