namespace app8
{
    partial class fmGenero
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
            this.txbId = new System.Windows.Forms.TextBox();
            this.txbGenero = new System.Windows.Forms.TextBox();
            this.btGravar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbLab = new System.Windows.Forms.ComboBox();
            this.cbPC = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gridGenero = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridGenero)).BeginInit();
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
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gênero:";
            // 
            // txbId
            // 
            this.txbId.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbId.Enabled = false;
            this.txbId.Location = new System.Drawing.Point(485, 58);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(100, 20);
            this.txbId.TabIndex = 4;
            // 
            // txbGenero
            // 
            this.txbGenero.Location = new System.Drawing.Point(485, 89);
            this.txbGenero.MaxLength = 20;
            this.txbGenero.Name = "txbGenero";
            this.txbGenero.Size = new System.Drawing.Size(100, 20);
            this.txbGenero.TabIndex = 5;
            // 
            // btGravar
            // 
            this.btGravar.Location = new System.Drawing.Point(420, 173);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(106, 36);
            this.btGravar.TabIndex = 7;
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
            this.cbLab.Sorted = true;
            this.cbLab.TabIndex = 10;
            this.cbLab.Text = "Selecione a sala";
            // 
            // cbPC
            // 
            this.cbPC.FormattingEnabled = true;
            this.cbPC.Location = new System.Drawing.Point(89, 93);
            this.cbPC.Name = "cbPC";
            this.cbPC.Size = new System.Drawing.Size(121, 21);
            this.cbPC.Sorted = true;
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
            this.label7.Size = new System.Drawing.Size(203, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Gravação no Banco de Dados:";
            // 
            // gridGenero
            // 
            this.gridGenero.AllowUserToAddRows = false;
            this.gridGenero.AllowUserToDeleteRows = false;
            this.gridGenero.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGenero.Location = new System.Drawing.Point(673, 58);
            this.gridGenero.Name = "gridGenero";
            this.gridGenero.ReadOnly = true;
            this.gridGenero.Size = new System.Drawing.Size(343, 355);
            this.gridGenero.TabIndex = 15;
            this.gridGenero.DoubleClick += new System.EventHandler(this.gridGenero_DoubleClick);
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
            this.btClear.Location = new System.Drawing.Point(532, 173);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(106, 36);
            this.btClear.TabIndex = 17;
            this.btClear.Text = "Cancelar";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(420, 215);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(106, 36);
            this.btDelete.TabIndex = 18;
            this.btDelete.Text = "Excluir do Banco de Dados";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // fmGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1044, 450);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gridGenero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbPC);
            this.Controls.Add(this.cbLab);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.txbGenero);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btConectar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fmGenero";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Gênero";
            ((System.ComponentModel.ISupportInitialize)(this.gridGenero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.TextBox txbGenero;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbLab;
        private System.Windows.Forms.ComboBox cbPC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gridGenero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btDelete;
    }
}