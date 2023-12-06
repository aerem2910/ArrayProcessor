using System;

public interface IArrayProcessor<in T>
{
    void ProcessArray(T[] array, int targetSum);
}

public class ArrayProcessor : IArrayProcessor<int>
{
    public void ProcessArray(int[] array, int targetSum)
    {
        for (int i = 0; i < array.Length - 2; i++)
        {
            for (int j = i + 1; j < array.Length - 1; j++)
            {
                for (int k = j + 1; k < array.Length; k++)
                {
                    if (array[i] + array[j] + array[k] == targetSum)
                    {
                        Console.WriteLine($"Numbers found: {array[i]}, {array[j]}, {array[k]}");
                    }
                }
            }
        }
    }
}
