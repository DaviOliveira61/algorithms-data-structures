namespace Algorithms;

class Kadane
{
    public static int MaxSum(int[] numbers)
    {
        int currentMax = numbers[0];
        int overallMax = numbers[0];

        for (int i = 0; i < numbers.Length; i++)
        {
            currentMax = Math.Max(numbers[i], currentMax + numbers[i]);
            overallMax = Math.Max(overallMax, currentMax);
        }
        return overallMax;
    }
}
