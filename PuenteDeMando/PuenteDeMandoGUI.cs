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
    public partial class PuenteDeMandoGUI : Form
    {
        public static EscudoGUI egui;

        public PuenteDeMandoGUI()
        {
            InitializeComponent();
        }


        private void MostrarEscudo(object sender, EventArgs e)
        {
            egui = new EscudoGUI();
            egui.Opacity = .95;
            egui.StartPosition = FormStartPosition.CenterScreen;
            egui.Show();
        }

        private void MostrarAboutUs(object sender, EventArgs e)
        {
            AboutUsGUI au=new AboutUsGUI();
            au.StartPosition = FormStartPosition.CenterScreen; 
            au.Opacity = .95;
            au.Show();
        }

        private void MenuSalir(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
