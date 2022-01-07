using System;
using System.Collections.Generic;
using System.Text;

namespace Dio
{
    class Xenlongao
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine()); //Método que converte um valor int para 32bits
            while(N-- > 0)
            {
                int val = Convert.ToInt32(Console.ReadLine());                           
                int newval = (int)Math.Sqrt(val);       //Método de raiz quadrada
                int resposta = val - newval;                 
                Console.WriteLine(resposta);
            }
        }
    }
}