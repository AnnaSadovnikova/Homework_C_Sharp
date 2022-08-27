using System;

class Program
{
    static void Main() {
         //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
         
         int number = 12;
         
         for (int i = 1; i <= number; i++)
         {
             Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)}");
         }
        
        
    }
}