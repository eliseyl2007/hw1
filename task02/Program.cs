Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 >= number2)
{
    Console.WriteLine("первое число большее");
    Console.WriteLine("второе число меньшие");
}
else
{
    Console.WriteLine("второе число большее");
    Console.WriteLine("первое число меньшие");
}