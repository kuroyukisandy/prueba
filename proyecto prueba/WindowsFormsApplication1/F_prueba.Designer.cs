namespace WindowsFormsApplication1
{
    partial class F_prueba
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.B_msj = new System.Windows.Forms.Button();
            this.L_msj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B_msj
            // 
            this.B_msj.Location = new System.Drawing.Point(168, 33);
            this.B_msj.Name = "B_msj";
            this.B_msj.Size = new System.Drawing.Size(146, 43);
            this.B_msj.TabIndex = 0;
            this.B_msj.Text = "Sorpresa";
            this.B_msj.UseVisualStyleBackColor = true;
            this.B_msj.Click += new System.EventHandler(this.B_msj_Click);
            // 
            // L_msj
            // 
            this.L_msj.AutoSize = true;
            this.L_msj.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_msj.ForeColor = System.Drawing.Color.Red;
            this.L_msj.Location = new System.Drawing.Point(62, 142);
            this.L_msj.Name = "L_msj";
            this.L_msj.Size = new System.Drawing.Size(0, 46);
            this.L_msj.TabIndex = 1;
            // 
            // F_prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 262);
            this.Controls.Add(this.L_msj);
            this.Controls.Add(this.B_msj);
            this.Name = "F_prueba";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_msj;
        private System.Windows.Forms.Label L_msj;
    }
}

