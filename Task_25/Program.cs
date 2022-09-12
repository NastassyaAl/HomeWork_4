Console.Clear();
Console.Write("a= ");
int a = int.Parse(Console.ReadLine());
Console.Write("b= ");
int b = int.Parse(Console.ReadLine());

int number = a;
for (int i = 1; i < b; i++)
{
    number = number*a;            
}
Console.WriteLine("Ответ: "+ number);