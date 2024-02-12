using System.Runtime.CompilerServices;

string[] adat = File.ReadAllLines("szeptember.csv");
List<Hiany> data = new List<Hiany>();




struct Hiany
{
    public string Nev;
    public string Oszt;
    public string elso;
    public string utolso;
    public int orakszama;


    public Hiany(string line)
    {
        //var -> Variable, ha nem tudod milyen típusú adatot kapsz, ő kiértékeli
        string[] splitted = line.Split(';');
        this.Nev = splitted[0];
        this.Oszt = splitted[1];
        this.elso = splitted[2];
        this.utolso = splitted[3];
        this.orakszama = int.Parse(splitted[4]);

    }

}