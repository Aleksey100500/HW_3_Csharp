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

    static int Reverse(int num, int count)
    {

        while (num > 0) 
        { 
            count = count * 10 + num % 10;
            
            num /= 10; 
        }
        Console.WriteLine("count = " +count);
        return count;
    }
}