using System;

class Algoritm1
{
    public static void Main()
    {
        int smallNumber = 510;
        int bigNumber = 500;

        if (bigNumber > smallNumber)
            Console.WriteLine($"{bigNumber} больше, чем {smallNumber}");
        else
            Console.WriteLine($"{bigNumber} меньше, чем {smallNumber}");

        Console.WriteLine("Для выхода нажмите Enter");
        Console.ReadLine();
    }
}
