
namespace Projeto_JogoVelha_TurmaA
{
    partial class frmInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.txtJogador2 = new System.Windows.Forms.TextBox();
            this.txtJogador1 = new System.Windows.Forms.TextBox();
            this.lblJogador2 = new System.Windows.Forms.Label();
            this.lblJogador1 = new System.Windows.Forms.Label();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lnkManual = new System.Windows.Forms.LinkLabel();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.process1 = new System.Diagnostics.Process();
            this.tabControl1.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLogin);
            this.tabControl1.Controls.Add(this.tabInfo);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(557, 402);
            this.tabControl1.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.btnFechar);
            this.tabLogin.Controls.Add(this.btnAcessar);
            this.tabLogin.Controls.Add(this.txtJogador2);
            this.tabLogin.Controls.Add(this.txtJogador1);
            this.tabLogin.Controls.Add(this.lblJogador2);
            this.tabLogin.Controls.Add(this.lblJogador1);
            this.tabLogin.Location = new System.Drawing.Point(4, 25);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(549, 373);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login Jogo";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::Projeto_JogoVelha_TurmaA.Properties.Resources.action_delete;
            this.btnFechar.Location = new System.Drawing.Point(232, 178);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(128, 68);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "&Finalizar Jogo";
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnAcessar
            // 
            this.btnAcessar.Image = global::Projeto_JogoVelha_TurmaA.Properties.Resources.control_play;
            this.btnAcessar.Location = new System.Drawing.Point(74, 178);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(128, 68);
            this.btnAcessar.TabIndex = 4;
            this.btnAcessar.Text = "&Acessar Jogo";
            this.btnAcessar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAcessar.UseVisualStyleBackColor = true;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // txtJogador2
            // 
            this.txtJogador2.Location = new System.Drawing.Point(176, 81);
            this.txtJogador2.Name = "txtJogador2";
            this.txtJogador2.Size = new System.Drawing.Size(215, 22);
            this.txtJogador2.TabIndex = 3;
            // 
            // txtJogador1
            // 
            this.txtJogador1.Location = new System.Drawing.Point(176, 35);
            this.txtJogador1.Name = "txtJogador1";
            this.txtJogador1.Size = new System.Drawing.Size(215, 22);
            this.txtJogador1.TabIndex = 2;
            // 
            // lblJogador2
            // 
            this.lblJogador2.AutoSize = true;
            this.lblJogador2.Location = new System.Drawing.Point(41, 86);
            this.lblJogador2.Name = "lblJogador2";
            this.lblJogador2.Size = new System.Drawing.Size(127, 16);
            this.lblJogador2.TabIndex = 1;
            this.lblJogador2.Text = "Nome do Jogador 2";
            // 
            // lblJogador1
            // 
            this.lblJogador1.AutoSize = true;
            this.lblJogador1.Location = new System.Drawing.Point(41, 40);
            this.lblJogador1.Name = "lblJogador1";
            this.lblJogador1.Size = new System.Drawing.Size(123, 16);
            this.lblJogador1.TabIndex = 0;
            this.lblJogador1.Text = "Nome do jogador 1";
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.btnVoltar);
            this.tabInfo.Controls.Add(this.lnkManual);
            this.tabInfo.Controls.Add(this.lblDescricao);
            this.tabInfo.Controls.Add(this.picLogo);
            this.tabInfo.Location = new System.Drawing.Point(4, 25);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(549, 373);
            this.tabInfo.TabIndex = 1;
            this.tabInfo.Text = "Informações Jogo";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = global::Projeto_JogoVelha_TurmaA.Properties.Resources.arrow_redo;
            this.btnVoltar.Location = new System.Drawing.Point(391, 260);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(130, 86);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar Login";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lnkManual
            // 
            this.lnkManual.AutoSize = true;
            this.lnkManual.Location = new System.Drawing.Point(46, 317);
            this.lnkManual.Name = "lnkManual";
            this.lnkManual.Size = new System.Drawing.Size(157, 16);
            this.lnkManual.TabIndex = 2;
            this.lnkManual.TabStop = true;
            this.lnkManual.Text = "Acessar Manual do Jogo";
            this.lnkManual.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkManual_LinkClicked);
            // 
            // lblDescricao
            // 
            this.lblDescricao.Location = new System.Drawing.Point(40, 16);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(311, 250);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "label3";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Projeto_JogoVelha_TurmaA.Properties.Resources.Imagem_jogo;
            this.picLogo.Location = new System.Drawing.Point(391, 16);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(135, 148);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 404);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmInicial";
            this.Text = "Jogo da Velha - Inicial";
            this.tabControl1.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.TextBox txtJogador2;
        private System.Windows.Forms.TextBox txtJogador1;
        private System.Windows.Forms.Label lblJogador2;
        private System.Windows.Forms.Label lblJogador1;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.LinkLabel lnkManual;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Diagnostics.Process process1;
    }
}