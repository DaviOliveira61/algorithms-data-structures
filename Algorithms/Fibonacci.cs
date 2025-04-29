namespace Algorithms;

public static class Fibonacci
{

    public static int Calculate(int n)
    {
        if (n <= 1) return n;

        int prev = 0, curr = 1;
        for (int i = 2; i <= n; i++)
        {
            int next = curr + prev;
            prev = curr;
            curr = next;
        }
        return curr;
    }

    public static void CallRecursively(int n)
    {
        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine(CalculateRecursively(i));
        }
    }

    private static int CalculateRecursively(int n)
    {
        if (n <= 1)
            return n;

        return CalculateRecursively(n - 1) + CalculateRecursively(n - 2);
    }

}
