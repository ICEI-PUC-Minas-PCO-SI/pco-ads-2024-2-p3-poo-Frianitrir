
class Motocross : Moto
{

    private int Ncorrente;
    private int Ncavalete;

 public void setNCorrente(int _Ncorrente)
    {
        this.Ncorrente = _Ncorrente;
    }

    public int getNCorrente()
    {
        return this.Ncorrente;
    }

    public void setNCavalete(int _Ncavalete)
    {
        this.Ncavalete = _Ncavalete;
    }

    public int getNCavalete()
    {
        return this.Ncavalete;
    }

    public override void Mostrar()
    {
        base.Mostrar();
        Console.WriteLine($"Número de Correntes: {Ncorrente}, Numero de Cavaletes: {Ncavalete}");
    }

}