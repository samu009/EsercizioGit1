using System;
using System.Collections.Generic;
using System.Text;

namespace Brani.Domain
{
    public class CD
    {
        private string titolo;
        private string autore;
        private List<Brano> listaBrani;

        public CD(string titolo, string autore)
        {
            this.titolo = titolo;
            this.autore = autore;
            this.listaBrani = new List<Brano>();
        }

        public string getTitolo()
        {
            return titolo;
        }

        public string getAutore()
        {
            return autore;
        }

        public void setTitolo(string titolo)
        {
            this.titolo = titolo;
        }

        public void setAutore(string autore)
        {
            this.autore = autore;
        }

        public int Durata()
        {
            int durataTotale = 0;
            foreach (Brano brano in listaBrani)
            {
                durataTotale += brano.getDurata();
            }
            return durataTotale;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Brano brano in listaBrani)
            {
                sb.AppendLine(brano.getTitolo());
            }

            return sb.ToString();
        }
    }
}