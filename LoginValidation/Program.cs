using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja salasõna
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!";
            //muul konsoolis kuvatakse "Vale kasutajatunnus või salasona. Proovi uuesti."
            //kasutajal on kolm katset


            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta oma kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta oma salasõna:");
                string userPassword = Console.ReadLine();

                if (userName != "admin" || userPassword != "admin1234")
                {
                    i++;
                    Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti.");
                    Console.WriteLine($"Veel on jäänud {3 - i} katset.");
                }

                else
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
            }

        }
    }
}
