using System.Text;
Console.OutputEncoding = UTF8Encoding.UTF8;
int i, b, sum = 0, correct = 0;
int[] a;
a = new int[5];
for (i = 0; i < 5; i++)
{
    Console.WriteLine($"Введіть значення {i+1}(1-100): "); a[i] = int.Parse(Console.ReadLine());
    sum += a[i];
    if ( a[i] > 0 && a[i] <= 100 )
    {
        correct = 1;
    }
    else { correct = 0; }
}
if (correct == 1)
{
    b = sum / 5;
    if (b > 50) {
        Console.WriteLine($"Студент допущений, бал {b}");
            }
    else {
        Console.WriteLine($"Студент не допущений, бал {b}");
            }
}
else Console.WriteLine("Помилка");