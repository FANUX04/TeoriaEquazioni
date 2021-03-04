using System;
using EquazioniLibrary;
namespace CalcoloEquazioni
{
    class Program
    {
        static void Main(string[] args)
        {
            string risposta2;
            Console.WriteLine("di quale equazioni hai bisogno? ");
            Console.WriteLine("scrivi Equazioni di secondo grado o Equazioni di primo grado");
            Console.WriteLine("ATTENZIONE SCRIVERE NELLO STESSO MODO COME INDICATO!!!");
            risposta2 = Console.ReadLine();
            if (risposta2=="Equazioni di primo grado")
            {
                Console.WriteLine("inserisci il valore del coefficente a ");
                double a = Convert.ToDouble(Console.ReadLine());
                bool controllo = Equazioni.IsDetermined(a);
                if (controllo == false)
                {
                    Console.WriteLine("ATTENZIONE!! la tua equazione potrebbe essere impossibile o indeterminata, per controllare inserici il valore del coefficente b");
                    double b = Convert.ToDouble(Console.ReadLine());
                    bool controllo2 = Equazioni.IsInconsisted(a, b);
                    if (controllo2 == true)
                    {
                        Console.WriteLine("si la tua è un'equazione IMPOSSIBILE");
                    }
                    else
                    {
                        Console.WriteLine("si la tua è un'equazione INDETERMINATA");
                    }
                }
                else
                {
                    Console.WriteLine("OK!! la tua è sicuramente un equazione di primo grado determinata");
                }
                Console.WriteLine("ok se vuoi addesso possiamo risolverla? (la risoluzione restituira solo la stringa)");
                string risposta = Console.ReadLine();
                if (risposta == "si")
                {
                    Console.WriteLine("ok inserisci il valore del coefficente a");
                    double a2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("inserisci anche il termine noto b");
                    double b2 = Convert.ToDouble(Console.ReadLine());
                    string risultato = Equazioni.EquationDegree1(a2, b2);
                    Console.WriteLine($"{risultato}");
                }
                else
                {
                    Console.WriteLine("spero di essere stato d'aiuto");
                } 
            }
            else
            {
                Console.WriteLine("inazitutto controlliamo se la tua è un equazione di primo grado, quindi inserisci il coefficente a");
                double a3 = Convert.ToDouble(Console.ReadLine());
                bool controlliamo = Equazioni.IsDegree2(a3);
                if(controlliamo==false)
                {
                    Console.WriteLine("ATTENTO!! la tua non è un equazione di secondo grado");
                }
                else
                {
                    Console.WriteLine("OK! la tua è un equazione di secondo grado. Vuoi risolverla?");
                    string rispostaFinale = Console.ReadLine();
                    if (rispostaFinale=="si")
                    {
                        Console.WriteLine("inserisci il coefficente b");
                        double b3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("inserisci anche il termine noto c");
                        double c3 = Convert.ToDouble(Console.ReadLine());
                        double deltaDouble = Equazioni.Delta(a3, b3, c3);
                        string delta = Equazioni.RisoluzioneEquazioneSecondoGrado(a3, b3, c3);
                        Console.WriteLine($"il delta è {deltaDouble} e quindi la tua equazione ha {delta}");
                        


                    }
                    else
                    {
                        Console.WriteLine("spero di esserti stato di aiuto");
                    }
                    
                    
                   
                }
            }

            
            

        }
    }
}
