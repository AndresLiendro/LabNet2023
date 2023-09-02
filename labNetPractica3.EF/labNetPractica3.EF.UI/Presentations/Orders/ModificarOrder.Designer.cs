namespace labNetPractica3.EF.UI.Presentations.Orders
{
    partial class ModificarOrder
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
            this.txtRegionShip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCityShip = new System.Windows.Forms.TextBox();
            this.txtNombreShip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudOrderUpdate = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrderUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRegionShip
            // 
            this.txtRegionShip.Location = new System.Drawing.Point(121, 92);
            this.txtRegionShip.Name = "txtRegionShip";
            this.txtRegionShip.Size = new System.Drawing.Size(235, 20);
            this.txtRegionShip.TabIndex = 24;
            this.txtRegionShip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegionShip_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Region de Ship";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(97, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "*";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(226, 134);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(82, 134);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCityShip
            // 
            this.txtCityShip.Location = new System.Drawing.Point(121, 66);
            this.txtCityShip.Name = "txtCityShip";
            this.txtCityShip.Size = new System.Drawing.Size(235, 20);
            this.txtCityShip.TabIndex = 19;
            this.txtCityShip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCityShip_KeyPress);
            // 
            // txtNombreShip
            // 
            this.txtNombreShip.Location = new System.Drawing.Point(121, 40);
            this.txtNombreShip.Name = "txtNombreShip";
            this.txtNombreShip.Size = new System.Drawing.Size(235, 20);
            this.txtNombreShip.TabIndex = 18;
            this.txtNombreShip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreShip_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "City de Ship";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre Ship";
            // 
            // nudOrderUpdate
            // 
            this.nudOrderUpdate.Location = new System.Drawing.Point(285, 12);
            this.nudOrderUpdate.Name = "nudOrderUpdate";
            this.nudOrderUpdate.ReadOnly = true;
            this.nudOrderUpdate.Size = new System.Drawing.Size(71, 20);
            this.nudOrderUpdate.TabIndex = 25;
            // 
            // ModificarOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 193);
            this.Controls.Add(this.nudOrderUpdate);
            this.Controls.Add(this.txtRegionShip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCityShip);
            this.Controls.Add(this.txtNombreShip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModificarOrder";
            this.Text = "BajaOrder";
            ((System.ComponentModel.ISupportInitialize)(this.nudOrderUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegionShip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCityShip;
        private System.Windows.Forms.TextBox txtNombreShip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudOrderUpdate;
    }
}