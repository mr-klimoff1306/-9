 //Задайте значение N. Напишите программу,
 // которая выведет все натуральные числа в промежутке от N до 1.


Console.WriteLine("Введите натуральное число больше 1:");
int number = Convert.ToInt32(Console.ReadLine());

///Метод вывода натуральных чисел от N до 1:
void PrintNumbers(int n)
{
    if (n == 0) return;
    Console.Write("{0,4}", n);
    PrintNumbers(n - 1);
}

PrintNumbers(number);
