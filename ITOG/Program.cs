// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символам

Console.Clear();

string[] M;
Console.WriteLine("Enter massiv with blankspaces");

string line = Console.ReadLine();
M = line.Split(' ');
var result = new string[M .Length];
var realSize = 0;
foreach (var value in M )
{
    if (value.Length <= 3)
         {
            result[realSize] = value;
            realSize++;
        }
}

Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));

Console.ReadKey(true);
