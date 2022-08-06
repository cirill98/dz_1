Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int num4 = 0;
if (num1 > num2)
{
    num4 = num1;
}
else
{
    num4 = num2;
}
if (num4 > num3)
{
    Console.WriteLine(num4);
}
else
{
    Console.WriteLine(num3);
}