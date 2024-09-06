
class Carro : Veiculo 
{
   private int qtdePortas;
   private string cinto;

   public SeguroCarro safe;

   public string Modelo { get; set; }

    public Carro(string modelo)
    {
        Modelo = modelo;
    }

   public Carro(){}

   public void setQtdePortas(int _numPortas)
   {
      this.qtdePortas = _numPortas;
   }

   public int getQtdePortas()
   {
      return this.qtdePortas;
   }

   public void setCinto(string _cinto)
   {
      this.cinto = _cinto;
   }

   public string getCinto()
   {
      return this.cinto;
   }

   public override void Mostrar()
   {
      base.Mostrar();
      Console.WriteLine($"Número de Portas: {qtdePortas}, Qtd de Cintos: {cinto}");
   }

}