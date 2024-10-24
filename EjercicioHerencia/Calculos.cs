
namespace EjercicioHerencia
{
    public class Calculos : Operaciones
    {
        public void Imprimir(int a, int b)
        {
            Console.WriteLine($"Suma: {Sumar(a, b)}");
            Console.WriteLine($"Resta: {Restar(a, b)}");
            Console.WriteLine($"Multiplicación: {Multiplicar(a, b)}");
        }
    }
}
