void Zadacha25()
{
        // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

   Random random = new Random();
   int number = random.Next(2, 6);
   int exponent = random.Next(2, 5);
   int result = 1;

   for (int i = 0; i < exponent; i++)
   {
    result *= number;
   }

   Console.WriteLine($"Chislo {number} v stepeni {exponent} ravno {result}");
}

void Zadacha27()

{
     //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    
    Random random = new Random();
    int number = random.Next(100, 100000);

    int sum = 0;

    Console.Write("V chisle " + number);
    while(number > 0)
    {
        sum += number % 10;
        number /= 10;
    }

    Console.WriteLine(" summa cifr ravna: " + sum);
}

void Zadacha29()

{
    //Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

         int size = 8;
         int[] array = new int[size];

         Random random = new Random();


         for (int i = 0; i < array.Length; i++) 
         {
            array[i] = random.Next(-10; 11);
         }

         Console.WriteLine();
         Console.WriteLine("Vivod massiva: ");

         for (int i = 0; i < array.Length; i++)
         {
            Console.WriteLine(array[i] + "\t");
         }

         Console.WriteLine();

}

Zadacha29();
