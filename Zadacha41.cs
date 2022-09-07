void Zadacha41()
{
    //Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

    int m = 5;
    int count = 0;

    for (int i = 0; i < m; i++)
    {
        Console.WriteLine();
        Console.Write($"Vvedite {i}-e chislo: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0) count++;
    }
    Console.WriteLine("Kolichestvo chisel bolshe nulya:" + count);

}

Zadacha41();
