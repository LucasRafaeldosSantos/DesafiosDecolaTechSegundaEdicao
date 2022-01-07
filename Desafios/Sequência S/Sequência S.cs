using System; 
class DIO 
{
    static void Main(string[] args) 
    { 

      double c, S= 0;                     //S = Fórmula
            for (double n = 1; n <= 100;n++) //n = divisor
            {
                c = 1 / n; //c = contador
                S = S + c;
            }
            var x=Math.Round(S,2);
            Console.WriteLine(x);
    }

}