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
            string query = $"{new DbConnection().search_path} SELECT Circuito.ID, Circuito.NUM, Pais.NOME AS \"NOME\", Circuito.PROVA, Circuito.CIRCUITO, Circuito.RETAS, Circuito.CURVAS, Circuito.VOLTAS, Circuito.TEMPO_BASE FROM Circuito JOIN Pais ON Circuito.ID_PAIS = Pais.ID ORDER BY NUM ASC;";


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
                DataGridViewRow selectedRow = Dt_Circuitos.SelectedRows[0];

                int circuitoId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                int circuitoNUM = Convert.ToInt32(selectedRow.Cells["$"].Value);

                DialogResult result = MessageBox.Show($"Deseja realmente excluir o circuito selecionado? Circuito selecionado é {selectedRow.Cells["Prova"].Value}", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string deleteQuery = $"{new DbConnection().search_path} DELETE FROM Circuito WHERE ID = @ID_Circuito;";
                    string updateQuery = $"{new DbConnection().search_path} UPDATE Circuito SET NUM = NUM - 1 WHERE NUM > @NUM_Circuito;";

                    using (DbConnection db = new DbConnection())
                    {
                        try
                        {
                            NpgsqlCommand deleteCommand = new NpgsqlCommand(deleteQuery, db.Connection);
                            deleteCommand.Parameters.AddWithValue("@ID_Circuito", circuitoId);

                            deleteCommand.ExecuteNonQuery();

                            NpgsqlCommand updateCommand = new NpgsqlCommand(updateQuery, db.Connection);
                            updateCommand.Parameters.AddWithValue("@NUM_Circuito", circuitoNUM);

                            updateCommand.ExecuteNonQuery();

                            Dt_Circuitos.Rows.Remove(selectedRow);

                            foreach (DataGridViewRow row in Dt_Circuitos.Rows)
                            {
                                if (Convert.ToInt32(row.Cells["$"].Value) > circuitoNUM)
                                {
                                    row.Cells["$"].Value = Convert.ToInt32(row.Cells["$"].Value) - 1;
                                }
                            }

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

        private void Dt_Circuitos_SelectionChanged(object sender, EventArgs e)
        {
            if (Dt_Circuitos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = Dt_Circuitos.SelectedRows[0];
                int circuitoNUM = Convert.ToInt32(selectedRow.Cells["$"].Value);

                int ultimoNUM = Dt_Circuitos.Rows.Count;

                if (circuitoNUM == 1)
                {
                    Btn_Sobe.BackColor = SystemColors.ControlDarkDark;
                    Btn_Sobe.Enabled = false;

                    Btn_Desce.BackColor = SystemColors.ActiveCaptionText;
                    Btn_Desce.Enabled = true;
                }
                else if (circuitoNUM == ultimoNUM)
                {
                    Btn_Sobe.BackColor = SystemColors.ActiveCaptionText;
                    Btn_Sobe.Enabled = true;

                    Btn_Desce.BackColor = SystemColors.ControlDarkDark;
                    Btn_Desce.Enabled = false;
                }
                else
                {
                    Btn_Sobe.BackColor = SystemColors.ActiveCaptionText;
                    Btn_Sobe.Enabled = true;

                    Btn_Desce.BackColor = SystemColors.ActiveCaptionText;
                    Btn_Desce.Enabled = true;
                }
            }
            else
            {
                Btn_Sobe.BackColor = SystemColors.ControlDarkDark;
                Btn_Sobe.Enabled = false;

                Btn_Desce.BackColor = SystemColors.ControlDarkDark;
                Btn_Desce.Enabled = false;
            }
        }

        private void Btn_Sobe_Click(object sender, EventArgs e)
        {
            if (Dt_Circuitos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = Dt_Circuitos.SelectedRows[0];
                int currentNUM = Convert.ToInt32(selectedRow.Cells["$"].Value);
                int newNUM = currentNUM - 1;

                // Encontra a linha acima (newNUM)
                foreach (DataGridViewRow row in Dt_Circuitos.Rows)
                {
                    if (Convert.ToInt32(row.Cells["$"].Value) == newNUM)
                    {
                        // Troca os valores de NUM
                        row.Cells["$"].Value = currentNUM;
                        selectedRow.Cells["$"].Value = newNUM;

                        // Atualiza o banco de dados
                        using (DbConnection db = new DbConnection())
                        {
                            string query1 = $"{new DbConnection().search_path} UPDATE Circuito SET NUM = @NUM WHERE ID = @ID;";
                            NpgsqlCommand command1 = new NpgsqlCommand(query1, db.Connection);
                            command1.Parameters.AddWithValue("@NUM", currentNUM);
                            command1.Parameters.AddWithValue("@ID", row.Cells["ID"].Value);
                            command1.ExecuteNonQuery();

                            string query2 = $"{new DbConnection().search_path} UPDATE Circuito SET NUM = @NUM WHERE ID = @ID;";
                            NpgsqlCommand command2 = new NpgsqlCommand(query2, db.Connection);
                            command2.Parameters.AddWithValue("@NUM", newNUM);
                            command2.Parameters.AddWithValue("@ID", selectedRow.Cells["ID"].Value);
                            command2.ExecuteNonQuery();
                        }

                        // Reordena as linhas no DataGridView
                        Dt_Circuitos.Sort(Dt_Circuitos.Columns["$"], System.ComponentModel.ListSortDirection.Ascending);
                        Dt_Circuitos.ClearSelection();
                        Dt_Circuitos.Rows[newNUM - 1].Selected = true;

                        break;
                    }
                }
            }
        }


        private void Btn_Desce_Click(object sender, EventArgs e)
        {
            if (Dt_Circuitos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = Dt_Circuitos.SelectedRows[0];
                int currentNUM = Convert.ToInt32(selectedRow.Cells["$"].Value);
                int newNUM = currentNUM + 1;

                // Encontra a linha abaixo (newNUM)
                foreach (DataGridViewRow row in Dt_Circuitos.Rows)
                {
                    if (Convert.ToInt32(row.Cells["$"].Value) == newNUM)
                    {
                        row.Cells["$"].Value = currentNUM;
                        selectedRow.Cells["$"].Value = newNUM;

                        using (DbConnection db = new DbConnection())
                        {
                            string query1 = $"{new DbConnection().search_path} UPDATE Circuito SET NUM = @NUM WHERE ID = @ID;";
                            NpgsqlCommand command1 = new NpgsqlCommand(query1, db.Connection);
                            command1.Parameters.AddWithValue("@NUM", currentNUM);
                            command1.Parameters.AddWithValue("@ID", row.Cells["ID"].Value);
                            command1.ExecuteNonQuery();

                            string query2 = $"{new DbConnection().search_path} UPDATE Circuito SET NUM = @NUM WHERE ID = @ID;";
                            NpgsqlCommand command2 = new NpgsqlCommand(query2, db.Connection);
                            command2.Parameters.AddWithValue("@NUM", newNUM);
                            command2.Parameters.AddWithValue("@ID", selectedRow.Cells["ID"].Value);
                            command2.ExecuteNonQuery();
                        }

                        // Reordena as linhas no DataGridView
                        Dt_Circuitos.Sort(Dt_Circuitos.Columns["$"], System.ComponentModel.ListSortDirection.Ascending);
                        Dt_Circuitos.ClearSelection();
                        Dt_Circuitos.Rows[newNUM - 1].Selected = true;

                        break;
                    }
                }
            }
        }

        private void Dt_Circuitos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_AddCircuito frm_AddCircuito = new Frm_AddCircuito(Dt_Circuitos.SelectedRows[0]);
            frm_AddCircuito.ShowDialog();

            LoadCircuitos();
        }
    }
}
