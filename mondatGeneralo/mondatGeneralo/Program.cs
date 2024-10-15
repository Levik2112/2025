List<string> igek = new List<string>();
List<string> hatarozok = new List<string>();
List<string> targy = new List<string>();
List<string> melleknev = new List<string>();
List<string> jelzok = new List<string>();


StreamReader olvas = new StreamReader("igek.txt");
string[] vag = olvas.ReadToEnd().Split(',');
for (int i = 0; i < vag.Length; i++)
{
    igek.Add(vag[i]);
}
olvas.Close();

StreamReader olvas2 = new StreamReader("hatarozo.txt");
string[] vag2 = olvas2.ReadToEnd().Split(',');
for (int i = 0; i < vag2.Length; i++)
{
    hatarozok.Add(vag2[i]);
}
olvas2.Close();

StreamReader olvas3 = new StreamReader("targy.txt");
string[] vag3 = olvas3.ReadToEnd().Split(',');
for (int i = 0; i < vag3.Length; i++)
{
    targy.Add(vag3[i]);
}
olvas3.Close();

StreamReader olvas4 = new StreamReader("melleknev.txt");
string[] vag4 = olvas4.ReadToEnd().Split(',');
for (int i = 0; i < vag4.Length; i++)
{
    melleknev.Add(vag4[i]);
}
olvas4.Close();

StreamReader olvas5 = new StreamReader("jelzok.txt");
string[] vag5 = olvas5.ReadToEnd().Split(',');
for (int i = 0; i < vag5.Length; i++)
{
    jelzok.Add(vag5[i]);
}
olvas3.Close();
Console.WriteLine(targy.Count);
for (int i = 0; i < 100; i++)
{
    Random rnd = new Random();
    StreamWriter ir = new StreamWriter("vege.txt");
    ir.WriteLine(targy.ElementAt(rnd.Next(0,targy.Count))+hatarozok.ElementAt(rnd.Next(0,hatarozok.Count)));
    ir.Close();
}
