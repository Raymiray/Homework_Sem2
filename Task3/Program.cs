// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.WriteLine("Enter a positive two-digit whole number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 10 && num <= 99)
{
    int firstDigit = num / 10;
    int lastDigit = num % 10;

    if (firstDigit > lastDigit)
    {
        Console.WriteLine(firstDigit);        
    }
    else
    {
        Console.WriteLine(lastDigit);
    }
    
}
else
{
    Console.WriteLine("Erorr");
}