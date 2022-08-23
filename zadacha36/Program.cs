/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/


int[] GetArray(int size, int minValue, int maxValue)
{
int[] res = new int[size];

for (int i = 0; i < size;i++)
{
res[i] = new Random().Next(minValue, maxValue + 1);
}
return res;
}

int SumNechot(int[] mas)
{
int sum = 0;
for (int i=1;i < mas.Length; i+=2 )
{
sum+=mas[i];
}
return sum;
}

int[] array = GetArray(5, 0, 20);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine($" {SumNechot(array)}");