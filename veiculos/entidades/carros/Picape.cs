using System.Runtime.CompilerServices;

class Picape : Carro
{
    int Ncacamba;
    int Ncabine;

    public void setNCacamba(int _Ncacamba)
    {
        this.Ncacamba = _Ncacamba;
    }


    public int geNCacamba()
    {
        return this.Ncacamba;
    }

    public void setNCabine(int _Ncabine)
    {
        this.Ncabine = _Ncabine;
    }

    public int getNCabine()
    {
        return this.Ncabine;
    }
    public override void Mostrar()
    {
        base.Mostrar();
        Console.WriteLine($"Numero de Caçambas: {Ncacamba}, Numero de Cabines: {Ncabine} ");
    }
}