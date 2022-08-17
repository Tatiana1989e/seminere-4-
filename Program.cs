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
