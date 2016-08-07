namespace BrainW
{
    partial class FRM_InicioSesion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtB_Usuario
            // 
            this.txtB_Usuario.Location = new System.Drawing.Point(92, 82);
            this.txtB_Usuario.Name = "txtB_Usuario";
            this.txtB_Usuario.Size = new System.Drawing.Size(100, 20);
            this.txtB_Usuario.TabIndex = 0;
            // 
            // txtB_Contraseña
            // 
            this.txtB_Contraseña.Location = new System.Drawing.Point(92, 125);
            this.txtB_Contraseña.Name = "txtB_Contraseña";
            this.txtB_Contraseña.PasswordChar = '*';
            this.txtB_Contraseña.Size = new System.Drawing.Size(100, 20);
            this.txtB_Contraseña.TabIndex = 1;
            // 
            // bttn_Aceptar
            // 
            this.bttn_Aceptar.Location = new System.Drawing.Point(105, 160);
            this.bttn_Aceptar.Name = "bttn_Aceptar";
            this.bttn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.bttn_Aceptar.TabIndex = 2;
            this.bttn_Aceptar.Text = "Aceptar";
            this.bttn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // FRM_InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttn_Aceptar);
            this.Controls.Add(this.txtB_Usuario);
            this.Controls.Add(this.txtB_Contraseña);
            this.Name = "FRM_InicioSesion";
            this.Text = "Inicio de sesión";
            this.Load += new System.EventHandler(this.FRM_InicioSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtB_Usuario;
        private System.Windows.Forms.TextBox txtB_Contraseña;
        private System.Windows.Forms.Button bttn_Aceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

