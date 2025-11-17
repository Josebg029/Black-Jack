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
            lbNumero2 = new Label();
            lbNumero3 = new Label();
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
            lbNumero.BackColor = Color.Transparent;
            lbNumero.Font = new Font("Segoe UI", 15F);
            lbNumero.Location = new Point(23, 40);
            lbNumero.Name = "lbNumero";
            lbNumero.Size = new Size(36, 28);
            lbNumero.TabIndex = 1;
            lbNumero.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbNumero2
            // 
            lbNumero2.BackColor = Color.Transparent;
            lbNumero2.Font = new Font("Segoe UI", 9F);
            lbNumero2.Location = new Point(-1, 29);
            lbNumero2.Name = "lbNumero2";
            lbNumero2.Padding = new Padding(2, 0, 2, 0);
            lbNumero2.Size = new Size(37, 24);
            lbNumero2.TabIndex = 2;
            lbNumero2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbNumero3
            // 
            lbNumero3.BackColor = Color.Transparent;
            lbNumero3.Font = new Font("Segoe UI", 9F);
            lbNumero3.Location = new Point(44, 62);
            lbNumero3.Name = "lbNumero3";
            lbNumero3.Padding = new Padding(2, 0, 2, 0);
            lbNumero3.Size = new Size(37, 24);
            lbNumero3.TabIndex = 3;
            lbNumero3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Carta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lbNumero);
            Controls.Add(lbPalo);
            Controls.Add(lbNumero3);
            Controls.Add(lbNumero2);
            Controls.Add(lbPalo2);
            Name = "Carta";
            Size = new Size(77, 107);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPalo;
        private Label lbPalo2;
        private Label lbNumero;
        private Label lbNumero2;
        private Label lbNumero3;
    }
}
