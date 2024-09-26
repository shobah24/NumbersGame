namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");


            var rand = new Random();
            int myChoice = rand.Next(1, 21);
            int guessLeft = 5;         // chances to guess the right number 
            bool rightGuess = false;

            //Console.WriteLine(myChoice);    //rnd number - to check if the code works or not myChoice is the random number 


            // the while-loop is there to check if the user guesses right or not 
            while (guessLeft > 0 && !rightGuess)
            {
                int urGuess = Convert.ToInt32(Console.ReadLine());
                string guess = CheckGuess(urGuess, myChoice);
                Console.WriteLine(guess);

                if (urGuess == myChoice)
                {
                    rightGuess = true;  // right guess = done
                    //break;

                }
                else
                {
                    guessLeft--;

                }

                if (guessLeft == 0 && !rightGuess)     // used to return this text if there is no right guess after 5 attempts
                {
                    Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");
                }

            }
        }


        static string CheckGuess(int urGuess, int myChoice) // method used for to check the users guess 
        {

            if (urGuess == myChoice)
            {
                return "Wohoo! Du gjorde det!";     //return is used to return as a value in this code "Wohoo! Du gjorde det!" etc..

            }
            else if (urGuess < myChoice)
            {
                return "Tyvärr du gissade för lågt!";

            }
            else
            {
                return "Tyvärr du gissade för högt!";
            }

        }






    }
}
