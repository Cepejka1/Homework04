// Задача 29: Напишите программу, которая задаёт массив из N элементов (из диапазона [0-14] ) и выводит на экран десятичное представление числа, записанного в СС по основанию 15

// N: 3 [9, 4, 12] => 2097

int [] numbers = new int[8];
Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 14);
    Console.Write(" " + Method (i) + " ");
 }
Console.Write("]");

int Method (int a)
{
    return numbers[a];
}