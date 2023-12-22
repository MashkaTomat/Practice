namespace Task2_1._6
/*Дан файл numsTask2.txt со словами расположенными в столбик. Из заданных
слов составьте одну длинную строку(разделить каждое слово пробелом)*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllLines("numsTask2.txt");

            foreach (string word in words)
            {
                Console.Write(word + ' ');
            }
        }
    }
}
