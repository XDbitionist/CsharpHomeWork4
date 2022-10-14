/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */
Console.Clear();
Console.Write("Введите число A: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int number = num;
void Number(int num, int num1)
{
    for (int i = 1; i < num1; i++)
    {
       number = number * num;
    }
}
Number(num, num1);
Console.WriteLine($"А в степени В равно: {number}");