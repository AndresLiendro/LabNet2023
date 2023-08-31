namespace labNetPractica3.EF.UI
{
    partial class Principal
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnCustomers = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnOrders = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnCustomers,
            this.toolStripBtnOrders});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(800, 44);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnCustomers
            // 
            this.toolStripBtnCustomers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnCustomers.Image = global::labNetPractica3.EF.UI.Properties.Resources.descarga__1_;
            this.toolStripBtnCustomers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripBtnCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCustomers.Name = "toolStripBtnCustomers";
            this.toolStripBtnCustomers.Size = new System.Drawing.Size(93, 41);
            this.toolStripBtnCustomers.Text = "Customers ";
            this.toolStripBtnCustomers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripBtnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnCustomers.Click += new System.EventHandler(this.toolStripBtnCustomers_Click);
            // 
            // toolStripBtnOrders
            // 
            this.toolStripBtnOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnOrders.Image = global::labNetPractica3.EF.UI.Properties.Resources.descarga__2_;
            this.toolStripBtnOrders.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripBtnOrders.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnOrders.Name = "toolStripBtnOrders";
            this.toolStripBtnOrders.Size = new System.Drawing.Size(62, 41);
            this.toolStripBtnOrders.Text = "Orders";
            this.toolStripBtnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnOrders.ToolTipText = "Orders";
            this.toolStripBtnOrders.Click += new System.EventHandler(this.toolStripBtnOrders_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::labNetPractica3.EF.UI.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnCustomers;
        private System.Windows.Forms.ToolStripButton toolStripBtnOrders;
    }
}

