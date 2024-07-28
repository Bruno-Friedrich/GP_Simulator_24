using GPManager_Editor.Operation;
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
            Frm_AddCircuito frm_AddCircuito = new Frm_AddCircuito();
            frm_AddCircuito.ShowDialog();
        }
    }
}
