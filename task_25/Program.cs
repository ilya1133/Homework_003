/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
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
void GetDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(a + " В степени " + b + " = " + result);
}
int numberA = GetNumber("Введите число: ");
int numberB = GetNumber("Введите степень: ");
GetDegree(numberA, numberB);