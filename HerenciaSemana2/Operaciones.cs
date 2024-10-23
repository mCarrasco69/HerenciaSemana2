public class Cuadrado : Operaciones
{
    private double lado;

    public Cuadrado(double lado)
    {
        this.lado = lado;
    }

    public  double Area()
    {
        return lado * lado;
    }

    public  double Perimetro()
    {
        return 4 * lado;
    }

    public double Diagonal()
    {
        return Math.Sqrt(2) * lado;
    }

    public void Imprimir()
    {
        Console.WriteLine("Área: " + Area());
        Console.WriteLine("Perímetro: " + Perimetro());
        Console.WriteLine("Diagonal: " + Diagonal());
    }
}