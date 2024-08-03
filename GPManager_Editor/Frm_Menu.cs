using GPManager_Editor.Circuitos;
using GPManager_Editor.Motor;

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

        private void Btn_Motor_Click(object sender, EventArgs e)
        {
            Frm_Motor frmMotor = new Frm_Motor();
            frmMotor.ShowDialog();
        }
    }
}
