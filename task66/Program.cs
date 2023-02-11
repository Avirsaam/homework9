/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


int SumOfRange (int rangeStart, int rangeEnd)
{
    if (rangeStart == rangeEnd) return rangeEnd;
    else
    {
        if (rangeStart < rangeEnd) return rangeStart + SumOfRange(++rangeStart, rangeEnd);
        else return rangeStart + SumOfRange(--rangeStart, rangeEnd);
    }
}

const int M = 4, N = 8;
Console.Clear();
Console.WriteLine ($"Sum of all numbers in range berween {M} and {N} is {SumOfRange(M, N)}");

