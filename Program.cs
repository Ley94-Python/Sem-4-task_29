
// // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
// // выводит их на экран.

// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// // 6, 1, 33 -> [6, 1, 33]

int [] arr = new int [8];
int n = arr.Length;
Console.Write("Введите длину массива через запятую: ");
Console.ReadLine();
void FillArray(int[]arr)
{
for (int i = 0; i < arr.Length; i++);

}

void PrintArray(int[]arr)
{
{
for (int i = 0; i < arr.Length; i++);

}
Console.Write("-> [" + String.Join(", ", arr) + "]");
}

FillArray(arr);
PrintArray(arr);
