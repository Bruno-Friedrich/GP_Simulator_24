using GPManager_Editor.Operation;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPManager_Editor.Circuitos
{
    public partial class Frm_Circuitos : Form
    {
        public Frm_Circuitos()
        {
            InitializeComponent();

            // Carregar o DatagridView
            LoadCircuitos();
            this.Load += Frm_Circuitos_Load;
        }

        private void LoadCircuitos()
        {
            string query = $"{new DbConnection().search_path} SELECT Circuito.ID, Circuito.NUM, Pais.NOME AS \"NOME\", Circuito.PROVA, Circuito.CIRCUITO, Circuito.RETAS, Circuito.CURVAS, Circuito.VOLTAS, Circuito.TEMPO_BASE FROM Circuito JOIN Pais ON Circuito.ID_PAIS = Pais.ID;";


            using (DbConnection db = new DbConnection())
            {
                DataTable dataTable = db.getDataTable(query);

                // Renomear as colunas para nomes mais apresentáveis
                dataTable.Columns["ID"].ColumnName = "ID";
                dataTable.Columns["NUM"].ColumnName = "$";
                dataTable.Columns["NOME"].ColumnName = "País";
                dataTable.Columns["PROVA"].ColumnName = "Prova";
                dataTable.Columns["CIRCUITO"].ColumnName = "Circuito";
                dataTable.Columns["RETAS"].ColumnName = "Retas";
                dataTable.Columns["CURVAS"].ColumnName = "Curvas";
                dataTable.Columns["VOLTAS"].ColumnName = "Voltas";
                dataTable.Columns["TEMPO_BASE"].ColumnName = "Tempo Base";

                Dt_Circuitos.DataSource = dataTable;

                // Ocultar a coluna
                Dt_Circuitos.Columns["ID"].Visible = false;

                db.Dispose();
            }
        }

        private void Frm_Circuitos_Load(object sender, EventArgs e)
        {
            Dt_Circuitos.CellFormatting += Dt_Circuitos_CellFormatting;
        }

        private void Dt_Circuitos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (Dt_Circuitos.Columns[e.ColumnIndex].Name == "Retas" || Dt_Circuitos.Columns[e.ColumnIndex].Name == "Curvas")
            {
                if (e.Value != null)
                {
                    int value = Convert.ToInt32(e.Value);
                    e.Value = value.ToString("D2") + "%";
                    e.FormattingApplied = true;
                }
            }
        }

        private void Btn_AddProva_Click(object sender, EventArgs e)
        {
            Frm_AddCircuito frm_AddCircuito = new Frm_AddCircuito(Dt_Circuitos.Rows.Count);
            frm_AddCircuito.ShowDialog();

            LoadCircuitos();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_DelProva_Click(object sender, EventArgs e)
        {
            if (Dt_Circuitos.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = Dt_Circuitos.SelectedRows[0];


                int circuitoId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                // Confirma a exclusão
                DialogResult result = MessageBox.Show($"Deseja realmente excluir o circuito selecionado? Circuito selecionado é {selectedRow.Cells["Prova"].Value}", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Remove o circuito do banco de dados
                    string deleteQuery = $"{new DbConnection().search_path} DELETE FROM Circuito WHERE ID = @ID_Circuito;";

                    using (DbConnection db = new DbConnection())
                    {
                        try
                        {
                            // Adiciona o parâmetro de ID_Circuito para evitar SQL Injection
                            NpgsqlCommand command = new NpgsqlCommand(deleteQuery, db.Connection);
                            command.Parameters.AddWithValue("@ID_Circuito", circuitoId);

                            command.ExecuteNonQuery();

                            // Remove a linha do DataGridView
                            Dt_Circuitos.Rows.Remove(selectedRow);

                            MessageBox.Show("Circuito excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao excluir o circuito: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            db.Dispose();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um circuito para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
