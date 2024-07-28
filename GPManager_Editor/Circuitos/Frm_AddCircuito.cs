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
    public partial class Frm_AddCircuito : Form
    {
        private int numNovoCircuito;

        public Frm_AddCircuito(int numNovoCircuito)
        {
            InitializeComponent();

            Txt_Nome.Text = "Novo GP";
            Txt_Circuito.Text = "Novo circuito";

            Cmb_Pais.SelectedIndexChanged += Cmb_Pais_SelectedIndexChanged;

            this.numNovoCircuito = numNovoCircuito + 1;


            LoadPaises();
        }

        private void LoadPaises()
        {
            string query = $"{new DbConnection().search_path} SELECT ID, NOME FROM Pais;";

            using (DbConnection db = new DbConnection())
            {
                try
                {
                    NpgsqlDataReader reader = db.getReader(query);

                    while (reader.Read())
                    {
                        int id = (int)reader["ID"];
                        string name = reader["NOME"].ToString();
                        Cmb_Pais.Items.Add(new ComboBoxItem(name, id));
                    }

                    // Seleciona o país "Afeganistão" se ele estiver na lista
                    foreach (ComboBoxItem item in Cmb_Pais.Items)
                    {
                        if (item.Name == "Afeganistão")
                        {
                            Cmb_Pais.SelectedItem = item;
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar países: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.Dispose();
                }
            }
        }

        private void Cmb_Pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_Pais.SelectedItem != null)
            {
                ComboBoxItem selectedItem = (ComboBoxItem)Cmb_Pais.SelectedItem;
                int selectedCountryId = selectedItem.Id;
            }
        }


        private void UpDwn_Voltas_ValueChanged(object sender, EventArgs e)
        {
            if (UpDwn_Voltas.Value == 1)
            {
                Lbl_Volta.Text = "volta";
            }
            else
            {
                Lbl_Volta.Text = "voltas";
            }
        }

        private void UpDwn_Retas_ValueChanged(object sender, EventArgs e)
        {
            UpDwn_Curvas.Value = 100 - UpDwn_Retas.Value;
        }

        private void UpDwn_Curvas_ValueChanged(object sender, EventArgs e)
        {
            UpDwn_Retas.Value = 100 - UpDwn_Curvas.Value;
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja cancelar a operação?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja salvar a operação?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = $"{new DbConnection().search_path} INSERT INTO Circuito (NUM, ID_PAIS, PROVA, CIRCUITO, RETAS, CURVAS, VOLTAS, TEMPO_BASE) VALUES ";

                if (Cmb_Pais.SelectedItem != null  && Txt_Nome.Text != null && Txt_Circuito.Text != null)
                {
                    ComboBoxItem selectedItem = (ComboBoxItem)Cmb_Pais.SelectedItem;
                    int selectedCountryId = selectedItem.Id;

                    string tempo = Operation.StringFormat.FormatTime(UpDwn_Minutos.Value, UpDwn_Segundos.Value, UpDwn_Milesimos.Value);
                    
                    // Exemplo de valores de insert: (1, 105, 'GP da Itália 1', 'Circuito 1', 50, 50, 50, '00:01:30.000'),
                    query += $"({numNovoCircuito}, {selectedCountryId}, '{Txt_Nome.Text}', '{Txt_Circuito.Text}', {UpDwn_Retas.Value}, {UpDwn_Curvas.Value}, {UpDwn_Voltas.Value}, '{tempo}')";
                    
                    // Executa a consulta para inserir os dados no banco de dados
                    using (DbConnection db = new DbConnection())
                    {
                        try
                        {
                            db.execCommand(query);
                            MessageBox.Show("Operação salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao salvar a operação: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            db.Dispose();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, preencha todos os campos corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
