namespace Black_Jack.Forms
{
    partial class Carta
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lbPalo = new Label();
            lbPalo2 = new Label();
            lbNumero = new Label();
            SuspendLayout();
            // 
            // lbPalo
            // 
            lbPalo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbPalo.AutoSize = true;
            lbPalo.Font = new Font("Segoe UI", 15F);
            lbPalo.Location = new Point(51, 79);
            lbPalo.Name = "lbPalo";
            lbPalo.Size = new Size(0, 28);
            lbPalo.TabIndex = 0;
            // 
            // lbPalo2
            // 
            lbPalo2.AutoSize = true;
            lbPalo2.Font = new Font("Segoe UI", 15F);
            lbPalo2.Location = new Point(3, 1);
            lbPalo2.Name = "lbPalo2";
            lbPalo2.Size = new Size(0, 28);
            lbPalo2.TabIndex = 0;
            // 
            // lbNumero
            // 
            lbNumero.AutoSize = true;
            lbNumero.Font = new Font("Segoe UI", 20F);
            lbNumero.Location = new Point(23, 40);
            lbNumero.Name = "lbNumero";
            lbNumero.Size = new Size(0, 37);
            lbNumero.TabIndex = 1;
            // 
            // Carta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lbNumero);
            Controls.Add(lbPalo2);
            Controls.Add(lbPalo);
            Name = "Carta";
            Size = new Size(77, 107);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPalo;
        private Label lbPalo2;
        private Label lbNumero;
    }
}
