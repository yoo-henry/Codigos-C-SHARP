using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faturamento_diário_de_um_lava_rápido
{
    public partial class Form1 : Form
    {

        int Valor = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text != string.Empty && txtNum2.Text != string.Empty && txtNum3.Text != string.Empty
                && txtQNum1.Text != string.Empty && txtQNum2.Text != string.Empty && txtQNum3.Text != string.Empty)
            {
                double vnum1 = Convert.ToDouble(txtNum1.Text);
                double vnum2 = Convert.ToDouble(txtNum2.Text);
                double vnum3 = Convert.ToDouble(txtNum3.Text);
                double Qnum1 = Convert.ToDouble(txtQNum1.Text);
                double Qnum2 = Convert.ToDouble(txtQNum2.Text);
                double Qnum3 = Convert.ToDouble(txtQNum3.Text);
                double total = (vnum1 * Qnum1) + (vnum2 * Qnum2) + (vnum3 * Qnum3);
                double media = total / (Qnum1 + Qnum2 + Qnum3) ;

                lblResultM.Text = media.ToString();
                lblResultD.Text = total.ToString("");

            }
            else
            {

                MessageBox.Show("Informe valores para cálculo", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtNum3.Clear();
            txtQNum1.Clear();
            txtQNum2.Clear();
            txtQNum3.Clear();
            lblResultD.Text = "";
            lblResultM.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Finalizar sistema ?", "Informação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
