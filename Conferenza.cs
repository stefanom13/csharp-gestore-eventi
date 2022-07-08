using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Conferenza : Evento
    {
        private string frontman;
        private double prezzo;

        public string Frontman
        {
            get { return frontman; }

            set
            {
                frontman = value;
            }
        }

        public double Prezzo
        {
            get { return prezzo; }

            set
            {
                prezzo = value;
            }
        }

        public Conferenza(string titolo, int postiMax, string data, string frontman, double prezzo) : base(titolo, postiMax, data)
        {
            this.frontman = frontman;
            this.prezzo = prezzo;
            this.titolo = titolo;
            this.postiMax = postiMax;
            this.data = data;

        }

        public override string ToString()
        {

            return this.data + " - " + this.titolo + " - " + this.frontman + " - " + GetPrezzoFormattato() + " euro";
        }

        public string GetPrezzoFormattato()
        {

            string prezzoFormattato = this.Prezzo.ToString("0.00");

            return prezzoFormattato;
        }
    }
}
