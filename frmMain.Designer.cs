namespace WinForms_Template
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.lvReciept = new System.Windows.Forms.ListView();
            this.txtFileBtn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(12, 12);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(100, 20);
            this.txtProduct.TabIndex = 0;
            // 
            // lvReciept
            // 
            this.lvReciept.HideSelection = false;
            this.lvReciept.Location = new System.Drawing.Point(12, 38);
            this.lvReciept.Name = "lvReciept";
            this.lvReciept.Size = new System.Drawing.Size(349, 161);
            this.lvReciept.TabIndex = 1;
            this.lvReciept.UseCompatibleStateImageBehavior = false;
            // 
            // txtFileBtn1
            // 
            this.txtFileBtn1.Location = new System.Drawing.Point(206, 12);
            this.txtFileBtn1.Name = "txtFileBtn1";
            this.txtFileBtn1.Size = new System.Drawing.Size(155, 23);
            this.txtFileBtn1.TabIndex = 2;
            this.txtFileBtn1.Text = "Click to turn into a text file";
            this.txtFileBtn1.UseVisualStyleBackColor = true;
            this.txtFileBtn1.Click += new System.EventHandler(this.txtFileBtn1_Click);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(747, 527);
            this.Controls.Add(this.txtFileBtn1);
            this.Controls.Add(this.lvReciept);
            this.Controls.Add(this.txtProduct);
            this.Name = "frmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSomething;
        private System.Windows.Forms.ListView lvReceipt;
        private System.Windows.Forms.TextBox txt_hey;
        private System.Windows.Forms.ListView lvRecieve;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.ListView lvReciept;
        private System.Windows.Forms.Button txtFileBtn1;
    }
}

