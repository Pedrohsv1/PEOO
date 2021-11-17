using System; 

class URI {

    static void Main(string[] args) { 

        double A, B, C;

        A = double.Parse(Console.GetLine())
        B = double.Parse(Console.GetLine())
        C = double.Parse(Console.GetLine())

        double Tri = A * C / 2
        double Cir = 3.14159 * (C * C)
        double Tra = (A + B) * C / 2
        double Qua = B * B
        double Ret = A * B

        Console.WriteLine($"TRIANGULO: {Tri:0.000}")
        Console.WriteLine($"CIRCULO: {Cir:0.000}")
        Console.WriteLine($"TRAPEZIO: {Tra:0.000}")
        Console.WriteLine($"QUADRADO: {Qua:0.000}")
        Console.WriteLine($"QUADRADO: {Ret:0.000}")
    }

}
