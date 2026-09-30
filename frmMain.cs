using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using WinForms_Template.Retail;

namespace WinForms_Template
{
    public partial class frmMain : Form
    {
        private object productList;
        public frmMain()
        {
            InitializeComponent();

            lvReceipt.View = View.Details;
            lvReceipt.FullRowSelect = true;
            lvReceipt.GridLines = true;

            lvReceipt.Columns.Add("Barcode");
            lvReceipt.Columns.Add("Desc.");
            lvReceipt.Columns.Add("Unit £");
            lvReceipt.Columns.Add("Qnty");
            lvReceipt.Columns.Add("Total");

            txt_hey.KeyDown += txtProductCode_KeyDown;
        }


        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void txtProductCode_KeyDown(object sender, EventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Return:
                    RecordProduct(txtSomething.Text);
                    break;
            }
        }
         
        private void RecordProduct(string code)
        {
            int _quantity = 1;
            Product? _product = productList.GetProduct(code);
            if(_product == null)
            {
                //Show Error
                return;
            }

            ListViewItem row1 = new ListViewItem(code);
            row1.SubItems.Add(_product.Value.description);
            row1.SubItems.Add(_product.Value.unitPrice.ToString());
            row1.SubItems.Add(_quantity.ToString());
            row1.SubItems.Add((_product.Value.unitPrice * _quantity).ToString);

            lvReceipt.Items.Add(row1);
            return true;
        }

        private void ChangeQuantity()
        {
            string quantityValue = txtProduct.Text;
            if(int.TryParse(quantityValue, out quantity))
            {
               if (quantityValue < 1 || quantityValue > 100)
               {
                    //Show error message
               }
               else
               {
                   ListViewItems latestItem = lvRecipt.Items[lvRecipt.Items.Count - 1];
                   latestItem.SubItems[3].Text = quantity.ToString();
                   latestItem.SubItems[4].Text = (float.Parse(latestItem.SubItem[2].Text) * quantity).ToString();
               }
            }
            txtProduct.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeQuantity;
        }
    }
}
