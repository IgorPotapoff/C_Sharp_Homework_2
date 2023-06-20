/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

void Print(string text)
{
Console.WriteLine(text);
}
bool IsPalindrome (int number) // Исправил тут.
{

if ((number/10000 == number%10) && ((number/1000)%10 == (number%100)/10))
    {
    return true;
    }
    else
    return false;
    }
Print("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); // Исправил тут.

if (number>=10000 && number<=99999)

    if (IsPalindrome(number) ==true) // Исправил тут.
    {
    Console.WriteLine($"{number} - палиндром");
    }
    else
    {
    Console.WriteLine($"{number} - не палиндром");
    }

else

Console.WriteLine($"{number} - не пятизначное число");







