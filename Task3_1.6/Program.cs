namespace Task3_1._6
/*Дано число. Определите будет ли это число четным и кратным 10*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

                if (a%10 == 0 && a% 2 == 0)
                {
                    Console.WriteLine("Число является чётным и кратным 10: " + a);
                }
                else
                {
                    Console.WriteLine("Число не является чётным и кратным 10.");
                }
            
        }
    }
}
