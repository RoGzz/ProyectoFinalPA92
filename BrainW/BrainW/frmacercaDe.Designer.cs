namespace BrainW
{
    partial class frmacercaDe
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
            this.lblAcercaDe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAcercaDe
            // 
            this.lblAcercaDe.AutoSize = true;
            this.lblAcercaDe.Location = new System.Drawing.Point(28, 9);
            this.lblAcercaDe.Name = "lblAcercaDe";
            this.lblAcercaDe.Size = new System.Drawing.Size(220, 91);
            this.lblAcercaDe.TabIndex = 0;
            this.lblAcercaDe.Text = "Proyecto Final Programación de Aplicaciones\r\n\r\n\r\nVersión 1.0\r\n\r\n\r\n@ Todos los Der" +
    "echos Reservados\r\n";
            this.lblAcercaDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmacercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 116);
            this.Controls.Add(this.lblAcercaDe);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmacercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca De";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAcercaDe;
    }
}