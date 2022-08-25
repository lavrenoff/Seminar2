int number=new Random().Next(100,1000);

int result=(number%100)/10;
Console.Write($"{number}={result}");
