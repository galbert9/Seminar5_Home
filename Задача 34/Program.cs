// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Задать размер массива");
int n = Convert.ToInt32(Console.ReadLine());
// Заполнение массива
int[] array = new int[n];

// Обертка 4-м методом
int[] Method4()
{
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();  
return array;
}

// Обертка 2-м методом
void Method2(int[] array)
{
//  Подсчет четных значений
int count = 0;
for (int i = 0; i < n; i++)
{
    if (array[i] % 2 == 0)
        count = count + 1;
}
Console.WriteLine($"Количество четных чисел в массиве равно {count} ");  
}
// Вызов 4-го метода
int[] res = Method4 ();
// Вызов 2-го метода
Method2(res);

// Решение без функуии
// Console.WriteLine("Задать размер массива");
// int n = Convert.ToInt32(Console.ReadLine());
// // Заполнение массива
// int[] array = new int[n];

// for (int i = 0; i < n; i++)
// {
//     array[i] = new Random().Next(100, 1000);
//     Console.Write($"{array[i]} ");
// }
// Console.WriteLine();
// //  Подсчет четных значений
// int count = 0;
// for (int i = 0; i < n; i++)
// {
//     if (array[i] % 2 == 0)
//         count = count + 1;
// }
// Console.WriteLine($"Количество четных чисел в массиве равно {count} ");

