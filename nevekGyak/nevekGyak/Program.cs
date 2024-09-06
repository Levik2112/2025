StreamReader olvas = new StreamReader("nevek.txt");
string[] vag = olvas.ReadToEnd().Split(',');

olvas.Close();

List<string> list = new List<string>();
for (int i = 0; i < vag.Length; i++)
{
    list.Add(vag[i]);
}

for (int i = 0;i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}