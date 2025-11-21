using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace app8
{
    public partial class fmCinema : Form
    {
        public fmCinema()
        {
            InitializeComponent();

            cbLab.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLab.Items.Add("202");
            cbLab.Items.Add("208");
            cbLab.SelectedIndexChanged += cbLab_SelectedIndexChanged;
        }

        private void cbLab_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarListaPCs();
        }

        private void AtualizarListaPCs()
        {
            cbPC.Items.Clear();
            int totalPCs = cbLab.SelectedItem.ToString() == "202" ? 41 : 25;
            for (int i = 1; i <= totalPCs; i++)
            {
                cbPC.Items.Add(i.ToString().PadLeft(2, '0'));
            }
        }

        private string GetConnectionString()
        {
            if (cbLab.SelectedItem == null || cbPC.SelectedItem == null)
            {
                MessageBox.Show("Selecione um laboratório e um PC.");
                return null;
            }
            string sala = cbLab.SelectedItem.ToString();
            string pcNumero = cbPC.SelectedItem.ToString().PadLeft(2, '0');
            string servidor = $"C{sala}-PC{pcNumero}\\SQLEXPRESS";

            return $@"Data Source={servidor};
                      Initial Catalog=SolucaoCinema;
                      Integrated Security=True;
                      Connect Timeout=30;
                      Encrypt=False;
                      TrustServerCertificate=False;
                      ApplicationIntent=ReadWrite;
                      MultiSubnetFailover=False";
        }

        private void CarregarGrid()
        {
            string strConn = GetConnectionString();
            if (strConn == null) return;

            using (SqlConnection con = new SqlConnection(strConn))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter dAdapt = new SqlDataAdapter("SELECT * FROM Cinema", con);
                    DataTable dTable = new DataTable();
                    dAdapt.Fill(dTable);
                    gridCinema.DataSource = dTable;
                    gridCinema.Columns["idCinema"].HeaderText = "ID";
                    gridCinema.Columns["nmCinema"].HeaderText = "Nome do Cinema";
                    gridCinema.Columns["dsEndereco"].HeaderText = "Endereço";
                    gridCinema.Columns["nrSalas"].HeaderText = "Nº de Salas";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problemas no acesso aos dados: \r\n" + ex.Message);
                }
            }
        }

        private void btConectar_Click(object sender, EventArgs e)
        {
            string strConn = GetConnectionString();
            if (strConn == null) return;

            using (SqlConnection objCon = new SqlConnection(strConn))
            {
                try
                {
                    objCon.Open();
                    CarregarGrid();
                    MessageBox.Show($"Conexão bem-sucedida!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar: " + ex.Message);
                }
            }
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            string strConn = GetConnectionString();
            if (strConn == null) return;

            using (SqlConnection objCon = new SqlConnection(strConn))
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(txbNmCinema.Text) || string.IsNullOrWhiteSpace(txbLogradouro.Text) || numLogradouro.Value <= 0 || numNrSalas.Value <= 0)
                    {
                        MessageBox.Show("Preencha todos os campos corretamente. O número do logradouro e de salas devem ser maiores que zero.");
                        return;
                    }

                    objCon.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = objCon;

                    string enderecoCompleto = $"{txbLogradouro.Text}, {numLogradouro.Value}";

                    if (string.IsNullOrEmpty(txbId.Text))
                    {
                        cmd.CommandText = "INSERT INTO Cinema (nmCinema, dsEndereco, nrSalas) VALUES (@nmCinema, @dsEndereco, @nrSalas)";
                    }
                    else
                    {
                        cmd.CommandText = "UPDATE Cinema SET nmCinema = @nmCinema, dsEndereco = @dsEndereco, nrSalas = @nrSalas WHERE idCinema = @idCinema";
                        cmd.Parameters.AddWithValue("@idCinema", txbId.Text);
                    }

                    cmd.Parameters.AddWithValue("@nmCinema", txbNmCinema.Text);
                    cmd.Parameters.AddWithValue("@dsEndereco", enderecoCompleto);
                    cmd.Parameters.AddWithValue("@nrSalas", numNrSalas.Value);

                    cmd.ExecuteNonQuery();
                    CarregarGrid();
                    MessageBox.Show("Operação concluída com sucesso!");
                    btClear_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problemas na operação com o banco de dados: " + ex.Message);
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbId.Text))
            {
                MessageBox.Show("Selecione um cinema da lista para deletar.");
                return;
            }

            var resultado = MessageBox.Show("Tem certeza que deseja deletar este cinema?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.No)
            {
                return;
            }

            string strConn = GetConnectionString();
            if (strConn == null) return;

            using (SqlConnection objCon = new SqlConnection(strConn))
            {
                try
                {
                    objCon.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Cinema WHERE idCinema = @idCinema", objCon);
                    cmd.Parameters.AddWithValue("@idCinema", txbId.Text);
                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Cinema deletado com sucesso!");
                        CarregarGrid();
                        btClear_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Nenhum cinema encontrado com o ID fornecido.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problemas ao deletar o cinema: " + ex.Message);
                }
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txbId.Clear();
            txbNmCinema.Clear();
            txbLogradouro.Clear();
            numLogradouro.Value = 0;
            numNrSalas.Value = 0;
        }

        private void gridCinema_DoubleClick(object sender, EventArgs e)
        {
            if (gridCinema.SelectedRows.Count > 0)
            {
                txbId.Text = gridCinema.CurrentRow.Cells["idCinema"].Value.ToString();
                txbNmCinema.Text = gridCinema.CurrentRow.Cells["nmCinema"].Value.ToString();
                numNrSalas.Value = Convert.ToDecimal(gridCinema.CurrentRow.Cells["nrSalas"].Value);

                string enderecoCompleto = gridCinema.CurrentRow.Cells["dsEndereco"].Value.ToString();
                var match = Regex.Match(enderecoCompleto, @"^(.*?),?\s*(\d+)$");
                if (match.Success)
                {
                    txbLogradouro.Text = match.Groups[1].Value.Trim();
                    numLogradouro.Value = decimal.Parse(match.Groups[2].Value);
                }
                else
                {
                    txbLogradouro.Text = enderecoCompleto;
                    numLogradouro.Value = 0;
                }
            }
        }
    }
}