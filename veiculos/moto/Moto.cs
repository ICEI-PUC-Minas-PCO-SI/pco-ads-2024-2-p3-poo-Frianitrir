class Moto : Veiculo
{
  private string guidao;
  private string garupa;

  public void setGuidao(string _guidao)
  {
    this.guidao = _guidao;
  }

  public string getGuidao()
  {
    return this.guidao;
  }

  public void setGarupa(string _garupa)
  {
    this.garupa = _garupa;
  }

  public string getGarupa()
  {
    return this.garupa;
  }

  public override void Mostrar()
  {
    base.Mostrar();
    Console.WriteLine($"Número de Guidao: {guidao}, Qtd de Garupas: {garupa}");
  }


}