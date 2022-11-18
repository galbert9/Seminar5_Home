// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("Задать размер массива");
int n = Convert.ToInt32(Console.ReadLine());
// Заполнение массива
int[] array = new int[n];

// Обертка 4-м методом
int[] Method4()
{
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(-99, 100);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();  
return array;
}

// Расчетных суммы элемнтов, стоящих на нечетных позициях
// Обертка 2-м методом
void Method2(int[] array)
{
int sum = 0;
for (int i=1; i<n; i+=2)
{
   sum = sum +array[i];
}
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях в массиве равна " +sum);
}


// Вызов 4-го метода
int[] res = Method4 ();

// Вызов 2-го метода
Method2(res);

