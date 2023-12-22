namespace Task5_1._1
/*В строке, которую вводит пользователь, определите количество слов,
добавьте в начало строки слово Start и в конец строки слово End.
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();

            int words = 1;

            string changeText = "Start, " + text + " ,End";

            if ( text == "" )
            {
                words = 0;
            }
            else
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == ' ')
                    {
                        words++;
                    }
                }
            }

            Console.WriteLine("Количество слов в предложении: " + words);
            Console.WriteLine("Строка с Start и End: " + changeText);
        }
    }
}
