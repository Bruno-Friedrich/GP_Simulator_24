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

namespace GPManager_Editor.Motor
{
    public partial class Frm_Motor : Form
    {
        public Frm_Motor()
        {
            InitializeComponent();

            LoadMotores();
        }

        private void LoadMotores()
        {
            string query = $"{new DbConnection().search_path} SELECT Motor.ID, Pais.NOME AS \"NOME\", Motor.Fornecedora, Motor.Potencia FROM Motor JOIN Pais ON Motor.ID_PAIS_MOTOR = Pais.ID;";


            using (DbConnection db = new DbConnection())
            {
                DataTable dataTable = db.getDataTable(query);

                // Renomear as colunas para nomes mais apresentáveis
                dataTable.Columns["ID"].ColumnName = "ID";
                dataTable.Columns["NOME"].ColumnName = "País";
                dataTable.Columns["FORNECEDORA"].ColumnName = "Fornecedora";
                dataTable.Columns["POTENCIA"].ColumnName = "Potência";

                Dt_Motor.DataSource = dataTable;

                // Ocultar a coluna
                Dt_Motor.Columns["ID"].Visible = false;

                db.Dispose();
            }
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dt_Motor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
