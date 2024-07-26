using GPManager_Editor.Circuitos;

namespace GPManager_Editor
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void Btn_Circuitos_Click(object sender, EventArgs e)
        {
            Frm_Circuitos frmCircuitos = new Frm_Circuitos();
            frmCircuitos.ShowDialog();
        }
    }
}
