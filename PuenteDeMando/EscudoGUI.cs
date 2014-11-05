using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuenteDeMando
{
    public partial class EscudoGUI : Form
    {
        Escudo escudo;
        public EscudoGUI()
        {
            escudo = new Escudo(8, 8);
            escudo.iniciarEscudo();
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public TableLayoutPanel getTable()
        {
            return tableEscudo;
        }
    }
}
