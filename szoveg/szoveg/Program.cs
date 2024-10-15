static List<string> feldolgoz(string szoveg)
{

    StreamReader olvas = new StreamReader(szoveg);
    List<string> mondatok = olvas.ReadToEnd().Split("\n").ToList();
    olvas.Close();

    for (int i = 0; i < mondatok.Count; i++)
    {
        Console.WriteLine(mondatok[i]);
    }
    return mondatok;

}
feldolgoz("szoveg.txt");

static List<string> feldolgozo2(List<string> mondat)
{
    List<string> szavak = new List<string>();
    Console.Write("Adj egy szamot: ");
    int szam = Convert.ToInt32(Console.ReadLine());

    Random rnd = new Random();

    for (int i = 0; i< mondat.Count; i++)
    {
       return szavak.Add(mondat.ToString().Split(' ').ToList().ToString());
    }
}