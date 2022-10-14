/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. */

Console.Write("Массив из 8 чисел: ");
void PrintArray(int[] array)
{
    int count = array.Length;
    string comma = ", ";
    for (int j = 1; j < count; j++)
    {
        Console.Write($"{array[j]}{comma}");
    } 
}
int[] mass = new int[9];
Random rand = new Random();
for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = rand.Next(0, 100); 
    }
PrintArray(mass);

