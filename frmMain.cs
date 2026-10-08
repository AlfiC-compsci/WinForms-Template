using System;
using System.Data.Common;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using WinForms_Template.Retail;

namespace WinForms_Template
{
    public partial class frmMain : Form
    {
        private ProductList productList = new ProductList();
        private static string dirParameter = AppDomain.CurrentDomain.BaseDirectory + @"\ReceiptFile.csv";

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
            if (_product == null)
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
            if (int.TryParse(quantityValue, out int quantity))
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

        private void txtFileBtn1_Click(object sender, EventArgs e)
        {
            SaveEvent();
        }

        private void SaveEvent()
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to save file?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question); if (result == DialogResult.No)
            {
                return;
            }
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (lvReciept.Text != null)
                    {
                        FileStream fParameter = new FileStream(dirParameter, FileMode.Create, FileAccess.Write);
                        StreamWriter m_WriterParameter = new StreamWriter(fParameter);
                        m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
                        foreach (ListViewItem Items in lvReciept.Items)
                        {
                            for (int i = 0; i < Items.SubItems.Count; i++)
                            {
                                m_WriterParameter.Write((Items.SubItems[i].Text));
                                if (i < Items.SubItems.Count - 1)
                                {
                                    m_WriterParameter.Write(",");
                                }
                            }
                            m_WriterParameter.Write("\n");
                        }
                        m_WriterParameter.Write("File writes Operation starts: ");
                        m_WriterParameter.Write("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                        m_WriterParameter.Write(lvReciept.Text);
                        m_WriterParameter.Flush();
                        m_WriterParameter.Close();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }

            }
        }


        // using (m_WriterParameter)
        //{
        //StringBuilder sb;
        //foreach (ListView item in lvReciept.Items)
        //{
        //    sb = new StringBuilder();
        //
        //    foreach (ListViewItem.ListViewSubItem listViewSubitem in lvReciept.Items)
        //    {
        //        sb.Append(string.Format("{0}\t", listViewSubitem.Text));
        //    }
        //}
        //}
    }

}  

