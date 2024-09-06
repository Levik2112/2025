
int szam = 1;

while (szam != 0)
{
    Console.Write("Szám: ");
    szam = Convert.ToInt32(Console.ReadLine());
}
StreamWriter ir = new StreamWriter("asd.txt",true);
ir.WriteLine(szam);
ir.Close();