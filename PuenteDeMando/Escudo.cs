using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuenteDeMando
{
    class Escudo{

        private Casilla[,] escudo;
        private int danio;
        private int x;
        private int y;
        public Escudo(int tamaniox,int tamanioy)
        {
            this.x = tamaniox;
            this.y = tamanioy;
            this.escudo = new Casilla[x, y];
            this.danio = 0;
        }

        public void compruebaEscudo()
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (escudo[i, j].getDaniado())
                    {
                        danio++;
                        PuenteDeMandoGUI.egui.getTable().GetControlFromPosition(i, j).BackColor=System.Drawing.Color.Red;
                    }
                }
            }
        }

        public void iniciarEscudo()
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    PuenteDeMandoGUI.egui.getTable().GetControlFromPosition(i, j).BackColor = System.Drawing.Color.Green;

                }
            }
        }
    
    }
}
