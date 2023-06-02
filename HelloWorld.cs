using System;
using System.Threading;

class Program
{
    static void Main()
    {
        bool isValidInput = false;
        bool isValidOperator = false;

        // Struct that is named "keyInfo" and is assigned when the user presses a key
        //ConsoleKeyInfo keyInfo = Console.ReadKey();
        //Console.WriteLine("You pressed " + keyInfo.Key);
        //keyInfo.Key != ConsoleKey.Escape
        //Console.ReadLine();

        
        //string uKey = int.Parse(Console.ReadKey());
        //Console.WriteLine(uKey);
        //Console.ReadLine();
                while (!isValidInput)
            {
                try
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.WriteLine(@"
 ______     ______     __         ______     __  __     __         ______     ______   ______     ______    
/\  ___\   /\  __ \   /\ \       /\  ___\   /\ \/\ \   /\ \       /\  __ \   /\__  _\ /\  __ \   /\  == \   
\ \ \____  \ \  __ \  \ \ \____  \ \ \____  \ \ \_\ \  \ \ \____  \ \  __ \  \/_/\ \/ \ \ \/\ \  \ \  __<   
 \ \_____\  \ \_\ \_\  \ \_____\  \ \_____\  \ \_____\  \ \_____\  \ \_\ \_\    \ \_\  \ \_____\  \ \_\ \_\ 
  \/_____/   \/_/\/_/   \/_____/   \/_____/   \/_____/   \/_____/   \/_/\/_/     \/_/   \/_____/   \/_/ /_/ 
                                                                                                            
");
                //First Number
                Console.WriteLine("Enter your first number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                isValidInput = true;
                Console.WriteLine(num1);
                
                // Operator
                Console.WriteLine("Select an operator: +, -, *, /");
                string opSymbol = Console.ReadLine();
                isValidInput = true;

                    if (opSymbol == "+")
                    {
                        Console.WriteLine("Choose a second number");
                        int numAdd = Convert.ToInt32(Console.ReadLine());
                        int addTotal = num1 + numAdd;
                        Console.WriteLine("It equals = " + addTotal);
                    }
                    else if (opSymbol == "-")
                    {
                        Console.WriteLine("Choose a second number");
                        int numSub = Convert.ToInt32(Console.ReadLine());
                        int subTotal = num1 - numSub;
                        Console.WriteLine("it equals = " + subTotal);
                    }
                    else if (opSymbol == "*")
                    {
                        Console.WriteLine("Choose a second number");
                        int numMulti = Convert.ToInt32(Console.ReadLine());
                        int multiTotal = num1 * numMulti;
                        Console.WriteLine("it equals = " + multiTotal);
                    }
                    else if (opSymbol == "/")
                    {
                        Console.WriteLine("Choose a second number");
                        double numDivi = Convert.ToInt32(Console.ReadLine());
                        double diviTotal = num1 / numDivi;
                        Console.WriteLine("it equals = " + diviTotal);
                    }
                }   
            catch (FormatException)
                {
                    Console.WriteLine("Wrong input");
                }
            }
        // Main
    }

    // Class
}
