//Per prima cosa è necessario creare una classe Evento che abbia i seguenti attributi:
//● titolo
//● data
//● capienza massima dell’evento
//● numero di posti prenotati

//Aggiungere metodi getter e setter in modo che:
//● titolo sia in lettura e in scrittura
//● data sia in lettura e scrittura
//●  numero di posti per la capienza massima sia solo in lettura
//●  numero di posti prenotati sia solo in lettura
//ai setters inserire gli opportuni controlli in modo che la data non sia già passata, 
//che il titolo non sia vuoto e che la capienza massima di posti sia un numero positivo.
//In caso contrario sollevare opportune eccezioni.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Evento
    {
        public string titolo;

        protected string data;
        public int postiMax;
        public int prenotazione { get; protected set; }

        public string Data
        {
            get { return data; }

            set
            {
                string today = DateTime.Today.ToShortDateString();
                DateTime Today = DateTime.Parse(today);
                DateTime tempDate = DateTime.Parse(value);
                if (Today > tempDate)
                {
                    throw new Exception("***Attenzione l'evento è giù passato!!! ***");
                }

                this.data = value;
            }
        }

        public string TitoloEvento
		{
			get
			{
				return titolo;
			}
			set
			{
				titolo = value;

				if (value.Length <= 0)
				{
					throw new ArgumentException("Questo campo non può essere vuoto...");
				}
			}
            
        }

		public int PostiMax
		{
			get
			{
				return postiMax;
			}
			set
			{

                if (value <= 0)
                {
                    throw new Exception("***Attenzione Devi inserire un nome all'evento!! ***");
                }

                postiMax = value;
            }
		}
        public Evento(string titolo, int postiMax, string data)
        {

            this.TitoloEvento = titolo;

            this.PostiMax = postiMax;

            this.Data = data;

            this.prenotazione = 0;
        }





        public void getPrenota(int numero)
		{
            string today = DateTime.Today.ToShortDateString();
            DateTime Today = DateTime.Parse(today);
            DateTime date = DateTime.Parse(this.data);
            if (Today > date)
            {
                throw new Exception("***Attenzione l'evento è giù passato!!! ***");
            }
            if (this.prenotazione >= this.PostiMax)
            {
                throw new Exception("***Attenzione non ci sono posti disponibili!!! ***");
            }
            this.prenotazione += numero;
        }

		public void CancellaPrenotazione(int codDisdetta)
		{
            string today = DateTime.Today.ToShortDateString();
            DateTime Today = DateTime.Parse(today);
            DateTime date = DateTime.Parse(this.data);
            if (Today > date)
            {
                throw new Exception("***Attenzione l'evento è giù passato!!! ***");
            }
            if ((this.prenotazione -= codDisdetta) <= 0 || this.prenotazione <= 0)
            {
                throw new Exception("***Attenzione non si puo revocare tutti questi posti!!! ***");
            }

            this.prenotazione += codDisdetta;

            this.prenotazione -= codDisdetta;
        }
	}
    //public override string ToString()
    //{
      // return this.data + " - " + this.titolo;
    //}
}

