using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Projeto_JogoVelha_TurmaA
{
    internal class jogo
    {
        #region Atributos/Campos e Propriedades
        string vbtn1 = "";
        string vbtn2 = "";
        string vbtn3 = "";
        string vbtn4 = "";
        string vbtn5 = "";
        string vbtn6 = "";
        string vbtn7 = "";
        string vbtn8 = "";
        string vbtn9 = "";





        public string Vbtn1
        {
            get
            {
                return vbtn1;
            }
            set
            {
                vbtn1 = value;
            }
        }

        public string Vbtn2 { get => vbtn2; set => vbtn2 = value; }
        public string Vbtn3 { get => vbtn3; set => vbtn3 = value; }
        public string Vbtn4 { get => vbtn4; set => vbtn4 = value; }
        public string Vbtn5 { get => vbtn5; set => vbtn5 = value; }
        public string Vbtn6 { get => vbtn6; set => vbtn6 = value; }
        public string Vbtn7 { get => vbtn7; set => vbtn7 = value; }
        public string Vbtn8 { get => vbtn8; set => vbtn8 = value; }
        public string Vbtn9 { get => vbtn9; set => vbtn9 = value; }
        #endregion

        #region Método para Verificar se houve um vencedor
        public Boolean Verificar(string Jogador)
        {

            if (vbtn1 == vbtn2 && vbtn2 == vbtn3 &&

                vbtn1 != "" && vbtn2 != "" && vbtn3 != "" ||

                vbtn4 == vbtn5 && vbtn5 == vbtn6 &&

                vbtn4 != "" && vbtn5 != "" && vbtn6 != "" ||

                vbtn7 == vbtn8 && vbtn8 == vbtn9 &&

                vbtn7 != "" && vbtn8 != "" && vbtn9 != "" ||

                vbtn1 == vbtn4 && vbtn4 == vbtn7 &&

                vbtn1 != "" && vbtn4 != "" && vbtn7 != "" ||

                vbtn2 == vbtn5 && vbtn5 == vbtn8 &&

                vbtn2 != "" && vbtn5 != "" && vbtn8 != "" ||

                vbtn3 == vbtn6 && vbtn6 == vbtn9 &&

                vbtn3 != "" && vbtn6 != "" && vbtn9 != "" ||

                vbtn1 == vbtn5 && vbtn5 == vbtn9 &&

                vbtn1 != "" && vbtn5 != "" && vbtn9 != "" ||

                vbtn3 == vbtn5 && vbtn5 == vbtn7 && vbtn3 != "" && vbtn5 != "" && vbtn7 != "")
            {
                MessageBox.Show($"Paranbéns! O jogador {Jogador} foi o vencedor", "Fim de Jogo");
                Zerar_Campos();
                return true;
            }

            else if (vbtn1 != "" && vbtn2 != "" && vbtn3 != "" && vbtn4 != "" && vbtn5 != "" && vbtn6 != "" && vbtn7 != "" && vbtn8!= "" && vbtn9 != "")
            {
                MessageBox.Show("Deu Velha!", "Final do Jogo");
                Zerar_Campos();
                return true;
            }
            return false;
        }
        #endregion

        #region Método para zerar os atribudos/campos
        private void Zerar_Campos() 
        {

            vbtn1 = string.Empty;
            vbtn2 = string.Empty;
            vbtn3 = string.Empty;
            vbtn4 = string.Empty;
            vbtn5 = string.Empty;
            vbtn6 = string.Empty;
            vbtn7 = string.Empty;
            vbtn8 = string.Empty;
            vbtn9 = string.Empty;


        }



        #endregion

    }
}