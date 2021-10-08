using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random1 = new Random();   
            int trueAnswerCount = 0, falseAnswerCount = 0, clientPoint = 0;
            string answer = "yes";
            int alert= 0;
            while (answer == "yes")
            {
                int number1 = random1.Next(100);
                int number2 = random1.Next(100);
                Console.WriteLine($"Two random numbers\n{number1} {number2}");
                Console.WriteLine("What is sum of this numbers ?");
                int clientSum = int.Parse(Console.ReadLine());
                int sum = number1 + number2;
                if (clientSum == sum)
                {
                    trueAnswerCount++;
                    clientPoint += 5;
                    Console.WriteLine("Ur answer is correct.");
                }
                else
                if (clientPoint != sum)
                {
                    falseAnswerCount++;
                    clientPoint -= 2;
                    if (clientPoint < 0)
                    {
                        clientPoint = 0;
                    }
                    Console.WriteLine("Ur answer is not correct");
                    Console.WriteLine($"Correct answer is:{sum}");
                }
                Console.WriteLine("Do u want to countinue ?");
                string temp= Console.ReadLine().ToLower();
                if (temp == "no")
                {
                    break;
                }                
                answer = temp;
                if(answer!="yes" && answer != "no")
                {
                    Console.WriteLine("Input is not correct.");
                    alert = 1;
                    break;
                }               
            }
            if (alert == 1)
            {
                Console.WriteLine("Game Ended");
            }
            else
            Console.WriteLine($"Your total point:{clientPoint}\nCorrect answer:{trueAnswerCount}\n" +
                $"Wrong answer:{falseAnswerCount}");       
        }
    }
}
