
class Scooter : Moto
{
    private int Nbau;
    private string estilo;


    public void setNBau(int _Nbau)
    {
        this.Nbau = _Nbau;
    }

    public int getNBau()
    {
        return this.Nbau;
    }

    public void setEstilo(string _estilo)
    {
        this.estilo = _estilo;
    }

    public string getEstilo()
    {
        return this.estilo;
    }

    public override void Mostrar()
    {
        base.Mostrar();
        Console.WriteLine($"Número de Baú: {Nbau}, Estilo: {estilo}");
    }


}