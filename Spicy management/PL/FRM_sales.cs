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
    public partial class FRM_sales : Form
    {
        DB_SpicyEntities3 db = new DB_SpicyEntities3();
        string txt_search;
        List<TB_Products> listProducts;
        //FRM_settings frm_set = new FRM_settings();

        public FRM_sales()
        {
            InitializeComponent();
            listProducts = db.TB_Products.ToList();
        }

        private void FRM_sales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SpicyDataSet18.TB_Products' table. You can move, or remove it, as needed.
            this.tB_ProductsTableAdapter3.Fill(this.dB_SpicyDataSet18.TB_Products);
            // TODO: This line of code loads data into the 'dB_SpicyDataSet17.TB_basket' table. You can move, or remove it, as needed.
            this.tB_basketTableAdapter.Fill(this.dB_SpicyDataSet17.TB_basket);
            // TODO: This line of code loads data into the 'dB_SpicyDataSet9.TB_Products' table. You can move, or remove it, as needed.
            this.tB_ProductsTableAdapter2.Fill(this.dB_SpicyDataSet9.TB_Products);
            // TODO: This line of code loads data into the 'dB_SpicyDataSet16.TB_Products' table. You can move, or remove it, as needed.
            this.tB_ProductsTableAdapter1.Fill(this.dB_SpicyDataSet16.TB_Products);
            // TODO: This line of code loads data into the 'dB_SpicyDataSet15.TB_Products' table. You can move, or remove it, as needed.
            this.tB_ProductsTableAdapter.Fill(this.dB_SpicyDataSet15.TB_Products);

            billNum.Text = (billNumber).ToString();
            
            for (int i = 0; i < listProducts.Count(); i++)
            {


                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = listProducts[i].product_name;
                listViewItem.SubItems.Add(listProducts[i].product_price.ToString());
                listViewItem.SubItems.Add(listProducts[i].id.ToString());
                listViewItem.Tag = listProducts[i];


                listView1.Items.Add(listViewItem);



            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            txt_search = edit_search.Text;

            if (txt_search != "")
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.Text.ToLower().Contains(txt_search.ToLower()))
                    {
                        item.Selected = true;
                    }
                    else
                    {
                        listView1.Items.Remove(item);
                    }

                }
                if (listView1.SelectedItems.Count == 1)
                {
                    listView1.Focus();
                }
            }
        }

        private void refresh(object sender, EventArgs e)
        {

            txt_search = "";
            for (int i = 0; i < listProducts.Count(); i++)
            {


                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = listProducts[i].product_name;
                listViewItem.SubItems.Add(listProducts[i].product_price.ToString());
                listViewItem.SubItems.Add(listProducts[i].id.ToString());
                listViewItem.Tag = listProducts[i];

                listView1.Items.Add(listViewItem);



            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                EPL.Dialog dialog = new EPL.Dialog();
                dialog.Width = this.Width;
                dialog.txt_message.Text = "يجب ادخال أرقام فقط";
                dialog.Show();
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
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


        //calculate total
        void calculateTotal()
        {
            decimal total = 0;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                //total +=  decimal.Parse(dataGridView1.Rows.);
                total += decimal.Parse(dataGridView1.Rows[i].Cells["Total"].Value.ToString());


            }
            totalTextPrice.Text = total.ToString();
            double x = double.Parse(total.ToString());
            totalAfterTax.Text = (total + (total * 0.15M).ToString());

        }//end of calculate TotalPrice

        public static int billNumber = 1;

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                var product = (TB_Products)listView1.SelectedItems[0].Tag;
                dataGridView1.Rows.Add(product.product_name, product.product_price, textBox1.Text, int.Parse(textBox1.Text) * int.Parse(product.product_price.ToString()));


            }
            calculateTotal();


        }

        private void newBill_Click(object sender, EventArgs e)
        {
            //set bill number 
            billNum.Text = (billNumber++).ToString();

            //reset Total and Total after Taxes
            totalTextPrice.Text = "0";
            totalAfterTax.Text = "0" ;

            //removing data grid
            dataGridView1.Rows.Clear();
        }

        private void button_editprice_Click(object sender, EventArgs e)
        {
            totalTextPrice.Text = edit_price.Text;
            totalAfterTax.Text = (Convert.ToInt32(edit_price.Text) + (Convert.ToInt32(edit_price.Text) * 0.15M)).ToString();
        }


        // refreshing when delete row
        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calculateTotal();
        }

        // print button event listener
        private void print_button_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

        }



        //print method

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float margin = 25;
            Font f = new Font("Arial", 18, FontStyle.Bold);

            string strNo = "#Order Number : " + billNumber;
            string strData = "تاريخ الفاتورة"+ "\n" + dateTimePicker1.Value;
            string strName = "اسم العميل" + "\n" + customer_name.Text;

            SizeF fontSizeNo = e.Graphics.MeasureString(strNo, f);
            SizeF fontSizeNo2 = e.Graphics.MeasureString(strData, f);
            SizeF fontSizeNo3 = e.Graphics.MeasureString(strName, f);

            e.Graphics.DrawImage(Properties.Resources.chilli_logo2, margin, margin, 200, 200);
            e.Graphics.DrawString(strNo, f, Brushes.Red, (e.PageBounds.Width - fontSizeNo.Width) / 2, margin);
            e.Graphics.DrawString(strData, f, Brushes.Black, (e.PageBounds.Width - fontSizeNo2.Width - margin), margin + fontSizeNo.Height + 20);
            e.Graphics.DrawString(strName, f, Brushes.Navy, (e.PageBounds.Width - fontSizeNo3.Width - margin), margin + fontSizeNo.Height + fontSizeNo2.Height + 20);

            //drawing Rectanagle
            float preHeights = margin + fontSizeNo.Height + fontSizeNo2.Height + fontSizeNo3.Height + 115;

            e.Graphics.DrawRectangle(Pens.Black, margin, preHeights, e.PageBounds.Width - margin * 2, e.PageBounds.Height - margin - preHeights);



            //drawing colums 

            float colHeight = 50;
            float col1Width = 300;
            float col2Width = 125 + col1Width;
            float col3Width = 125 + col2Width;
            float col4Width = 150 + col3Width;

            e.Graphics.DrawLine(Pens.Black, margin, preHeights + colHeight, e.PageBounds.Width - margin, preHeights + colHeight);

            //draw strings

            /* first coluom */
            e.Graphics.DrawString(" المنتج ", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col1Width, preHeights);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col1Width, preHeights, e.PageBounds.Width - margin * 2 - col1Width, e.PageBounds.Height - margin);

            /* second coluom */
            e.Graphics.DrawString(" السعر ", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col2Width, preHeights);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col2Width, preHeights, e.PageBounds.Width - margin * 2 - col2Width, e.PageBounds.Height - margin);


            /* third coluom */
            e.Graphics.DrawString(" الكمية ", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col3Width, preHeights);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col3Width, preHeights, e.PageBounds.Width - margin * 2 - col3Width, e.PageBounds.Height - margin);

            /* last coluom */
            e.Graphics.DrawString(" اجمالي العنصر ", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col4Width, preHeights);
            //e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col4Width, preHeights, e.PageBounds.Width - margin * 2 - col4Width, e.PageBounds.Height - margin);



            // * invoice contents * //

            float rowsHeight = 50;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {

                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), f, Brushes.Navy, e.PageBounds.Width - margin * 2 - col1Width, preHeights + rowsHeight);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), f, Brushes.Navy, e.PageBounds.Width - margin * 2 - col2Width, preHeights + rowsHeight);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), f, Brushes.Navy, e.PageBounds.Width - margin * 2 - col3Width, preHeights + rowsHeight);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), f, Brushes.Navy, e.PageBounds.Width - margin * 2 - col4Width, preHeights + rowsHeight);

                e.Graphics.DrawLine(Pens.Black, margin, preHeights + rowsHeight, e.PageBounds.Width - margin, preHeights + rowsHeight);

                rowsHeight += 60;

            }
            e.Graphics.DrawLine(Pens.Black, margin, preHeights + rowsHeight, e.PageBounds.Width - margin, preHeights + rowsHeight);

            //invoice total
            e.Graphics.DrawString(" الاجمالي  ", f, Brushes.Olive, e.PageBounds.Width - margin * 2 - col3Width, preHeights + rowsHeight);
            e.Graphics.DrawString(totalTextPrice.Text, f, Brushes.Olive, e.PageBounds.Width - margin * 2 - col4Width, preHeights + rowsHeight);
            e.Graphics.DrawLine(Pens.Black, margin, preHeights + rowsHeight, e.PageBounds.Width - margin, preHeights + rowsHeight);


            //invoice total with taxes
            e.Graphics.DrawString(" الاجمالي \n بالضريبة ", f, Brushes.Red, e.PageBounds.Width - margin * 2 - col3Width, preHeights + rowsHeight + 50);
            e.Graphics.DrawString(totalAfterTax.Text, f, Brushes.Red, e.PageBounds.Width - margin * 2 - col4Width, preHeights + rowsHeight + 50);
            //e.Graphics.DrawLine(Pens.Black, margin, preHeights + rowsHeight, e.PageBounds.Width - margin, preHeights + rowsHeight);
        }





    }
}
