/*static void concatenar(string nome, string sobrenome)
{
  string nomeSobrenome = nome + " " + sobrenome;
  Console.WriteLine(nomeSobrenome);
}

concatenar("Eluara", "Andrade");
Console.WriteLine("Fim!!!");
*/

/*
static string concatenar()
{
  Console.WriteLine("Digite o nome: ");
  string nome = Console.ReadLine()!;

  Console.WriteLine("Digite o sobrenome: ");
  string sobrenome = Console.ReadLine()!;

  string nomeSobrenome = nome + " " + sobrenome;
  Console.WriteLine(nomeSobrenome);

}

//concatenar();
string concatenado = concatenar();
Console.WriteLine(concatenado);
Console.WriteLine("Fim!!");
*/

static int LerNumeroTabuada()
{
  Console.WriteLine("Digite o número da tabuada: ");
  int numero = int.Parse(Console.ReadLine()!);

  return numero;
}

static void ExibirTabuada(int numero)
{
  Console.WriteLine();

  int contador = 1;

  while (contador <= 10)
  {
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
    contador++;
  }

  Console.WriteLine();
}

static string LerContinuacao()
{
  Console.WriteLine("Deseja consultar outra tabuada? s/n: ");
  string resposta = Console.ReadLine()!;

  return resposta;
}

static bool DesejaContinuar(string resposta)
{
  if (resposta == "s" || resposta == "S")
  {
    return true;
  }
  else
  {
    return false;
  }
}
static void ExecutarTabuada()
{
  Console.Clear();

  int numero = LerNumeroTabuada();

  ExibirTabuada(numero);

  string resposta = LerContinuacao();

  if (DesejaContinuar(resposta))
  {
    ExecutarTabuada();
  }
  else
  {
    Console.WriteLine();
    Console.WriteLine("Programa encerrado");
  }
}

ExecutarTabuada();