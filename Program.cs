/*
// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Exponentiation(int numberA, int numberB)
{
  int result = 1;
  for(int i=1; i <= numberB; i++)
   result = result * numberA;
  
    // int result = Math.Pow(numberA, numberB);
    return result;
  
}

  Console.Write("Input number A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input number B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int degree = Exponentiation(numberA, numberB);
  Console.WriteLine("Number A in a power B: " + degree);
*/
/*
 // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Input number: ");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0)
{
int num = i % 10;
i = i / 10;
sum = sum + num;
}
Console.WriteLine("sum of all the digits in the number: " + sum);
*/