using System;

namespace StudentInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValid = false;
            int number;
            bool proceed = false;
            string cont;
            string input;

            do
            {
                // Welcome Message
                Console.Clear();
                Console.WriteLine("Welcome to Dev.Build (4.0) class. Which student would you like to learn more about?");
                number = 0;
                
                // Do Loop for validation for first quesiton
                

                do
                {
                    isValid = false;
                    Console.WriteLine("Enter a number 1-16 or list for a complete list of students: ");
                    input = Console.ReadLine();
                    if (input == "list")
                    {
                        break;
                    }
                    isValid = int.TryParse(input, out number);
                    if (number < 1 || number > 16)
                    {
                        Console.WriteLine("That student does not exist. Please try again.");
                        isValid = false;
                    }

                    
                } while (isValid == false);

                if (input == "list" )
                {
                    ListStudents();
                }
                else
                {
                    Console.WriteLine($"Student number {number} is {GetName(number - 1)}.");
                    Console.WriteLine("1 = Favorite Candy");
                    Console.WriteLine("2 = Previous Title");
                    do
                    {
                        isValid = false;
                        Console.Write($"What would you like to know about {GetName(number - 1)}? ");
                        input = Console.ReadLine();
                        if (input == "1" || input == "2")
                        {
                            isValid = true;
                            switch (input)
                            {
                                case "1":
                                    Console.WriteLine($"{GetName(number - 1)}'s favorite candy is {GetCandy(number - 1)}.");
                                    break;
                                case "2":
                                    Console.WriteLine($"{GetName(number - 1)}'s previous title is {GetPrevTitle(number - 1)}.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.Write("That data does not exist. Please try again. ");
                        }
                    } while (isValid == false);
                }
                

                Console.WriteLine();
                do
                {
                    Console.Write("Would you like to learn about another student?: (y/n) ");
                    cont = Console.ReadLine();
                    cont = cont.ToUpper();
                } while (cont != "Y" && cont != "N");
                if (cont == "N")
                {
                    proceed = true;
                }
            } while(proceed == false);
            
        }

        static void ListStudents()
        {
            for(int StudentNumber = 0; StudentNumber < 16; StudentNumber++)
            {
                Console.WriteLine($"Student number {StudentNumber + 1} is {GetName(StudentNumber)}");
            }
        }
       
        static string GetName(int StudentNumber)
        {
            string[] Names =
            {
                "Eugene Hill",
                "Kathryn Pidek",
                "David Heizer",
                "Audrey, Hepburn",
                "YuGi Muto",
                "Takashi Shiro",
                "Keith Yeun",
                "Lance Shada",
                "Pidge Holt",
                "Hunk Labine",
                "Princess Alura",
                "Jace Beleren",
                "Chandra Nalar",
                "Ajani Goldmane",
                "Liliana Vess",
                "Gideon Jura"
            };
            return Names[StudentNumber];
        }

        static string GetCandy(int StudentNumber)
        {
            string[] Names =
            {
                "Sour Patch Kids",
                "Reeses' PeanutButter Cups",
                "Reeses Sticks",
                "Spaghetti al Pomodoro",
                "Dark Choclate",
                "Nestle Cruch bars",
                "Red Hots",
                "Sour Punch Straws",
                "Pidge Holt",
                "Runts",
                "Ferro Rocher",
                "Salt-Water Taffy",
                "Atomic Fireball",
                "Kit-Kat",
                "Black Licorrice",
                "Red Liccorice"
            };
            return Names[StudentNumber];
        }

        static string GetPrevTitle(int StudentNumber)
        {
            string[] Names =
            {
                "Document Alias Analsyt",
                "Vendor Support Specialst",
                "Appraisal Management Specialist",
                "Actress",
                "King of Games",
                "Pilot of Back Lion",
                "Pilot of Red Lion",
                "Pilot of Blue Lion",
                "Pilot of Green Lion",
                "Pilot of Yellow Lion",
                "Princess of the planet Altea",
                "Vryn's Prodigy",
                "Fire of Kaladesh",
                "Mentor",
                "Heretical Healer",
                "Hero of Akros"
            };
            return Names[StudentNumber];
        }
    }
}
