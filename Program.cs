using System;

namespace ConvertData;

class Program
{
    static void Main(string[] args)
    {
        /* ERROR Convert / ошибка неявного преобразования C# не может преобразовать текст в число
        int first = 2;
        string second = "4";
        int result = first + second; <----- int + string != int
        Console.WriteLine(result);
        */

        /*
        int first = 2;
        string second = "4";
        string result = first + second; // <----- int + string == string / преобразование чило с строку проходит без ошибок
        Console.WriteLine(result);
        */

        /*
            int myInt = 3;
            Console.WriteLine($"int: {myInt}");
            // the expanding transformation/ расширяющее преобразование 
            decimal myDecimal = myInt;
            Console.WriteLine($"decimal: {myDecimal}");
        */

        /* 
        myDecimal = 3.14m;
        Console.WriteLine($"decimal: {myDecimal}");
        // the narrowing transformation / Сужающее преобразование инт срезаен дробную часть
        myInt = (int)myDecimal; // explicit conversion
        Console.WriteLine($"int: {myInt}");
        */

        /*
        decimal myDecimal = 1.23456789m;
        float myFloat = (float)myDecimal;
        // the narrowing transformation / float урезает дробную часть 
        Console.WriteLine($"Decimal: {myDecimal}");
        Console.WriteLine($"Float  : {myFloat}");

        -------------------
        Decimal: 1.23456789
        Float  : 1.2345679        
        -------------------

        */

        /*
        //У переменной любого типа данных есть метод ToString()
        // method ToString() for all types.

        int first = 5;
        int second = 7;
        string message = first.ToString() + second.ToString();
        Console.WriteLine(message);

        ------------
        57
        ------------   

        */

        /**
        //Большинство числовых типов данных имеют Parse() метод
        //Parse() method to convert a string to int

        string first = "5";
        string second = "7";
        int sum = int.Parse(first) + int.Parse(second);
        Console.WriteLine(sum);

        ------------
        12
        ------------

        **/


        /**
        //Преобразование string в int класс с помощью Convert
        //class Convert - to convert to the desired format
        
        string value1 = "5";
        string value2 = "7";
        int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
        Console.WriteLine(result);

        -----------
        35
        -----------

        //Сужаюзщее преобразование с округлением через класс Convert
        //Class Convert 

        int value = (int)1.5m; // casting truncates
        Console.WriteLine(value);

        int value2 = Convert.ToInt32(1.5m); // converting rounds up
        Console.WriteLine(value2);

        -----------
        1
        2
        -----------    



        **/


        /*
        // int.TryParse(value, out result) - returns true if the conversion from a string to a number is successful.

        string value = "102";
        int result = 0;
        if (int.TryParse(value, out result))
        {
        Console.WriteLine($"Measurement: {result}");
        }
        else
        {
        Console.WriteLine("Unable to report the measurement.");
        }



        */

        string[] values = { "12,3", "45", "ABC", "11", "DEF" };

        decimal sum = 0;
        string message = "";

        for (int i = 0; i < values.Length; i++)
        {
            decimal number;
            if (decimal.TryParse(values[i], out number))
            {
                sum += number;
            }
            else
            {
                message += values[i];
            }
        }
        Console.WriteLine($"Message: {message}");
        Console.WriteLine($"Total: {sum}");

        // int value1 = 11;
        // decimal value2 = 6.2m;
        // float value3 = 4.3f;

        // // Your code here to set result1
        // // Hint: You need to round the result to nearest integer (don't just truncate)
        // decimal result1 = value1 / value2;
        // Console.WriteLine($"Divide value1 by value2, display the result as an int: {Convert.ToInt32(result1)}");

        // // Your code here to set result2
        // decimal result2 = value2 / (decimal)value3;
        // Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

        // // Your code here to set result3
        // float result3 = value3 / (float)value1;
        // Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
    }
}
