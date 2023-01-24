//По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = int.Parse(Console.ReadLine());
if ((number1 % number2) == 0)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else{
    Console.WriteLine("первое число не явлется");
}