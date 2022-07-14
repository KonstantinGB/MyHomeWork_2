// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//  6 -> да
//  7 -> да
//  1 -> нет

bool Vixodnoy(int num)
{
    if ( num < 6) return false;
    else return true;
}

Console.Write("Введите день недели что бы узнать выходной ли это день : ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 8)
{
    bool day = Vixodnoy(num);
    Console.WriteLine(day);
}
else
    Console.WriteLine("Такого дня недели не существует");