using System.Globalization;

namespace Threading_Aufgabe_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   Task task1 = Task.Run(() => 

            foreach (string file in Directory.EnumerateFiles(@"D:\Texte\","*.txt"))
            {
              
                    Task.Run(() =>
                    {
                        string freq = CreateFile(file);
                      
                        string text = File.ReadAllText(file);
              
                        WriteToFile(CountWords(text), freq);
                     

                        Console.WriteLine("Finish");
                    });
            }
            Task.WaitAll();
            Console.WriteLine("alles fertig");
            Console.ReadLine();
        }

        public static Dictionary<string,int> CountWords(string text)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (char buchstabe in text)
            {
                if (words.ContainsKey(buchstabe.ToString()) == false)
                {
                    words.Add(buchstabe.ToString(), 1);
                }
                else
                {
                    words[buchstabe.ToString()]++;
                }
            }
            return words;
        }
        public static string CreateFile(string pfad)
        {
            File.Open(Path.ChangeExtension(pfad, ".freq"),FileMode.Create).Close();
            return Path.ChangeExtension(pfad, ".freq");

        }
        public static void WriteToFile(Dictionary<string,int> dict, string pfad)
        {
            using (StreamWriter sw = new StreamWriter(pfad))
            {
               foreach(KeyValuePair<string,int> kvp in dict)
                {
                    sw.WriteLine(kvp.Key + " - " + kvp.Value);
                }
            }
        }
    }
}
