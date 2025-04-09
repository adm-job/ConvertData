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
    
    }
}
