using System;
using System.Collections;

namespace TestWeek2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList oggetti = new ArrayList();
            ArrayList oggettiI = new ArrayList();
            bool cicli = true;
            while (cicli)
            {
                int scelta = MenuAScelta();
                switch (scelta)//analizzo la scelta fatta dal mio utente
                {
                    case 1:
                        TaskUtente taska = GestioneTask.InserimentoTask();
                        oggetti.Add(taska);
                        break;
                    case 2:
                        GestioneTask.StampaTask(oggetti);
                        break;
                    case 3:
                        TaskUtente taske = GestioneTask.CercaTask(oggetti);
                        try
                        {
                            oggetti.Remove(taske);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Task non trovato, riprova.");
                        }
                        break;
                    case 4:
                        StampaFinale.StampaSuFile(oggetti);
                        break;
                    case 5:
                        TaskUtente taski = GestioneTask.CercaTask2(oggetti);
                        try
                        {
                            oggettiI.Add(taski);
                            GestioneTask.StampaTask2(oggettiI);
                            StampaImportanza.StampaPerImportanza(oggettiI);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Task non trovati, riprova.");
                        }
                        break;
                    case 0://gestisce l'eccezione
                        break;
                    default://si chiude l'app
                        cicli = false;
                        Console.WriteLine("Arrivederci!");
                        break;
                }
            }
        }

        public static int MenuAScelta()
        {
            int scelta = 0;
            Console.WriteLine("1. Inserisci un task");
            Console.WriteLine("2. Aggiungi il task");
            Console.WriteLine("3. Elimina il task");
            Console.WriteLine("4. Stampa i task inseriti");
            Console.WriteLine("5. Stampa i task in base al livello di importanza");
            Console.WriteLine("6. Exit");
            try
            {
                scelta = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                scelta = 0;
            }
            return scelta;
        }
    }
}
