using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user);
            //mõlemad mängijad viskavad täringuid;
            //programm kontrollib kumb mängija viskas rohkem;
            //mängija, kes viskab rohkem, ongi mängu võitja;
            //*täringuid visatakse kolm korda;
            //programm kuulutab võitja.

            Random rnd = new Random();

            


            int cpuScore = 0;
            int userScore = 0;

            for (int i = 0; i < 3; i++)
            {

                //arvuti vise
                int cpuRandom = rnd.Next(1, 7);
                //kasuta ja vise
                int userRandom = rnd.Next(1, 7);

                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}.");

            if(cpuRandom < userRandom)
            {
                Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
                userScore = userScore + 1;
            }
            else if(cpuRandom > userRandom)
            {
                Console.WriteLine("Arvuti on mängu võitnud.");
                cpuScore = cpuScore + 1;
            }
            else
            {
                Console.WriteLine("Viik!");
            }
            }


            




        }
    }
}
