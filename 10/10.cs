Console.WriteLine("Введите длину окружности");
double l = Convert.ToDouble(Console.ReadLine());
double s = Math.Pow((l / 2), 2) / Math.PI;
Console.WriteLine($"Площадь вписанного круга: {s}");

