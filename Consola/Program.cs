using Consola.Class;

internal class Program
{
    private static void Main(string[] args)
    {
        var test = new Test1(10.5,"kim");
        test.HelloWorld();

        Calculadora calcu = new Calculadora(32,12);
        Calculadora calcu1 = new Calculadora(32, 12);
        Calculadora calcu2= new Calculadora(32, 12);
        Calculadora calcu3 = new Calculadora(32, 12);

        Console.WriteLine(Calculadora.instancias);

    }
}