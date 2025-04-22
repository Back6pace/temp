using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class algoritm2
{
    public static void Main()
    {
        int smallNumber = 510;
        int bigNumber = 500;

        if (bigNumber < smallNumber)
        {
            System.Console.Write(bigNumber);
            System.Console.Write(" меньше, чем ");
            System.Console.WriteLine(smallNumber);
        }
        else
        {
            System.Console.Write(smallNumber);
            System.Console.Write(" меньше, чем ");
            System.Console.WriteLine(bigNumber);
        }

        System.Console.WriteLine("Для выхода нажмите любую клавишу");
        System.Console.ReadLine();
    }
}
