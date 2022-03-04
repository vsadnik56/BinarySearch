public class Binary
{
    static void BinarySearch(int[] array, int MaxValue, int MinValue, int Value)
    {
        int MidlValue = (MaxValue + MinValue) / 2;
        if (MinValue > MaxValue)
        {
            Console.WriteLine($"Данного числа нет в массиве");
        }
        else
        {
            if (array[MidlValue] > Value)
            {
                BinarySearch(array, MidlValue - 1, MinValue, Value);
            }
            else if (array[MidlValue] < Value)
            {
                BinarySearch(array, MaxValue, MidlValue + 1, Value);
            }
            else if (array[MidlValue] == Value)
            {
                Console.WriteLine($"Индекс числа {Value} равен {MidlValue}");
            }
        }
    }
    static void Main()
    {
        int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        Binary.BinarySearch(array1, array1.Length, 0,10);
    }
}