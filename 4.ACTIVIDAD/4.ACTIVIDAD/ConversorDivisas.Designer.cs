namespace _4.ACTIVIDAD
{
    partial class ConversorDivisas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbA = new System.Windows.Forms.ComboBox();
            this.cmbDe = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad a convertir:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(254, 45);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(308, 35);
            this.txtCantidad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 65);
            this.label2.TabIndex = 2;
            this.label2.Text = " De:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 65);
            this.label3.TabIndex = 3;
            this.label3.Text = " A:";
            // 
            // cmbA
            // 
            this.cmbA.FormattingEnabled = true;
            this.cmbA.Location = new System.Drawing.Point(428, 195);
            this.cmbA.Name = "cmbA";
            this.cmbA.Size = new System.Drawing.Size(187, 37);
            this.cmbA.TabIndex = 4;
            // 
            // cmbDe
            // 
            this.cmbDe.FormattingEnabled = true;
            this.cmbDe.Location = new System.Drawing.Point(166, 195);
            this.cmbDe.Name = "cmbDe";
            this.cmbDe.Size = new System.Drawing.Size(185, 37);
            this.cmbDe.TabIndex = 5;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(189, 300);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(315, 65);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado...";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(194, 332);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(397, 72);
            this.btnConvertir.TabIndex = 7;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // ConversorDivisas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 462);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cmbDe);
            this.Controls.Add(this.cmbA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label1);
            this.Name = "ConversorDivisas";
            this.Text = "ConversorDivisas";
            this.Load += new System.EventHandler(this.ConversorDivisas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbA;
        private System.Windows.Forms.ComboBox cmbDe;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnConvertir;
    }
}