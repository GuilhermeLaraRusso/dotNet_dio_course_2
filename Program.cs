using ExemploExplorando.Models;


Pessoa p1 = new Pessoa(nome: "Guilherme", sobrenome: "Russo");

Pessoa p2 = new Pessoa();
p2.Nome = "João";
p2.Sobrenome = "Silva";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
int quantidadeDeAlunos = cursoDeIngles.QuantidadeAlunos();
Console.WriteLine($"Quantidade de alunos: {quantidadeDeAlunos}");



























// Pessoa p1 = new Pessoa();
// p1.Nome = "Guilherme";
// p1.Sobrenome = "Russo";
// p1.Idade = 34;
// p1.Apresentar();