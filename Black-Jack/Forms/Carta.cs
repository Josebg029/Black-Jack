using Black_Jack.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black_Jack.Forms
{
    public partial class Carta : UserControl
    {
        public bool lleno = false;
        public string exeDir = AppDomain.CurrentDomain.BaseDirectory;


        public Carta()
        {
            InitializeComponent();
            string filePath = Path.Combine(exeDir, "../../../reverso.jpg");
            this.BackgroundImage = Image.FromFile(filePath);
        }

        public void Load(Cartas carta)
        {
            this.lbPalo.Text = carta.Palo;
            this.lbPalo2.Text = carta.Palo;

            if (carta.Id == 11)
            {
                lbNumero.Text = "J";
            }
            else if (carta.Id == 12)
            {
                lbNumero.Text = "Q";
            }
            else if (carta.Id == 13)
            {
                lbNumero.Text = "K";
            }
            else if (carta.Id == 1)
            {
                lbNumero.Text = "A";
            }
            else
            {
                lbNumero.Text = carta.Id.ToString();
            }

            if (carta.Palo.Equals("♣") || carta.Palo.Equals("♠"))
            {
                lbPalo.ForeColor = Color.Black;
                lbPalo2.ForeColor = Color.Black;
            }
            else
            {
                lbPalo.ForeColor = Color.Red;
                lbPalo2.ForeColor = Color.Red;
            }
            this.BackgroundImage = null;
            lleno = true;
        }

        public void reset()
        {
            lbNumero.Text = "";
            lbPalo.Text = "";
            lbPalo2.Text = "";
            lleno = false;
            string filePath = Path.Combine(exeDir, "../../../reverso.jpg");
            this.BackgroundImage = Image.FromFile(filePath);
        }
    }
}
