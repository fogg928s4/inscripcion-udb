namespace ProyectoCatedra
{
    partial class frmportal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btniniciodesesion = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btniniciodesesion
            // 
            this.btniniciodesesion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniniciodesesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btniniciodesesion.Location = new System.Drawing.Point(291, 301);
            this.btniniciodesesion.Name = "btniniciodesesion";
            this.btniniciodesesion.Size = new System.Drawing.Size(272, 32);
            this.btniniciodesesion.TabIndex = 5;
            this.btniniciodesesion.Text = "Iniciar sesión";
            this.btniniciodesesion.UseVisualStyleBackColor = true;
            this.btniniciodesesion.Click += new System.EventHandler(this.btniniciodesesion_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnregistrar.Location = new System.Drawing.Point(19, 301);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(266, 32);
            this.btnregistrar.TabIndex = 4;
            this.btnregistrar.Text = "Registrarse";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb1.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb1.Location = new System.Drawing.Point(200, 256);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(197, 25);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Portal universitario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoCatedra.Properties.Resources.Imagen_de_WhatsApp_2023_04_11_a_las_14_04_09;
            this.pictureBox1.Location = new System.Drawing.Point(157, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmportal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 380);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btniniciodesesion);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.lb1);
            this.Name = "frmportal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portal";
            this.Load += new System.EventHandler(this.frmportal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btniniciodesesion;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

