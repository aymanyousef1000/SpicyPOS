using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spicy_management.EPL
{
    public partial class FRM_login : Form
    {
        DB_SpicyEntities3 db = new DB_SpicyEntities3();

        public FRM_login()
        {
            InitializeComponent();
        }


        private void openForm()
        {

            Application.Run(new Main());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var result = db.TB_users.Where(x => x.user_name == edit_username.Text && x.password == edit_password.Text).ToList();

            if (result.Count() > 0)
            {


                this.Close();
                Thread th = new Thread(openForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                MessageBox.Show("خطا بكلمه المرور او اسم المستخدم");
            }
        }
    }
}
