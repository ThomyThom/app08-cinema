using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app8
{
    public partial class frmRoom : Form
    {
        public frmRoom()
        {
            InitializeComponent();

            // Configuração dos ComboBoxes de Conexão
            cbLab.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLab.Items.Add("202");
            cbLab.Items.Add("208");
            cbLab.SelectedIndexChanged += cbLab_SelectedIndexChanged;

            // Configuração do ComboBox de Tipo de Sala
            cbTpSala.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTpSala.Items.Add("2D");
            cbTpSala.Items.Add("3D");
            cbTpSala.Items.Add("IMAX");
        }

        private void cbLab_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarListaPCs();
        }

        private void AtualizarListaPCs()
        {
            cbPC.Items.Clear();

            // Determina o total de PCs com base no laboratório selecionado
            int totalPCs = cbLab.SelectedItem?.ToString() == "202" ? 41 : 25;

            for (int i = 1; i <= totalPCs; i++)
            {
                cbPC.Items.Add(i.ToString().PadLeft(2, '0')); // PC01, PC02...
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
                    // ALTERAÇÃO AQUI: Modificada a consulta SQL para incluir JOIN com a tabela Cinema
                    SqlDataAdapter dAdapt =
                    new SqlDataAdapter("SELECT s.idSala, s.nrSala, s.nrPoltronas, s.tpSala, s.idCinema, c.nmCinema " +
                                       "FROM Sala s " +
                                       "INNER JOIN Cinema c ON s.idCinema = c.idCinema", con);

                    DataTable dTable = new DataTable();
                    dAdapt.Fill(dTable);
                    gridRoom.DataSource = dTable;

                    // Configuração das colunas existentes
                    gridRoom.Columns["idSala"].HeaderText = "ID";
                    gridRoom.Columns["idSala"].Width = 50;
                    gridRoom.Columns["nrSala"].HeaderText = "Nº Sala";
                    gridRoom.Columns["nrPoltronas"].HeaderText = "Poltronas";
                    gridRoom.Columns["tpSala"].HeaderText = "Tipo";
                    gridRoom.Columns["idCinema"].HeaderText = "ID Cinema";

                    // ADIÇÃO AQUI: Configuração da nova coluna "Nome Cinema"
                    gridRoom.Columns["nmCinema"].HeaderText = "Nome Cinema";
                    // Opcional: Ajustar a largura da nova coluna
                    gridRoom.Columns["nmCinema"].Width = 200;
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

            // Validação dos campos numéricos
            if (numNrSala.Value <= 0 || numNrPoltronas.Value <= 0 || numIdCinema.Value <= 0 || cbTpSala.SelectedItem == null)
            {
                MessageBox.Show("Preencha todos os campos corretamente. Os números de Sala, Poltronas e ID do Cinema devem ser maiores que zero e o Tipo de Sala deve ser selecionado.");
                return;
            }

            using (SqlConnection objCon = new SqlConnection(strConn))
            {
                try
                {
                    objCon.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = objCon;

                    if (string.IsNullOrEmpty(txbId.Text))
                    {
                        // INSERT
                        cmd.CommandText = "INSERT INTO Sala (nrSala, nrPoltronas, tpSala, idCinema) VALUES (@nrSala, @nrPoltronas, @tpSala, @idCinema)";
                    }
                    else
                    {
                        // UPDATE
                        cmd.CommandText = "UPDATE Sala SET nrSala = @nrSala, nrPoltronas = @nrPoltronas, tpSala = @tpSala, idCinema = @idCinema WHERE idSala = @idSala";
                        cmd.Parameters.AddWithValue("@idSala", txbId.Text);
                    }

                    cmd.Parameters.AddWithValue("@nrSala", numNrSala.Value);
                    cmd.Parameters.AddWithValue("@nrPoltronas", numNrPoltronas.Value);
                    cmd.Parameters.AddWithValue("@tpSala", cbTpSala.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@idCinema", numIdCinema.Value);


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

        private void btClear_Click(object sender, EventArgs e)
        {
            txbId.Clear();
            numNrSala.Value = 0;
            numNrPoltronas.Value = 0;
            cbTpSala.SelectedIndex = -1; // Limpa a seleção do ComboBox
            numIdCinema.Value = 0;
        }

        private void gridRoom_DoubleClick(object sender, EventArgs e)
        {
            if (gridRoom.SelectedRows.Count > 0)
            {
                txbId.Text = gridRoom.CurrentRow.Cells["idSala"].Value.ToString();
                numNrSala.Value = Convert.ToDecimal(gridRoom.CurrentRow.Cells["nrSala"].Value);
                numNrPoltronas.Value = Convert.ToDecimal(gridRoom.CurrentRow.Cells["nrPoltronas"].Value);

                string tpSala = gridRoom.CurrentRow.Cells["tpSala"].Value.ToString().Trim();
                cbTpSala.SelectedIndex = cbTpSala.Items.IndexOf(tpSala);

                numIdCinema.Value = Convert.ToDecimal(gridRoom.CurrentRow.Cells["idCinema"].Value);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbId.Text))
            {
                MessageBox.Show("Selecione uma sala da lista para deletar.");
                return;
            }

            var resultado = MessageBox.Show("Tem certeza que deseja deletar esta sala?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
                    SqlCommand cmd = new SqlCommand("DELETE FROM Sala WHERE idSala = @idSala", objCon);
                    cmd.Parameters.AddWithValue("@idSala", txbId.Text);
                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Sala deletada com sucesso!");
                        CarregarGrid();
                        btClear_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma sala encontrada com o ID fornecido.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problemas ao deletar a sala: " + ex.Message);
                }
            }
        }
    }
}