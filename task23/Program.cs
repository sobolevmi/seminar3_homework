// Таблица кубов всех чисел от 1 до N
Console.WriteLine ("Введите целое число: ");
int number = Convert.ToInt32 (Console.ReadLine ());
int i = 1;
Console.Write (number + " -> ");

void stepenPlus (int a)
{
    for (i = 1; i < number; i++)
        {   
            int num = Convert.ToInt32 (Math.Pow (i, 3));
            Console.Write (num + ", ");
        }
    if (i == number)
        {
            Console.WriteLine (Convert.ToInt32 (Math.Pow (i, 3)));
        }
}

void stepenMinus (int a)
{
    int i = 1;
    while (i > number)
        {   
            int num = Convert.ToInt32 (Math.Pow (i, 3));
            Console.Write (num + ", ");
            i = i - 1;
        }
    if (i == number)
        {
            Console.WriteLine (Convert.ToInt32 (Math.Pow (i, 3)));
        }
}

if (number > 0)
    {
        stepenPlus (number);
    }
else if (number < 0)
    {
        stepenMinus (number);
    }
else if (number == 0)
    {
        Console.Write ("0");
    }