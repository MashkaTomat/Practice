namespace Task4_1._2
/* 
Напишите программу, вычисляющую среднюю температуру за год. Создайте
двумерный рандомный массив temperature 12 на 30, в котором будет храниться
температура для каждого дня месяца (предполагается, что в каждом месяце 30 дней).
Сгенерируйте значения температур случайным образом(в рамках разумного). Для
каждого месяца выведите среднюю температуру. Для этого напишите метод, который
пройдется по массиву temperature и для каждого месяца вычислит среднюю
температуру, в качестве результата метод должен вернуть массив средних температур.
Полученный массив средних температур отсортируйте по возрастанию.
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] temperature = new int[12, 30];
            Random rnd = new Random();

            for (int i = 0; i < temperature.GetLength(0); i++)
            {
                for (int j = 0; j < temperature.GetLength(1); j++)
                {
                    temperature[i, j] = rnd.Next(-37, 32);

                    Console.Write(temperature[i, j].ToString().PadLeft(10));
                }
                Console.WriteLine();
            }

            float[] averageTemperature = GetAverageTemperature(temperature);


            float temp;

            for (int k = 0; k < averageTemperature.Length; k++)
            {
                for (int g = 0; g < averageTemperature.Length - 1; g++)
                {
                    if (averageTemperature[g] > averageTemperature[g + 1])
                    {
                        temp = averageTemperature[g + 1];
                        averageTemperature[g + 1] = averageTemperature[g];
                        averageTemperature[g] = temp;
                    }
                }
            }

            Console.WriteLine("Средняя температура в каждом месяце: ");

            for (int i = 0; i < averageTemperature.Length; i++)
            {
                Console.WriteLine(averageTemperature[i]);
            }
        }

        static float[] GetAverageTemperature(int[,] temperature)
        {
            float[] averageTemperature = new float[12];

            float Sum = 0;

            for (int i = 0; i < temperature.GetLength(0); i++)
            {
                for (int j = 0; j < temperature.GetLength(1); j++)
                {
                    Sum += temperature[i, j];
                }

                averageTemperature[i] = Sum / 30;
            }

            return averageTemperature;
        }

    }
}
