namespace app8
{
    partial class frmRoom
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
            this.btConectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.numNrSala = new System.Windows.Forms.NumericUpDown();
            this.numNrPoltronas = new System.Windows.Forms.NumericUpDown();
            this.cbTpSala = new System.Windows.Forms.ComboBox();
            this.numIdCinema = new System.Windows.Forms.NumericUpDown();
            this.btGravar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbLab = new System.Windows.Forms.ComboBox();
            this.cbPC = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gridRoom = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numNrSala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNrPoltronas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdCinema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoom)).BeginInit();
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
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nº da Sala (nrS):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nº Poltronas (nrPoltronas):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(417, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tipo de Sala (tpS):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(417, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "ID do Cinema (FK):";
            // 
            // txbId
            // 
            this.txbId.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbId.Enabled = false;
            this.txbId.Location = new System.Drawing.Point(532, 58);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(106, 20);
            this.txbId.TabIndex = 4;
            // 
            // numNrSala
            // 
            this.numNrSala.Location = new System.Drawing.Point(532, 90);
            this.numNrSala.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numNrSala.Name = "numNrSala";
            this.numNrSala.Size = new System.Drawing.Size(106, 20);
            this.numNrSala.TabIndex = 5;
            // 
            // numNrPoltronas
            // 
            this.numNrPoltronas.Location = new System.Drawing.Point(532, 123);
            this.numNrPoltronas.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numNrPoltronas.Name = "numNrPoltronas";
            this.numNrPoltronas.Size = new System.Drawing.Size(106, 20);
            this.numNrPoltronas.TabIndex = 6;
            // 
            // cbTpSala
            // 
            this.cbTpSala.FormattingEnabled = true;
            this.cbTpSala.Location = new System.Drawing.Point(532, 152);
            this.cbTpSala.Name = "cbTpSala";
            this.cbTpSala.Size = new System.Drawing.Size(106, 21);
            this.cbTpSala.TabIndex = 7;
            this.cbTpSala.Text = "Selecione o tipo";
            // 
            // numIdCinema
            // 
            this.numIdCinema.Location = new System.Drawing.Point(532, 183);
            this.numIdCinema.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numIdCinema.Name = "numIdCinema";
            this.numIdCinema.Size = new System.Drawing.Size(106, 20);
            this.numIdCinema.TabIndex = 8;
            // 
            // btGravar
            // 
            this.btGravar.Location = new System.Drawing.Point(420, 240);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(106, 36);
            this.btGravar.TabIndex = 9;
            this.btGravar.Text = "Gravar no Banco de Dados";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Info Lab:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "PC:";
            // 
            // cbLab
            // 
            this.cbLab.FormattingEnabled = true;
            this.cbLab.Location = new System.Drawing.Point(89, 58);
            this.cbLab.Name = "cbLab";
            this.cbLab.Size = new System.Drawing.Size(121, 21);
            this.cbLab.TabIndex = 12;
            this.cbLab.Text = "Selecione a sala";
            // 
            // cbPC
            // 
            this.cbPC.FormattingEnabled = true;
            this.cbPC.Location = new System.Drawing.Point(89, 93);
            this.cbPC.Name = "cbPC";
            this.cbPC.Size = new System.Drawing.Size(121, 21);
            this.cbPC.TabIndex = 13;
            this.cbPC.Text = "Selecione o PC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Selecione o PC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(417, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cadastro de Sala:";
            // 
            // gridRoom
            // 
            this.gridRoom.AllowUserToAddRows = false;
            this.gridRoom.AllowUserToDeleteRows = false;
            this.gridRoom.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRoom.Location = new System.Drawing.Point(673, 58);
            this.gridRoom.Name = "gridRoom";
            this.gridRoom.ReadOnly = true;
            this.gridRoom.Size = new System.Drawing.Size(584, 380);
            this.gridRoom.TabIndex = 16;
            this.gridRoom.DoubleClick += new System.EventHandler(this.gridRoom_DoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(670, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Visualização de tabelas";
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(532, 240);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(106, 36);
            this.btClear.TabIndex = 18;
            this.btClear.Text = "Limpar";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(420, 282);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(106, 36);
            this.btDelete.TabIndex = 19;
            this.btDelete.Text = "Excluir do Banco de Dados";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // frmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 450);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gridRoom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbPC);
            this.Controls.Add(this.cbLab);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.numIdCinema);
            this.Controls.Add(this.cbTpSala);
            this.Controls.Add(this.numNrPoltronas);
            this.Controls.Add(this.numNrSala);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btConectar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmRoom";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Sala";
            ((System.ComponentModel.ISupportInitialize)(this.numNrSala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNrPoltronas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdCinema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.NumericUpDown numNrSala;
        private System.Windows.Forms.NumericUpDown numNrPoltronas;
        private System.Windows.Forms.ComboBox cbTpSala;
        private System.Windows.Forms.NumericUpDown numIdCinema;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbLab;
        private System.Windows.Forms.ComboBox cbPC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gridRoom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btDelete;
    }
}