// Определение палиндрома среди пятизначных чисел
Console.WriteLine ("Введите пятизначное число: ");
int number = Convert.ToInt32 (Console.ReadLine ());
if ((number < 10000) & (number > 99999))
    {
        Console.WriteLine ("Введено неверное число");
    }
else 
    {
        int [] massive ()
        {
            int [] array = new int [5];
            int index = 1;
            int num = number;
            while (index <= array.Length)
            {
                array [array.Length - index] = num % 10;
                num = num / 10;
                index++;
            }
            return array;
        }
    
        int [] result = massive ();
        if (result [0] == result [4] && result [1] == result [3])
        {
            Console.WriteLine (number + " -> " + "да");
        }
        else
        {
            Console.WriteLine (number + " -> " + "нет");
        }

    }