using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskBeispiele
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Task anlegen und später starten
            Task task1 = new Task(TaskMethode);
            task1.Start();

            // Task anlegen und sofort starten
            Task task2 = Task.Factory.StartNew(TaskMethode);

            // Task als Lambda-Ausdruck anlegen und sofort starten
            // () => ... bedeutet keine Übergabeparameter
            Task task3 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Ein Lambda-Task wird ausgeführt ...");
            });

            // Task mit Übergabeparameter anlegen und sofort starten
            string text = "Hallo Welt";
            Task task4 = Task.Factory.StartNew(Ausgabe, text);

            // Task mit Lambda-Ausdruck und Übergabeparameter anlegen und sofort starten
            // Erst Lambda-Ausdruck, dann Übergabeparameter
            Task task5 = Task.Factory.StartNew((parameter) =>
                                               {
                                                   Thread.Sleep(100);
                                                   string s = (string)parameter;
                                                   Console.WriteLine("Lambda: {0}", s);
                                               },
                                               text);

            // Auf Beendigung eines Tasks warten
            task1.Wait();

            // Auf alle Tasks warten
            Task.WaitAll(task1, task2, task3, task4, task5);

            int startWert = 14;
            // Task mit Rückgabewert
            Task<int> task = Task<int>.Factory.StartNew((wert) =>
                                                            {
                                                                Console.WriteLine("\tIm Task...");
                                                                int einWert = (int)wert;
                                                                Thread.Sleep(3000);
                                                                return einWert * einWert;
                                                            }, startWert);

            Console.WriteLine("Warte auf Resultat vom Task...");

            // Blockiert bis Result ein Ergebnis enthält
            Console.WriteLine("Resultat: {0}", task.Result);
        }

        public static void TaskMethode()
        {
            Console.WriteLine("Ein Task wird ausgeführt ...");
            Console.WriteLine();
        }

        public static void Ausgabe(object parameter)
        {
            string s = (string)parameter;
            Console.WriteLine(s);
            Console.WriteLine();
        }
    }
}