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
		public int PostiRiservati { get; private set; }

		public Evento(string titolo, DateTime data, uint postiMax, int postiRiservati = 0)
		{
			this.TitoloEvento = titolo;
			this.Data = data;
			this.PostiMax = postiMax;
			this.PostiRiservati = postiRiservati;
		}
		public string TitoloEvento
		{
			get
			{
				return TitoloEvento;
			}
			set
			{
				TitoloEvento = value;

				if (value.Length == 0)
				{
					throw new ArgumentException("Questo campo non può essere vuoto...");
				}
			}
		}
		public DateTime Data
		{
			get
			{
				return Data;
			}
			set
			{
				Data = value;
				DateTime now = DateTime.Now;
				if (Data < now.Date)
				{
					throw new Exception("no..mi dispiace.");
				}
				else if (Data == now.Date)
				{
					throw new Exception("L evento è oggi");
				}
			}
		}
		public uint PostiMax
		{
			get
			{
				return PostiMax;
			}
			private set
			{
				PostiMax = value;
				try
				{
					if (PostiMax is uint)
					{
						PostiMax = (uint)PostiMax;
					}
				}
				catch (Exception)
				{
					Console.WriteLine("inserimento non valido. Il numero deve essere positivo.");
				}
			}
		}
	

		public void Prenota()
		{

		}

		public void CancellaPrenotazione()
		{

		}
	}
}
