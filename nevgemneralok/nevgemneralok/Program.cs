StreamReader kereszt = new StreamReader("nevek.txt");
string[] keresztNevek = kereszt.ReadToEnd().Split(",");
kereszt.Close();
StreamReader vezetek = new StreamReader("vezetek.txt");
string[] vezetekNev = vezetek.ReadToEnd().Split("\n");
vezetek.Close();

Random random = new Random();

int randomSzam = random.Next();
StreamWriter kiir = new StreamWriter("nevekveg.txt",true);
kiir.WriteLine(vezetekNev[random] + keresztNevek[random]);