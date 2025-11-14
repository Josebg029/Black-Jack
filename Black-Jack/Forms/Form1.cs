using Black_Jack.Clases;
using Black_Jack.Servicios;
using System.Collections;
using System.Xml.Linq;

namespace Black_Jack
{
    public partial class Form1 : Form
    {
        public CartasService CartasService = new CartasService();
        public ArrayList mano = new ArrayList();
        public int SumaTotal = 0;
        private bool inGame = false;
        private int creditos;
        private int apuesta;

        public Form1()
        {
            InitializeComponent();
            CartasService.GenerarCartas();
        }

        private void btnSacarCarta_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCreditos.Text))
            {
                MessageBox.Show("Introduce tus creditos!!");
            }
            else
            {
                if (String.IsNullOrEmpty(txtApuesta.Text))
                {
                    MessageBox.Show("Introduce tu apuesta!!");
                }
                else
                {
                    creditos = int.Parse(txtCreditos.Text.ToString());
                    txtCreditos.Enabled = false;

                    txtApuesta.Enabled = false;
                    apuesta = int.Parse(txtApuesta.Text.ToString());

                    if (inGame == false)
                    {
                        creditos -= apuesta;
                        txtCreditos.Text = creditos.ToString();
                        inGame = true;
                    }

                    btnSacarCarta.Text = "Sacar Carta";

                    Cartas carta = CartasService.SacarCarta();

                    if (carta1.lleno == false)
                    {
                        carta1.Load(carta);
                    }
                    else if (carta2.lleno == false)
                    {
                        carta2.Load(carta);
                    }
                    else if (carta3.lleno == false)
                    {
                        carta3.Load(carta);
                    }
                    else if (carta4.lleno == false)
                    {
                        carta4.Load(carta);
                    }
                    else if (carta5.lleno == false)
                    {
                        carta5.Load(carta);
                    }
                    else if (carta6.lleno == false)
                    {
                        carta6.Load(carta);
                    }
                    else if (carta7.lleno == false)
                    {
                        carta7.Load(carta);
                    }
                    else if (carta8.lleno == false)
                    {
                        carta8.Load(carta);
                    }
                    else if (carta9.lleno == false)
                    {
                        carta9.Load(carta);
                    }
                    else if (carta10.lleno == false)
                    {
                        carta10.Load(carta);
                    }
                    else if (carta11.lleno == false)
                    {
                        carta11.Load(carta);
                    }

                    SumaTotal += carta.Valor;

                    lbValor.Text = "Suma: " + SumaTotal.ToString();

                    if (SumaTotal == 21)
                    {
                        MessageBox.Show("Ganador");
                        refresh();
                    }
                    else if (SumaTotal > 21)
                    {
                        MessageBox.Show("Perdedor");
                        refresh();
                    }
                }
            }
        }

        private void refresh()
        {
            SumaTotal = 0;
            lbValor.Text = "";
            carta1.reset();
            carta2.reset();
            carta3.reset();
            carta4.reset();
            carta5.reset();
            carta6.reset();
            carta7.reset();
            carta8.reset();
            carta9.reset();
            carta10.reset();
            carta11.reset();
            txtApuesta.Enabled = true;
            inGame = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
