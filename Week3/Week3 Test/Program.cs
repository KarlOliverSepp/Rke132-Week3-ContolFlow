Console.WriteLine("Mis hinne sul on? (sisesta A, B, C, D, E või F)");
string hinne = Console.ReadLine().ToUpper();

if (hinne == "A")
{
    Console.WriteLine("Suurepärane!");
}
else if (hinne == "B")
{
    Console.WriteLine("Väga hea!");
}
else if (hinne == "C")
{
    Console.WriteLine("Hea!");
}
else if (hinne == "D")
{
    Console.WriteLine("Rahuldav!");
}
else if (hinne == "E")
{
    Console.WriteLine("Kasin!");
}
else if (hinne == "F")
{
    Console.WriteLine("Puudulik!");
}
else
{
    Console.WriteLine("Vale väärtus!");
}
