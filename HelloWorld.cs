using System;
using System.Threading;

class Program
{
    private static int num1;

    static void Main()
    {
        bool validInput = true;
        bool firstNum = true;

        while (validInput)
        {
            if (firstNum)
            {
                try
                {
                    Console.WriteLine("First number");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(num1);
                }
                catch (FormatException)
                {
                    firstNum = false;

                    Console.Clear();
                    //Console.WriteLine("FormatException");
                    //Console.Write("Press Enter To Continue...");
                    //ConsoleKeyInfo keyInfo = Console.ReadKey();
                    //Console.Clear();
                    //if (keyInfo.Key == ConsoleKey.Enter)
                    //{
                    //    Console.Clear();

                    //}
                    //Console.ReadKey(intercept: true); = keyInfo.Key == ConsoleKey.Enter
                }
            }
            else
            {
                
            }

            try
            {
                Console.WriteLine("Second number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1);
            }
            catch (FormatException)
            {
                Console.Clear();
            }
        }

        // Main
    }

    // Class
}

















// Old Code

//        bool isValidInput = false;
//        bool isValidOperator = false;

//        Console.BackgroundColor = ConsoleColor.Black;
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine(@"
// ______     ______     __         ______     __  __     __         ______     ______   ______     ______    
///\  ___\   /\  __ \   /\ \       /\  ___\   /\ \/\ \   /\ \       /\  __ \   /\__  _\ /\  __ \   /\  == \   
//\ \ \____  \ \  __ \  \ \ \____  \ \ \____  \ \ \_\ \  \ \ \____  \ \  __ \  \/_/\ \/ \ \ \/\ \  \ \  __<   
// \ \_____\  \ \_\ \_\  \ \_____\  \ \_____\  \ \_____\  \ \_____\  \ \_\ \_\    \ \_\  \ \_____\  \ \_\ \_\ 
//  \/_____/   \/_/\/_/   \/_____/   \/_____/   \/_____/   \/_____/   \/_/\/_/     \/_/   \/_____/   \/_/ /_/ 

//");
//        while (!isValidInput)
//        {
//            try
//            {
//                // First Number
//                Console.WriteLine("Enter your first number");
//                int num1 = Convert.ToInt32(Console.ReadLine());
//                Console.Clear();
//                isValidInput = true;
//                Console.WriteLine(num1);



//                while (!isValidOperator)
//                {

//                    // Operator
//                    Console.WriteLine("Select an operator: +, -, *, /");
//                    string opSymbol = Console.ReadLine();
//                    Console.Clear();

//                    if (opSymbol == "+")
//                    {
//                        Console.WriteLine("Choose a second number");
//                        int numAdd = Convert.ToInt32(Console.ReadLine());
//                        int addTotal = num1 + numAdd;
//                        Console.WriteLine("It equals = " + addTotal);
//                        isValidOperator = true;
//                    }
//                    else if (opSymbol == "-")
//                    {
//                        Console.WriteLine("Choose a second number");
//                        int numSub = Convert.ToInt32(Console.ReadLine());
//                        int subTotal = num1 - numSub;
//                        Console.WriteLine("it equals = " + subTotal);
//                        isValidOperator = true;

//                    }
//                    else if (opSymbol == "*")
//                    {
//                        Console.WriteLine("Choose a second number");
//                        int numMulti = Convert.ToInt32(Console.ReadLine());
//                        int multiTotal = num1 * numMulti;
//                        Console.WriteLine("it equals = " + multiTotal);
//                        isValidOperator = true;
//                    }
//                    else if (opSymbol == "/")
//                    {
//                        Console.WriteLine("Choose a second number");
//                        double numDivi = Convert.ToInt32(Console.ReadLine());
//                        double diviTotal = num1 / numDivi;
//                        Console.WriteLine("it equals = " + diviTotal);
//                        isValidOperator = true;
//                    }
//                }
//            }
//            catch (FormatException)
//            {
//                Console.WriteLine("FormatExceptionCatch");
//                Console.Clear();
//            }

//        }
