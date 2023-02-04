﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int m = 2;
int n = 3;

int functionAkkerman = A(m, n);

Console.Write($"Функция Аккермана ({m},{n}) = {functionAkkerman} ");

int A (int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return A (m - 1, 1);
    else return A (m - 1, A (m, n - 1));
}

