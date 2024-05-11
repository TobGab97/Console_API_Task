using static Console_API_Task.Grabber;
using static Console_API_Task.TXTReader;
namespace Console_API_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string repoLocation = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(repoLocation, "data.txt");
            string url = "https://catfact.ninja/fact";

            try
            {
                string localData = ReadTextFromFile(filePath);
                byte[] data = GetDataFromURL(url);
                string textData = System.Text.Encoding.UTF8.GetString(data);
                string combinedData = localData + "\n" + textData;

                File.WriteAllText(filePath, combinedData);
                Console.WriteLine("Dane zostały pomyślnie zapisane do pliku: " + filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wystąpił błąd podczas zapisywania danych: " + ex.Message);
            }
        }
    }
}
