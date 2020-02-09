using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            programOne();
            programTwo();
            programFour();
            programSix();
            timeProgram();
            //In the below line specify the word for palindrome pairs to be checkd upon
            List<String> vect = new List<String>() { "abcd", "dcba", "lls", "s", "sssll" };


            checkPalindromePair(vect);

            Console.ReadLine();
            

        }

        

        public static void programOne()
        {
            Console.WriteLine("Enter the number n for the pattern to be printed");
            string userInput = Console.ReadLine();
            int inputNumber = Convert.ToInt32(userInput);
            int i, j;
            // Logic is to loop from the number given and print all the preceeding numbers by decrementing the loop by one in every iteration
            for (i = inputNumber; i >= 1; i--)
            {
                for (j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        public static void programTwo()
        {
            try
            {

                Console.WriteLine("Enter the number n for the pattern to be printed");
                string userInput2 = Console.ReadLine();
                int inputNumber = Convert.ToInt32(userInput2);
                int i;
                // Logic is that every suceeeding number get added by 1,2,3.. on each iteration
                int sum = 0;
                for (i = 1; i <= inputNumber; i++)
                {
                    sum = sum + i;
                    Console.Write(sum + " ");

                }
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printPattern");
            }

        }
        public static void programFour()
        {

            // Logic is to check each number and divisibility for each individual case(3,5,7 and each pair is checked)
            Console.WriteLine("\n \n");
            for (int i = 1; i <= 110; i++)
            {
                if (i % 11 == 0)
                {
                    Console.WriteLine(i);
                    continue;
                }


                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write(" US ");
                }
                else if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.Write(" UF ");
                }
                else if (i % 5 == 0 && i % 7 == 0)
                {
                    Console.Write(" SF ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("U ");
                }
                else if (i % 7 == 0)
                {
                    Console.Write("S ");
                }

                else
                {
                    Console.Write(i + " ");
                }
            }


        }
        public static void timeProgram()
        {
            Console.WriteLine("Enter the time to convert");
            string userInput = Console.ReadLine();
            string time = userInput;
            DateTime dt;
            bool res = DateTime.TryParse(time, out dt);
            // Printing out the time in 24 Hour format. If Incorrect format is given, output will be 00:00:00
            Console.WriteLine(dt.ToString("HH:mm:ss"));
            double seconds = TimeSpan.Parse(dt.ToString("HH:mm:ss")).TotalSeconds;
            int sec = Convert.ToInt32(seconds % 45);
            int min = (int)((seconds / 45) % 60);
            int hr = Convert.ToInt32(seconds / 2700);
            //After the required processing time in new format is printed
            Console.WriteLine(string.Format("{0:D2}:{1:D2}:{2:D2}", hr, min, sec));
            Console.WriteLine(" ");
        }
        static Boolean isPalindrome(String str)
        {
            int len = str.Length;

            // Compare each character from starting 
            // with its corresponding character from last 
            for (int i = 0; i < len / 2; i++)
                if (str[i] != str[len - i - 1])
                    return false;

            return true;
        }

        // Function to check if a palindrome pair exists 
        static void checkPalindromePair(List<String> vect)
        {
            // Consider each pair one by one 
            // Using this logic all the possible palindrome pairs are printed
            for (int i = 0; i < vect.Count - 1; i++)
            {
                for (int j = i + 1; j < vect.Count; j++)
                {
                    String str = "";

                    // Concatenate both strings 
                    str = vect[i] + vect[j];
                    if (isPalindrome(str))
                    {
                        Console.WriteLine(str);

                    }
                    str = vect[j] + vect[i];
                    if (isPalindrome(str))
                    {
                        Console.WriteLine(str);

                    }
                }
            }

        }
        public static void programSix()
        {
            Console.WriteLine("Enter the number n of Stones in the bag :");
            string userInput2 = Console.ReadLine();
            int inputNumber = Convert.ToInt32(userInput2);
            // The logic is that it is always possible for the user to win if the number of stones is not divisible by 4
            if (inputNumber % 4 == 0)
                Console.WriteLine(" False: It is not possible for the user to win the game ! ");
            else
            {
                //Printing  one combination that is always possible if the user wins
                Console.WriteLine(" It is possible for the player to win. One Possible Set of moves is :  ");
                int m, n = 1;
                Console.Write(" Set of Moves : ");
                for (m = 1; m <= inputNumber; m++)
                    Console.Write(n + " ");
                
                Console.WriteLine("  ");




            }
        }

        
    }

}





        




        
    
    
