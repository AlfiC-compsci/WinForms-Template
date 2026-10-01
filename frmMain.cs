using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using WinForms_Template.Retail;

namespace WinForms_Template
{
    public partial class frmMain : Form
    {
        private ProductList productList = new ProductList();

        public frmMain()
        {
            InitializeComponent();

            lvReciept.View = View.Details;
            lvReciept.FullRowSelect = true;
            lvReciept.GridLines = true;

            lvReciept.Columns.Add("Barcode");
            lvReciept.Columns.Add("Desc.");
            lvReciept.Columns.Add("Unit £");
            lvReciept.Columns.Add("Qnty");
            lvReciept.Columns.Add("Total");

            txtProduct.KeyDown += txtProductCode_KeyDown;
        }


        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void txtProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Return:
                    RecordProduct(txtProduct.Text);
                    txtProduct.Text = "";
                    break;
            }
        }
         
        private bool RecordProduct(string code)
        {
            int _quantity = 1;
            Product? _product = productList.GetProduct(code);
            if(_product == null)
            {
                //Show Error
                return false;
            }

            ListViewItem row1 = new ListViewItem(code);
            row1.SubItems.Add(_product.Value.description);
            row1.SubItems.Add(_product.Value.unitPrice.ToString());
            row1.SubItems.Add(_quantity.ToString());
            row1.SubItems.Add((_product.Value.unitPrice * _quantity).ToString());

            lvReciept.Items.Add(row1);
            return true;
        }

        private void ChangeQuantity()
        {
            string quantityValue = txtProduct.Text;
            if(int.TryParse(quantityValue, out  int quantity))
            {
               if (quantity < 1 || quantity > 100)
               {
                    //Show error message
               }
               else
               {
                   ListViewItem latestItems = lvReceipt.Items[lvReceipt.Items.Count - 1];
                   latestItems.SubItems[3].Text = quantity.ToString();
                   latestItems.SubItems[4].Text = (float.Parse(latestItems.SubItems[2].Text) * quantity).ToString();
               }
            }
            txtProduct.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeQuantity();
        }
    }
}
