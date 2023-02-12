// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
void Array(int[] arr)
{
    Random col = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = col.Next(0, 50);
    }
    System.Console.Write("[" + string.Join(", ", arr) + "]");
}
Array(array);