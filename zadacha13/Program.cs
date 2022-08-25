Console.Write("Введите число=");
int number = Convert.ToInt32(Console.ReadLine());

string viv=number.ToString();

if(viv.Length>2)
   Console.WriteLine($"{number} Третья цифра =  {viv[2]}");
   else
   Console.WriteLine("третьей цифры нет");
