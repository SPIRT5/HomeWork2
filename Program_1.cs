
Random rnd = new Random();
int number = rnd.Next(100, 1000);

int firstDigit = number / 100;
int secondDigit = (number / 10) % 10;
int thirdDigit = number % 10;

Console.WriteLine("Сгенерированное число: " + number);

Console.WriteLine(secondDigit);