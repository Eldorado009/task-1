#region MyRegion
string ay = Console.ReadLine();
string fesil = "yaz";

if (ay == "mart" || ay == "aprel" || ay == "may" && fesil == "yaz")
{
    Console.WriteLine("dogrudur!");
}
else
{
    Console.WriteLine("yanlis ad daxil etmisiniz!");
}
#endregion

#region Task2
int toplam = Convert.ToInt32(Console.ReadLine());
int mertebe = 0;
int testNumber = 0;
bool state = true;

while (state)
{
    testNumber = toplam % 10;
    toplam = toplam / 10;

    if (testNumber > 0)
    {
        mertebe++;
    }
    else
    {
        state = false;
    }
}
Console.WriteLine(mertebe);
#endregion

#region Task3
Console.Write("Reqem Daxil Edin: ");
int reqem = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = reqem; i >= 1; i--)
{
    result = result * i;
}
Console.WriteLine("Netice: " + result);
#endregion