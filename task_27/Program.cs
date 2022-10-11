/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

int GetNumber(string message)

{
    int result = 0;
    bool correctInput = false;
    
    while(!correctInput)
    {
        Console.WriteLine(message);
        correctInput = int.TryParse(Console.ReadLine(), out result);

        if(result < 1)
            correctInput = false; 

        if(!correctInput)
            Console.WriteLine("Вы ввели некоректное число");

        Console.WriteLine();
    }
    
    return result;

}

int GetLen(int a)
{
    int index = 0;
    while(a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void GetSum(int n, int len)
{
    int summ = 0;
    for (int i = 1; i <= len; i++)
    {
        summ += n % 10;
        n /= 10;
    }
    Console.WriteLine($"Сумма цифр {summ}");
}

int number = GetNumber("Введите число: ");

int len = GetLen(number);

GetSum(number, len);