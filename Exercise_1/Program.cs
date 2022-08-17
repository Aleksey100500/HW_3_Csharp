class Program
{
    // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    static void Main()
    {
        Console.WriteLine("Введите число");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Reverse(num, 0) == num);
        Console.ReadKey();
    }

    static int Reverse(int num, int acc)
    {

        while (num > 0) 
        { 
            acc = acc * 10 + num % 10;
            
            num /= 10; 
        }
        Console.WriteLine("acc = " +acc);
        return acc;
    }
}