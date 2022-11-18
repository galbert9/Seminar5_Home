// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// Заполнение массива
Console.WriteLine("Задать размер массива");
int n = Convert.ToInt32(Console.ReadLine());

double [] array = new double [n];

// Обертка 4-м методом
double [] Method4()
{
    for (int i = 0; i < n; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(-9, 10))/10;
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}
// Вызов 4-го метода
double [] res = Method4();

// Поиск Max 
// Обертка 4-м методом
double Method4_Max()
{
    double max = array[0];

    for (int i = 0; i < n; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;

}

// Вызов 4-го метода
double Max = Method4_Max();
Console.WriteLine("Max " + Max);

// Поиск Min
// Обертка 4-м методом
double Method4_Min()
{
    
    double min = array[0];

    for (int i = 1; i < n; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;

}

// Вызов 4-го метода
double Min = Method4_Min();
Console.WriteLine("Min " + Min);

// Разница Max - Min
double D = Max - Min;
Console.WriteLine("Max - Min = " + D);
