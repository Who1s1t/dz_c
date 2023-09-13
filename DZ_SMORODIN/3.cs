Console.WriteLine("Введите радиус:");
double r = Convert.ToInt32(Console.ReadLine());
double s = Math.PI * Math.Pow(r, 2);
double l = 2 * Math.PI * r;
Console.WriteLine($"Длина круга: {l}");
Console.WriteLine($"Площадь круга: {s}");