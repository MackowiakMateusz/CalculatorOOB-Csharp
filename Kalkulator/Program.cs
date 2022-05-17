using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{//Zrobione przez Mateusza Maćkowiaka
    class Program// No to pomyslalem ze generalnei ten program zrobie zeby pokazywac ze wiem jak dziala interfejs, dziedziczenie, abstrakcja, polymorphism, no i bede pisal te pojecia przy rzeczach ktore to pokazuja
    {
        static void Main(string[] args)
        {
            double kontenerNaLiczbe = 0;//boxing, tzn wiem ze do klasy powinno sie wkladac wartosc no ale generalnei polega na tym ze mapujemy jeden typ zmiennej na inny i wkladamy gdzies do przechowania
            double drugaLiczbaDoOperacji = 0;//bedzie pobrana z konsoli
            List<string> historiaDzialan = new List<string>();
            // musze dac przed petla bo bedzie sie resetowac co dzialanie
            while (true)//niebezpieczne jak sie zrobi kod ktory bedzie cos liczyl w nieskonczonosc i zapomni
            {
                
                string choice;
                
                Operations operationsClassInstance = new Operations();
                Console.WriteLine("Kalkulator przykładowy.");
                Console.WriteLine("Wybierz opcję wpisując numer jako pojedynczą cyfrę.");
                Console.WriteLine("1. Dodawanie dwóch liczb.");
                Console.WriteLine("2. Odejmowanie dwóch liczb.");
                Console.WriteLine("3. Mnożenie dwóch liczb.");
                Console.WriteLine("4. Dzielenie dwóch liczb.");
                Console.WriteLine("5. Wypisz historię działań.");
                Console.WriteLine("6. Zresetuj liczbe i historie dzialań na wartość 0.");
                Console.WriteLine("Obecnie przechowywana liczba:");
                Console.WriteLine(kontenerNaLiczbe);
                choice = Console.ReadLine();
                //generalnie ponizej duzo kodu sie powtarza. moglbym zrobic z tego 2 procedury
                if (choice.Equals("1"))
                {
                    wpiszDrugaLiczbaDoOperacji();
                    
                    //ze to single responsibility principle lamie xd
                    string wiadomosc = historiaDzialan.Count + ". Dodawanie " + kontenerNaLiczbe + " + " + drugaLiczbaDoOperacji;
                    kontenerNaLiczbe = operationsClassInstance.Add(kontenerNaLiczbe, drugaLiczbaDoOperacji);
                    wiadomosc = wiadomosc + " = " + kontenerNaLiczbe;
                    Console.Write(wiadomosc);
                    historiaDzialan.Add(wiadomosc);
                    Console.WriteLine("");
                    Console.WriteLine("Wpisz cokolwiek i kliknij enter zeby kontynuować.");
                    Console.ReadLine();
                }
                else if (choice.Equals("2"))
                {
                    wpiszDrugaLiczbaDoOperacji();
                    string wiadomosc = historiaDzialan.Count + ". Odejmowanie " + kontenerNaLiczbe + " - " + drugaLiczbaDoOperacji;
                    kontenerNaLiczbe = operationsClassInstance.Subtract(kontenerNaLiczbe, drugaLiczbaDoOperacji);
                    wiadomosc = wiadomosc + " = " + kontenerNaLiczbe;
                    Console.Write(wiadomosc);
                    historiaDzialan.Add(wiadomosc);
                    Console.WriteLine("");
                    Console.WriteLine("Wpisz cokolwiek i kliknij enter zeby kontynuować.");
                    Console.ReadLine();
                }
                else if (choice.Equals("3"))
                {
                    wpiszDrugaLiczbaDoOperacji();
                    string wiadomosc = historiaDzialan.Count + ". Mnożenie " + kontenerNaLiczbe + " * " + drugaLiczbaDoOperacji;
                    kontenerNaLiczbe = operationsClassInstance.Multiply(kontenerNaLiczbe, drugaLiczbaDoOperacji);
                    wiadomosc = wiadomosc + " = " + kontenerNaLiczbe;
                    Console.Write(wiadomosc);
                    historiaDzialan.Add(wiadomosc);
                    Console.WriteLine("");
                    Console.WriteLine("Wpisz cokolwiek i kliknij enter zeby kontynuować.");
                    Console.ReadLine();
                }
                else if (choice.Equals("4"))
                {
                    wpiszDrugaLiczbaDoOperacji();
                    string wiadomosc = historiaDzialan.Count + ". Dzielenie " + kontenerNaLiczbe + " / " + drugaLiczbaDoOperacji;
                    kontenerNaLiczbe = operationsClassInstance.Divide(kontenerNaLiczbe, drugaLiczbaDoOperacji);
                    wiadomosc = wiadomosc + " = " + kontenerNaLiczbe;
                    Console.Write(wiadomosc);
                    historiaDzialan.Add(wiadomosc);
                    Console.WriteLine("");
                    Console.WriteLine("Wpisz cokolwiek i kliknij enter zeby kontynuować.");
                    Console.ReadLine();
                }
                else if (choice.Equals("5"))
                {
                    foreach (string i in historiaDzialan)
                    {
                        Console.WriteLine(i);
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Wpisz cokolwiek i kliknij enter zeby kontynuować.");
                    Console.ReadLine();
                }
                else if (choice.Equals("6"))
                {
                    kontenerNaLiczbe = 0;
                    historiaDzialan = new List<string>();
                    Console.WriteLine("");
                    Console.WriteLine("Wpisz cokolwiek i kliknij enter zeby kontynuować.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Wpisałeś złą cyferkę! Albo zrobiłeś w ogóle coś niebywałego.");
                }
                Console.Clear();
                /* cos takiego jeszcze jest, ale normalnie wole else ify
                switch (expression)
                {
                    case x:
                        // code block
                        break;
                    case y:
                        // code block
                        break;
                    default:
                        // code block
                        break;
                }
                */
            }
            void wpiszDrugaLiczbaDoOperacji()
            {
                try
                {
                    drugaLiczbaDoOperacji = Convert.ToDouble(Console.ReadLine());//no generalnie niepotrzebnie robilem methody w klasie operacji do inta i floata, mozna by sie przyczepic 
                }
                catch
                {
                    Console.WriteLine("Zły Input");
                    wpiszDrugaLiczbaDoOperacji();
                }
            }
        }
        
    }
}
