Console.Clear();
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
int summ = 0;
int n = 0;
while (number > 0)
{
    n = number %10;
    summ = summ+ n;
    number /= 10;
}
Console.WriteLine("Сумма цифр равна " + summ);
