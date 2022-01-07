using System; 
class DIO 
{
    static void Main(string[] args) 
    {
        int a, b, c = 7;
                
        for(int i = 1; i <= 9; i++)    
        {
            c = 7;
                    
            for (int j = 1; j <= 3; j++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"I={i} J={c}");
                    
                    c--;
                }
            }
        }
    }
}