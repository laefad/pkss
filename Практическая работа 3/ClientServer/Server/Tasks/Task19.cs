namespace Server.Tasks
{
    internal class Task19
    {
        public static double firstNegative()
        {
            for (int n = 1; n < int.MaxValue; n++)
            {
                var z = Math.Sin(Math.Tan(n / 2));
                if (z < 0) {
                    return z;
                }
            }

            return 0;
        }
    }
}
