// Принимает координаты 2х точек и находит расстояние между ними.

Console.WriteLine("Введите координаты первой точки ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки ");
int numberB = int.Parse(Console.ReadLine());

int xa = numberA / 10;//Первая1
int ya = numberA % 10;//Первая2
int xb = numberB / 10;//Вторая1
int yb = numberB % 10;//Вторая2

int sqr1 = Convert.ToInt32(Math.Pow((xb-xa), 2));//Первая часть выражения в квадрате
int sqr2 = Convert.ToInt32(Math.Pow((yb-ya), 2));//Вторая часть выражения в квадрате

int result = sqr1+sqr2;//Осталось возвести это число в корень
double result2 = Math.Sqrt(result);

Console.WriteLine($"Расстояние между этими точками равно {result2=result2:f2}");


