namespace ProyectoCatedra
{
    partial class Pensum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pensum));
            this.dgvPensum = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPensum)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPensum
            // 
            this.dgvPensum.AllowUserToAddRows = false;
            this.dgvPensum.AllowUserToDeleteRows = false;
            this.dgvPensum.AllowUserToResizeColumns = false;
            this.dgvPensum.AllowUserToResizeRows = false;
            this.dgvPensum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPensum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPensum.Location = new System.Drawing.Point(67, 70);
            this.dgvPensum.Name = "dgvPensum";
            this.dgvPensum.ReadOnly = true;
            this.dgvPensum.Size = new System.Drawing.Size(674, 324);
            this.dgvPensum.TabIndex = 0;
            this.dgvPensum.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPensum_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::ProyectoCatedra.Properties.Resources.goback;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 37);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Pensum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvPensum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pensum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pensum";
            this.Load += new System.EventHandler(this.Pensum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPensum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPensum;
        private System.Windows.Forms.Button button2;
    }
}