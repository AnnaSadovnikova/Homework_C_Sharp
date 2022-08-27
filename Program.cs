//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
        
        
        Console.WriteLine("Vvedite 5ti znachnoe chislo");
        int number = Convert.ToInt32(Console.ReadLine());
        int digitOnes = number%10;
        int digitTens = number/10%10;
        int digitThousands = number/1000%10;
        int digitTenOfThousands = number/10000;
        
        if (digitOnes == digitTenOfThousands && digitTens == digitThousands)
        {
            Console.WriteLine("eto palindrom");
        }
        else 
        {
            Console.WriteLine("eto ne palindrom");
        } 
