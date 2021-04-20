using System;

namespace higherLower_headsTails
{
    class Program
    {
        public string HT(int num)
        {
            string HT;
            string[] lines = { "heads", "tails" };
            HT = lines[num];
            return HT;
        }
        static int RandomNumberHT()
        {
            Random rastgele = new Random();
            int num = rastgele.Next(0, 2);
            return num;
        }
        static int RandomDice()
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(1, 7);
            return sayi;
        }
        public string Dice(int n, int g)
        {
            string Dice;
            if(n>g)
            {
                Dice = "Lower";
            }
            else if(g>n)
            {
                Dice = "Higher";
            }
            else
            {
                Dice = "Equal";
            }
            return Dice;
        }

        static void Main(string[] args)
        {
            String choice,guessHT,resultHT,resultDice;
            int numberHT,guessDice,numberDice;

            Console.WriteLine("Enter your game: Heads/Tails or DiceGame");
            choice = Console.ReadLine();

            if (choice == "Heads/Tails")
            {
                Console.WriteLine("Enter your guess");
                guessHT = Console.ReadLine();
                guessHT = guessHT.ToLower();
                numberHT = RandomNumberHT();
                resultHT = new Program().HT(numberHT);

                if (guessHT == resultHT)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
                Console.Read();

            }

            else if(choice == "DiceGame")
            {
                Console.WriteLine("Enter your guess");
                guessDice = Console.Read();
                numberDice = RandomDice();
                resultDice = new Program().Dice(numberDice,guessDice);
                Console.WriteLine(resultDice);

                Console.Read();
            }
            
        }
    }
}
