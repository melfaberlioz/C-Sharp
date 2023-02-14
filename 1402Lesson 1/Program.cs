/* Завдання 1
 Обчислити площу трикутника, якшо трикутник задано довжинами сторін.*/
using System;

public class Program
{
    public static void Main()
    {
        float a = Convert.ToSingle(Console.ReadLine());
        float b = Convert.ToSingle(Console.ReadLine());
        float c = Convert.ToSingle(Console.ReadLine());

        double P = (a + b + c) / 2;

        //добути корінь через клас Math для математичних обчислень 
        double S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
        //double використовуємо, бо програма вимагає більшої точності.
        //Аби не зазначати явну конвертацію float до double 
        Console.WriteLine(S);
        Console.ReadKey();
    }
}