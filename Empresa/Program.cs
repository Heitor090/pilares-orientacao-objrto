using System;
using Empresa;

public class Program
{
    static void Main() {
        Vendedor vendedor1 = new Vendedor();
        vendedor1.Nome = "Juninho Capixaba";

        Gerente gerente = new Gerente();
        gerente.Nome = "Ronaldo fenomeno";

        Console.WriteLine($"Vendedor: {vendedor1.Nome}, Comissão {vendedor1.Comissao()}");
        Console.WriteLine($"Gerente: {gerente.Nome}, Comissão {gerente.Comissao()}");
    
    }
}