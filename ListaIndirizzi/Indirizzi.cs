using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaIndirizzi
{
    internal class Indirizzi
    {

        public string nome;
        public string cognome;
        public string via;
        public string città;
        public string provincia;
        public int codicePostale;

        //creo costruttore

        public Indirizzi(string nome, string cognome, string via, string città, string provincia, int codicePostale)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.via = via;
            this.città = città;
            this.provincia = provincia;
            this.codicePostale = codicePostale;

        }

        //metodo override

        public override string ToString()
        {
            string rappresentazioneInStringa = "indirizzo\n";
            
            rappresentazioneInStringa += "nome: \t" + this.nome + "\n";
            rappresentazioneInStringa += "cognome: \t" + this.cognome + "\n";
            rappresentazioneInStringa += "via: \t" + this.via + "\n";
            rappresentazioneInStringa += "città: \t" + this.città + "\n";
            rappresentazioneInStringa += "provincia: \t" + this.provincia + "\n";
            rappresentazioneInStringa += "codice postale: \t" + this.codicePostale + "\n";

            return rappresentazioneInStringa;
        }








    }
}
