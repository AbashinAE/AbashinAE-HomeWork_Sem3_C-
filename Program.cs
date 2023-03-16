// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine()!; //int number = Convert.ToInt32(Console.Readline());
if (number.Length == 5)
{
  if (number[0] == number[4] && number[1] == number[3])
  {
    Console.WriteLine(" Данное число является палиндромом");
  }
  else
  {
    Console.WriteLine(" Данное число не является палиндромом");
  }

}
else
{
  Console.WriteLine("Введено неверное число");
}
