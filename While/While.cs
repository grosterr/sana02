using System.Text;
using System;
Console.OutputEncoding = UTF8Encoding.UTF8;
int n, i = 0, fact = 0;
double b, c = 1, d = 0;
Console.WriteLine("Введіть n: "); n = int.Parse(Console.ReadLine());
while (i <= n)
        {
                b = Math.Pow(-1, i + 1);
                c += 2;
                d += b / c;
                i++;
            }
            Console.WriteLine($"a = {d}");
i = 1;
b = 0;
while(i <= n)
{
    b += 1 + (1 / Math.Pow(i, 2));
    i++;
}
Console.WriteLine($"b = {b}");
i = 1;
b = 0; c = 1;
while (i <= n)
{
    c *= i;
    i++;
}
Console.WriteLine($"c = {c}");