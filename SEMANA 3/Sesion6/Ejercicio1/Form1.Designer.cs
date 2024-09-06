namespace Ejercicio1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbnAgregar = new System.Windows.Forms.Button();
            this.cmbNombres = new System.Windows.Forms.ComboBox();
            this.cmbNombres2 = new System.Windows.Forms.ComboBox();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.ForeColor = System.Drawing.Color.DimGray;
            this.tbNombre.Location = new System.Drawing.Point(116, 37);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(325, 26);
            this.tbNombre.TabIndex = 1;
            // 
            // tbnAgregar
            // 
            this.tbnAgregar.BackColor = System.Drawing.Color.Beige;
            this.tbnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbnAgregar.Image = global::Ejercicio1.Properties.Resources.agregar;
            this.tbnAgregar.Location = new System.Drawing.Point(447, 30);
            this.tbnAgregar.Name = "tbnAgregar";
            this.tbnAgregar.Size = new System.Drawing.Size(59, 38);
            this.tbnAgregar.TabIndex = 2;
            this.tbnAgregar.UseVisualStyleBackColor = false;
            this.tbnAgregar.Click += new System.EventHandler(this.tbnAgregar_Click);
            // 
            // cmbNombres
            // 
            this.cmbNombres.FormattingEnabled = true;
            this.cmbNombres.Location = new System.Drawing.Point(116, 83);
            this.cmbNombres.Name = "cmbNombres";
            this.cmbNombres.Size = new System.Drawing.Size(325, 21);
            this.cmbNombres.TabIndex = 3;
            // 
            // cmbNombres2
            // 
            this.cmbNombres2.FormattingEnabled = true;
            this.cmbNombres2.Location = new System.Drawing.Point(116, 199);
            this.cmbNombres2.Name = "cmbNombres2";
            this.cmbNombres2.Size = new System.Drawing.Size(325, 21);
            this.cmbNombres2.TabIndex = 4;
            // 
            // btnCopiar
            // 
            this.btnCopiar.BackColor = System.Drawing.Color.Beige;
            this.btnCopiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiar.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCopiar.Location = new System.Drawing.Point(164, 142);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(239, 39);
            this.btnCopiar.TabIndex = 5;
            this.btnCopiar.Text = "Copiar todos los elementos";
            this.btnCopiar.UseVisualStyleBackColor = false;
            this.btnCopiar.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.cmbNombres2);
            this.Controls.Add(this.cmbNombres);
            this.Controls.Add(this.tbnAgregar);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button tbnAgregar;
        private System.Windows.Forms.ComboBox cmbNombres;
        private System.Windows.Forms.ComboBox cmbNombres2;
        private System.Windows.Forms.Button btnCopiar;
    }
}

