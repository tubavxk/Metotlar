Console.Write("Öğrenci adı: ");
string ad = Console.ReadLine();

Console.Write("Öğrenci soyadı: ");
string soyad = Console.ReadLine();

Console.Write("Birinci sınav notu: ");
double sinav1 = Convert.ToDouble(Console.ReadLine());

Console.Write("İkinci sınav notu: ");
double sinav2 = Convert.ToDouble(Console.ReadLine());


double ortalama = (sinav1 + sinav2) / 2;

Console.WriteLine("Öğrenci: ");
Console.WriteLine(ad + soyad);
Console.WriteLine("Ortalama: ");
Console.WriteLine(ortalama);
Console.ReadKey();