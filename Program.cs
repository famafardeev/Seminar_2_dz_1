// Задача 1.

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

if(a > b)
{
    Console.Write($" Число {a} - max, число {b} - min");
}
else
{
    Console.Write($" Число {b} - max, число {a} - min");
}

// Задача 2.

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine()!);
int max = a;
if(max < b)
max = b;
if(max < c)
max = c;
{
   Console.WriteLine($" Число {max} - max"); 
}

// Задача 3.

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
if(a%2 == 0)
{
    Console.WriteLine($" Число {a} - чётное ");
}
else
{
    Console.WriteLine($"Число {a} - не чётное");
}

// Задача 4.

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int N1 = 1;
while(N1 < N)
{
    if(N1%2 == 0)
 {Console.Write($" {N1} ");
 }
 N1 = N1 + 1;
}



