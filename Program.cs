// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Введите любое число: ");
int a = Convert.ToInt32(Console.ReadLine());

int y = 10;
int x1 = 99;
int count = 0;
int N = a;
int ind1 = 0;
int ind2 = 0;

if (a > x1)
{
        while (N > 0)
        {
            count = count + 1;
            N = N / 10;
            ind1 = Convert.ToInt32(Math.Pow(y,count-2));
            ind2 = Convert.ToInt32(Math.Pow(y,count-3));
        }        
    Console.WriteLine($"Третья цифра числа {(a%ind1/ind2)}");
}    
else
{
    Console.WriteLine("В вашем числе менее трех цифр");
}


//Console.WriteLine($"каккое количество цифр в чсиле {count}");
        //Console.WriteLine($"индекс {ind1}");
        //Console.WriteLine($"индекс {ind2}");
