﻿
namespace ExemploBanco
{
    partial class Transferencia
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
            this.txtTransferencia = new System.Windows.Forms.TextBox();
            this.lblSaque = new System.Windows.Forms.Label();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.txtIdOutraConta = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPessoaDeDestino = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTransferencia
            // 
            this.txtTransferencia.Location = new System.Drawing.Point(102, 109);
            this.txtTransferencia.Name = "txtTransferencia";
            this.txtTransferencia.Size = new System.Drawing.Size(166, 20);
            this.txtTransferencia.TabIndex = 2;
            // 
            // lblSaque
            // 
            this.lblSaque.AutoSize = true;
            this.lblSaque.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaque.Location = new System.Drawing.Point(28, 33);
            this.lblSaque.Name = "lblSaque";
            this.lblSaque.Size = new System.Drawing.Size(234, 44);
            this.lblSaque.TabIndex = 0;
            this.lblSaque.Text = "Insira o ID do destinatário e o \r\nvalor que se deseja transferir:";
            // 
            // btnTransferir
            // 
            this.btnTransferir.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferir.Location = new System.Drawing.Point(86, 174);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(110, 42);
            this.btnTransferir.TabIndex = 5;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // txtIdOutraConta
            // 
            this.txtIdOutraConta.Location = new System.Drawing.Point(19, 109);
            this.txtIdOutraConta.Name = "txtIdOutraConta";
            this.txtIdOutraConta.Size = new System.Drawing.Size(77, 20);
            this.txtIdOutraConta.TabIndex = 1;
            this.txtIdOutraConta.TextChanged += new System.EventHandler(this.txtIdOutraConta_TextChanged);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(182, 140);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(30, 22);
            this.lblSaldo.TabIndex = 4;
            this.lblSaldo.Text = ". . .";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seu saldo atual:";
            // 
            // lblPessoaDeDestino
            // 
            this.lblPessoaDeDestino.AutoSize = true;
            this.lblPessoaDeDestino.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPessoaDeDestino.Location = new System.Drawing.Point(21, 81);
            this.lblPessoaDeDestino.Name = "lblPessoaDeDestino";
            this.lblPessoaDeDestino.Size = new System.Drawing.Size(30, 22);
            this.lblPessoaDeDestino.TabIndex = 6;
            this.lblPessoaDeDestino.Text = ". . .";
            // 
            // Transferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblPessoaDeDestino);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdOutraConta);
            this.Controls.Add(this.txtTransferencia);
            this.Controls.Add(this.lblSaque);
            this.Controls.Add(this.btnTransferir);
            this.MaximizeBox = false;
            this.Name = "Transferencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferencia";
            this.Load += new System.EventHandler(this.Transferencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTransferencia;
        private System.Windows.Forms.Label lblSaque;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.TextBox txtIdOutraConta;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPessoaDeDestino;
    }
}