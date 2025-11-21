using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app8
{
    public partial class fmGenero : Form
    {
        public fmGenero()
        {
            InitializeComponent();

            cbLab.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLab.Items.Add("202");
            cbLab.Items.Add("208");
            cbLab.SelectedIndexChanged += cbLab_SelectedIndexChanged; // evento de mudança
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
                cbPC.Items.Add(i.ToString().PadLeft(2, '0')); // PC01, PC02...
            }
        }

        private void CarregarGrid()
        {
            string sala = cbLab.SelectedItem.ToString();
            string pcNumero = cbPC.SelectedItem.ToString().PadLeft(2, '0'); // coloca 01, 02, 03...

            string servidor = $"C{sala}-PC{pcNumero}\\SQLEXPRESS";

            string strConn = $@"Data Source={servidor};
                        Initial Catalog=SolucaoCinema;
                        Integrated Security=True;
                        Connect Timeout=30;
                        Encrypt=False;
                        TrustServerCertificate=False;
                        ApplicationIntent=ReadWrite;
                        MultiSubnetFailover=False";

            SqlConnection con = new SqlConnection(strConn);

            try
            {
                con.Open();
                SqlDataAdapter dAdapt =
                new SqlDataAdapter("SELECT * FROM Genero", con);
                DataTable dTable = new DataTable();
                dAdapt.Fill(dTable);
                gridGenero.DataSource = dTable;
                gridGenero.Columns["idGenero"].HeaderText = "ID";
                gridGenero.Columns["idGenero"].Width = 50;
                gridGenero.Columns["dsGenero"].HeaderText = "Gênero";
                gridGenero.Columns["dsGenero"].Width = 250;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas no acesso aos dados \r\n" + ex.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        private void btConectar_Click(object sender, EventArgs e)
        {
            if (cbLab.SelectedItem == null || cbPC.SelectedItem == null)
            {
                MessageBox.Show("As caixas de seleção não foram carregadas corretamente.");
                return;
            }

            string sala = cbLab.SelectedItem.ToString();
            string pcNumero = cbPC.SelectedItem.ToString().PadLeft(2, '0'); // coloca 01, 02, 03...

            string servidor = $"C{sala}-PC{pcNumero}\\SQLEXPRESS";

            string strConn = $@"Data Source={servidor};
                        Initial Catalog=SolucaoCinema;
                        Integrated Security=True;
                        Connect Timeout=30;
                        Encrypt=False;
                        TrustServerCertificate=False;
                        ApplicationIntent=ReadWrite;
                        MultiSubnetFailover=False";

            using (SqlConnection objCon = new SqlConnection(strConn))
            {
                try
                {
                    objCon.Open();
                    CarregarGrid();
                    MessageBox.Show($"Conexão bem-sucedida com {servidor}!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar: " + ex.Message);
                }
            }
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            if (cbLab.SelectedItem == null || cbPC.SelectedItem == null)
            {
                MessageBox.Show("As caixas de seleção não foram carregadas corretamente.");
                return;
            }

            string sala = cbLab.SelectedItem.ToString();
            string pcNumero = cbPC.SelectedItem.ToString().PadLeft(2, '0');

            string servidor = $"C{sala}-PC{pcNumero}\\SQLEXPRESS";

            string strConn = $@"Data Source={servidor};
                        Initial Catalog=SolucaoCinema;
                        Integrated Security=True;
                        Connect Timeout=30;
                        Encrypt=False;
                        TrustServerCertificate=False;
                        ApplicationIntent=ReadWrite;
                        MultiSubnetFailover=False";

            using (SqlConnection objCon = new SqlConnection(strConn))
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(txbGenero.Text))
                    {
                        MessageBox.Show("Digite a descrição do Gênero.");
                        return;
                    }

                    objCon.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = objCon;
                    if (txbId.Text == "")
                    {
                        cmd.CommandText = "Insert into Genero (dsGenero) values (@dsGenero)";
                        cmd.Parameters.AddWithValue("@dsGenero", txbGenero.Text);
                    }
                    else
                    {
                        cmd.CommandText = "Update Genero set dsGenero = @dsGenero where idGenero = @idGenero";
                        cmd.Parameters.AddWithValue("@dsGenero", txbGenero.Text);
                        cmd.Parameters.AddWithValue("@idGenero", txbId.Text);
                    }
                    cmd.ExecuteNonQuery();
                    CarregarGrid();
                    MessageBox.Show("Operação concluída com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problemas com a Inclusão do Gênero. " + ex.Message);
                }
                finally
                {
                    objCon.Close();
                    objCon.Dispose();
                }
                txbId.Clear();
                txbGenero.Clear();
            }
        }

        private void gridGenero_DoubleClick(object sender, EventArgs e)
        {
            if (gridGenero.SelectedRows.Count > 0)
            {
                txbId.Text = gridGenero.CurrentRow.Cells[0].Value.ToString();
                txbGenero.Text = gridGenero.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txbId.Clear();
            txbGenero.Clear();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (cbLab.SelectedItem == null || cbPC.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um laboratório e um PC para se conectar.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txbId.Text))
            {
                MessageBox.Show("Por favor, selecione um gênero da lista para deletar.");
                return;
            }

            var resultado = MessageBox.Show("Tem certeza que deseja deletar este gênero?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.No)
            {
                return;
            }

            string sala = cbLab.SelectedItem.ToString();
            string pcNumero = cbPC.SelectedItem.ToString().PadLeft(2, '0');
            string servidor = $"C{sala}-PC{pcNumero}\\SQLEXPRESS";

            string strConn = $@"Data Source={servidor};
                      Initial Catalog=SolucaoCinema;
                      Integrated Security=True;
                      Connect Timeout=30;
                      Encrypt=False;
                      TrustServerCertificate=False;
                      ApplicationIntent=ReadWrite;
                      MultiSubnetFailover=False";

            using (SqlConnection objCon = new SqlConnection(strConn))
            {
                try
                {
                    objCon.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = objCon;

                    cmd.CommandText = "DELETE FROM Genero WHERE idGenero = @idGenero";
                    cmd.Parameters.AddWithValue("@idGenero", txbId.Text);

                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Gênero deletado com sucesso!");
                        CarregarGrid();
                        btClear_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Nenhum gênero encontrado com o ID fornecido. A operação não foi realizada.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problemas ao deletar o gênero. Erro: " + ex.Message);
                }
            }
        }
    }
}