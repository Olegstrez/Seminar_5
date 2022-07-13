/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным
 элементов массива.

[3 7 22 2 78] -> 76*/

Console.WriteLine("Введите массив ширина");
int ShirinaMasia = Convert.ToInt32(Console.ReadLine());
int [] Massib  = new int[ShirinaMasia];
int razn = 0, max = 0 , min = 1000;

for (int i =0; i < ShirinaMasia; i++)
{
    
    Massib[i] = new Random().Next(100,1000);
    Console.WriteLine($"A {i} = {Massib[i]}");
    if (Massib[i]> max)
    {
        max = Massib[i];
         
    }
     else if (Massib[i]< min)
    {
        min = Massib[i];
        
    }
    
}
int resultMaxMin = max - min ;
Console.WriteLine("Разница между максимальным и минимальным элементов массива");

Console.WriteLine(resultMaxMin );


