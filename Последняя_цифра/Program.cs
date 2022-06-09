Console.WriteLine ("Введите число: ");
string input = Console.ReadLine ();
int number = Convert.ToInt32(input);
if (number > 99 && number < 1000)
{
    int lastNumber = number % 10;
    Console.WriteLine("Последняя цифра вашего числа: " + lastNumber);
}
else
{
   Console.WriteLine("Число неверно"); 
}