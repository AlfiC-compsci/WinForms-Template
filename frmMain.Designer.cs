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
            this.txtSomething = new System.Windows.Forms.TextBox();
            this.lvReceipt = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtSomething
            // 
            this.txtSomething.Location = new System.Drawing.Point(14, 12);
            this.txtSomething.Name = "txtSomething";
            this.txtSomething.Size = new System.Drawing.Size(258, 20);
            this.txtSomething.TabIndex = 0;
            // 
            // lvReceipt
            // 
            this.lvReceipt.HideSelection = false;
            this.lvReceipt.Location = new System.Drawing.Point(16, 40);
            this.lvReceipt.Name = "lvReceipt";
            this.lvReceipt.Size = new System.Drawing.Size(461, 203);
            this.lvReceipt.TabIndex = 1;
            this.lvReceipt.UseCompatibleStateImageBehavior = false;
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(489, 261);
            this.Controls.Add(this.lvReceipt);
            this.Controls.Add(this.txtSomething);
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSomething;
        private System.Windows.Forms.ListView lvReceipt;
    }
}

