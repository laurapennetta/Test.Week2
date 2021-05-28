using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek2
{
    class StampaImportanza
    {
        internal static void StampaPerImportanza(ArrayList oggettiI)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Task(Importanza).txt");
            try
            {
                using (StreamWriter writer = File.CreateText(path))
                {
                    foreach (TaskUtente t in oggettiI)
                    {
                        writer.WriteAsync(t.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
