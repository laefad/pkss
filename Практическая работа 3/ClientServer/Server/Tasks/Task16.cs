namespace Server.Tasks
{
    internal class Task16
    {
        public static List<double> values()
        {
            var list = new List<double>();
            for (double x = 12; x >= 1; x -= 1.2)
            {
                var z = Math.Tan(x) + 5 * Math.Cos(x - 2);
                list.Add(z);
            }
            return list;
        }
    }
}
