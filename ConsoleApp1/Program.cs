namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            double result;
            string num1, num2;
            string a = "0";
            while (a != "9")
            {
                Console.WriteLine("Выберите операцию.");
                Console.WriteLine("1. Сложить 2 числа\n" + "2. Вычесть первое из второго\n" + "3. Перемножить два числа\n" + "4. Разделить первое на второе\n" + "5. Возвести число в степень\n" + "6. Найти квадратный корень из числа\n" + "7. Найти 1 процент от числа\n" + "8. Найти факториал из числа\n" + "9. Выйти из программы");
                a = Console.ReadLine();
                if (a == "1")
                {
                    Console.WriteLine("Введите первое число:");
                    num1 = Console.ReadLine();
                    x = Convert.ToInt32(num1);
                    Console.WriteLine("Введите второе число:");
                    num2 = Console.ReadLine();
                    y = Convert.ToInt32(num2);
                    result = x + y;
                    Console.WriteLine("Результат: " + result);
                }
                else if (a == "2")
                {
                    Console.WriteLine("Введите первое число:");
                    num1 = Console.ReadLine();
                    x = Convert.ToInt32(num1);
                    Console.WriteLine("Введите второе число:");
                    num2 = Console.ReadLine();
                    y = Convert.ToInt32(num2);
                    result = y - x;
                    Console.WriteLine("Результат: " + result);
                }
                else if (a == "3")
                {
                    Console.WriteLine("Введите первое число:");
                    num1 = Console.ReadLine();
                    x = Convert.ToInt32(num1);
                    Console.WriteLine("Введите второе число:");
                    num2 = Console.ReadLine();
                    y = Convert.ToInt32(num2);
                    result = x * y;
                    Console.WriteLine("Результат: " + result);
                }
                else if (a == "4")
                {
                    Console.WriteLine("Введите первое число:");
                    num1 = Console.ReadLine();
                    x = Convert.ToInt32(num1);
                    Console.WriteLine("Введите второе число:");
                    num2 = Console.ReadLine();
                    y = Convert.ToInt32(num2);
                    result = x / y;
                    Console.WriteLine("Результат: " + result);
                }
                else if (a == "5")
                {
                    Console.WriteLine("Введите число:");
                    num1 = Console.ReadLine();
                    x = Convert.ToInt32(num1);
                    Console.WriteLine("Введите показатель степени:");
                    num2 = Console.ReadLine();
                    y = Convert.ToInt32(num2);
                    result = Math.Pow(x, y);
                    Console.WriteLine("Результат: " + result);
                }
                else if (a == "6")
                {
                    Console.WriteLine("Введите число:");
                    num1 = Console.ReadLine();
                    x = Convert.ToInt32(num1);
                    result = Math.Sqrt(x);
                    Console.WriteLine("Результат: " + result);
                }
                else if (a == "7")
                {
                    Console.WriteLine("Введите число:");
                    num1 = Console.ReadLine();
                    x = Convert.ToInt32(num1);
                    result = x / 100;
                    Console.WriteLine("Результат: " + result);
                }
                else if (a == "8") 
                {
                    Console.WriteLine("Введите число:");
                    num1 = Console.ReadLine();
                    x = Convert.ToInt32(num1);
                    int fact = 1;
                    for (int i = 1; i <= x; i++)
                    {
                        fact *= i;
                    }
                    Console.WriteLine("Результат: " +  fact);
                }
            }
        }
    }
}