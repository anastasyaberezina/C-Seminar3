// Принимает число и выдает таблицу квадратов чисел от 1 до n

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i<=number; i++)
{
    Math.Pow(i, 2);
    Console.Write(i +" ");
}

