﻿using Banco;
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
    public partial class Transferencia : Form
    {
        #region Construtor
        public Transferencia(DadosLogin dadosLogin)
        {
            InitializeComponent();

            this.dadosLogin = dadosLogin;
        }

        #endregion

        #region Atributos

        private DadosLogin dadosLogin = null;
        private Operacoes op = new Operacoes();

        #endregion

        #region Método

        public void AtualizarSaldo()
        {
            lblSaldo.Text = Convert.ToString(op.MostrarSaldo(dadosLogin.id_login));
        }

        #endregion


        private void Transferencia_Load(object sender, EventArgs e)
        {
            AtualizarSaldo();
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            op.id = dadosLogin.id_login;
            op.saldo = double.Parse(txtTransferencia.Text.Trim());  

            if (txtIdOutraConta.Text == string.Empty && txtTransferencia.Text == string.Empty)
            {
                MessageBox.Show("Campos Obrigatórios!");
                return;
            }

            if (op.saldo < 1)
            {
                MessageBox.Show("Valor Inválido!");
                return;
            }

            if (txtIdOutraConta.Text == string.Empty)
            {
                MessageBox.Show("Destinatário não informado!");
                return;
            }

            if (txtTransferencia.Text == string.Empty)
            {
                MessageBox.Show("Você deve informar um valor para transferência!");
                return;
            }

            op.id_dest = int.Parse(txtIdOutraConta.Text);

            

            if (op.saldo <= double.Parse(lblSaldo.Text))
            {
                op.Transferir();
            }
            else if (Convert.ToDouble(txtTransferencia.Text) > double.Parse(lblSaldo.Text))
            {
                MessageBox.Show("Saldo Insuficiente!");
                return;
            }

            if (op.HasError)
            {
                MessageBox.Show(op.MsgError, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            MessageBox.Show("Transferência realizada com sucesso!",
                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult dg = MessageBox.Show("Deseja realizar outra transferência?", "Aviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                AtualizarSaldo();
                txtIdOutraConta.Text = string.Empty;
                txtTransferencia.Text = string.Empty;
                return;
            }
            else
            {
                this.Close();
            }
        }

        private void txtIdOutraConta_TextChanged(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////
            
            if (txtIdOutraConta.Text == string.Empty)
            {
                lblPessoaDeDestino.Text = string.Empty;
                return;
            }

            int id = int.Parse(txtIdOutraConta.Text);

            if (op.HasError)
            {
                MessageBox.Show(op.MsgError, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lblPessoaDeDestino.Text = Convert.ToString(op.MostrarNome(id));
            //lblPessoaDeDestino.Text = op.nome;

            ///////////////////////////////////////////////
        }
    }
}
