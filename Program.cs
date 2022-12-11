
// // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
// // выводит их на экран.

// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// // 6, 1, 33 -> [6, 1, 33]

 

int [] arr;
int number;
Console.WriteLine("Введите длину массива: ");
number = Convert.ToInt32(Console.ReadLine());
arr = new int [number];

for (int i = 0; i < number; i++)
{
arr[i] = new Random().Next(0, 9);
}
Console.Write($"{number} -> [" + String.Join(", ", arr) + "]");


