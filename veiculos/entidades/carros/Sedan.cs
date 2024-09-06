class Sedan : Carro
{
   
    private string portamalas;

    public Sedan(string _portamalas)
    {
       this.portamalas = _portamalas;
    }



    public void setPortaMalas(string _portamalas)
    {
        this.portamalas = _portamalas;
    }

    public string getPortaMalas()
    {
        return this.portamalas;
    }

    public override void Mostrar()
    {
        base.Mostrar();
        Console.WriteLine($"Porta Malas: {portamalas}");
    }
    
    
}