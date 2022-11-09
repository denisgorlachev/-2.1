//Горлачев средний уровень 
Console.WriteLine("Введите число k: ");
double k = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число l: ");
double l = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число n: ");
double n = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число m: ");
double m = double.Parse(Console.ReadLine());
if ((k + l + m + n > 0 && k > 0 && 2 * m > l) || (k + l + m + n > 0 && k < 0 && n > 3 * l))
    Console.WriteLine("Условия выполняется");
else
    Console.WriteLine("Условия не выполянется");