using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_JogoVelha_TurmaA
{
    public partial class frmJogo : Form
    {
        string NomeJ1, NomeJ2;
        int Jogador = 1;
        jogo Jogo = new jogo();

        public frmJogo(string Jogador1, string Jogador2) //Construtor
        {
            InitializeComponent();
            lblData.Text = "Data - " + DateTime.Now.ToShortDateString();
            lblHora.Text = "Hora - " + DateTime.Now.ToLongTimeString();
            lblJogador1.Text = $"Jogador 0 - {Jogador1}";
            lblJogador2.Text = "Jogador X - " + Jogador2;
            NomeJ1 = Jogador1;
            NomeJ2 = Jogador2;
            lblVez.Text = $"Vez do JOgador - {Jogador1}";

            jogo Jogo = new jogo();
            
        }

        private void Jogada(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            if (Jogador == 1)
            {
                button.Text = "0";
                lblVez.Text = "Vez do Jogador - " +
                    NomeJ2;
                button.Enabled = false;
                Carregar_jogada("0",
                    Convert.ToInt32(button.Tag));
                Boolean retorno = Jogo.Verificar(NomeJ1);
                Jogador = 2;

                if (retorno)
                {
                     panel3.Enabled = false;
                }


            }
            else
            {
                button.Text = "X";
                button.Enabled = false;
                lblVez.Text = $"Vez do jogador - {NomeJ1}";
                Carregar_jogada("X",
                    Convert.ToInt32(button.Tag));
                Boolean retorno = Jogo.Verificar(NomeJ2);

                if (retorno)
                {
                    panel3.Enabled = false;
                }


                Jogador = 1;


            }
        }

        private void Carregar_jogada(string simbolo,
            int tag )
        {
            switch (tag)
            {
                case 1:
                    Jogo.Vbtn1 = simbolo;
                    break;
                case 2:
                    Jogo.Vbtn2 = simbolo;
                    break;
                case 3:
                    Jogo.Vbtn3 = simbolo;
                    break;
                case 4:
                    Jogo.Vbtn4 = simbolo;
                    break;
                case 5:
                    Jogo.Vbtn5 = simbolo;
                    break;
                case 6:
                    Jogo.Vbtn6 = simbolo;
                    break;
                case 7:
                    Jogo.Vbtn7 = simbolo;
                    break;
                case 8:
                    Jogo.Vbtn8 = simbolo;
                    break;
                case 9:
                    Jogo.Vbtn9 = simbolo;
                    break;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            panel3.Enabled = true;

            foreach (Control item in panel3.Controls)
            {
                (item as Button).Text = "";
                (item as Button).Enabled = true;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora - " + DateTime.Now.ToLongTimeString();
        }
    }
}
