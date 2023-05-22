// Задача +: Задана последовательность натуральных чисел, завершающаяся числом 0. 
// Требуется определить значение второго по величине элемента в этой последовательности, 
// то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент.

Console.Clear();
int max1;
int max2;
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите число c: ");
int c = int.Parse(Console.ReadLine()!);
Console.Write("Введите число d: ");
int d = int.Parse(Console.ReadLine()!);
Console.Write("Введите число e: ");
int e = int.Parse(Console.ReadLine()!);
//Сравнение двух первых чисел и первичное определение max1 и max2
if (a > b)
{
    max1 = a;
    max2 = b;
}    
else
{
    max2 = a;
    max1 = b;
}
//Сравнение с "с"
if (c > max1)
{
    max2 = max1;
    max1 = c;
}
else if(c > max2)
        max2 = c;
//Сравнение с "b"
if (d > max1)
{
    max2 = max1;
    max1 = d;
}
else if(d > max2)
        max2 = d;
//Сравнение с "e"
if (e > max1)
{
    max2 = max1;
    max1 = e;
}
else if(e > max2)
        max2 = e;
//Вывод max2"       
Console.Write($"Второе максимальное число: {max2}");