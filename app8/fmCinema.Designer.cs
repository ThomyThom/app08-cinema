namespace app8
{
    partial class fmCinema
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btConectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.txbNmCinema = new System.Windows.Forms.TextBox();
            this.txbLogradouro = new System.Windows.Forms.TextBox();
            this.numLogradouro = new System.Windows.Forms.NumericUpDown();
            this.numNrSalas = new System.Windows.Forms.NumericUpDown();
            this.btGravar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbLab = new System.Windows.Forms.ComboBox();
            this.cbPC = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gridCinema = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numLogradouro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNrSalas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCinema)).BeginInit();
            this.SuspendLayout();
            // 
            // btConectar
            // 
            this.btConectar.Location = new System.Drawing.Point(36, 180);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(107, 23);
            this.btConectar.TabIndex = 0;
            this.btConectar.Text = "Verificar Conexão";
            this.btConectar.UseVisualStyleBackColor = true;
            this.btConectar.Click += new System.EventHandler(this.btConectar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do Cinema:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Logradouro:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(417, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Número:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(417, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nº de Salas:";
            // 
            // txbId
            // 
            this.txbId.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbId.Enabled = false;
            this.txbId.Location = new System.Drawing.Point(510, 58);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(128, 20);
            this.txbId.TabIndex = 4;
            // 
            // txbNmCinema
            // 
            this.txbNmCinema.Location = new System.Drawing.Point(510, 89);
            this.txbNmCinema.MaxLength = 30;
            this.txbNmCinema.Name = "txbNmCinema";
            this.txbNmCinema.Size = new System.Drawing.Size(128, 20);
            this.txbNmCinema.TabIndex = 5;
            // 
            // txbLogradouro
            // 
            this.txbLogradouro.Location = new System.Drawing.Point(510, 122);
            this.txbLogradouro.MaxLength = 150;
            this.txbLogradouro.Name = "txbLogradouro";
            this.txbLogradouro.Size = new System.Drawing.Size(128, 20);
            this.txbLogradouro.TabIndex = 6;
            // 
            // numLogradouro
            // 
            this.numLogradouro.Location = new System.Drawing.Point(510, 153);
            this.numLogradouro.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numLogradouro.Name = "numLogradouro";
            this.numLogradouro.Size = new System.Drawing.Size(128, 20);
            this.numLogradouro.TabIndex = 6;
            // 
            // numNrSalas
            // 
            this.numNrSalas.Location = new System.Drawing.Point(510, 183);
            this.numNrSalas.Name = "numNrSalas";
            this.numNrSalas.Size = new System.Drawing.Size(128, 20);
            this.numNrSalas.TabIndex = 6;
            // 
            // btGravar
            // 
            this.btGravar.Location = new System.Drawing.Point(420, 240);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(106, 36);
            this.btGravar.TabIndex = 7;
            this.btGravar.Text = "Gravar";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Info Lab:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "PC:";
            // 
            // cbLab
            // 
            this.cbLab.FormattingEnabled = true;
            this.cbLab.Location = new System.Drawing.Point(89, 58);
            this.cbLab.Name = "cbLab";
            this.cbLab.Size = new System.Drawing.Size(121, 21);
            this.cbLab.TabIndex = 10;
            this.cbLab.Text = "Selecione a sala";
            // 
            // cbPC
            // 
            this.cbPC.FormattingEnabled = true;
            this.cbPC.Location = new System.Drawing.Point(89, 93);
            this.cbPC.Name = "cbPC";
            this.cbPC.Size = new System.Drawing.Size(121, 21);
            this.cbPC.TabIndex = 11;
            this.cbPC.Text = "Selecione o PC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Selecione o PC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(417, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cadastro de Cinema:";
            // 
            // gridCinema
            // 
            this.gridCinema.AllowUserToAddRows = false;
            this.gridCinema.AllowUserToDeleteRows = false;
            this.gridCinema.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridCinema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCinema.Location = new System.Drawing.Point(673, 58);
            this.gridCinema.Name = "gridCinema";
            this.gridCinema.ReadOnly = true;
            this.gridCinema.Size = new System.Drawing.Size(584, 380);
            this.gridCinema.TabIndex = 15;
            this.gridCinema.DoubleClick += new System.EventHandler(this.gridCinema_DoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(670, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Visualização de tabelas";
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(532, 240);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(106, 36);
            this.btClear.TabIndex = 17;
            this.btClear.Text = "Limpar";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(420, 282);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(106, 36);
            this.btDelete.TabIndex = 18;
            this.btDelete.Text = "Excluir";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // fmCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 450);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gridCinema);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbPC);
            this.Controls.Add(this.cbLab);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.numNrSalas);
            this.Controls.Add(this.numLogradouro);
            this.Controls.Add(this.txbLogradouro);
            this.Controls.Add(this.txbNmCinema);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btConectar);
            this.Name = "fmCinema";
            this.Text = "Cadastro de Cinema";
            ((System.ComponentModel.ISupportInitialize)(this.numLogradouro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNrSalas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCinema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.TextBox txbNmCinema;
        private System.Windows.Forms.TextBox txbLogradouro;
        private System.Windows.Forms.NumericUpDown numLogradouro;
        private System.Windows.Forms.NumericUpDown numNrSalas;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbLab;
        private System.Windows.Forms.ComboBox cbPC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gridCinema;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btDelete;
    }
}