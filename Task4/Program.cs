// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

Console.WriteLine("Enter a natural number: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 0)
{
   if (n < 10)
   {
        Console.WriteLine(n);
   }
   else
   {
    while (n > 0)
    {
        int currentDigit = n % 10;
        n /= 10;
        if (n > 0)
        {
            Console.Write(currentDigit + ",");
        }
        else
        {
            Console.WriteLine(currentDigit);
        }
    }
   }
}
else
{
    Console.WriteLine("Erorr");
}