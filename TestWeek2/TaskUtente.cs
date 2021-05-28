using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek2
{
    public enum LivelloImportanza
    {
        Basso,
        Medio,
        Alto
    }
    public class TaskUtente
    {
        //Definisco una Classe Task che avrà caratteristiche definite dall'utente
        public string Name { get; set; }
        public string Descrizione { get; set; }
        public LivelloImportanza Importanza { get; set; }
        public DateTime Scadenza { get; set; }

        public override string ToString()//faccio la stampa
        {
            return $"Nome Oggetto:{Name}\nLivello di importanza:{Importanza}\nScadenza:{Scadenza.ToShortDateString()}\nDescrizione:{Descrizione}"; 
        }
    }
}
