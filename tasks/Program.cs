
// Задача 2. Программа, которая на вход принимает два числа и выдаёт, какое число больше, а какое меньше.

Console.Clear();
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("max = " + number1 + "min = " + number2); 
}
else 
{
    Console.WriteLine("max = " + number2 + "min = " + number1); 
}


// Задача 4. Программа, которая принимает на вход 3 числа и выдаёт максимальное из этих чисел:
Console.Clear();
int a = 10;
int b = 25;
int c = 46;
int max = a;
if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;
Console.Write("max = ");
Console.WriteLine(max);


//Задача 6. Программа , которая на вход принимает число и выдаёт, является ли число чётным.

Console.Clear();
int number = new Random().Next(2, 1000); 
Console.WriteLine(number);

if(number == number % 2)
{
    Console.Write("чётное");
}


//Задача 8. Программа, которая на вход приримает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();

int number = new Random().Next(0, 100); 
Console.WriteLine(number);
int numbereven = 2;
if(number > 1)
{
    while(numbereven <= number)
    {Console.Write(numbereven + ", ");
    numbereven = numbereven + 2;
    }
} 
