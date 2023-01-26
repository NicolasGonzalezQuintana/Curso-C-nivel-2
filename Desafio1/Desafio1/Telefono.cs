using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Telefono
    {
        public Telefono(string modelo, string marca)
        {
            this.modelo = modelo;  
            this.marca = marca;
        }

        public string modelo { get; }
        public string marca  { get; }
        public string NumeroTelefonico { get; set; }
        private int codigooperador;
        private string contacto;
        public int CodigoOperador
        {
            get { return codigooperador; }
            set
            {
                if (value > 0 && value < 4)
                {
                    codigooperador = value;
                }
                else
                {
                    codigooperador = 0;
                }
               
            }
        }
        public string Contacto
        {
            get { return contacto; }
            set { contacto = value; }
        }
        public string Llamar()
        {
           return "Realizando llamada..." + NumeroTelefonico;
        }
        public string Llamar(string contacto)
        {
            return "Llamando a: " + contacto;
        }
        
    }
}
