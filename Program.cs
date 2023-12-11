Console.WriteLine("--- Entrada Válida ---\n");

int numero = 10;

while (numero < 0 || numero > 9)
{
    Console.Write("Digite um número entre 1 e 9 (ou 0 para cancelar): ");
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero < 0 || numero > 9) {
      Console.WriteLine("\nNúmero inválido!\n");
    }
}

if (numero == 0)
{
    Console.WriteLine("\nOperação cancelada.");
}
else
{
    Console.WriteLine($"\nNúmero selecionado = {numero}");
}

Console.WriteLine("\nVolte sempre!");