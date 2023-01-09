using ExemploExplorando.Models;
using System.Globalization;

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("MG", "Minas Gerais");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("ES", "Espírito Santo");

foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Sigla: {item.Key} - Estado: {item.Value}");
}

estados.Remove("ES");

estados["SP"] = "São Paulo - SP";

foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Sigla: {item.Key} - Estado: {item.Value}");
}

string chave = "BA";

Console.WriteLine($"Verificando o elemento: {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else
{
    Console.WriteLine($"Valor não existente: {chave}");
}




































// Stack<int> pilha = new Stack<int>();

// pilha.Push(2);
// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
// pilha.Push(10);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }




































// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }





































// ExemploExcecao exemplo = new ExemploExcecao();
// exemplo.Metodo1();








































// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }

// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Diretório não encontrado. {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally // Executado sempre, independente de ter ocorrido uma exceção ou não
// {
//     Console.WriteLine("Fim do programa");
// }














































// DateTime data = DateTime.Now;

// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToShortTimeString());

// DateTime data2 = DateTime.Parse("17/04/2022 18:00");
// Console.WriteLine(data2);

// string dataString = "2022-14-17 18:00";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataConvertida);

// if (sucesso)
// {
//   Console.WriteLine($"Conversão com sucesso: {dataConvertida}");
// }
// else
// {
//   Console.WriteLine($"{dataString} não é uma data válida");
// }








































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