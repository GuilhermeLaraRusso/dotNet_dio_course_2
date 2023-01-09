using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int QuantidadeAlunos()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");
            for (int index = 0; index < Alunos.Count; index++)
            {
                // string texto = "N° " + (index + 1) + " - " + Alunos[index].NomeCompleto;
                string texto = $"N° {index + 1} - {Alunos[index].NomeCompleto}";
                Console.WriteLine(texto);
                
            }

        }
    }
}