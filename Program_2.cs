Console.Write("Введите число: ");
string numberStr = Console.ReadLine();
int cnt = numberStr.Length;

if  (cnt <= 2)
{
    Console.WriteLine("Третьей цифры нет"); 
}
else
{
    char[] arrayNumberStr = numberStr.ToCharArray();
    Console.WriteLine("Третья цифра: " + arrayNumberStr[2]);
}