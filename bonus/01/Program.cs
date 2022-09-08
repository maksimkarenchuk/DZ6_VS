// На вход программы подаются три целых положительных числа. 
// Определить , является ли это сторонами треугольника. 
// Если да, то вывести всю информацию по нему - площадь, 
// периметр, значения углов треугольника в градусах, 
// является ли он прямоугольным, равнобедренным, равносторонним.


Console.Write("Введите длину стороны треугольника A: ");
double a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину стороны треугольника B: ");
double b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину стороны треугольника C: ");
double c = Convert.ToInt32(Console.ReadLine());
if (a < b + c && b < a + c && c < b + a)
{
    Console.WriteLine($"Отрезки {a}, {b}, {c} являются сторонами треугольника");
    Perimetr(a, b, c);
    Ravnosstor(a, b, c);
    Ravnobedr(a, b, c);
    areatriangle(a, b, c);
    anglealfa(a, b, c);
    anglebeta(a, b, c);
    anglegamma(a, b, c);
}

else Console.WriteLine($"Отрезки {a}, {b}, {c} НЕ являются сторонами треугольника");


void Perimetr(double a, double b, double c)
{
    double perimetr = a + b + c;
    Console.WriteLine($"Периметр треугольника: {perimetr}");
}

void Ravnosstor(double a, double b, double c)
{
    if (a == b && a == c) Console.WriteLine("Треугольник равносторонний");
    else Console.WriteLine("Треугольник неравносторонний");
}

void Ravnobedr(double a, double b, double c)
{
    if (a == b || b == c || a == c) Console.WriteLine("Треугольник равнобедренный");
    else Console.WriteLine("Треугольник неравнобедренный");
}

void areatriangle(double a, double b, double c)
{
    double p = (a + b + c) / 2;
    double S = Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);
    Console.WriteLine($"Площадь треугольника {S}");
}

void anglealfa(double a, double b, double c)
{
    
    double alfa = Math.Round((Math.Acos ((b * b + c * c - a * a) / (2 * b * c))* 180 / Math.PI) , 2);
    Console.WriteLine($"Угол BAC {alfa} градусов");  
    if (alfa == 90) Console.WriteLine("Треугольник прямоугольный");
}

void anglebeta(double a, double b, double c)
{
    double beta = Math.Round((Math.Acos((a * a + b * b - c * c) / (2 * b * a)) * 180 / Math.PI), 2);
    Console.WriteLine($"Угол ABC {beta} градусов");
    if (beta == 90) Console.WriteLine("Треугольник прямоугольный");
}

void anglegamma(double a, double b, double c)
{
    double gamma = Math.Round((Math.Acos((c * c + a * a - b * b) / (2 * c * a)) * 180 / Math.PI), 2);
    Console.WriteLine($"Угол BCA {gamma} градусов");
    if (gamma == 90) Console.WriteLine("Треугольник прямоугольный");
}
