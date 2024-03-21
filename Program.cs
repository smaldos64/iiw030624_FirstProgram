namespace FirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string UserAnswer;
            int NumberOfAnswers;
            int CurrentAnswer;
            int GeneratedNumber;

            do
            {
                Console.Clear();
                Console.Write("Ønsker du at køre programmet (j/n) : ");
                UserAnswer = Console.ReadLine();

                if (UserAnswer != "n")
                {
                    NumberOfAnswers = 1;
                    Random rnd = new Random();
                    GeneratedNumber = rnd.Next(1, 101);  
                    // creates a number between 1 and 100
                   
                    do
                    {
                        Console.Write($"Indtast dit {NumberOfAnswers}. Tal : ");
                        CurrentAnswer = Convert.ToInt32( Console.ReadLine() );
                        // Læs en string ind fra tastaturet og konverter denne string
                        // om til en integer (et heltal)
                        if (CurrentAnswer == GeneratedNumber)
                        {
                            Console.WriteLine($"Du gættede tallet {GeneratedNumber} på {NumberOfAnswers} forsøg !!!");
                            Console.Write("Tryk en tast for at forsætte spillet");
                            Console.ReadLine();
                        }
                        else
                        {
                            NumberOfAnswers++;
                            if (CurrentAnswer > GeneratedNumber)
                            {
                                Console.WriteLine($"{CurrentAnswer} er større end det generede tal !!!");
                            }
                            else
                            {
                                Console.WriteLine($"{CurrentAnswer} er mindre end det generede tal !!!");
                            }
                        }

                    } while (CurrentAnswer != GeneratedNumber);
                    
                }

            } while (UserAnswer != "n");

            Console.WriteLine("");
            Console.WriteLine("Du har nu afsluttet programmet !!!");
        }
    }
}
