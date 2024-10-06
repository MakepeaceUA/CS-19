namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1,2 и 3
            //int[] array = { 63, 150, 945, 1008, 9, 7, 18, 65,18,9 };

            //int product = array.Aggregate((acc, val) => acc * val);
            //Console.WriteLine($"Произведение элементов массива: {product}");
            //int count = array.Count();
            //Console.WriteLine($"Произведение элементов массива: {count}");
            //int count1 = array.Count(x => x % 9 == 0);
            //Console.WriteLine($"Кол-во элементов кратных 9: {count1}");
            //int count2 = array.Count(x => x % 7 == 0 && x > 945);
            //Console.WriteLine($"Кол-во элементов кратных 7 и больше 945: {count2}");
            //int sum = array.Sum();
            //Console.WriteLine($"Сумма: {sum}");
            //int even = array.Where(x => x % 2 == 0).Sum();
            //Console.WriteLine($"Сумма парных элементов: {even}");
            //int min = array.Min();
            //Console.WriteLine($"Минимальный элемент: {min}");
            //int max = array.Max();
            //Console.WriteLine($"Максимальный элемент: {max}");
            //double average = array.Average();
            //Console.WriteLine($"Среднее значение: {average}");
            //var topMax = array.OrderByDescending(x => x).Take(3);
            //Console.Write("Топ 3 максимальных элементов: ");
            //foreach (var elem in topMax)
            //{
            //    Console.Write(elem + " ");
            //}
            //Console.WriteLine();
            //var topMin = array.OrderBy(x => x).Take(3);
            //Console.Write("Топ 3 минимальных элементов: ");
            //foreach (var elem in topMin)
            //{
            //    Console.Write(elem + " ");
            //}
            //Console.WriteLine();
            //var statistics = array.GroupBy(x => x).
            //    Select(g => new {Number = g.Key,Count = g.Count()});
            //Console.WriteLine("Статистика вхождений всех чисел:");
            //foreach (var item in statistics)
            //{
            //    Console.WriteLine($"{item.Number} – {item.Count} раза");
            //}
            //var EvenStatistics = array.Where(x => x % 2 == 0)
            //                         .GroupBy(x => x)
            //                         .Select(g => new {Number = g.Key,Count = g.Count()});
            //Console.WriteLine("Статистика вхождений парных чисел:");
            //foreach (var item in EvenStatistics)
            //{
            //    Console.WriteLine($"{item.Number} – {item.Count} раза");
            //}


            //Задание 4
            //List<Laptop> laptops = new List<Laptop>
            //{ 
            //new Laptop("Model 1", "Manufacturer A", 2.5, 4, 800, 2020),
            //new Laptop("Model 3", "Manufacturer B", 3.0, 6, 1200, 2021),
            //new Laptop("Model 2", "Manufacturer D", 1.8, 2, 600, 2019),
            //new Laptop("Model 1", "Manufacturer C", 2.2, 4, 1500, 2023),
            //new Laptop("Model 3", "Manufacturer D", 3.5, 8, 2000, 2022),
            //new Laptop("Model 1", "Manufacturer A", 1.2, 2, 300, 2014),
            //new Laptop("Model 2", "Manufacturer B", 4.2, 4, 3000, 2017)
            //};

            //Console.WriteLine($"Кол-во ноутбуков: {laptops.Count}");

            //int inputPrice = 1000;

            //int count1 = laptops.Count(l => l.Price > inputPrice);
            //Console.WriteLine($"Кол-во ноутбуков с ценной больше {inputPrice}: {count1}");


            //int count2 = laptops.Count(l => l.Price >= 700 && l.Price <= 1500);
            //Console.WriteLine($"Кол-во ноутбуков в диапозоне: {count2}");

            //int count3 = laptops.Count(l => l.Manufacturer == "Manufacturer X");
            //Console.WriteLine($"Кол-во ноутбуков производителя: {count3}");

            //Laptop cheape = laptops.OrderBy(l => l.Price).FirstOrDefault();
            //Console.WriteLine($"Ноутбук с минимальной ценой: {cheape?.Model}, цена: {cheape?.Price}");

            //Laptop expensive = laptops.OrderByDescending(l => l.Price).FirstOrDefault();
            //Console.WriteLine($"Ноутбук с максимальной ценой: {expensive?.Model}, цена: {expensive?.Price}");

            //Laptop LowestFrequency = laptops.OrderBy(l => l.ProcessorFrequency).FirstOrDefault();
            //Console.WriteLine($"Ноутбук с самой маленькой частотой: {LowestFrequency?.Model}, частота: {LowestFrequency?.ProcessorFrequency}");

            //Laptop LatestLaptop = laptops.OrderByDescending(l => l.Year).FirstOrDefault();
            //Console.WriteLine($"Самая новая модель: {LatestLaptop?.Model}, год: {LatestLaptop?.Year}");

            //double AveragePrice = laptops.Average(l => l.Price);
            //Console.WriteLine($"Среднняя цена ноутбуков: {AveragePrice}");
            //var Stats1 = laptops.GroupBy(l => l.Manufacturer)
            //                               .Select(g => new { Manufacturer = g.Key, Count = g.Count() });
            //Console.WriteLine("Статистика по производителям:");
            //foreach (var stat in Stats1)
            //{
            //    Console.WriteLine($"Производитель: {stat.Manufacturer}, Кол-во: {stat.Count}");
            //}
            //var Stats2 = laptops.GroupBy(l => l.Model)
            //                        .Select(g => new { Model = g.Key, Count = g.Count() });

            //Console.WriteLine("Статистика по моделям:");
            //foreach (var stat in Stats2)
            //{
            //    Console.WriteLine($"Модель: {stat.Model}, Кол-во: {stat.Count}");
            //}

            //var Stats3 = laptops.GroupBy(l => l.Year)
            //                       .Select(g => new { Year = g.Key, Count = g.Count() });

            //Console.WriteLine("Статистика по годам:");
            //foreach (var stat in Stats3)
            //{
            //    Console.WriteLine($"Год: {stat.Year}, Кол-во: {stat.Count}");
            //}

            //Console.WriteLine("Топ пять самых дорогих ноутбуков:");
            //var TopExpensive = laptops.OrderByDescending(l => l.Price).Take(5);
            //foreach (var laptop in TopExpensive)
            //{
            //    Console.WriteLine($"{laptop.Model}, цена: {laptop.Price}");
            //}

            //Console.WriteLine("Топ пять самых дешёвых ноутбуков:");
            //var TopCheapest = laptops.OrderBy(l => l.Price).Take(5);
            //foreach (var laptop in TopCheapest)
            //{
            //    Console.WriteLine($"{laptop.Model}, цена: {laptop.Price}");
            //}

            //Console.WriteLine("Топ три самых старых ноутбука:");
            //var oldest = laptops.OrderBy(l => l.Year).Take(3);
            //foreach (var laptop in oldest)
            //{
            //    Console.WriteLine($"{laptop.Model}, год: {laptop.Year}");
            //}
            //Console.WriteLine("Топ три самых новых ноутбуков:");
            //var newestLaptops = laptops.OrderByDescending(l => l.Year).Take(3);
            //foreach (var laptop in newestLaptops)
            //{
            //    Console.WriteLine($"{laptop.Model}, год: {laptop.Year}");
            //}

            //Задание 5
            //int[] arr = { 1, -4, 2, - 1, 4, 2, -7, 7, 14, 20 };
            //var res = arr.Aggregate(new {index = arr[0], CurrentLength = 0, MaxLength = 0},
            //(acc, next) => 
            //{
            //    if (next > acc.index)
            //    {
            //        return new { index = next, CurrentLength = acc.CurrentLength + 1, MaxLength = Math.Max(acc.MaxLength, acc.CurrentLength + 1) };
            //    }
            //    else
            //    {
            //        return new { index = next, CurrentLength = 1, MaxLength = acc.MaxLength };
            //    }
            //});
            //Console.WriteLine(res.MaxLength);


            //Задание 6
            //string[] surnames = { "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis", "Martinez", "Robinson", "White", "Orange" };

            //bool names1 = surnames.All(s => s.Length > 3);
            //Console.WriteLine($"Фамилии длиною больше трёх: {names1}");
            //bool names2 = surnames.All(s => s.Length > 3 && s.Length < 10);
            //Console.WriteLine($"Фамилии длиною больше трёх и меньше десяти: {names2}");
            //bool names3 = surnames.Any(s => s.StartsWith("W"));
            //Console.WriteLine($"Фамилии начинающиеся на «W»: {names3}");
            //bool names4 = surnames.Any(s => s.EndsWith("y"));
            //Console.WriteLine($"Фамилии заканчивающиеся на «Y»: {names4}");
            //bool names5 = surnames.Contains("Orange");
            //Console.WriteLine($"Есть ли фамилия «Orange»: {names5}");
            //string names6 = surnames.FirstOrDefault(s => s.Length == 6);
            //Console.WriteLine($"Первая фамилия с длинной равной шести: {names6}");
            //string names7 = surnames.LastOrDefault(s => s.Length < 15);
            //Console.WriteLine($"Последняя фамилия длинной меньше пятнадцати: {names7}");

            //Задание 7
            //List<Journal> journals = new List<Journal>
            //{
            //new Journal { Title = "Polit", Genre = "Politic", Pages = 40, Date = new DateTime(2014, 5, 10) },
            //new Journal { Title = "Title Fashion", Genre = "Fashion", Pages = 32, Date = new DateTime(2020, 3, 15) },
            //new Journal { Title = "Title Sport", Genre = "Sport", Pages = 45, Date = new DateTime(2021, 8, 20) },
            //new Journal { Title = "Title Garden and Orchard", Genre = "Garden and Orchard", Pages = 25, Date = new DateTime(2019, 10, 30) },
            //new Journal { Title = "Fishing Title", Genre = "Fishing", Pages = 28, Date = new DateTime(2022, 6, 22) },
            //new Journal { Title = "Hunting Title", Genre = "Hunting", Pages = 50, Date = new DateTime(2023, 1, 15) },
            //new Journal { Title = "Auto car", Genre = "Auto", Pages = 35, Date = new DateTime(2021, 9, 11) }
            //};

            //bool stat1 = journals.All(j => j.Pages > 30);
            //Console.WriteLine("У всех ли журналов количество страниц больше 30: " + stat1);
            //bool stat2 = journals.All(j => j.Genre == "Politic" || j.Genre == "Fashion" || j.Genre == "Sport");
            //Console.WriteLine("Все ли журналы в жанре 'Politic', 'Fashion' или 'Sport': " + stat2);
            //bool stat3 = journals.Any(j => j.Genre == "Garden and Orchard");
            //Console.WriteLine("Есть ли хотя бы один журнал в жанре 'Garden and Orchard': " + stat3);
            //bool stat4 = journals.Any(j => j.Genre == "Fishing");
            //Console.WriteLine("Есть ли хотя бы один журнал в жанре 'Fishing': " + stat4);
            //bool stat5 = journals.Any(j => j.Genre.Equals("Hunting", StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine("Есть ли журналы про 'Hunting': " + stat5);
            //Journal stat6 = journals.FirstOrDefault(j => j.Date.Year == 2022);
            //Console.WriteLine("Первый журнал 2022 года: " + (stat6 != null ? stat6.Title : "Не найдено"));
            //Journal stat7 = journals.LastOrDefault(j => j.Title.StartsWith("Auto"));
            //Console.WriteLine("Последний журнал, начинающийся на 'Auto': " + (stat7 != null ? stat7.Title : "Не найдено"));

            //Задание 8
            //int[] arr = { 1, 2, 8, -1, 4, 2, -7, 9, 15, 5 };

            //var res = arr.Aggregate(new { CurrentLength = 0, MaxLength = 0 },
            //(acc, next) =>
            //{
            //    if (next > 0)
            //    {
            //        return new { CurrentLength = acc.CurrentLength + 1, MaxLength = Math.Max(acc.MaxLength, acc.CurrentLength + 1) };
            //    }
            //    else
            //    {
            //        return new { CurrentLength = 0, MaxLength = acc.MaxLength };
            //    }
            //});

            //Console.WriteLine(res.MaxLength);

        }
    }
}