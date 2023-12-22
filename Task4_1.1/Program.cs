
/*Напишите функцию, которая заполняет список случайными числами в
диапазоне, указанном пользователем. Функция принимает начало диапазона и его конец,
и возвращает целочисленный массив. С помощью специальной формы цикла for
выведете элементы получившегося массив в одну строку, с пробелами;
*/
namespace Task4_1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNum = (Int32.Parse(Console.ReadLine())), maxNum = (Int32.Parse(Console.ReadLine()));

            int[] Mass = new int[10];

            Random rnd = new Random();

            for (int i = 0; i < Mass.Length; i++)
            {
                Mass[i] = rnd.Next(minNum, maxNum);

                Console.Write( Mass[i] + " ");
            }
        }
    }
}
