namespace Task1_1._6
/*Дан файл numsTask1.txt со словами. Выведите все слова нечетной длины*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] words = File.ReadAllText("numsTask1.txt").Split(' ');

                foreach (string word in words)
                {
                    if (word.Length % 2 != 0)
                    {
                        Console.WriteLine(word);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
