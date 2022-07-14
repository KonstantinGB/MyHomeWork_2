
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//  456 -> 5
//  782 -> 8
//  918 -> 1

int VtoroeChislo (int num)
{
int one = num / 10;
int resolt = one % 10;
 return resolt;
}

Console.Write("Введите 3-х значное число для нахождения 2 цифры: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 99 && num < 1000)    
{
    int twonumber = VtoroeChislo(num);
    Console.WriteLine(twonumber);
}
else 
{
Console.WriteLine("Вы ввели не трёхзначное число");
}