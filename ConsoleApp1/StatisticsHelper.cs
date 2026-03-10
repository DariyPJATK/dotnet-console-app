public static double CalculateAverage(int[] values)
{
    if (values.Length == 0)
        return 0;
    int sum = 0;
    foreach (var v in values)
    {
        sum += v;
    }
    return (double)sum / values.Length;
}