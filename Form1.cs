using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.VisualBasic;

namespace AgendaContatos
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;");
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand command = new SqlCommand();
        int Id = 0;
        public Form1()
        {
            InitializeComponent();
            ExibirDados();


        }

        private void ExibirDados()
        {

            try
            {
                connection.Open();
                DataTable Data_Table = new DataTable();
                adapter = new SqlDataAdapter("SELECT * FROM Contatos", connection);
                adapter.Fill(Data_Table);
                AgendaDataGridView.DataSource = Data_Table;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void LimparDados()
        {
            NomeTextBox.Text = string.Empty;
            EndereçoTextBox.Text = string.Empty;
            TelefoneTextBox.Text = string.Empty;
            CelularTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
        }
        private void AdicionarButton_Click(object sender, EventArgs e)
        {
            LimparDados();
        }


        private void SalvarButton_Click(object sender, EventArgs e)
        {
            if (NomeTextBox.Text != "" && EndereçoTextBox.Text != "" && CelularTextBox.Text != ""
                && TelefoneTextBox.Text != "" && EmailTextBox.Text != "")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Contatos(Nome,Endereço,Celular,Telefone,Email) " +
                        "VALUES(@nome,@endereço,@celular,@telefone,@email)", connection);
                    connection.Open();
                    cmd.Parameters.AddWithValue("@nome", NomeTextBox.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@endereço", EndereçoTextBox.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@celular", CelularTextBox.Text);
                    cmd.Parameters.AddWithValue("@telefone", TelefoneTextBox.Text);
                    cmd.Parameters.AddWithValue("@email", EmailTextBox.Text.ToLower());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Contato Salvo com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:" + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                    ExibirDados();
                    LimparDados();
                }

            }
        }


        private void EditarButton_Click(object sender, EventArgs e)
        {
            string IdEditar = Interaction.InputBox("Informe o ID:", "Editar Contato");

            if (NomeTextBox.Text != "" && EndereçoTextBox.Text != "" && CelularTextBox.Text != ""
    && TelefoneTextBox.Text != "" && EmailTextBox.Text != "")
            {
                try
                {


                    SqlCommand cmd = new SqlCommand("UPDATE Contatos SET Nome = @nome, Endereço = @endereço, " +
                    "Celular = @celular,Telefone = @telefone, Email = @email WHERE Id = @id", connection);
                    connection.Open();
                    cmd.Parameters.AddWithValue("@id", IdEditar);
                    cmd.Parameters.AddWithValue("@nome", NomeTextBox.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@endereço", EndereçoTextBox.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@celular", CelularTextBox.Text);
                    cmd.Parameters.AddWithValue("@telefone", TelefoneTextBox.Text);
                    cmd.Parameters.AddWithValue("@email", EmailTextBox.Text.ToLower());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Contato Salvo com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:" + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                    ExibirDados();
                    LimparDados();
                }
            }
        }

        private void DeletarButton_Click(object sender, EventArgs e)
        {
            string IdDelete = Interaction.InputBox("Qual o Id a ser Deletado?", "Deletar Id!");
            if (!string.IsNullOrEmpty(IdDelete))
            {

                if (MessageBox.Show("Deseja Deletar este registro ?", "Agenda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("DELETE Contatos WHERE Id = @id", connection);
                        connection.Open();
                        cmd.Parameters.AddWithValue("@id", IdDelete);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Contato Excluido com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }catch(Exception ex)
                    {
                        MessageBox.Show("Erro:" + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                        ExibirDados();
                        LimparDados();
                    }
       
                }
            }
        }

        private void SairButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AgendaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Id = Convert.ToInt32(AgendaDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                NomeTextBox.Text = AgendaDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                EndereçoTextBox.Text= AgendaDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                CelularTextBox.Text = AgendaDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                TelefoneTextBox.Text = AgendaDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                EmailTextBox.Text = AgendaDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch
            {

            }
        }
    }
}


