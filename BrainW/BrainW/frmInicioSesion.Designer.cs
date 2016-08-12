namespace BrainW
{
    partial class frmInicioSesion
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
            this.txtB_Usuario = new System.Windows.Forms.TextBox();
            this.txtB_Contraseña = new System.Windows.Forms.TextBox();
            this.bttn_Aceptar = new System.Windows.Forms.Button();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtB_Usuario
            // 
            this.txtB_Usuario.Location = new System.Drawing.Point(92, 87);
            this.txtB_Usuario.Name = "txtB_Usuario";
            this.txtB_Usuario.Size = new System.Drawing.Size(100, 20);
            this.txtB_Usuario.TabIndex = 0;
            // 
            // txtB_Contraseña
            // 
            this.txtB_Contraseña.Location = new System.Drawing.Point(92, 134);
            this.txtB_Contraseña.Name = "txtB_Contraseña";
            this.txtB_Contraseña.PasswordChar = '*';
            this.txtB_Contraseña.Size = new System.Drawing.Size(100, 20);
            this.txtB_Contraseña.TabIndex = 1;
            // 
            // bttn_Aceptar
            // 
            this.bttn_Aceptar.Location = new System.Drawing.Point(105, 169);
            this.bttn_Aceptar.Name = "bttn_Aceptar";
            this.bttn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.bttn_Aceptar.TabIndex = 2;
            this.bttn_Aceptar.Text = "Aceptar";
            this.bttn_Aceptar.UseVisualStyleBackColor = true;
            this.bttn_Aceptar.Click += new System.EventHandler(this.bttn_Aceptar_Click);
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(121, 68);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_Usuario.TabIndex = 3;
            this.lbl_Usuario.Text = "Usuario";
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Location = new System.Drawing.Point(112, 118);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(61, 13);
            this.lbl_Contraseña.TabIndex = 4;
            this.lbl_Contraseña.Text = "Contraseña";
            // 
            // frmInicioSesion
            // 
            this.AcceptButton = this.bttn_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_Contraseña);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.bttn_Aceptar);
            this.Controls.Add(this.txtB_Usuario);
            this.Controls.Add(this.txtB_Contraseña);
            this.Name = "frmInicioSesion";
            this.Text = "Inicio de sesión";
            this.Load += new System.EventHandler(this.FRM_InicioSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtB_Usuario;
        private System.Windows.Forms.TextBox txtB_Contraseña;
        private System.Windows.Forms.Button bttn_Aceptar;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Contraseña;
    }
}

