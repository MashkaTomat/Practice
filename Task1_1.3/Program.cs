namespace Task1_1._3
/*
На различных мероприятиях команда стажировок регулярно разыгрывает
призы в лотерею. Организаторы выбирают 10 случайных различных чисел от 1 до 32.
Каждому участнику выдается лотерейный билет, на котором записаны 6 различных чисел
от 1 до 32. Билет считается выигрышным, если в нем есть не менее 3 выбранных
организаторами числа. Помогите Юле, напишите программу, которая будет сообщать,
какие билеты выигрышные.
*/
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                string[] stringsFromFile = File.ReadAllLines("Input.txt");

                File.WriteAllText("Output.txt", "");


                string[] firstStringNums = stringsFromFile[0].Split(' ');

                foreach (string str in stringsFromFile)
                {
                    int winNumbersCount = 0;

                    if (Array.IndexOf(stringsFromFile, str) >= 2)
                    {
                        string[] ticketNums = str.Split(' ');

                        for (int i = 0; i < firstStringNums.Length; i++)
                        {
                            for (int j = 0; j < ticketNums.Length; j++)
                            {
                                if (firstStringNums[i] == ticketNums[j])
                                {
                                    winNumbersCount++;
                                }
                            }
                        }

                        if (winNumbersCount >= 3)
                        {
                            Console.WriteLine("Lucky");

                            File.AppendAllText("Output.txt", "Lucky\n");
                        }
                        else
                        {
                            Console.WriteLine("Unlucky");

                            File.AppendAllText("Output.txt", "Unlucky\n");
                        }
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
