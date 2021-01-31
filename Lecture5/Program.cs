using System;

namespace Lecture5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool working = true;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            System.Console.WriteLine("Welcome to Array Function:\n" +
            "First you have add size and elements of array");
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.Write("Size of your array : ");
            int sizeOfArray = int.Parse(Console.ReadLine());


            int[] arrayInt = new int[sizeOfArray];
            string[] arrayString = new string[sizeOfArray];
            double[] arrayDouble = new double[sizeOfArray];
            decimal[] arrayDecimal = new decimal[sizeOfArray];
            float[] arrayFloat = new float[sizeOfArray];


            int choice = 1;
        userTypeArrayInput:
            System.Console.Write(@"
Please choose type of your array: 
1. Int
2. String
3. Double
4. Decimal 
5. Float
6. Exit
Choose reference number: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        System.Console.WriteLine($"In next {sizeOfArray} lines\n" +
                                    "Please input elements of array");
                        for (int i = 0; i < sizeOfArray; i++)
                        {
                            int tempIntput = int.Parse(Console.ReadLine());
                            arrayInt[i] = tempIntput;
                        }
                    }
                    break;
                case 2:
                    {
                        System.Console.WriteLine($"Next {sizeOfArray} lines" +
                                    "please input elements of array");
                        for (int i = 0; i < sizeOfArray; i++)
                        {
                            string tempIntput = (Console.ReadLine());
                            arrayString[i] = tempIntput;
                        }
                    }
                    break;
                case 3:
                    {

                        System.Console.WriteLine($"Next {sizeOfArray} lines" +
                                    "please input elements of array");
                        for (int i = 0; i < sizeOfArray; i++)
                        {
                            double tempIntput = double.Parse(Console.ReadLine());
                            arrayDouble[i] = tempIntput;
                        }
                    }
                    break;
                case 4:
                    {
                        System.Console.WriteLine($"Next {sizeOfArray} lines" +
                                    "please input elements of array");
                        for (int i = 0; i < sizeOfArray; i++)
                        {
                            decimal tempIntput = decimal.Parse(Console.ReadLine());
                            arrayDecimal[i] = tempIntput;
                        }
                    }
                    break;
                case 5:
                    {
                        System.Console.WriteLine($"Next {sizeOfArray} lines" +
                                    "please input elements of array");
                        for (int i = 0; i < sizeOfArray; i++)
                        {
                            float tempIntput = float.Parse(Console.ReadLine());
                            arrayFloat[i] = tempIntput;
                        }
                    }
                    break;
                case 6:
                    {
                        working = false;
                    }
                    break;
                default:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("Invalid input....");
                        Console.ForegroundColor = ConsoleColor.White;
                        goto userTypeArrayInput;
                    }
            }
            working = true;
            while (working)
            {
            mainProcess:
                System.Console.Write(@"Now you have these options :
                                            1. Pop()
                                            2. Push()
                                            3. Shift()
                                            4. UnShift() 
                                            5. Exit 
                                            Please choose reference number: ");
                int choice1 = int.Parse(Console.ReadLine());
                switch (choice1)
                {
                    case 1:
                        {
                            switch (choice)
                            {
                                case 1:
                                    {
                                        var tempAns = 0;
                                        if (arrayInt.Length > 0)
                                        {
                                            tempAns = ArrayHelper.Pop(ref arrayInt);
                                            System.Console.WriteLine($"Result of pop() is {tempAns}");
                                        }
                                        else
                                        {
                                            System.Console.WriteLine("Your array is empty");
                                        }
                                    }
                                    break;
                                case 2:
                                    {
                                        var tempAns = "";
                                        if (arrayString.Length > 0)
                                        {
                                            tempAns = ArrayHelper.Pop(ref arrayString);
                                            System.Console.WriteLine($"Result of pop() is {tempAns}");
                                        }
                                        else
                                        {
                                            System.Console.WriteLine("Your array is empty");
                                        }
                                    }
                                    break;
                                case 3:
                                    {
                                        double tempAns;
                                        if (arrayDouble.Length > 0)
                                        {
                                            tempAns = ArrayHelper.Pop(ref arrayDouble);
                                            System.Console.WriteLine($"Result of pop() is {tempAns}");
                                        }
                                        else
                                        {
                                            System.Console.WriteLine("Your array is empty");
                                        }
                                    }
                                    break;
                                case 4:
                                    {
                                        decimal tempAns;
                                        if (arrayDecimal.Length > 0)
                                        {
                                            tempAns = ArrayHelper.Pop(ref arrayDecimal);
                                            System.Console.WriteLine($"Result of pop() is {tempAns}");
                                        }
                                        else
                                        {
                                            System.Console.WriteLine("Your array is empty");
                                        }
                                    }
                                    break;
                                case 5:
                                    {
                                        float tempAns;
                                        if (arrayFloat.Length > 0)
                                        {
                                            tempAns = ArrayHelper.Pop(ref arrayFloat);
                                            System.Console.WriteLine($"Result of pop() is {tempAns}");
                                        }
                                        else
                                        {
                                            System.Console.WriteLine("Your array is empty");
                                        }
                                    }
                                    break;
                            }
                        }
                        break;
                    case 2:
                        {
                            switch (choice)
                            {
                                case 1:
                                    {
                                        var tempAns = 0;
                                        System.Console.Write("Please type what you want to push(): ");
                                        int tempElement = int.Parse(Console.ReadLine());
                                        tempAns = ArrayHelper.Push(ref arrayInt, tempElement);
                                        System.Console.WriteLine(tempAns);
                                    }
                                    break;
                                case 2:
                                    {
                                        int tempAns;
                                        System.Console.Write("Please type what you want to push(): ");
                                        string tempElement = Console.ReadLine();
                                        tempAns = ArrayHelper.Push(ref arrayString, tempElement);
                                        System.Console.WriteLine(tempAns);
                                    }
                                    break;
                                case 3:
                                    {
                                        int tempAns;
                                        System.Console.Write("Please type what you want to push(): ");
                                        double tempElement = double.Parse(Console.ReadLine());
                                        tempAns = ArrayHelper.Push(ref arrayDouble, tempElement);
                                        System.Console.WriteLine(tempAns);
                                    }
                                    break;
                                case 4:
                                    {
                                        int tempAns;
                                        System.Console.Write("Please type what you want to push(): ");
                                        decimal tempElement = decimal.Parse(Console.ReadLine());
                                        tempAns = ArrayHelper.Push(ref arrayDecimal, tempElement);
                                        System.Console.WriteLine(tempAns);
                                    }
                                    break;
                                case 5:
                                    {
                                        int tempAns;
                                        System.Console.Write("Please type what you want to push(): ");
                                        float tempElement = float.Parse(Console.ReadLine());
                                        tempAns = ArrayHelper.Push(ref arrayFloat, tempElement);
                                        System.Console.WriteLine(tempAns);
                                    }
                                    break;
                            }
                        }
                        break;
                    case 3:
                        {
                            switch (choice)
                            {
                                case 1:
                                    {
                                        var tempAns = 0;
                                        if (arrayInt.Length > 0)
                                        {
                                            tempAns = ArrayHelper.Shift(ref arrayInt);
                                            System.Console.WriteLine($"Result of shift() is {tempAns}");
                                        }
                                        else
                                        {
                                            System.Console.WriteLine("Your array is empty");
                                        }
                                    }
                                    break;
                                case 2:
                                    {
                                        var tempAns = "";
                                        if (arrayString.Length > 0)
                                        {
                                            tempAns = ArrayHelper.Shift(ref arrayString);
                                            System.Console.WriteLine($"Result of shift() is {tempAns}");
                                        }
                                        else
                                        {
                                            System.Console.WriteLine("Your array is empty");
                                        }
                                    }
                                    break;
                                case 3:
                                    {
                                        double tempAns;
                                        if (arrayDouble.Length > 0)
                                        {
                                            tempAns = ArrayHelper.Shift(ref arrayDouble);
                                            System.Console.WriteLine($"Result of shift() is {tempAns}");
                                        }
                                        else
                                        {
                                            System.Console.WriteLine("Your array is empty");
                                        }
                                    }
                                    break;
                                case 4:
                                    {
                                        decimal tempAns;
                                        if (arrayDecimal.Length > 0)
                                        {
                                            tempAns = ArrayHelper.Shift(ref arrayDecimal);
                                            System.Console.WriteLine($"Result of shift() is {tempAns}");
                                        }
                                        else
                                        {
                                            System.Console.WriteLine("Your array is empty");
                                        }
                                    }
                                    break;
                                case 5:
                                    {
                                        float tempAns;
                                        if (arrayFloat.Length > 0)
                                        {
                                            tempAns = ArrayHelper.Shift(ref arrayFloat);
                                            System.Console.WriteLine($"Result of shift() is {tempAns}");
                                        }
                                        else
                                        {
                                            System.Console.WriteLine("Your array is empty");
                                        }
                                    }
                                    break;
                            }
                        }
                        break;
                    case 4:
                        {
                            switch (choice)
                            {
                                case 1:
                                    {
                                        var tempAns = 0;
                                        System.Console.Write("Please type what you want to unshift(): ");
                                        int tempElement = int.Parse(Console.ReadLine());
                                        tempAns = ArrayHelper.UnShift(ref arrayInt, tempElement);
                                        System.Console.WriteLine(tempAns);
                                    }
                                    break;
                                case 2:
                                    {
                                        int tempAns;
                                        System.Console.Write("Please type what you want to unshift(): ");
                                        string tempElement = Console.ReadLine();
                                        tempAns = ArrayHelper.UnShift(ref arrayString, tempElement);
                                        System.Console.WriteLine(tempAns);
                                    }
                                    break;
                                case 3:
                                    {
                                        int tempAns;
                                        System.Console.Write("Please type what you want to unshift(): ");
                                        double tempElement = double.Parse(Console.ReadLine());
                                        tempAns = ArrayHelper.UnShift(ref arrayDouble, tempElement);
                                        System.Console.WriteLine(tempAns);
                                    }
                                    break;
                                case 4:
                                    {
                                        int tempAns;
                                        System.Console.Write("Please type what you want to unshift(): ");
                                        decimal tempElement = decimal.Parse(Console.ReadLine());
                                        tempAns = ArrayHelper.UnShift(ref arrayDecimal, tempElement);
                                        System.Console.WriteLine(tempAns);
                                    }
                                    break;
                                case 5:
                                    {
                                        int tempAns;
                                        System.Console.Write("Please type what you want to unshift(): ");
                                        float tempElement = float.Parse(Console.ReadLine());
                                        tempAns = ArrayHelper.UnShift(ref arrayFloat, tempElement);
                                        System.Console.WriteLine(tempAns);
                                    }
                                    break;
                            }
                        }
                        break;
                    case 5:
                        {
                            working = false;
                        }
                        break;
                    default:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.WriteLine("Invalid choice please repeat......");
                            Console.ForegroundColor = ConsoleColor.White;
                            goto mainProcess;
                        }

                }

            }
        }
    }
}
