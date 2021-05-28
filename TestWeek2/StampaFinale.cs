using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek2
{
    class StampaFinale
    {
        public static void StampaSuFile(ArrayList oggetti)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Task.txt");
            try
            {
                using (StreamWriter writer = File.CreateText(path))
                {
                    foreach (TaskUtente t in oggetti)
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
