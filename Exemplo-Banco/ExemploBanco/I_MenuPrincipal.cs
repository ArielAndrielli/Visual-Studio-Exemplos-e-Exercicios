﻿using Banco;
using ExemploBanco;
using ExemploBanco.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploBanco
{
    public partial class I_MenuPrincipal : Form
    {
        #region Construtor

        public I_MenuPrincipal(DadosLogin dadosLogin)
        {
            InitializeComponent();

            this.dadosLogin = dadosLogin;
        }

        #endregion

        #region Atributos

        private DadosLogin dadosLogin = null;
        Operacoes oprc = new Operacoes();

        #endregion

        #region Métodos


        #endregion

        #region Eventos

        public void AtualizarSaldo()
        {
            lblSaldo.Text = Convert.ToString(oprc.MostrarSaldo(dadosLogin.id_login));
        }

        public void I_MenuPrincipal_Load(object sender, EventArgs e)
        {
            //lblMeuId.Text = Convert.ToString(dadosLogin.id_login);
            lblMeuId.Text = dadosLogin.id_login.ToString();

            lblPessoa.Text = Convert.ToString(oprc.MostrarNome(dadosLogin.id_login));
            AtualizarSaldo();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pcb1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pcb1.BorderStyle = default;
        }

        private void pcb2_MouseHover(object sender, EventArgs e)
        {
            pcb2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void pcb2_MouseLeave(object sender, EventArgs e)
        {
            pcb2.BorderStyle = default;
        }

        private void pcb3_MouseHover(object sender, EventArgs e)
        {
            pcb3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void pcb3_MouseLeave(object sender, EventArgs e)
        {
            pcb3.BorderStyle = default;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Tem certeza de que deseja fazer Logout?", "Aviso", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Hide();
                I_Login login = new I_Login();
                login.ShowDialog();
            }
            else
            {
                return;
            }
        }

        private void pcb3_Click(object sender, EventArgs e)
        {
            Transferencia transferencia = new Transferencia(dadosLogin);
            transferencia.ShowDialog();
            AtualizarSaldo();
        }

        private void pcb2_Click(object sender, EventArgs e)
        {
            Deposito deposito = new Deposito(dadosLogin);
            deposito.ShowDialog();
            AtualizarSaldo();
        }

        private void pcb1_Click(object sender, EventArgs e)
        {
            Saque saque = new Saque(dadosLogin);
            saque.ShowDialog();
            AtualizarSaldo();
        }

        private void btnSairMesmo_Click(object sender, EventArgs e)
        {
              DialogResult dg = MessageBox.Show("Tem certeza de que deseja sair?", "Aviso",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    return;
                }
        }


        #endregion

    }
}
