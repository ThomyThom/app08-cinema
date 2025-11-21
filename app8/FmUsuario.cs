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
    public partial class FmUsuario : Form
    {
        public FmUsuario()
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
                new SqlDataAdapter("SELECT * FROM USUARIO ", con);
                DataTable dTable = new DataTable();
                dAdapt.Fill(dTable);
                gridUser.DataSource = dTable;
                gridUser.Columns["idUsuario"].HeaderText = "ID";
                gridUser.Columns["idUsuario"].Width = 50;
                gridUser.Columns["Usuario"].HeaderText = "User";
                gridUser.Columns["Senha"].HeaderText = "Password";
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
            if (cbLab == null || cbPC == null)
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
            if (cbLab == null || cbPC == null)
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

            // Criar o objeto de conexão
            using (SqlConnection objCon = new SqlConnection(strConn))
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(txbUser.Text) || string.IsNullOrWhiteSpace(txbPassword.Text))
                    {
                        MessageBox.Show("Digite o usuário e a senha.");
                        return;
                    }


                    // Abrir a conexão
                    objCon.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = objCon;
                    if (txbId.Text == "")
                    {
                        cmd.CommandText = "Insert into Usuario (Usuario , Senha) values (@Usuario , @Senha)";
                        cmd.Parameters.AddWithValue("@Usuario", txbUser.Text);
                        cmd.Parameters.AddWithValue("@Senha", txbPassword.Text);
                    }
                    else
                    {
                        cmd.CommandText = "Update Usuario set Senha =@Senha where idUsuario = @idUsuario";
                        cmd.Parameters.AddWithValue("@Senha", txbPassword.Text);
                        cmd.Parameters.AddWithValue("@idUsuario", txbId.Text);

                    }
                    cmd.ExecuteNonQuery();
                    CarregarGrid();
                    MessageBox.Show("Operação concluída com sucesso!");


                }
                catch (Exception ex)
                {
                    // Tratar exceções
                    MessageBox.Show("Problemas com a Inclusão do Filme. " + ex.Message);
                }
                finally
                {
                    // fecha a conexão
                    objCon.Close();
                    objCon.Dispose();
                }
                txbId.Clear();
                txbUser.Clear();
                txbPassword.Clear();
            } // A conexão será fechada automaticamente aqui
        }
        private void btSSMS_Click(object sender, EventArgs e)
        {
            string sala = cbLab.SelectedItem.ToString();
            string pcNumero = cbPC.SelectedItem.ToString();

            string servidor = $"C{sala}-PC{pcNumero}\\SQLEXPRESS";

            try
            {
                // Caminho padrão do SSMS 2019 (alterar se necessário)
                string ssmsPath = @"C:\Program Files (x86)\Microsoft SQL Server Management Studio 19\Common7\IDE\Ssms.exe";

                if (System.IO.File.Exists(ssmsPath))
                {
                    System.Diagnostics.Process.Start(ssmsPath, $"-S {servidor}");
                }
                else
                {
                    MessageBox.Show("SQL Server Management Studio não encontrado no caminho padrão.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o SSMS: " + ex.Message);
            }
        }

        private void gridUser_DoubleClick(object sender, EventArgs e)
        {
            if (gridUser.SelectedRows.Count > 0) 
            { 
                txbId.Text = gridUser.CurrentRow.Cells[0].Value.ToString();
                txbUser.Text = gridUser.CurrentRow.Cells[1].Value.ToString();
                txbPassword.Text = gridUser.CurrentRow.Cells[2].Value.ToString();
                txbUser.Enabled = false;
            }

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txbId.Clear();
            txbUser.Clear();
            txbPassword.Clear();
            txbUser.Enabled = true;    
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            // 1. Validação inicial dos ComboBoxes e da caixa de texto do ID
            if (cbLab.SelectedItem == null || cbPC.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um laboratório e um PC para se conectar.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txbId.Text))
            {
                MessageBox.Show("Por favor, selecione um usuário da lista para deletar.");
                return;
            }

            // 2. Mensagem de confirmação para o usuário
            var resultado = MessageBox.Show("Tem certeza que deseja deletar este usuário?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.No)
            {
                return; // Usuário cancelou a operação
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

                    // 3. Define o comando SQL para deletar, usando o nome da sua tabela 'Usuario'
                    cmd.CommandText = "DELETE FROM Usuario WHERE idUsuario = @idUsuario";

                    // 4. Adiciona o parâmetro de forma segura para evitar SQL Injection
                    cmd.Parameters.AddWithValue("@idUsuario", txbId.Text);

                    // 5. Executa o comando e verifica se alguma linha foi afetada
                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Usuário deletado com sucesso!");
                        CarregarGrid(); // Atualiza o grid
                        btClear_Click(sender, e); // Limpa os campos chamando o método do botão Limpar
                    }
                    else
                    {
                        MessageBox.Show("Nenhum usuário encontrado com o ID fornecido. A operação não foi realizada.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problemas ao deletar o usuário. Erro: " + ex.Message);
                }
                // O bloco 'using' já garante que a conexão será fechada,
                // então o bloco 'finally' com objCon.Close() é desnecessário.
            }
        }
    }
}