using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuenteDeMando
{
    class Casilla
    {
        private int id;
        private int valor;
        private Boolean daniado;

        public Casilla(int id, int valor)
        {
            this.id = id;
            this.valor = valor;
            this.daniado = false;
        }


        public Boolean getDaniado()
        {
            return daniado;
        }
        public int getId()
        {
            return id;
        }
        public int getValor()
        {
            return valor;
        }
        public void setValor(int valor)
        {
            this.valor = valor;
        }
        public void setDaniado(Boolean danio)
        {
            this.daniado = danio;
        }



    }
}
