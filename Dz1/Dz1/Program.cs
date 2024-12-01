// See https://aka.ms/new-console-template for more information

using System;
class Program
{
    static void Main()
    {
       
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Вазни баданро дар воҳидҳои интихобшуда ворид кунед: ");
        double massa = double.Parse(Console.ReadLine());
        double masskilogram = ConvertToKilograms(number, massa);
        Console.WriteLine($"Вазни бадан дар килограмм: {masskilogram}");
    }
    
    
    static double ConvertToKilograms(int number, double massa)
    {
        switch (number)
        {
            case 1: 
                return massa;
            case 2: 
                return massa / 1_000_000;
            case 3: 
                return massa / 1_000;
            case 4: 
                return massa * 100;
            default:
                throw new ArgumentException("Рақами воҳиди масса нодуруст ас");
        }
    }
}
