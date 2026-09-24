using System;
using System.Windows.Forms;

namespace WinForms_Template
{
    public partial class frmMain : Form
    {
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

            txtProduct.KeyDown += txtProductCode_KeyDown;
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

            ListViewItem row1 = new ListViewItem("105");
            row1.SubItems.Add("Apples");
            row1.SubItems.Add("0.60");
            row1.SubItems.Add("5");
            row1.SubItems.Add("3.00");

            lvReceipt.Items.Add(row1);
        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {

        }
    }
}
