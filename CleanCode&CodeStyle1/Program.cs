using System;

internal class Program
{
    public static int FindElement(int[] array, int element)
    {
        if (array == null || array.Length == 0)
            throw new ArgumentNullException($"{nameof(array)} is empty");

        for (int i = 0; i < array.Length; i++)
            if (array[i] == element)
                return i;

        throw new ArgumentNullException($"{nameof(array)} hasn't got an {nameof(element)}");
    }
}