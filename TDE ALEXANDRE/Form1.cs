﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDE_ALEXANDRE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {

        }

        private void txtSENHA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCONFIRMAR_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRUA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBAIRRO_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCIDADE_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbESTADO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtEMAIL_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNOME_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSOBRENOME_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtbNUMERO_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnSALVAR_Click(object sender, EventArgs e)
        {
            String mensagem = "";
            mensagem += "Nome: " + txtNOME.Text + " " + txtSOBRENOME.Text + "\n";
            mensagem += "E-mail:  " + txtEMAIL.Text + "\n";
            mensagem += "CPF:  " + mtbCPF.Text + "\n";
            mensagem += "Cidade:  " + txtCIDADE.Text + "\n";
            mensagem += "Bairro:  " +txtBAIRRO.Text + "\n";
            mensagem += "Estado:  " + cmbESTADO.Text + "\n";
            mensagem += "Rua:  " + txtRUA.Text + "\n";
            mensagem += "Número:  " + mtbNUMERO.Text + "\n";
            mensagem += "Senha:  " + txtSENHA.Text + "\n";
            MessageBox.Show(mensagem);
            

        }
    }
}
