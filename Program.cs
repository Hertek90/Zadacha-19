// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100000 && num > 9999)
{
    int a = num%10;
    int b = num%100000/10000;
    int c = num%100/10;
    int d = num%10000/1000;
    if (a==b && c==d)
    {
        System.Console.WriteLine("Да");
    }
    else
    {
        System.Console.WriteLine("Нет");
    }
}

else
{
    System.Console.WriteLine("Число не соответствует условию задачи!");
}