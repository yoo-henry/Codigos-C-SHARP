
namespace Projeto_JogoVelha_TurmaA
{
    partial class frmJogo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblJogador2 = new System.Windows.Forms.Label();
            this.lblversus = new System.Windows.Forms.Label();
            this.lblVez = new System.Windows.Forms.Label();
            this.lblJogador1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.tmrHora = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 440);
            this.panel1.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::Projeto_JogoVelha_TurmaA.Properties.Resources.anchor;
            this.btnFechar.Location = new System.Drawing.Point(8, 245);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(118, 74);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Voltar &Tela Inicial";
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::Projeto_JogoVelha_TurmaA.Properties.Resources.control_end;
            this.btnNovo.Location = new System.Drawing.Point(7, 158);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(118, 74);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "&Novo Jogo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(22, 47);
            this.lblHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(35, 13);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "label2";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(22, 16);
            this.lblData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(35, 13);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblJogador2);
            this.panel2.Controls.Add(this.lblversus);
            this.panel2.Controls.Add(this.lblVez);
            this.panel2.Controls.Add(this.lblJogador1);
            this.panel2.Location = new System.Drawing.Point(140, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 98);
            this.panel2.TabIndex = 1;
            // 
            // lblJogador2
            // 
            this.lblJogador2.AutoSize = true;
            this.lblJogador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador2.Location = new System.Drawing.Point(211, 19);
            this.lblJogador2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJogador2.Name = "lblJogador2";
            this.lblJogador2.Size = new System.Drawing.Size(76, 17);
            this.lblJogador2.TabIndex = 3;
            this.lblJogador2.Text = "Jogador2";
            // 
            // lblversus
            // 
            this.lblversus.AutoSize = true;
            this.lblversus.Location = new System.Drawing.Point(190, 21);
            this.lblversus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblversus.Name = "lblversus";
            this.lblversus.Size = new System.Drawing.Size(18, 13);
            this.lblversus.TabIndex = 2;
            this.lblversus.Text = "vs";
            // 
            // lblVez
            // 
            this.lblVez.AutoSize = true;
            this.lblVez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVez.Location = new System.Drawing.Point(89, 65);
            this.lblVez.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVez.Name = "lblVez";
            this.lblVez.Size = new System.Drawing.Size(0, 20);
            this.lblVez.TabIndex = 1;
            // 
            // lblJogador1
            // 
            this.lblJogador1.AutoSize = true;
            this.lblJogador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador1.Location = new System.Drawing.Point(10, 19);
            this.lblJogador1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJogador1.Name = "lblJogador1";
            this.lblJogador1.Size = new System.Drawing.Size(76, 17);
            this.lblJogador1.TabIndex = 0;
            this.lblJogador1.Text = "Jogador1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn9);
            this.panel3.Controls.Add(this.btn8);
            this.panel3.Controls.Add(this.btn7);
            this.panel3.Controls.Add(this.btn6);
            this.panel3.Controls.Add(this.btn5);
            this.panel3.Controls.Add(this.btn4);
            this.panel3.Controls.Add(this.btn3);
            this.panel3.Controls.Add(this.btn2);
            this.panel3.Controls.Add(this.btn1);
            this.panel3.Location = new System.Drawing.Point(140, 109);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 334);
            this.panel3.TabIndex = 2;
            // 
            // btn9
            // 
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(268, 226);
            this.btn9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(98, 84);
            this.btn9.TabIndex = 8;
            this.btn9.Tag = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Jogada);
            // 
            // btn8
            // 
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(141, 226);
            this.btn8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(98, 84);
            this.btn8.TabIndex = 7;
            this.btn8.Tag = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Jogada);
            // 
            // btn7
            // 
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(14, 226);
            this.btn7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(98, 84);
            this.btn7.TabIndex = 6;
            this.btn7.Tag = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Jogada);
            // 
            // btn6
            // 
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(266, 115);
            this.btn6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(98, 84);
            this.btn6.TabIndex = 5;
            this.btn6.Tag = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Jogada);
            // 
            // btn5
            // 
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(139, 115);
            this.btn5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(98, 84);
            this.btn5.TabIndex = 4;
            this.btn5.Tag = "5";
            this.btn5.Text = " ";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Jogada);
            // 
            // btn4
            // 
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(11, 115);
            this.btn4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(98, 84);
            this.btn4.TabIndex = 3;
            this.btn4.Tag = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Jogada);
            // 
            // btn3
            // 
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(266, 10);
            this.btn3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(98, 84);
            this.btn3.TabIndex = 2;
            this.btn3.Tag = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Jogada);
            // 
            // btn2
            // 
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(139, 10);
            this.btn2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(98, 84);
            this.btn2.TabIndex = 1;
            this.btn2.Tag = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Jogada);
            // 
            // btn1
            // 
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(14, 10);
            this.btn1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(98, 84);
            this.btn1.TabIndex = 0;
            this.btn1.Tag = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Jogada);
            // 
            // tmrHora
            // 
            this.tmrHora.Enabled = true;
            this.tmrHora.Interval = 1000;
            this.tmrHora.Tick += new System.EventHandler(this.tmrHora_Tick);
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 444);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmJogo";
            this.Text = "Jogo da Velha";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblJogador2;
        private System.Windows.Forms.Label lblversus;
        private System.Windows.Forms.Label lblVez;
        private System.Windows.Forms.Label lblJogador1;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Timer tmrHora;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

