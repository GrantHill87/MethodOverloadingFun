using System;

namespace MethodOverloadingFun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, chum! Welcome to Method Overloading. Here, we will craft a single method, that is smart enough to perform many tasks for us.");
            Console.WriteLine("");
            Console.WriteLine("Please select one number.");
            Console.WriteLine("");
            int Axe = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Awesome, now choose another number.");
            Console.WriteLine("");
            int Sword = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            int AxeSword = Add(Axe, Sword);
            Console.WriteLine($"We'll just go ahead and add those two numbers together -- aaaaannnddd we get; {AxeSword}.");
            Console.WriteLine("");
            Console.WriteLine("Ever considered saving for your future? If someone were to ask you how much spare change you had on you right now, what would be your answer?");
            Console.WriteLine("");
            decimal SpareChange = decimal.Parse(Console.ReadLine());
            Console.WriteLine("");
            if(SpareChange < 1 && SpareChange > 0)
            {
                Console.WriteLine($"Only ${SpareChange} dollars?? At least you've got some spare change.");
            }
            else if(SpareChange == 0)
            {
                Console.WriteLine($"Aww, you currently have ${SpareChange} dollars on you at the moment.... No worries.");
            }
            else if(SpareChange > 1 && SpareChange <= 100)
            {
                Console.WriteLine($"Hey! That's great, you've already got ${SpareChange} dollars in your pocket -- put that cash to good use!");
            }
            else if(SpareChange > 100)
            {
                Console.WriteLine($"Whoa! You're well on your way to retirement.... Or at least, you could be, with ${SpareChange}.");
            }
            else if(SpareChange < 0)
            {
                Console.WriteLine($"You're ${SpareChange} in debt?? Understandable, many others are as well.");
            }
            Console.WriteLine("");
            Console.WriteLine("Moving onto sitting down for dinner with your significant other, at a nice restaurant.");
            Console.WriteLine("");
            Console.WriteLine("Would you like to have dinner tonight? (Please answer with true or false.");
            Console.WriteLine("");
            bool SumChecker = bool.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Great. How much would you be willing to spend on an appetizer?");
            Console.WriteLine("");
            decimal spec1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Cool, and the entrees being featured this evening are quite wonderful, how much would you like to spend on your entree?");
            Console.WriteLine("");
            decimal spec2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Excellent, and what you like to expend for your spouse's entree?");
            Console.WriteLine("");
            decimal spec3 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("");
            var SpecTacular = Add(spec1, spec2, spec3, true);
        }
        public static int Add(int spec1, int spec2)
        {
            return spec1 + spec2;
        }
        public static decimal Add(decimal spec1, decimal spec2)
        {
            return spec1 + spec2;
        }
        public static string Add(decimal spec1, decimal spec2, decimal spec3, bool SumChecker)
        {
            var CheckSum = spec1 + spec2 + spec3;

            if(SumChecker == true && CheckSum > 0 && CheckSum < 100)
            {
                return $"Your total bill for the evening is ${CheckSum} dollars.";
            }
            else if(SumChecker == true && CheckSum > 100)
            {
                return $"Alright, high roller! Your total bill for the evening is ${CheckSum} dollars.";
            }
            else if(SumChecker == true && CheckSum <= 100 && CheckSum >0)
            {
                return $"Nice! What a great meal experience -- your total bill comes to the sum of ${CheckSum} dollars.";
            }
            else if(SumChecker == false)
            {
                return "Ok, no dinner for you and your spouse tonight! Bye!";
                Environment.Exit(0);
            }
            else
            {
                return SumChecker.ToString();
            }
        }
    }
}
