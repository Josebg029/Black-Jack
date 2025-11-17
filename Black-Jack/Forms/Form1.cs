using Black_Jack.Clases;
using Black_Jack.Forms;
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
            carta1.Visible = true;
            carta2.Visible = true;

            carta1.BackgroundImage = Properties.Resources.reverso;
            carta2.BackgroundImage = Properties.Resources.reverso;
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

                    if (!inGame)
                    {
                        creditos -= apuesta;
                        txtCreditos.Text = creditos.ToString();

                        carta1.BackgroundImage = null;
                        carta2.BackgroundImage = null;
                        Cartas Carta = CartasService.SacarCarta();
                        Cartas Carta2 = CartasService.SacarCarta();
                        carta2.BringToFront();
                        carta1.Load(Carta);
                        carta2.Load(Carta2);

                        SumaTotal += Carta.Valor + Carta2.Valor;

                        inGame = true;
                    }
                    else {
                        Cartas carta = CartasService.SacarCarta();

                        if (carta3.lleno == false)
                        {
                            carta3.Load(carta);
                            carta3.BringToFront();
                        }
                        else if (carta4.lleno == false)
                        {
                            carta4.Load(carta);
                            carta4.BringToFront();
                        }
                        else if (carta5.lleno == false)
                        {
                            carta5.Load(carta);
                            carta5.BringToFront();
                        }
                        else if (carta6.lleno == false)
                        {
                            carta6.Load(carta);
                            carta6.BringToFront();
                        }
                        else if (carta7.lleno == false)
                        {
                            carta7.Load(carta);
                            carta7.BringToFront();
                        }
                        else if (carta8.lleno == false)
                        {
                            carta8.Load(carta);
                            carta8.BringToFront();
                        }
                        else if (carta9.lleno == false)
                        {
                            carta9.Load(carta);
                            carta9.BringToFront();
                        }
                        else if (carta10.lleno == false)
                        {
                            carta10.Load(carta);
                            carta10.BringToFront();
                        }
                        else if (carta11.lleno == false)
                        {
                            carta11.Load(carta);
                            carta11.BringToFront();
                        }
                        SumaTotal += carta.Valor;
                    }

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
            carta1.BackgroundImage = Properties.Resources.reverso;
            carta2.BackgroundImage = Properties.Resources.reverso;
            carta1.Visible = true;
            carta2.Visible = true;
        }

    }
}
