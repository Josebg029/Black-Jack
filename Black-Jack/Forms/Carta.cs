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
            Visible = false;
        }

        public void Load(Cartas carta)
        {
            this.lbPalo.Text = carta.Palo;
            this.lbPalo2.Text = carta.Palo;

            if (carta.Id == 11)
            {
                lbNumero.Text = "J";
                lbNumero2.Text = "J";
                lbNumero3.Text = "J";
            }
            else if (carta.Id == 12)
            {
                lbNumero.Text = "Q";
                lbNumero2.Text = "Q";
                lbNumero3.Text = "Q";

            }
            else if (carta.Id == 13)
            {
                lbNumero.Text = "K";
                lbNumero2.Text = "K";
                lbNumero3.Text = "K";

            }
            else if (carta.Id == 1)
            {
                lbNumero.Text = "A";
                lbNumero2.Text = "A";
                lbNumero3.Text = "A";

            }
            else
            {
                lbNumero.Text = carta.Id.ToString();
                lbNumero2.Text = carta.Id.ToString();
                lbNumero3.Text = carta.Id.ToString();

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
            lleno = true;
            Visible = true;
        }

        public void reset()
        {
            lbNumero.Text = "";
            lbPalo.Text = "";
            lbPalo2.Text = "";
            lleno = false;
            Visible = false;
            lbNumero2.Text = "";
            lbNumero3.Text = "";
        }
    }
}
