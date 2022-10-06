/* Задача 41: Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

int count = 0;
    Console.WriteLine("Количество чисел?");
    Console.WriteLine("count =");
count = Convert.ToInt32(Console.ReadLine());
double[] array = new double[count];

int i = 0;
while (i < count)
{
    Console.WriteLine($"Введите число номер{i+1}: ");
    {
    array[i] = Convert.ToDouble(Console.ReadLine());
    i++;
    }
}

double res = 0;
foreach (double j in array)
{
    if (j > 0)
        res++;
}
Console.WriteLine($"Количество чисел > 0 = {res}");


