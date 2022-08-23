/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/


int[] GetArray(int size, int minValue, int maxValue)
{
int[] res = new int[size];

for (int i = 0; i < size;i++)
{
res[i] = new Random().Next(minValue, maxValue + 1);
}
return res;
}

int razniza(int[] mas)
{
int raz = 0;
int max =0;
int min=mas[0];
foreach(int el in mas)
{
    max=el>max?el:max;
    min=el<min?el:min;
}
raz=max-min;
return raz;

}

int[] array = GetArray(5, 0, 20);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine($" {razniza(array)}");

