namespace Task3_1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = File.ReadAllText("numsTask3.txt");
            string[] texdt = text.Split(',');

            List<float> nums = new List<float>();

            foreach (var Num in texdt)
            {
                if (Num == "0")
                {
                    break;
                }

                nums.Add(Int32.Parse(Num));
            }

            float ratio = nums.Min() / nums.Max();

            Console.Write(ratio);
        }
    }
}
