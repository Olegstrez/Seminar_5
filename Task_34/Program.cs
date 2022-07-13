/*Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

*/
Console.WriteLine("Введите массив ширина");
int ShirinaMasia = Convert.ToInt32(Console.ReadLine());
int [] Massib  = new int[ShirinaMasia];
int count=0;
for (int i =0; i < ShirinaMasia; i++)
{
    Massib[i] = new Random().Next(100,1000);
    Console.WriteLine($"A {i} = {Massib[i]}");
    if (Massib[i] % 2 == 0)
    {
        count = count +1;

    }
}
Console.WriteLine("Колличество четных ="+ count);
