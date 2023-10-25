namespace Tasks.Question1
{
    public class Implementation
    {
        public static IEnumerable<int> GetNumbers(int value1, int value2)
        {
            var min = Math.Min(value1, value2);
            var max = Math.Max(value1, value2);
            min = min % 2 == 0 ? min : min * 2; // check and fix to even number
            for (int current = min; current <= max; current += min)
            {
                yield return current;
            }
        }
    }
}