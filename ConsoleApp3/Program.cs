using System;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            try
            {
                Console.WriteLine(
                    "Amynta Group FizzBuzz Program\n" +
                    "------------------------------------------------------------------\n" +
                    "If the number is divisible by 3, Amynta is returned\n" +
                    "If the number is divisible by 5, Group is returned\n" +
                    "If the number is divisible by 3 & 5, Amynta Group is returned\n" +
                    "------------------------------------------------------------------\n" +
                    "Please input the starting number less than 100\n" +
                    "==================================================================");
                string input1 = Console.ReadLine();
                int startPoint = IntConverter(input1);

                Console.WriteLine(
                    "Please input a maximum number larger than the starting number that's 100 or less\n" +
                    "==================================================================");
                string input2 = Console.ReadLine();
                int stoppingPoint = IntConverter(input2);
                Console.WriteLine("==================================================================");

                program.AmyntaGroupFizzBuzz(startPoint, stoppingPoint);
                Console.WriteLine("==================================================================");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            Program.Main(args);
        }

        public void AmyntaGroupFizzBuzz(int startPoint, int stoppingPoint)
        {
            try
            {
                InputCheck(startPoint, stoppingPoint);

                for(int i = startPoint; i <= stoppingPoint; i++)
                {
                    if(i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("Amynta Group");
                    }
                    else if(i % 3 == 0)
                    {
                        Console.WriteLine("Amynta");
                    }
                    else if(i % 5 == 0)
                    {
                        Console.WriteLine("Group");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Check inputs and try again");
            }
        }

        public void InputCheck(int startPoint, int stoppingPoint)
        {
            if(startPoint > 99)
            {
                throw new Exception("Starting number must be less than 100");
            }
            if(startPoint < 1)
            {
                throw new Exception("Starting number must be a positive number");
            }
            if(stoppingPoint < 1)
            {
                throw new Exception("Stopping number must be a positive number");
            }
            if(startPoint > stoppingPoint)
            {
                throw new Exception("Stopping number must be greater than starting number");
            }
            if(stoppingPoint > 100)
            {
                throw new Exception("Stopping number is too large");
            }
        }

        public static int IntConverter(string input)
        {
            int number;

            try
            {
                if(int.TryParse(input, out number))
                {
                    return number;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine(input + " is not a positive whole number");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                throw;
            }
        }
    }
}