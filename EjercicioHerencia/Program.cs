using EjercicioHerencia;

class Program
{
    static void Main(string[] args)
    {
        Calculos calculos = new Calculos();

        Console.Write("Ingrese el primer número: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int b = Convert.ToInt32(Console.ReadLine());

        calculos.Imprimir(a, b);
    }
}
