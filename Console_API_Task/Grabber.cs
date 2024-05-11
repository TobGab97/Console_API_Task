using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Console_API_Task
{
    internal class Grabber
    {
        public static byte[] GetDataFromURL(string url)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    byte[] data = client.DownloadData(url);
                    Console.WriteLine("Dane zostały pomyślnie pobrane z URL: " + url);
                    return data;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wystąpił błąd podczas pobierania danych z URL: " + ex.Message);
                return null;
            }
        }
    }
}
