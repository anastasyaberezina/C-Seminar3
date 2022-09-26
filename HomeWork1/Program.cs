// Принимает число n и выдает таблицу кубов чисел от 1 до n

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i<=number; i++)
{
    int result = Convert.ToInt32(Math.Pow(i, 3));
    Console.Write(result +" ");
}