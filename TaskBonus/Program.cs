// Задача +: Задана последовательность натуральных чисел, завершающаяся числом 0. 
// Требуется определить значение второго по величине элемента в этой последовательности, 
// то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент.

Console.Clear();
int max1;
int max2;
Console.Write("Какое колличество чисел, желаете ввести i: ");
int i = int.Parse(Console.ReadLine()!);
int [] n = new int[i];
for (int j = 0; j < i; j++)
{
    Console.Write($"Введите n{j+1}: ");
    n[j] = int.Parse(Console.ReadLine()!);
}
//for (int m = 0; m < i; m++)
//Console.Write($"{n[m]} ");
if (n[0] > n[1])
{
    max1 = n[0];
    max2 = n[1];
}
else
{
    max1 = n[1];
    max2 = n[0];
}
for (int m = 2; m < i; m++)
    if (n[m] > max1)
    {
        max2 = max1;
        max1 = n[m];
    }
    else if(n[m] > max2)
    {
        max2 = n[m];
    }
Console.Write($"Второе максимальное число: {max2}");