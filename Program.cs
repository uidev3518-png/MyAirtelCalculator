using System;

Console.WriteLine("--- Airtel Digital Calculator ---");

// 1. Pehla number lein
Console.Write("Pehla number enter karein: ");
double num1 = Convert.ToDouble(Console.ReadLine());

// 2. Doosra number lein
Console.Write("Doosra number enter karein: ");
double num2 = Convert.ToDouble(Console.ReadLine());

// 3. Operation choose karein
Console.WriteLine("Operation choose karein: (+, -, *, /)");
string op = Console.ReadLine();

double result = 0;

// 4. Switch Case se calculation karein
switch (op)
{
    case "+":
        result = num1 + num2;
        Console.WriteLine($"Result: {num1} + {num2} = {result}");
        break;
    case "-":
        result = num1 - num2;
        Console.WriteLine($"Result: {num1} - {num2} = {result}");
        break;
    case "*":
        result = num1 * num2;
        Console.WriteLine($"Result: {num1} * {num2} = {result}");
        break;
    case "/":
        // Zero se divide check karna zaroori hai
        if (num2 != 0) {
            result = num1 / num2;
            Console.WriteLine($"Result: {num1} / {num2} = {result}");
        } else {
            Console.WriteLine("Error: Zero se divide nahi kar sakte!");
        }
        break;
    default:
        Console.WriteLine("Galat symbol dala hai!");
        break;
}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();