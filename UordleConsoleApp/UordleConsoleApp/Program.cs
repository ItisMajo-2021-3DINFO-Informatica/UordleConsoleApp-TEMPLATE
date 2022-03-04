using System;

namespace UordleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uordle");
            Console.WriteLine("Indovina una parola");

            // L'applicazione deve:
            // - scegliere una parola a caso
            // - dare la possibilità all'utente di scrivere una parola per indovinare
            // - controllare se il tentativo ha successo, ovvero la parola è stata indovinata
            // - in particolare:
            //   - se tutte le lettere sono corrette in posizione corretta hai vinto
            //   - altrimenti indicare le lettere corrette e se sono in posizione corretta

            const int dimensione = 4;
            string[] paroleDaIndovinare = new string[dimensione];
            paroleDaIndovinare[0] = "Albero";
            paroleDaIndovinare[1] = "Banana";
            paroleDaIndovinare[2] = "Scarpa";
            paroleDaIndovinare[3] = "Scuola";

            Random generatore = new Random();
            int indiceCasuale = generatore.Next(0, dimensione);

            string parolaDaIndovinare = paroleDaIndovinare[indiceCasuale];

            Console.WriteLine("TEST parola da indovinare: " + parolaDaIndovinare);

            bool indovinato = false;
            while (indovinato == false)
            {
                Console.WriteLine("Inserisci il tuo tentativo:");
                string tentativo = Console.ReadLine();

                if (tentativo.Length == parolaDaIndovinare.Length) 
                {
                    int lettereCorrette = 0;
                    for (int i = 0; i < parolaDaIndovinare.Length; i++)
                    {
                        if (parolaDaIndovinare[i] == tentativo[i])
                        {
                            // siamo qui quando le lettere indicate da i sono uguali
                            lettereCorrette++;
                            Console.WriteLine("La lettera in posizione " + (i+1) + " è corretta");
                        }
                    }
                    if (lettereCorrette == parolaDaIndovinare.Length)
                    {
                        indovinato = true;
                    }
                }
            }

            Console.WriteLine("BRAVO hai indovinato!");
        }
    }
}
