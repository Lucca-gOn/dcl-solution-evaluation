//Entrada: Idade, meses, anos.
// Processamento: Informar o resultado expressa em apenas dias.

Console.WriteLine(@$"
| ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡  ≡|
|                       |
|                       |
|    Programa Idade     |
|                       |
|                       |
| ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ |
");

Console.WriteLine("Informe quantos anos você tem:");
int years = int.Parse(Console.ReadLine());

Console.WriteLine("Quantos meses se passaram desde o seu último aniversário?");
int months = int.Parse(Console.ReadLine());

Console.WriteLine("Quantos dias se passaram desde o último mês completo?");
int days = int.Parse(Console.ReadLine());

int totalDays = (years * 365) + (months * 30) + days;

Console.WriteLine($"Você viveu aproximadamente {totalDays} dias.");
