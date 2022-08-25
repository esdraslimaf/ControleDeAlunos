using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoControleDeAlunos.Entities
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Nota4 { get; set; }
        public double Media { get; set; }

        public Aluno(string nome, double nota1, double media)
        {
            Nome = nome;
            Nota1 = nota1;
            Media = media;
        }

        public Aluno(string nome, double nota1, double nota2, double media) : this(nome, nota1, media)
        {
            this.Nota2 = nota2;
        }

        public Aluno(string nome, double nota1, double nota2, double nota3, double media) : this(nome, nota1, nota2, media)
        {
            this.Nota3 = nota3;
        }
        public Aluno(string nome, double nota1, double nota2, double nota3, double nota4, double media) : this(nome, nota1, nota2, nota3, media)
        {
            this.Nota4 = nota4;
        }

        public Aluno(double media)
        {
            this.Media = media;
        }
       
        
    }
}
