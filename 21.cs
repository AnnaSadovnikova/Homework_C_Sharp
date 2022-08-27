 //Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
        
        Console.WriteLine("Vvedite koordinati A: ");
        double Ax = Convert.ToDouble(Console.ReadLine());
        double Ay = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Vvedite koordinati B: ");
        double Bx = Convert.ToDouble(Console.ReadLine());
        double By = Convert.ToDouble(Console.ReadLine());
        
        double distance = Math.Sqrt(Math.Pow(Ax-Bx, 2) + Math.Pow(Ay -By, 2));
        Console.WriteLine(distance);