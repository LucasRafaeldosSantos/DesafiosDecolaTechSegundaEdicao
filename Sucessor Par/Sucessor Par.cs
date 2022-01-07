using System; 
class DIO 
{
    static void Main(string[] args) 
    { 
        int x = int.Parse(Console.ReadLine());
        if (x % 2 == 0)       //se for par soma-se 2.
        {
            x = x + 2;
            Console.WriteLine(x);
        }
        else                  //Caso não seja par, soma-se 1
        {
            x = x + 1;
            Console.WriteLine(x);
        }
    }
}