using System.Text;
Console.OutputEncoding = UTF8Encoding.UTF8;
int a, b, c;
double x1, x2;
Console.WriteLine("Введіть значення a: "); a = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть значення b: "); b = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть значення c: "); c = int.Parse(Console.ReadLine());

double D = Math.Pow(b, 2 - 4 * a * c);
if (D > 0)
{
    x1 = (-b + Math.Sqrt(D)) / (2 * a);
    x2 = (-b - Math.Sqrt(D)) / (2 * a);
    Console.WriteLine($"Корені рівняння: x1 = {x1}, x2 = {x2}");
}
else if (D == 0)
{
    x1 = -b / (2 * a);
    Console.WriteLine($"Корінь рівняння: x = {x1}");
}
else
{
    Console.WriteLine("Коренів немає");
}
