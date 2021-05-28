using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek2
{
    class GestioneTask
    {
        internal static TaskUtente InserimentoTask()
        {
            TaskUtente task = new TaskUtente();
            try
            {
                Console.WriteLine("Inserisci il nome del task:");
                task.Name = Console.ReadLine();
                Console.WriteLine("Inserisci il livello di importanza del task:");
                //a questo punto devo gestire l'eccezione dell'enum
                bool success;
                int[] values = new int[] { 0, 1, 2 };
                foreach (int enumValue in values)
                {
                    Console.WriteLine(Enum.GetName(typeof(LivelloImportanza), enumValue));
                }
                success = Enum.TryParse(Console.ReadLine(), out LivelloImportanza tipo);
                task.Importanza = tipo;
                //ora devo gestire le eccezioni per la data
                //creo un ciclo do while con all'interno:
                //-la gestione delle eccezioni
                //-e il vincolo che la data debba essere uguale o posteriore alla data corrente
                //il ciclo fa in modo che l'utente debba inserire una data fino a che la data non rispetta i requisiti
                Console.WriteLine("Inserisci la data (0000/00/00) di scadenza del task:");
                success = DateTime.TryParse(Console.ReadLine(), out DateTime scadenza);
                while (!success)
                {
                    Console.WriteLine("Inserisci una data coerente");
                    success = DateTime.TryParse(Console.ReadLine(), out scadenza);
                }
                //Verifica della scadenza
                int result = DateTime.Compare(scadenza, DateTime.Today);
                if (result < 0)
                {
                    Console.WriteLine("Data di scadenza non valida");
                    Console.WriteLine("Devi inserire una data che sia uguale o posteriore alla data corrente");
                    Console.WriteLine("Ricominciamo l'inserimento");
                    InserimentoTask();
                }
                task.Scadenza = scadenza;
                Console.WriteLine("Inserisci una breve descrizione del task:");
                task.Descrizione = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return task;
        }

        internal static void StampaTask2(ArrayList oggettiI)
        {
            foreach (TaskUtente t in oggettiI)
            {
                Console.WriteLine(t);
            }
        }

        internal static TaskUtente CercaTask2(ArrayList oggetti)
        {
            Console.WriteLine("Cerca il task in base al livello di importanza");
            Console.WriteLine("Inserisci il livello di importanza del task:"); 
            bool success;
            int[] values = new int[] { 0, 1, 2 };
            foreach (int enumValue in values)
            {
                Console.WriteLine(Enum.GetName(typeof(LivelloImportanza), enumValue));
            }
            success = Enum.TryParse(Console.ReadLine(), out LivelloImportanza level);
            foreach (TaskUtente ti in oggetti)
            {
                if (ti.Importanza == level)
                {
                    return ti;
                }
            }
            return null;
        }

        internal static TaskUtente CercaTask(ArrayList oggetti)
        {
            Console.WriteLine("Cerca il task in base al nome");
            string nome = Console.ReadLine();
            foreach (TaskUtente t in oggetti)
            {
                if (t.Name == nome)
                {
                    return t;
                }
            }
            return null;
        }

        public static void StampaTask(ArrayList oggetti)
        {
            foreach (TaskUtente t in oggetti)
            {
                Console.WriteLine(t);
            }
        }
    }
}
