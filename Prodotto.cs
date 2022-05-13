using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto

    {
        static private HashSet<string> nomi = new HashSet<string>();
        public int Codice { get; }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { if (nomi.Contains(value))
                    throw new Exception("product name apreadu exist");
                nomi.Add(value);
                nome = value;
            }
        }
        public string? Descrizione { get; set; }


       
        public double Prezzo { get; set; }


        private double iva;

        public double Iva
        {
            get { return iva; }
            set { iva = value; }
        }

        private static Random myRand = new Random();

        public Prodotto(string nome, string descrizione, double prezzo, double iva)
        {
            this.Nome = nome;
            this.Descrizione = descrizione;
            this.Prezzo = prezzo;
            this.Iva = iva;
            Codice = myRand.Next();
        }

        public double GetPrezzoIvato()
        {
            return Prezzo * (1.0 + Iva);
        }

        public string NomeEsteso()
        {
            return string.Format("{0}-{1}", Codice, Nome);
        }

        public string GetCodiceFormatted()
        {
            string scod = Codice.ToString();
            if (scod.Length < 13)
                return new String('0', 13 - scod.Length) + scod;
            else
                return scod;
        }
    }
}
