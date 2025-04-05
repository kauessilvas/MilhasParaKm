Console.Clear();
double milhas, quilometros;
Console.WriteLine("===== Milhas Para Km =====");
while (true)
{
    Console.Write("Digite a medida em milhas: ");
    string? entrada = Console.ReadLine();

    if (double.TryParse(entrada, out milhas))
    {
        break;
    }
    else
    {
        Console.WriteLine("Valor inválido! Por favor, digite um número.");
    }
}
Console.WriteLine("==========================");

quilometros = milhas * 1.609;
Console.WriteLine($"{quilometros} km");
