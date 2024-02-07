using System;

class Program
{
    static void task1()
    {
        Console.WriteLine("Task1 !");
        Console.WriteLine("Enter a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the angle (in degrees): ");
        double angleDegrees = Convert.ToDouble(Console.ReadLine());

        // Переведення кута з градусів у радіани
        double angleRadians = angleDegrees * Math.PI / 180;

        // Обчислення висоти трапеції
        double height = Math.Sin(angleRadians) * (b - a) / 2;

        double area = (a + b) * height / 2;

        Console.WriteLine($"The area of the isosceles trapezoid is: {area}");
    }

    static void task2()
    {
        Console.WriteLine("Task2 !");
        Console.WriteLine("Enter a three-digit number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Отримуємо останню цифру числа
        int lastDigit = number % 10;

        // Отримуємо другу цифру числа
        int secondDigit = (number / 10) % 10;

        if (secondDigit > lastDigit)
        {
            Console.WriteLine($"The second digit ({secondDigit}) is greater than the last digit ({lastDigit}).");
        }
        else if (lastDigit > secondDigit)
        {
            Console.WriteLine($"The last digit ({lastDigit}) is greater than the second digit ({secondDigit}).");
        }
        else
        {
            Console.WriteLine("The second and last digits are equal.");
        }
    }

    static void task3()
    {
        Console.WriteLine("Task3 !");
        Console.WriteLine("Please input coordinate your point:");
        Console.WriteLine("Enter x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        // Перевірка чи точка знаходиться всередині, поза або на межі області
        if (x <= 10 && y >= -x)
        {
            Console.WriteLine("Yes");
        }
        else if (x > 10 && y < -x)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine("On the border");
        }
    }
    static void task4()
    {
        Console.WriteLine("Task4 !");
        Console.WriteLine("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        string category;

        if (age < 1)
        {
            category = "infant";
        }
        else if (age <= 11)
        {
            category = "child";
        }
        else if (age <= 15)
        {
            category = "teenager";
        }
        else if (age <= 25)
        {
            category = "young man";
        }
        else if (age <= 70)
        {
            category = "man";
        }
        else
        {
            category = "old man";
        }

        Console.WriteLine($"Age category: {category}");
    }

    // Функція для піднесення до квадрату добутку двох чисел
    static double SquareOfProduct(double num1, double num2)
    {
        double product = num1 * num2;
        double squareOfProduct = product * product;
        return squareOfProduct;
    }

    static void task5()
    {
        Console.WriteLine("Task5 !");
        Console.WriteLine("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Виклик функції та виведення результату
        double result = SquareOfProduct(num1, num2);
        Console.WriteLine($"The square of the product of {num1} and {num2} is: {result}");
    }

    static void task6()
    {
        Console.WriteLine("Enter the value of n: ");
        double n = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the value of m: ");
        double m = Convert.ToDouble(Console.ReadLine());

        double result = (5 / Math.Pow(n + m, 2)) * (m + n) + Math.Pow(n, 2);

        Console.WriteLine($"Result: {result}");
    }


    static void Main()
    {
        Console.WriteLine("Lab 1 !");
        Console.WriteLine("Please input task");
        Console.Write("n=");

        byte n = byte.Parse(Console.ReadLine());

        switch (n)
        {
            case 1: task1(); break;
            case 2: task2(); break;
            case 3: task3(); break;
            case 4: task4(); break;
            case 5: task5(); break;
            case 6: task6(); break;
        }
    }
}
