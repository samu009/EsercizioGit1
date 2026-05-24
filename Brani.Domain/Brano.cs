using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brani.Domain
{

    public class Brano
    {

        private string Titolo;
        private string Autore;
        private int Durata; 

        public Brano(string titolo, string autore, int durata)
        {
            Titolo = titolo;
            Autore = autore;
            Durata = durata;
        }

        public string getTitolo()
        {
            return Titolo;
        }

        public string getAutore()
        {
            return Autore;
        }

        public int getDurata()
        {
            return Durata;
        }

        public void setTitolo(string titolo)
        {
            Titolo = titolo;
        }

        public void setAutore(string autore)
        {
            Autore = autore;
        }

        public void setDurata(int durata)
        {
            Durata = durata;
        }

        public override string ToString()
        {
            return $"Titolo: {Titolo} , Autore: {Autore} , Durata: {Durata} secondi";
        }

        // Metodo shortSong
        public bool shortSong(int limiteDurata)
        {
            return this.Durata < limiteDurata;
        }
    }
}
