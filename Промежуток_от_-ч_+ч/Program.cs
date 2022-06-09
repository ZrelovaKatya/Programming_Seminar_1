Console.WriteLine ("Введите положительное число: ");
string input = Console.ReadLine ();
int number = Convert.ToInt32(input);
int min = -number;

while (min <= number)
{
    Console.Write(min + " ");
    min ++;
}