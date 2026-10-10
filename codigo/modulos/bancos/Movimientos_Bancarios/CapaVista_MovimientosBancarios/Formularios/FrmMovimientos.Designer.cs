namespace CapaVista_MovimientosBancarios.Formularios
{
    partial class FrmMovimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMovimientos));
            this.BancosPnlMovimientos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BancosPnlMovimientos.SuspendLayout();
            this.SuspendLayout();
            // 
            // BancosPnlMovimientos
            // 
            this.BancosPnlMovimientos.BackColor = System.Drawing.Color.Transparent;
            this.BancosPnlMovimientos.BackgroundImage = global::CapaVista_MovimientosBancarios.Properties.Resources.movbac_contenedor1;
            this.BancosPnlMovimientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BancosPnlMovimientos.Controls.Add(this.label1);
            this.BancosPnlMovimientos.Location = new System.Drawing.Point(0, 0);
            this.BancosPnlMovimientos.Name = "BancosPnlMovimientos";
            this.BancosPnlMovimientos.Size = new System.Drawing.Size(737, 608);
            this.BancosPnlMovimientos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movimientos xd";
            // 
            // FrmMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 608);
            this.Controls.Add(this.BancosPnlMovimientos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMovimientos";
            this.Text = "Movimientos";
            this.BancosPnlMovimientos.ResumeLayout(false);
            this.BancosPnlMovimientos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel BancosPnlMovimientos;
    }
}