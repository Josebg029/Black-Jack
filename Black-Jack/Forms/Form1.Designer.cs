namespace Black_Jack
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSacarCarta = new Button();
            lbValor = new Label();
            carta1 = new Black_Jack.Forms.Carta();
            carta2 = new Black_Jack.Forms.Carta();
            carta3 = new Black_Jack.Forms.Carta();
            carta4 = new Black_Jack.Forms.Carta();
            carta5 = new Black_Jack.Forms.Carta();
            carta6 = new Black_Jack.Forms.Carta();
            carta7 = new Black_Jack.Forms.Carta();
            carta8 = new Black_Jack.Forms.Carta();
            carta9 = new Black_Jack.Forms.Carta();
            carta10 = new Black_Jack.Forms.Carta();
            carta11 = new Black_Jack.Forms.Carta();
            txtCreditos = new TextBox();
            txtApuesta = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnSacarCarta
            // 
            btnSacarCarta.Location = new Point(12, 337);
            btnSacarCarta.Name = "btnSacarCarta";
            btnSacarCarta.Size = new Size(107, 49);
            btnSacarCarta.TabIndex = 0;
            btnSacarCarta.Text = "Sacar Carta";
            btnSacarCarta.UseVisualStyleBackColor = true;
            btnSacarCarta.Click += btnSacarCarta_Click;
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Location = new Point(12, 304);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(33, 15);
            lbValor.TabIndex = 2;
            lbValor.Text = "Valor";
            // 
            // carta1
            // 
            carta1.BorderStyle = BorderStyle.FixedSingle;
            carta1.Location = new Point(10, 402);
            carta1.Name = "carta1";
            carta1.Size = new Size(79, 109);
            carta1.TabIndex = 5;
            carta1.Visible = false;
            // 
            // carta2
            // 
            carta2.BorderStyle = BorderStyle.FixedSingle;
            carta2.Location = new Point(40, 402);
            carta2.Name = "carta2";
            carta2.Size = new Size(79, 109);
            carta2.TabIndex = 6;
            carta2.Visible = false;
            // 
            // carta3
            // 
            carta3.BorderStyle = BorderStyle.FixedSingle;
            carta3.Location = new Point(70, 402);
            carta3.Name = "carta3";
            carta3.Size = new Size(79, 109);
            carta3.TabIndex = 7;
            carta3.Visible = false;
            // 
            // carta4
            // 
            carta4.BorderStyle = BorderStyle.FixedSingle;
            carta4.Location = new Point(100, 402);
            carta4.Name = "carta4";
            carta4.Size = new Size(79, 109);
            carta4.TabIndex = 8;
            carta4.Visible = false;
            // 
            // carta5
            // 
            carta5.BorderStyle = BorderStyle.FixedSingle;
            carta5.Location = new Point(130, 402);
            carta5.Name = "carta5";
            carta5.Size = new Size(79, 109);
            carta5.TabIndex = 9;
            carta5.Visible = false;
            // 
            // carta6
            // 
            carta6.BorderStyle = BorderStyle.FixedSingle;
            carta6.Location = new Point(160, 402);
            carta6.Name = "carta6";
            carta6.Size = new Size(79, 109);
            carta6.TabIndex = 10;
            carta6.Visible = false;
            // 
            // carta7
            // 
            carta7.BorderStyle = BorderStyle.FixedSingle;
            carta7.Location = new Point(190, 402);
            carta7.Name = "carta7";
            carta7.Size = new Size(79, 109);
            carta7.TabIndex = 11;
            carta7.Visible = false;
            // 
            // carta8
            // 
            carta8.BorderStyle = BorderStyle.FixedSingle;
            carta8.Location = new Point(220, 402);
            carta8.Name = "carta8";
            carta8.Size = new Size(79, 109);
            carta8.TabIndex = 12;
            carta8.Visible = false;
            // 
            // carta9
            // 
            carta9.BorderStyle = BorderStyle.FixedSingle;
            carta9.Location = new Point(250, 402);
            carta9.Name = "carta9";
            carta9.Size = new Size(79, 109);
            carta9.TabIndex = 13;
            carta9.Visible = false;
            // 
            // carta10
            // 
            carta10.BorderStyle = BorderStyle.FixedSingle;
            carta10.Location = new Point(280, 402);
            carta10.Name = "carta10";
            carta10.Size = new Size(79, 109);
            carta10.TabIndex = 14;
            carta10.Visible = false;
            // 
            // carta11
            // 
            carta11.BorderStyle = BorderStyle.FixedSingle;
            carta11.Location = new Point(310, 402);
            carta11.Name = "carta11";
            carta11.Size = new Size(79, 109);
            carta11.TabIndex = 15;
            carta11.Visible = false;
            // 
            // txtCreditos
            // 
            txtCreditos.Location = new Point(289, 337);
            txtCreditos.Name = "txtCreditos";
            txtCreditos.Size = new Size(100, 23);
            txtCreditos.TabIndex = 16;
            // 
            // txtApuesta
            // 
            txtApuesta.Location = new Point(289, 366);
            txtApuesta.Name = "txtApuesta";
            txtApuesta.Size = new Size(100, 23);
            txtApuesta.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(230, 340);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 18;
            label1.Text = "Creditos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 369);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 19;
            label2.Text = "Apuesta:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 521);
            Controls.Add(carta11);
            Controls.Add(carta10);
            Controls.Add(carta9);
            Controls.Add(carta8);
            Controls.Add(carta7);
            Controls.Add(carta6);
            Controls.Add(carta5);
            Controls.Add(carta4);
            Controls.Add(carta3);
            Controls.Add(carta2);
            Controls.Add(carta1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtApuesta);
            Controls.Add(txtCreditos);
            Controls.Add(lbValor);
            Controls.Add(btnSacarCarta);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSacarCarta;
        private Label lbValor;
        private Forms.Carta carta1;
        private Forms.Carta carta2;
        private Forms.Carta carta3;
        private Forms.Carta carta4;
        private Forms.Carta carta5;
        private Forms.Carta carta6;
        private Forms.Carta carta7;
        private Forms.Carta carta8;
        private Forms.Carta carta9;
        private Forms.Carta carta10;
        private Forms.Carta carta11;
        private TextBox txtCreditos;
        private TextBox txtApuesta;
        private Label label1;
        private Label label2;
    }
}
