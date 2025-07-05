namespace _4.ACTIVIDAD
{
    partial class tabsPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.convertirDivisasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cálculoDeImpuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serieDeFibonacciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertirDivisasToolStripMenuItem,
            this.registroDeUsuarioToolStripMenuItem,
            this.cálculoDeImpuestosToolStripMenuItem,
            this.serieDeFibonacciToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1342, 47);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // convertirDivisasToolStripMenuItem
            // 
            this.convertirDivisasToolStripMenuItem.Name = "convertirDivisasToolStripMenuItem";
            this.convertirDivisasToolStripMenuItem.Size = new System.Drawing.Size(237, 43);
            this.convertirDivisasToolStripMenuItem.Text = "Convertir Divisas";
            this.convertirDivisasToolStripMenuItem.Click += new System.EventHandler(this.convertirDivisasToolStripMenuItem_Click);
            // 
            // registroDeUsuarioToolStripMenuItem
            // 
            this.registroDeUsuarioToolStripMenuItem.Name = "registroDeUsuarioToolStripMenuItem";
            this.registroDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(274, 43);
            this.registroDeUsuarioToolStripMenuItem.Text = "Registro De Usuario";
            this.registroDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registroDeUsuarioToolStripMenuItem_Click);
            // 
            // cálculoDeImpuestosToolStripMenuItem
            // 
            this.cálculoDeImpuestosToolStripMenuItem.Name = "cálculoDeImpuestosToolStripMenuItem";
            this.cálculoDeImpuestosToolStripMenuItem.Size = new System.Drawing.Size(300, 43);
            this.cálculoDeImpuestosToolStripMenuItem.Text = " Cálculo de Impuestos";
            this.cálculoDeImpuestosToolStripMenuItem.Click += new System.EventHandler(this.cálculoDeImpuestosToolStripMenuItem_Click);
            // 
            // serieDeFibonacciToolStripMenuItem
            // 
            this.serieDeFibonacciToolStripMenuItem.Name = "serieDeFibonacciToolStripMenuItem";
            this.serieDeFibonacciToolStripMenuItem.Size = new System.Drawing.Size(253, 43);
            this.serieDeFibonacciToolStripMenuItem.Text = "Serie de Fibonacci";
            this.serieDeFibonacciToolStripMenuItem.Click += new System.EventHandler(this.serieDeFibonacciToolStripMenuItem_Click);
            // 
            // tabsPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 755);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "tabsPrincipal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem convertirDivisasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cálculoDeImpuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serieDeFibonacciToolStripMenuItem;
    }
}

