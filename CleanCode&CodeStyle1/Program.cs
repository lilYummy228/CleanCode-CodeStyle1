internal class Program
{
    public static int TryFindElement(int[] array, int element)
    {
        for (int i = 0; i < array.Length; i++)
            if (array[i] == element)
                return i;

        return -1; 
    }
}