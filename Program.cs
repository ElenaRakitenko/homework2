
Console.WriteLine("");
Console.WriteLine("Задача 10");
Console.WriteLine(" Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа");

// запрашиваем ввод значений
Console.WriteLine("Введите трехзначное число");
 int number= Convert.ToInt32(Console.ReadLine());

 if (number <100 || number >= 1000)
 {
    Console.WriteLine("Введенное число не трехзначное, повторите ввод");
    
 }
else
{
 int number1= number/10 % 10;

 Console.WriteLine($"Вторая цифра числа {number1}");
};


Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Задача 13");
Console.WriteLine("Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет");

// запрашиваем ввод значений
Console.WriteLine("Введите число");
 int num= Convert.ToInt32(Console.ReadLine());

 if (num <100 )
{
    Console.WriteLine("Третьей цифры нет");
}   
else
{
    while (num >= 1000)
    {
        num = num/10;
    }
    
int num1 = num % 10;

Console.WriteLine($"Третья цифра заданного числа {num1}");

};


Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Задача 15");
Console.WriteLine("Напишите программу, которая принимает на вход цифру, обозначающую день недели,и проверяет, является ли этот день выходным");

// запрашиваем ввод значений
Console.WriteLine("Введите число");
int data = Convert.ToInt32(Console.ReadLine());

if (data > 7)
{
    Console.WriteLine("Введите,пожалуйста, другое число");
}
else if (data < 6)
{
    Console.WriteLine("Нет");
}
else
{
    Console.WriteLine("Да");
};

Console.WriteLine("Программа HomeWork #2 завершена.");
return 0;



    
    



