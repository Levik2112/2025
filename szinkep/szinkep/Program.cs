//1.feladat
List<string> szinek = new List<string>();
StreamReader olvas = new StreamReader("kep.txt");

while (!olvas.EndOfStream)
{
    string line = olvas.ReadLine();
    line.Split("\n");
    szinek.Add(line);
}

olvas.Close();
Console.WriteLine(szinek.Count);

//2.feladat
Console.Write("Adj meg egy RGB kódot: ");
string bekeres = Console.ReadLine();

if (szinek.Contains(bekeres)){
    Console.WriteLine("2.feladat Van ilyen szín!");
}
else
{
    Console.WriteLine("2.feladat Nincs ilyen szín");
}


//3.feladat

int width = 50;
int height = 50;
(int r, int g, int b)[,] kep = new (int, int, int)[height, width];
string[] sorok = File.ReadAllLines("kep.txt");
for (int i = 0; i < sorok.Length; i++)
{
    string[] rgb = sorok[i].Split(' '); ;
    int sor = i / width;
    int cella = i % width;
    kep[sor, cella] = (int.Parse(rgb[0]), int.Parse(rgb[1]), int.Parse(rgb[2]));

}

(int r, int g, int b) valasztott = kep[34, 7];

int sorSzam = 0;
for (int i = 0; i < width; i++)
{
    if (kep[34, i] == valasztott)
    {
        sorSzam++;
    }
}
int oszlopSzam = 0;
for (int i = 0; i < height; i++)
{
    if (kep[i, 7] == valasztott)
    {
        oszlopSzam++;
    }
}

Console.WriteLine("3.feladat Sorban: {0} Oszlopban: {1}", sorSzam, oszlopSzam);

//4.feladat

int zold = 0;
int kek = 0;
int voros = 0;

for (int i = 0; i < szinek.Count; i++)
{
    if (szinek[i] == "255 0 0")
    {
        voros++;
    }
    else if (szinek[i] == "0 255 0")
    {
        zold++;
    }
    else if (szinek[i] == "0 0 255")
    {
        kek++;
    }
}

/*
Console.WriteLine("kek: "+kek);
Console.WriteLine("pris: "+voros);
Console.WriteLine("zold: "+zold);
*/

Dictionary<string, int> cuc = new Dictionary<string, int>();
cuc.Add("Zöld", zold);
cuc.Add("Vörös", voros);
cuc.Add("Kék", kek);
Console.WriteLine("4.feladat A legtöbbször előforduló szín: {0}", cuc.FirstOrDefault(x => x.Value == cuc.Values.Max()).Key);


