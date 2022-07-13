/*Задача 36: Задайте одномерный массив, заполненный 
случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

*/
Console.WriteLine("Введите массив ширина");
int ShirinaMasia = Convert.ToInt32(Console.ReadLine());
int [] Massib  = new int[ShirinaMasia];
int sum = 0;
for (int i =1; i < ShirinaMasia; i++)
{
    Massib[i] = new Random().Next(100,1000);
    Console.WriteLine($"A {i} = {Massib[i]}");
    if (i % 2 != 0)
    {
        sum = sum +Massib[i];

    }
}
Console.WriteLine("Суммак нечетных ="+ sum);