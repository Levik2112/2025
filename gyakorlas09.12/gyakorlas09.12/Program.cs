static int Szambekeres(int min=3,int max = 15)
{
    if (min > max)
    {
        throw new ArgumentException("A minimum nem lehet nagyobb mint a maximum.");
    }
    int szam = 0;
    while(szam == 0)
    {
        try
        {
            Console.Write("adj egy szamot {0} {1} között: ", min, max);
            szam = Convert.ToInt32(Console.ReadLine());
            if (szam < min || szam > max)
            {
                throw new Exception();
            }
        }
        catch
        {
            szam = 0;
        }
    }
    
    return szam;
}

static string szoGeneralas(int hossz)
{
    string[] betuk = { "euioöüóúőűáéíaá", "qwrtzplkjhgfdsyxcvbnm" }; 
    Random rnd = new Random();
    int melyikJon = rnd.Next(2);
    string vissza = "";
    for (int i = 0; i < hossz; i++)
    {
        vissza += betuk[melyikJon][rnd.Next(betuk[melyikJon].Length)];
        melyikJon = 1 - melyikJon;
    }
    return vissza;


}

static List<string> sokSzo(int hossz,int darab=200)
{
    List<string> vissza = new List<string>();
    for (int i = 0; i < darab; i++)
    {
        vissza.Add(szoGeneralas(hossz));
    }
    return vissza;
}

static void filebaIr(List<string> szavak)
{
    StreamWriter ir = new StreamWriter("sok-szo.txt");
    for (int i = 0; i < szavak.Count; i++)
    {
        ir.WriteLine(szavak[i]);
    }
    ir.Close();
}


//Szambekeres();

int betuSzam = Szambekeres(5, 10);
//Console.WriteLine(szoGeneralas(4));
List<string> szavak = sokSzo(betuSzam);
filebaIr(szavak);