namespace Server.Tasks
{
    internal class Task10
    {
        public static int getNearestNumber(int number)
        {
            int k = 0;
            while (true)
            {
                int a = (int)Math.Pow(4, k++);
                if (a > number)
                    return a;
            }
        }
    }
}
