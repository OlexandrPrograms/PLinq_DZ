namespace PLinq_DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// ======== TASK 1 ========
            //List<string> countries1 = new List<string> { "Ukraine", "Poland", "Germany", "France", "Italy" };
            //List<string> countries2 = new List<string> { "Germany", "France", "Spain", "Italy", "Portugal" };

            //var res1 = countries1.AsParallel()
            //                    .Where(c => !countries2.Contains(c));
            //Print(res1);

            //var res2 = countries1.AsParallel()
            //                    .Where(c => countries2.Contains(c))
            //                    .Distinct();
            //Print(res2);

            //var res3 = countries1.AsParallel()
            //                    .Union(countries2.AsParallel());
            //Print(res3);

            //var res4 = countries1.AsParallel()
            //                    .Distinct();
            //Print(res4);




            //// ======== TASK 2 ========
            //List<Device> devices1 = new List<Device>
            //{
            //    new Device("Galaxy S22", "Samsung", 800m),
            //    new Device("iPhone 13", "Apple", 900m),
            //    new Device("Xperia 1", "Sony", 750m),
            //    new Device("Mi 11", "Xiaomi", 600m)
            //};

            //List<Device> devices2 = new List<Device>
            //{
            //    new Device("iPhone 14", "Apple", 1000m),
            //    new Device("Galaxy A53", "Samsung", 400m),
            //    new Device("Pixel 7", "Google", 700m),
            //    new Device("Reno 8", "Oppo", 500m)
            //};

            //var res1 = devices1.AsParallel()
            //                    .Where(d => !(devices2.Select(d2 => d2.brand)).Contains(d.brand))
            //                    .Distinct();
            //PrintDevice(res1);

            //var res2 = devices1.AsParallel()
            //                    .Where(d => (devices2.Select(d2 => d2.brand)).Contains(d.brand))
            //                    .Distinct();
            //PrintDevice(res2);

            //var res3 = devices1.AsParallel()
            //                    .Concat(devices2.AsParallel())
            //                    .DistinctBy(d => d.brand);
            //PrintDevice(res3);




            //// ======== TASK 3 ========
            //List<Phone> phones = new List<Phone>
            //{
            //    new Phone("iPhone 13", "Apple", 850m, new DateTime(2021, 9, 24)),
            //    new Phone("Galaxy S21", "Samsung", 700m, new DateTime(2021, 1, 29)),
            //    new Phone("Redmi Note 10", "Xiaomi", 250m, new DateTime(2021, 3, 16)),
            //    new Phone("Xperia 5", "Sony", 450m, new DateTime(2020, 10, 1)),
            //    new Phone("iPhone 11", "Apple", 450m, new DateTime(2019, 9, 20)),
            //    new Phone("Galaxy A12", "Samsung", 180m, new DateTime(2020, 12, 21)),
            //    new Phone("Nokia 3310", "Nokia", 50m, new DateTime(2000, 9, 1))
            //};

            //int count = phones.AsParallel().Count();
            //Console.WriteLine(count);

            //int countPrice100 = phones.AsParallel().Count(p => p.price > 100m);
            //Console.WriteLine(countPrice100);

            //int countPriceRange = phones.AsParallel().Count(p => p.price >= 400m && p.price <= 700m);
            //Console.WriteLine(countPriceRange);

            //int countBrandApple = phones.AsParallel().Count(p => p.brand == "Apple");
            //Console.WriteLine(countBrandApple);

            //var minPricePhone = phones.AsParallel().OrderBy(p => p.price).First();
            //Console.WriteLine($"{minPricePhone.brand} {minPricePhone.model} - {minPricePhone.price}");

            //var maxPricePhone = phones.AsParallel().OrderByDescending(p => p.price).First();
            //Console.WriteLine($"{maxPricePhone.brand} {maxPricePhone.model} - {maxPricePhone.price}");

            //var oldestPhone = phones.AsParallel().OrderBy(p => p.releaseDate).First();
            //Console.WriteLine($"{oldestPhone.brand} {oldestPhone.model} - {oldestPhone.releaseDate.ToShortDateString()}");

            //var newestPhone = phones.AsParallel().OrderByDescending(p => p.releaseDate).First();
            //Console.WriteLine($"{newestPhone.brand} {newestPhone.model} - {newestPhone.releaseDate.ToShortDateString()}");

            //var avgPrice = phones.AsParallel().Average(p => p.price);
            //Console.WriteLine(avgPrice);




            //// ======== TASK 4 ========
            //List<Phone> phones = new List<Phone>
            //{
            //    new Phone("iPhone 13", "Apple", 850m, new DateTime(2021, 9, 24)),
            //    new Phone("Galaxy S21", "Samsung", 700m, new DateTime(2021, 1, 29)),
            //    new Phone("Redmi Note 10", "Xiaomi", 250m, new DateTime(2021, 3, 16)),
            //    new Phone("Xperia 5", "Sony", 450m, new DateTime(2020, 10, 1)),
            //    new Phone("iPhone 11", "Apple", 450m, new DateTime(2019, 9, 20)),
            //    new Phone("Galaxy A12", "Samsung", 180m, new DateTime(2020, 12, 21)),
            //    new Phone("Nokia 3310", "Nokia", 50m, new DateTime(2000, 9, 1))
            //};

            //var res1 = phones.AsParallel()
            //                  .OrderByDescending(p => p.price)
            //                  .Take(5);
            //PrintPhone(res1);

            //var res2 = phones.AsParallel()
            //                  .OrderBy(p => p.price)
            //                  .Take(5);
            //PrintPhone(res2);

            //var res3 = phones.AsParallel()
            //                  .OrderBy(p => p.releaseDate)
            //                  .Take(3);
            //PrintPhone(res3);

            //var res4 = phones.AsParallel()
            //                  .OrderByDescending(p => p.releaseDate)
            //                  .Take(3);
            //PrintPhone(res4);




            //// ======== TASK 5 ========
            //List<Phone> phones = new List<Phone>
            //{
            //    new Phone("iPhone 13", "Apple", 850m, new DateTime(2021, 9, 24)),
            //    new Phone("Galaxy S21", "Samsung", 700m, new DateTime(2021, 1, 29)),
            //    new Phone("Redmi Note 10", "Xiaomi", 250m, new DateTime(2021, 3, 16)),
            //    new Phone("Xperia 5", "Sony", 450m, new DateTime(2020, 10, 1)),
            //    new Phone("iPhone 11", "Apple", 450m, new DateTime(2019, 9, 20)),
            //    new Phone("Galaxy A12", "Samsung", 180m, new DateTime(2020, 12, 21)),
            //    new Phone("Nokia 3310", "Nokia", 50m, new DateTime(2000, 9, 1))
            //};

            //var res1 = phones.AsParallel()
            //                  .GroupBy(p => p.brand)
            //                  .Select(g => new { Brand = g.Key, Count = g.Count() });

            //foreach (var item in res1)
            //{
            //    Console.WriteLine($"{item.Brand} — {item.Count}");
            //}
            //Console.WriteLine();

            //var res2 = phones.AsParallel()
            //                  .GroupBy(p => p.model)
            //                  .Select(g => new { Model = g.Key, Count = g.Count() });

            //foreach (var item in res2)
            //{
            //    Console.WriteLine($"{item.Model} — {item.Count}");
            //}
            //Console.WriteLine();

            //var res3 = phones.AsParallel()
            //                  .GroupBy(p => p.releaseDate.Year)
            //                  .Select(g => new { Year = g.Key, Count = g.Count() });

            //foreach (var item in res3)
            //{
            //    Console.WriteLine($"{item.Year} — {item.Count}");
            //}
        }

        public record Device(string model, string brand, decimal price);
        public record Phone(string model, string brand, decimal price, DateTime releaseDate);

        static void Print(IEnumerable<string> list)
        {
            foreach (string item in list)
                Console.Write(item + ", ");
            Console.WriteLine("\n=================================");
        }

        static void PrintDevice(IEnumerable<Device> devices)
        {
            foreach (Device device in devices)
            {
                Console.WriteLine(device.brand + " / " + device.model + " / " + device.price);
            }
            Console.WriteLine("==================================");
        }

        static void PrintPhone(IEnumerable<Phone> phones)
        {
            foreach (Phone phone in phones)
            {
                Console.WriteLine($"{phone.brand} / {phone.model} / {phone.price} / {phone.releaseDate.ToShortDateString()}");
            }
            Console.WriteLine("==================================");
        }
    }
}
