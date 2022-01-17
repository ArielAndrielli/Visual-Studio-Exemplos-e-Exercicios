﻿using Banco;
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

namespace ExemploBanco.Login
{
    public partial class I_Login : Form
    {
        #region construtor

        public I_Login()
        {
            InitializeComponent();
        }

        #endregion

        #region Atributos

        private Log_in oLogin = new Log_in();

        #endregion

        private void Logar()
        {
            bool existeCadastro = oLogin.VerificarCadastro(txtUsuario.Text.Trim(), txtSenha.Text.Trim());

            if (existeCadastro)
            {
                DadosLogin dadosLogin = new DadosLogin();
                dadosLogin.id_login = oLogin.Id;

                Positivo pstv = new Positivo(dadosLogin);
                pstv.ShowDialog();
                Hide();

                //As duas linhas abaixo mostram o form do menu principal
                I_MenuPrincipal menu = new I_MenuPrincipal(dadosLogin);
                menu.ShowDialog();

                
            }
            else
            {
                Negativo ngtv = new Negativo();
                ngtv.ShowDialog();

                return;
            }
        }

        #region Eventos

        private void I_Login_Load(object sender, EventArgs e)
        {
#if DEBUG
            txtUsuario.Text = "Alecrim";
            txtSenha.Text = "123";
#endif
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.ForeColor = Color.Black;

            if (txtUsuario.Text == "Username")
            {
                txtUsuario.Text = string.Empty;
            }
            else
            {
                txtUsuario.Text = txtUsuario.Text;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Password")
            {
                txtSenha.Text = string.Empty;
            }
            else
            {
                txtSenha.Text = txtSenha.Text;
            }
            txtSenha.ForeColor = Color.Black;
            txtSenha.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Username" || txtSenha.Text == "Password")
            {
                MessageBox.Show("Campos Obrigatórios!");
                return;
            }
            else
            {
                Logar();
            }

        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.ForeColor = Color.Black;

            if (txtUsuario.Text == "Username")
            {
                txtUsuario.Text = string.Empty;
            }
            else
            {
                txtUsuario.Text = txtUsuario.Text;
            }


        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Password")
            {
                txtSenha.Text = string.Empty;
            }
            else
            {
                txtSenha.Text = txtSenha.Text;
            }
            txtSenha.ForeColor = Color.Black;
            txtSenha.PasswordChar = '*';
        }

        private void lblCadastro_Click(object sender, EventArgs e)
        {
            I_Cadastro cad = new I_Cadastro();
            cad.ShowDialog();
        }

        private void lblCadastro_MouseHover(object sender, EventArgs e)
        {
            lblCadastro.ForeColor = Color.DarkBlue;
        }

        private void lblCadastro_MouseLeave(object sender, EventArgs e)
        {
            lblCadastro.ForeColor = Color.DodgerBlue;
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == string.Empty)
            {
                txtUsuario.Text = "Username";
                txtUsuario.ForeColor = Color.Gray;
            }
            else
            {
                txtUsuario.Text = txtUsuario.Text;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == string.Empty)
            {
                txtSenha.Text = "Password";
                txtSenha.ForeColor = Color.Gray;
                txtSenha.PasswordChar = '\u0000';
            }
            else
            {
                txtSenha.Text = txtSenha.Text;
            }

        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            //Esse evento é pra quando apertar o enter ele verificar se tem um cadastro com os dados digitados
            if (txtSenha.Text == "Password")
            {
                MessageBox.Show("Campos Obrigatórios!");
                return;
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Logar();
                }
            }
           
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtUsuario.Text == "Username")
            {
                MessageBox.Show("Campos Obrigatórios!");
                return;
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Logar();
                }
            }
        }

        private void I_Login_KeyDown(object sender, KeyEventArgs e)
        {
            Logar();
        }


        #endregion


    }
}
