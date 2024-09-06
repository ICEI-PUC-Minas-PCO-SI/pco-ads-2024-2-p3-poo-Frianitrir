class Veiculo
{

    private string placa;
    private string renavam;


    public void setPlaca(string _placa)
    {
        this.placa = _placa;
    }


    public string getPlaca()
    {
        return this.placa;
    }

    public void setRenavan(string _renavam)
    {
        this.renavam = _renavam;
    }

    public string getRenavan()
    {
        return this.renavam;
    }

    public virtual void Mostrar()
    {
        Console.WriteLine($"Marca: {placa}, Modelo: {renavam}");
    }
}   