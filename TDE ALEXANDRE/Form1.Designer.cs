namespace TDE_ALEXANDRE
{
    partial class Form1
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
            this.lblNOME = new System.Windows.Forms.Label();
            this.txtNOME = new System.Windows.Forms.TextBox();
            this.cmbESTADO = new System.Windows.Forms.ComboBox();
            this.lblSOBRENOME = new System.Windows.Forms.Label();
            this.lblEMAIL = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblESTADO = new System.Windows.Forms.Label();
            this.lblCIDADE = new System.Windows.Forms.Label();
            this.lblBAIRRO = new System.Windows.Forms.Label();
            this.lblRUA = new System.Windows.Forms.Label();
            this.lblNUMERO = new System.Windows.Forms.Label();
            this.lblSENHA = new System.Windows.Forms.Label();
            this.txtSOBRENOME = new System.Windows.Forms.TextBox();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.txtCIDADE = new System.Windows.Forms.TextBox();
            this.txtBAIRRO = new System.Windows.Forms.TextBox();
            this.txtRUA = new System.Windows.Forms.TextBox();
            this.txtSENHA = new System.Windows.Forms.TextBox();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.lblCONFIRMAR = new System.Windows.Forms.Label();
            this.txtCONFIRMAR = new System.Windows.Forms.TextBox();
            this.mtbNUMERO = new System.Windows.Forms.MaskedTextBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnSALVAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNOME
            // 
            this.lblNOME.AutoSize = true;
            this.lblNOME.Location = new System.Drawing.Point(12, 24);
            this.lblNOME.Name = "lblNOME";
            this.lblNOME.Size = new System.Drawing.Size(39, 13);
            this.lblNOME.TabIndex = 0;
            this.lblNOME.Text = "NOME";
            // 
            // txtNOME
            // 
            this.txtNOME.Location = new System.Drawing.Point(12, 40);
            this.txtNOME.Name = "txtNOME";
            this.txtNOME.Size = new System.Drawing.Size(148, 20);
            this.txtNOME.TabIndex = 1;
            this.txtNOME.TextChanged += new System.EventHandler(this.txtNOME_TextChanged);
            // 
            // cmbESTADO
            // 
            this.cmbESTADO.FormattingEnabled = true;
            this.cmbESTADO.Location = new System.Drawing.Point(12, 218);
            this.cmbESTADO.Name = "cmbESTADO";
            this.cmbESTADO.Size = new System.Drawing.Size(148, 21);
            this.cmbESTADO.TabIndex = 2;
            this.cmbESTADO.SelectedIndexChanged += new System.EventHandler(this.cmbESTADO_SelectedIndexChanged);
            // 
            // lblSOBRENOME
            // 
            this.lblSOBRENOME.AutoSize = true;
            this.lblSOBRENOME.Location = new System.Drawing.Point(166, 24);
            this.lblSOBRENOME.Name = "lblSOBRENOME";
            this.lblSOBRENOME.Size = new System.Drawing.Size(76, 13);
            this.lblSOBRENOME.TabIndex = 5;
            this.lblSOBRENOME.Text = "SOBRENOME";
            // 
            // lblEMAIL
            // 
            this.lblEMAIL.AutoSize = true;
            this.lblEMAIL.Location = new System.Drawing.Point(12, 74);
            this.lblEMAIL.Name = "lblEMAIL";
            this.lblEMAIL.Size = new System.Drawing.Size(42, 13);
            this.lblEMAIL.TabIndex = 6;
            this.lblEMAIL.Text = "E-MAIL";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(233, 74);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 7;
            this.lblCPF.Text = "CPF";
            // 
            // lblESTADO
            // 
            this.lblESTADO.AutoSize = true;
            this.lblESTADO.Location = new System.Drawing.Point(12, 202);
            this.lblESTADO.Name = "lblESTADO";
            this.lblESTADO.Size = new System.Drawing.Size(70, 13);
            this.lblESTADO.TabIndex = 8;
            this.lblESTADO.Text = "ESTADO/UF";
            // 
            // lblCIDADE
            // 
            this.lblCIDADE.AutoSize = true;
            this.lblCIDADE.Location = new System.Drawing.Point(166, 202);
            this.lblCIDADE.Name = "lblCIDADE";
            this.lblCIDADE.Size = new System.Drawing.Size(47, 13);
            this.lblCIDADE.TabIndex = 9;
            this.lblCIDADE.Text = "CIDADE";
            // 
            // lblBAIRRO
            // 
            this.lblBAIRRO.AutoSize = true;
            this.lblBAIRRO.Location = new System.Drawing.Point(9, 242);
            this.lblBAIRRO.Name = "lblBAIRRO";
            this.lblBAIRRO.Size = new System.Drawing.Size(48, 13);
            this.lblBAIRRO.TabIndex = 10;
            this.lblBAIRRO.Text = "BAIRRO";
            // 
            // lblRUA
            // 
            this.lblRUA.AutoSize = true;
            this.lblRUA.Location = new System.Drawing.Point(9, 281);
            this.lblRUA.Name = "lblRUA";
            this.lblRUA.Size = new System.Drawing.Size(30, 13);
            this.lblRUA.TabIndex = 11;
            this.lblRUA.Text = "RUA";
            // 
            // lblNUMERO
            // 
            this.lblNUMERO.AutoSize = true;
            this.lblNUMERO.Location = new System.Drawing.Point(273, 281);
            this.lblNUMERO.Name = "lblNUMERO";
            this.lblNUMERO.Size = new System.Drawing.Size(55, 13);
            this.lblNUMERO.TabIndex = 12;
            this.lblNUMERO.Text = "NÚMERO";
            // 
            // lblSENHA
            // 
            this.lblSENHA.AutoSize = true;
            this.lblSENHA.Location = new System.Drawing.Point(9, 320);
            this.lblSENHA.Name = "lblSENHA";
            this.lblSENHA.Size = new System.Drawing.Size(44, 13);
            this.lblSENHA.TabIndex = 13;
            this.lblSENHA.Text = "SENHA";
            // 
            // txtSOBRENOME
            // 
            this.txtSOBRENOME.Location = new System.Drawing.Point(169, 40);
            this.txtSOBRENOME.Name = "txtSOBRENOME";
            this.txtSOBRENOME.Size = new System.Drawing.Size(148, 20);
            this.txtSOBRENOME.TabIndex = 14;
            this.txtSOBRENOME.TextChanged += new System.EventHandler(this.txtSOBRENOME_TextChanged);
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Location = new System.Drawing.Point(12, 90);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(218, 20);
            this.txtEMAIL.TabIndex = 15;
            this.txtEMAIL.TextChanged += new System.EventHandler(this.txtEMAIL_TextChanged);
            // 
            // txtCIDADE
            // 
            this.txtCIDADE.Location = new System.Drawing.Point(169, 218);
            this.txtCIDADE.Name = "txtCIDADE";
            this.txtCIDADE.Size = new System.Drawing.Size(148, 20);
            this.txtCIDADE.TabIndex = 17;
            this.txtCIDADE.TextChanged += new System.EventHandler(this.txtCIDADE_TextChanged);
            // 
            // txtBAIRRO
            // 
            this.txtBAIRRO.Location = new System.Drawing.Point(12, 258);
            this.txtBAIRRO.Name = "txtBAIRRO";
            this.txtBAIRRO.Size = new System.Drawing.Size(305, 20);
            this.txtBAIRRO.TabIndex = 18;
            this.txtBAIRRO.TextChanged += new System.EventHandler(this.txtBAIRRO_TextChanged);
            // 
            // txtRUA
            // 
            this.txtRUA.Location = new System.Drawing.Point(12, 297);
            this.txtRUA.Name = "txtRUA";
            this.txtRUA.Size = new System.Drawing.Size(258, 20);
            this.txtRUA.TabIndex = 19;
            this.txtRUA.TextChanged += new System.EventHandler(this.txtRUA_TextChanged);
            // 
            // txtSENHA
            // 
            this.txtSENHA.Location = new System.Drawing.Point(12, 336);
            this.txtSENHA.Name = "txtSENHA";
            this.txtSENHA.Size = new System.Drawing.Size(148, 20);
            this.txtSENHA.TabIndex = 20;
            this.txtSENHA.TextChanged += new System.EventHandler(this.txtSENHA_TextChanged);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Location = new System.Drawing.Point(169, 362);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(148, 54);
            this.btnCANCELAR.TabIndex = 22;
            this.btnCANCELAR.Text = "CANCELAR";
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // lblCONFIRMAR
            // 
            this.lblCONFIRMAR.AutoSize = true;
            this.lblCONFIRMAR.Location = new System.Drawing.Point(166, 320);
            this.lblCONFIRMAR.Name = "lblCONFIRMAR";
            this.lblCONFIRMAR.Size = new System.Drawing.Size(111, 13);
            this.lblCONFIRMAR.TabIndex = 24;
            this.lblCONFIRMAR.Text = "CONFIRMAR SENHA";
            // 
            // txtCONFIRMAR
            // 
            this.txtCONFIRMAR.Location = new System.Drawing.Point(169, 336);
            this.txtCONFIRMAR.Name = "txtCONFIRMAR";
            this.txtCONFIRMAR.Size = new System.Drawing.Size(148, 20);
            this.txtCONFIRMAR.TabIndex = 25;
            this.txtCONFIRMAR.TextChanged += new System.EventHandler(this.txtCONFIRMAR_TextChanged);
            // 
            // mtbNUMERO
            // 
            this.mtbNUMERO.Location = new System.Drawing.Point(276, 297);
            this.mtbNUMERO.Mask = "(00000)";
            this.mtbNUMERO.Name = "mtbNUMERO";
            this.mtbNUMERO.Size = new System.Drawing.Size(43, 20);
            this.mtbNUMERO.TabIndex = 27;
            this.mtbNUMERO.ValidatingType = typeof(int);
            this.mtbNUMERO.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbNUMERO_MaskInputRejected);
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(236, 90);
            this.mtbCPF.Mask = "000-000-000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(81, 20);
            this.mtbCPF.TabIndex = 28;
            this.mtbCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCPF_MaskInputRejected);
            // 
            // btnSALVAR
            // 
            this.btnSALVAR.Location = new System.Drawing.Point(12, 362);
            this.btnSALVAR.Name = "btnSALVAR";
            this.btnSALVAR.Size = new System.Drawing.Size(148, 54);
            this.btnSALVAR.TabIndex = 29;
            this.btnSALVAR.Text = "SALVAR";
            this.btnSALVAR.UseVisualStyleBackColor = true;
            this.btnSALVAR.Click += new System.EventHandler(this.btnSALVAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(331, 428);
            this.Controls.Add(this.btnSALVAR);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.mtbNUMERO);
            this.Controls.Add(this.txtCONFIRMAR);
            this.Controls.Add(this.lblCONFIRMAR);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.txtSENHA);
            this.Controls.Add(this.txtRUA);
            this.Controls.Add(this.txtBAIRRO);
            this.Controls.Add(this.txtCIDADE);
            this.Controls.Add(this.txtEMAIL);
            this.Controls.Add(this.txtSOBRENOME);
            this.Controls.Add(this.lblSENHA);
            this.Controls.Add(this.lblNUMERO);
            this.Controls.Add(this.lblRUA);
            this.Controls.Add(this.lblBAIRRO);
            this.Controls.Add(this.lblCIDADE);
            this.Controls.Add(this.lblESTADO);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblEMAIL);
            this.Controls.Add(this.lblSOBRENOME);
            this.Controls.Add(this.cmbESTADO);
            this.Controls.Add(this.txtNOME);
            this.Controls.Add(this.lblNOME);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNOME;
        private System.Windows.Forms.TextBox txtNOME;
        private System.Windows.Forms.ComboBox cmbESTADO;
        private System.Windows.Forms.Label lblSOBRENOME;
        private System.Windows.Forms.Label lblEMAIL;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblESTADO;
        private System.Windows.Forms.Label lblCIDADE;
        private System.Windows.Forms.Label lblBAIRRO;
        private System.Windows.Forms.Label lblRUA;
        private System.Windows.Forms.Label lblNUMERO;
        private System.Windows.Forms.Label lblSENHA;
        private System.Windows.Forms.TextBox txtSOBRENOME;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.TextBox txtCIDADE;
        private System.Windows.Forms.TextBox txtBAIRRO;
        private System.Windows.Forms.TextBox txtRUA;
        private System.Windows.Forms.TextBox txtSENHA;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Label lblCONFIRMAR;
        private System.Windows.Forms.TextBox txtCONFIRMAR;
        private System.Windows.Forms.MaskedTextBox mtbNUMERO;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Button btnSALVAR;
    }
}

