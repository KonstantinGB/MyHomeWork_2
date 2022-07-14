// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//  645 -> 5
//  78 -> третьей цифры нет
//  32679 -> 6

int ThreeNumber (int num)
{
    while ( num > 999)
        num = num / 10;
    
    int resolt = num % 10;
    return resolt;
    
}

Console.Write("Введите число для нахождения третьей цифры : ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99)
{
    int threenumber = ThreeNumber(num);
    Console.WriteLine(threenumber);
}
else
    Console.WriteLine("В вашем числе меньше трех цифр");


