public interface Seguro
{
    public void SeguroParticular();
}

public class SeguroCarro : Seguro
{
    public void SeguroParticular()
    {
        Console.WriteLine("Seguro específico para Carros.");
    }
}
