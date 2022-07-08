using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class GestioneEventi
    {
        public string Titolo { get; set; }
        public List<Evento> Eventi { get; private set; }

        public GestioneEventi(string titolo)
        {

            this.Titolo = titolo;
            this.Eventi = new List<Evento>();
        }

        public static void StampaListaEventi(List<Evento> eventi)
        {
            foreach (Evento itemEvento in eventi)
            {
                itemEvento.ToString();
            }
        }

        public void ContoEventi()
        {
            Console.WriteLine("Al momento sono in programma {0} eventi", Eventi.Count());
        }

        public void PulisciListaEventi()
        {
            this.Eventi.Clear();

        }

        public string MostraProgrammaEventi()
        {
            string post = $"****   {this.Titolo}  *****\n";

            foreach (Evento itemEventi in this.Eventi)
            {
                post += itemEventi.ToString();
            }

            return post;
        }



        public void AggiungiEvento(Evento DataEvento)
        {
            this.Eventi.Add(DataEvento);
        }

        public void CercaEventoxData()
        {
            List<Evento> DataEvento = new List<Evento>();
            Console.Write("Inserire la data richiesta per gli eventi nel formato 'gg/mm/yyyy': ");
            string date = Console.ReadLine();
            foreach (Evento itemEvento in this.Eventi)
            {
                if (itemEvento.Data == date)
                {
                    DataEvento.Add(itemEvento);
                }
            }
            Console.Write("gli eventi che ci sono in data {0} sono:", date);
            foreach (Evento itemEvento in DataEvento)
            {
                Console.Write("\nNome: {0}\tData: {1}\tCapienza Max: {2}\tPrenotati: {3}\n", itemEvento.titolo, itemEvento.Data, itemEvento.postiMax, itemEvento.prenotazione);
            }
        }
    }
}
