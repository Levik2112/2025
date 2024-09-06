StreamReader olvas = new StreamReader("szoveg.txt");
olvas.ReadToEnd().Replace(".","").Replace("!","").Replace(",","").Replace(";","");
Dictionary<string,int> konyvtar = new Dictionary<string, int>();

olvas.Close();