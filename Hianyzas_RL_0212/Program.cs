﻿
string[] input = File.ReadAllLines("szeptember.csv");
Hianyzas[] data = new Hianyzas[input.Length];
for (int i = 1; i < input.Length; i++)
{
    data[i] = new Hianyzas(input[i]);
}
Console.WriteLine($"{input.Length} hianyzas rogzitve");
int mossz = 0;
for (int i = 0; i < data.Length; i++)
{
    mossz += data[i].mora;
}
Console.WriteLine($"Az osszes mulasztas: {mossz} óra");



struct Hianyzas
{
    public string nev;
    public string osztaly;
    public int enap;
    public int unap;
    public int mora;

    public Hianyzas(string line)
    {
        string[] splitted = line.Split(";");
        nev = splitted[0];
        osztaly = splitted[1];
        enap = int.Parse(splitted[2]);
        unap = int.Parse(splitted[3]);
        mora = int.Parse(splitted[4]);
    }
    public int Atvalto()
    {
        int mperc = mora * 45;
        return mperc;
    }
}