namespace Task5_1._2
/* 
Выполните задание 4, используя Dictionary<key, value>. В качестве ключей
используйте названия месяцев, а в качестве значений – массив температур по дням.
Напишите метод, который используя данные из словаря вычислит среднюю температуру
для каждого месяца, и вернет словарь(Dictionary) средних температур (В качестве ключа
название месяца, в качестве значения коллекция средних температура).
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> temperature = new Dictionary<string, int[]>()
            {
                { "Январь",   RandomTemperatures() },
                { "Февраль",  RandomTemperatures() },
                { "Март",     RandomTemperatures() },
                { "Апрель",   RandomTemperatures() },
                { "Май",      RandomTemperatures() },
                { "Июнь",     RandomTemperatures() },
                { "Июль",     RandomTemperatures() },
                { "Август",   RandomTemperatures() },
                { "Сентябрь", RandomTemperatures() },
                { "Октябрь",  RandomTemperatures() },
                { "Ноябрь",   RandomTemperatures() },
                { "Декабрь",  RandomTemperatures() }
            };

            Dictionary<string, double> monthAverage = new Dictionary<string, double>();

            foreach (var item in temperature)
            {
                int sum = 0;

                if (item.Key == "Март" || item.Key == "Август")
                {
                    Console.Write($"Температуры в {item.Key}е: ".PadRight(35));
                }
                else
                {
                    Console.Write($"Температуры в {item.Key.Substring(0, item.Key.Length - 1)}е: ".PadRight(35));
                }

                for (int i = 0; i < item.Value.Length; i++)
                {
                    sum += item.Value[i];

                    Console.Write(item.Value[i].ToString().PadLeft(5));
                }

                monthAverage.Add(item.Key, sum * 1.0 / item.Value.Length);

                Console.WriteLine();
            }

            Console.WriteLine();

            foreach (var item in monthAverage)
            {
                if (item.Key == "Март" || item.Key == "Август")
                {
                    Console.Write($"Средние температуры в {item.Key}е: ".PadRight(45));
                }
                else
                {
                    Console.Write($"Средние температуры в {item.Key.Substring(0, item.Key.Length - 1)}е: ".PadRight(45));
                }

                Console.WriteLine(item.Value);
            }

        }

        static int[] RandomTemperatures()
        {
            Random rnd = new Random();

            int[] temperature = new int[30];

            for (int i = 0; i < temperature.Length; i++)
            {
                temperature[i] = rnd.Next(-37, 32);
            }

            return temperature;
        }

    }
}
