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
    public partial class frmInicial : Form
    {
        public frmInicial() //Construtor
        {
            InitializeComponent();
            string msg = "Descrição Jogo da Velha"+ Environment.NewLine +
                "O jogo da velha (ou jogo do galo)" +
                "é um popular passatempo de regras simples," +
                "jogado entre duas pessoas em um tabuleiro" +
                "O objetivo é conseguir alinhar três símbolos" +
                "iguais — geralmente 'X' ou 'O' ";
            lblDescricao.Text = msg;

        }

        
        private void lnkManual_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            process1.StartInfo.FileName = @"D:\Manual.pdf";
            process1.Start();
            
         }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Finalizar?",
                "Saída",MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            frmJogo jogo = new frmJogo(txtJogador1.Text,txtJogador2.Text);
            jogo.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }
    }
}
