using System;

namespace ConvertData;

class Program
{
    static void Main(string[] args)
    {
        /* ERROR Convert
        int first = 2;
        string second = "4";
        int result = first + second; <----- int + string != int
        Console.WriteLine(result);
        */

        int first = 2;
        string second = "4";
        string result = first + second; // <----- int + string == string
        Console.WriteLine(result);

        int myInt = 3;
        Console.WriteLine($"int: {myInt}");
        // the expanding transformation
        decimal myDecimal = myInt;
        Console.WriteLine($"decimal: {myDecimal}");

        myDecimal = 3.14m;
        Console.WriteLine($"decimal: {myDecimal}");
        // the narrowing transformation
        myInt = (int)myDecimal; // explicit conversion
        Console.WriteLine($"int: {myInt}");

        myDecimal = 1.23456789m;
        float myFloat = (float)myDecimal;

        Console.WriteLine($"Decimal: {myDecimal}");
        Console.WriteLine($"Float  : {myFloat}");


    }
}
