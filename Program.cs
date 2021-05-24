using System;

namespace Examples
{
    class Program
    {
        static void Main()
        {
            int a, b, c;
            double x1, x2, res;

            Console.WriteLine("Insira o Valor A: ");
            a = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Insira o Valor B: ");
            b = int.Parse(Console.ReadLine());
          
            Console.WriteLine("Insira o Valor C: ");
            c = int.Parse(Console.ReadLine());

            res= b*b - 4*a*c;
            res= Math.Sqrt(res);

            x1= (-b + res)/(2*a);
            x2= (-b - res)/(2*a);
            

            Console.WriteLine("O resultado da operação é: \n X1= " + x1 + "           " + "X2= "  + x2);
        } 
    }
}
