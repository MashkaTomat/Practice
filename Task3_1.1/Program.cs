namespace Task3_1._1
/*
Добавляйте новые элементы в список до тех пор, пока пользователь не
отправит пустую строку. Выведите в консоль самый короткий и самый длинный элементы
списка.
 */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();

            while (true)
            {

                string temp = Console.ReadLine();

                if (temp == "")
                {
                    break;
                }
                else
                {
                    words.Add(temp);
                }
            }
            
            string minWord = words[0];

            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Length < minWord.Length)
                {
                    minWord = words[i];
                }
            }
            Console.WriteLine(minWord);

            string maxWord = words[0];

            for (int j = 0; j < words.Count; j++)
            {
                if (words[j].Length > maxWord.Length)
                {
                    maxWord = words[j];
                }
            }
            Console.WriteLine(maxWord);

        }
    }
}
