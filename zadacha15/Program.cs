Console.Write("Введите число от 1 до 7: ");

int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber >= 1 && dayNumber <= 7)
    {
        if (dayNumber == 7 || dayNumber == 6)
        {
            Console.Write("Под цифрой " + dayNumber + " - Выходной день");
        }
        else
        {
            Console.Write("Под цифрой " + dayNumber + " - Рабочий день");
        }
    }
    else
    {
        Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
    }
    

