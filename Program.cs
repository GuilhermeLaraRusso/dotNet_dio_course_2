using ExemploExplorando.Models;
using System.Globalization;

DateTime data = DateTime.Now;

Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());

DateTime data2 = DateTime.Parse("17/04/2022 18:00");
Console.WriteLine(data2);

string dataString = "2022-14-17 18:00";

bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataConvertida);

if (sucesso)
{
  Console.WriteLine($"Conversão com sucesso: {dataConvertida}");
}
else
{
  Console.WriteLine($"{dataString} não é uma data válida");
}








































// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// decimal valorMonetario = 1582.40M;

// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("jp-JP")));
// Console.WriteLine($"{valorMonetario:C}");
// Console.WriteLine($"{valorMonetario:C4}");
// Console.WriteLine($"{valorMonetario:C8}");



// double porcentagem = .3421;

// Console.WriteLine($"{porcentagem:P2}");
// Console.WriteLine($"{porcentagem:P4}");


// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));



































// Pessoa p1 = new Pessoa(nome: "Guilherme", sobrenome: "Russo");

// Pessoa p2 = new Pessoa();
// p2.Nome = "João";
// p2.Sobrenome = "Silva";

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();
// int quantidadeDeAlunos = cursoDeIngles.QuantidadeAlunos();
// Console.WriteLine($"Quantidade de alunos: {quantidadeDeAlunos}");



























// Pessoa p1 = new Pessoa();
// p1.Nome = "Guilherme";
// p1.Sobrenome = "Russo";
// p1.Idade = 34;
// p1.Apresentar();