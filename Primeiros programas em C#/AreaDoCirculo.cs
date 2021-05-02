using System;

class Classe
{

    static void Main(string[] args)
    {

        double pi = 3.14159, r;
        double area;

        r = Convert.ToDouble(Console.ReadLine());

        area = ((r * r) * pi);

        Console.WriteLine("A=" + area.ToString("0.0000"));
    }


}