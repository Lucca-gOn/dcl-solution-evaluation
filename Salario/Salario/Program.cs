using Salario;

Vendedor vendedor = new Vendedor();

Console.WriteLine("Informe o número de carros vendidos:");
vendedor.NumeroDeCarrosVendidos = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o valor total das vendas:");
vendedor.ValorTotalDasVendas = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o salário fixo:");
vendedor.SalarioFixo = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o valor por carro vendido:");
vendedor.ValorPorCarroVendido = int.Parse(Console.ReadLine());

vendedor.CalcularSalario();

Console.WriteLine($"Salário final: {vendedor.SalarioFinal}");
