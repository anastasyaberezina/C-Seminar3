// Принимает координаты 2 точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты первой точки ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки ");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки ");
int numberC = int.Parse(Console.ReadLine());


int xa = numberA / 100;//Первая
int za = xa % 10;//Третья
int ya = xa - za - (xa*100);//Вторая

int xb = numberB / 10;//Первая
int zb = xb % 10;//Третья
int yb = xb - zb - (xb*100); //Вторая

int sqr1 = Convert.ToInt32(Math.Pow((xb-xa), 2));
int sqr2 = Convert.ToInt32(Math.Pow((yb-ya), 2));
int sqr3 = Convert.ToInt32(Math.Pow((zb-za), 2));

int result = sqr1+sqr2+sqr3;
double result2 = Math.Sqrt(result);

Console.WriteLine($"Расстояние между этими точками равно {result2=result2:f2}");
