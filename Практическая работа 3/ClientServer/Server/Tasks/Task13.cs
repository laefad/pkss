namespace Server.Tasks
{
    internal class Task13
    {
        public static bool isThreePow(int number)
        {
            while (true)
            {
                if (number == 1)
                {
                    return true;
                }

                if (number % 3 == 0)
                {
                    number /= 3;
                }
                else
                {
                    return false;
                }

            }
        }
    }
}