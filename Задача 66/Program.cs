//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int numberM = 4;
int numberN = 8;

///Метод нахождения суммы натуральных элементов в промежутке от M до N
void NumberSum(int m, int n, int sum)
{
    if (m > n)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от {numberM} до {numberN}: {sum}");
        return;
    }
    sum = sum + (m++);
    NumberSum(m, n, sum);
}

NumberSum(numberM, numberN, 0);

