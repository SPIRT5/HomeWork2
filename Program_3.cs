                                      // Работачий вариант с рандомом //
/*
Random rnd = new Random();
int number = rnd.Next(1, 8);

Console.WriteLine(number);

if (number == 6 || number == 7)
{
    Console.WriteLine("День недели под номером: " + number + " является выходным");
}
else
{
    Console.WriteLine("День недели под номером: " + number + " НЕ является выходным");
}
*/

                                      // Работачий вариант с ручным вводом //
Console.Write("Введите цифру, обозначающую день недели: ");
string numberStrDay = Console.ReadLine();
int numberDay = int.Parse(numberStrDay);

string[] weekDays = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

if (numberDay > 7)
{
    Console.WriteLine("Число больше, чем кол-во дней в недели (7)");
}
else if (numberDay == 6 || numberDay == 7)
{
    Console.WriteLine("День недели под номером " + numberDay + " - " + weekDays[(numberDay-1)] + " является выходным");
}
else
{
    Console.WriteLine("День недели под номером " + numberDay + " - " + weekDays[(numberDay-1)] + " НЕ является выходным");
}


