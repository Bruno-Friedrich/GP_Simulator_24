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
        public Frm_AddCircuito()
        {
            InitializeComponent();

            Txt_Nome.Text = "Novo GP";
            Txt_Circuito.Text = "Novo circuito";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
