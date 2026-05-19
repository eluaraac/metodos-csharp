/*
static string LerNomeCliente()
{
  Console.Write("Digite o nome do cliente: ");
  return Console.ReadLine()!;
}

static double LerValorCompra()
{
  Console.Write("Digite o valor da compra: ");
  return double.Parse(Console.ReadLine()!);
}

static double CalcularDesconto(double valorCompra)
{
  double desconto = 0;

  if (valorCompra > 100)
  {
    desconto = valorCompra * 0.1;
  }
  else
  {
    desconto = valorCompra * 0.05;
  }
  double valorFinal = valorCompra - desconto;
  return valorFinal;
}

static void ExibirResultado()
{
  string cliente = LerNomeCliente();
  double valorCompra = LerValorCompra();
  double valorFinal = CalcularDesconto(valorCompra);

  Console.WriteLine($"Cliente: {cliente}");
  Console.WriteLine($"Valor da compra: {valorCompra:F2}");
  Console.WriteLine($"Desconto aplicado: {valorCompra - valorFinal:F2}");
  Console.WriteLine($"Valor final da compra: {valorFinal:F2}");
}

ExibirResultado();
*/