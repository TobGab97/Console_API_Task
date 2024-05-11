using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_API_Task
{
    internal class TXTReader
    {
        public static string ReadTextFromFile(string filePath)
        {
            try
            {
                string text = File.ReadAllText(filePath);
                Console.WriteLine("Dane zostały pomyślnie odczytane z pliku: " + filePath);
                return text;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wystąpił błąd podczas odczytywania danych z pliku: " + ex.Message);
                return null;
            }
        }
    }
}
