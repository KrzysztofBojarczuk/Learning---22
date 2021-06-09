using System;

namespace _114
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                Console.WriteLine("Mikser kolorów.");
                Console.WriteLine("Czerwony, niebieski, żółty.");
                Console.WriteLine("Wprowadź pierwszy kolor:");
                string colorFirst = Console.ReadLine();
                Console.WriteLine("Wprwoadź drugi drugi kolor:");
                string colorSecond = Console.ReadLine();
                string red = "czerwony";
                string blue = "niebieski";
                string yellow = "żółty";
                if ((colorFirst == red && colorSecond == blue) || (colorFirst == blue && colorSecond == red))
                {
                    Console.WriteLine("Otrzymałeś kolor fioletowy.");
                }
                else if ((colorFirst == red && colorSecond == yellow) || (colorFirst == yellow && colorSecond == red))
                {
                    Console.WriteLine("Otrzymałeś kolor pomrańczowy.");
                }
                else if ((colorFirst == blue && colorSecond == yellow) | (colorFirst == yellow && colorSecond == blue))
                {
                    Console.WriteLine("Otrzymałeś kolor zielony.");
                }
                else
                {
                    Console.WriteLine("Wprwoadziłeś zły kolor.");
                }
                Console.WriteLine();
                Console.WriteLine("Czy chcesz zakońcyzć program? Jeśl tak wpisz Tak / tak. Jesli chcesz dalej kontynować wćisjnij inny przycisk.");
                string end = Console.ReadLine();
                if (end == "Tak" || end == "tak")
                {
                    break;
                }
                Console.Clear();
            }
        }
    }
}
