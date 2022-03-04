namespace ExemploConstrutores.Models
{
    public class Aluno : Pessoa
    {
        private string disciplina;
        public Aluno(string nome, string sobrenome, string disciplina) : base(nome, sobrenome)
        {
            this.disciplina = disciplina;
            Console.WriteLine("Construtor classe Aluno");
        }
    }
}