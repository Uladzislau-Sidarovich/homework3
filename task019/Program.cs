Console.Write("Введите пятизначное число : ");
string number = Console.ReadLine();
if (number[0] == number[4] && number[1] == number[3])
{
    Console.Write(number + " Палиндром");
}
else
{
    Console.Write(number + " Не палиндром");
}
