Console.Clear();
Console.Write("a= ");
int a = int.Parse(Console.ReadLine());
Console.Write("b= ");
int b = int.Parse(Console.ReadLine());

//double number = Math.Pow(a,b); - первый вариант решения

int number = a;
for (int i = 1; i < b; i++)
{
    number = number*a;            //второй вариант решения
}
Console.WriteLine("Ответ: "+ number);