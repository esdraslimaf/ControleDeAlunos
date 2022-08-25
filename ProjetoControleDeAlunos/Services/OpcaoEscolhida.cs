using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoControleDeAlunos.Entities;

namespace ProjetoControleDeAlunos.Services
{
    internal class OpcaoEscolhida
    {
        public int Opcao { get; set; }


        public OpcaoEscolhida(int opcao)
        {
            Opcao = opcao;
        }


        public Aluno OpcaoEscolhidaAdicionarAluno()
        {

            Console.WriteLine("Insira primeiro o nome do aluno: ");
            string nomealuno = Console.ReadLine();

            Console.WriteLine("Quantas notas deseja inserir? 1, 2, 3 ou 4");
            int numerodenotas = int.Parse(Console.ReadLine());

            /* while(numerodenotas != 1 || numerodenotas != 2 || numerodenotas != 3 || numerodenotas != 4) {
                 Console.WriteLine("Quantas notas deseja inserir? 1, 2, 3 ou 4");
                 numerodenotas = int.Parse(Console.ReadLine());
                 } */
            if (numerodenotas == 1)
            {
                Console.WriteLine("Insira a nota 1: ");
                double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Clear();
                Console.WriteLine("Aluno adicionado");
                return new Aluno(nomealuno, nota1);
            }


            else if (numerodenotas == 2)
            {
                Console.WriteLine("Insira a nota 1: ");
                double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Insira a nota 2: ");
                double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Clear();
                Console.WriteLine("Aluno adicionado");
                return new Aluno(nomealuno, nota1, nota2);

            }
            else if (numerodenotas == 3)
            {
                Console.WriteLine("Insira a nota 1: ");
                double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Insira a nota 2: ");
                double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Insira a nota 3: ");
                double nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Clear();
                Console.WriteLine("Aluno adicionado");
                return new Aluno(nomealuno, nota1, nota2, nota3);
            }
            else if (numerodenotas == 4)
            {
                Console.WriteLine("Insira a nota 1: ");
                double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Insira a nota 2: ");
                double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Insira a nota 3: ");
                double nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Insira a nota 4: ");
                double nota4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Clear();
                Console.WriteLine("Aluno adicionado");
                return new Aluno(nomealuno, nota1, nota2, nota3, nota4);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Número inválido! ");
                return new Aluno("unknow", 1);
            }
        }

        public void RemoveAlunoUnknow(List<Aluno> lista) // vai ser após o usado no número inválido, pois acima vai ser gerado
        {                                              //um aluno de nome "unknow" e logo após irá ser removido utilizando esse
                                                       //método
            foreach (Aluno aluno in lista.ToList())
            {

                if (aluno.Nome == "unknow")
                {
                    lista.Remove(aluno);
                }

            }
        }

        public void imprimirlista(List<Aluno> lista)
        {
            Console.WriteLine();
            if (lista.Count == 0) Console.WriteLine("Ainda não foram adicionados alunos na lista!");
            else
            {


                foreach (Aluno aluno in lista)
                {
                    Console.WriteLine($"Aluno: {aluno.Nome}, 1º Nota: {aluno.Nota1}, 2º Nota: {aluno.Nota2}, 3º Nota: {aluno.Nota3}, 4º Nota: {aluno.Nota4}");
                }
            }
        }

        public void RetornaMedia(List<Aluno> lista)
        {
            Console.WriteLine("Por quanto deseja dividir as notas para fazer a média (1, 2, 3, ou 4)?");
            int numerodivisor = int.Parse(Console.ReadLine());

            foreach (Aluno aluno in lista)
            {
                double media = 0.0;
                media += aluno.Nota1 + aluno.Nota2 + aluno.Nota3 + aluno.Nota4;
                media = media / numerodivisor;
                Console.WriteLine($"Aluno: {aluno.Nome} - Notas: {aluno.Nota1}, {aluno.Nota2}, {aluno.Nota3}, {aluno.Nota4} - média feita por {numerodivisor} = {media.ToString("F2", CultureInfo.InvariantCulture)}");
            }

        }

        public void RemoveAluno(List<Aluno> listadealunos)
        {
            if (listadealunos.Count == 0)
            {
                Console.WriteLine("Não é possível excluir aluno.");
            }

            else
            {
                Console.WriteLine("Qual aluno deseja remover? ");
                string nomealuno = Console.ReadLine();

                foreach (Aluno aluno in listadealunos.ToList())
                {

                    if (aluno.Nome == nomealuno)
                    {
                        listadealunos.Remove(aluno);
                    }

                }
                Console.Clear();
                Console.WriteLine($"{nomealuno} foi removido.");

            }

        }

        public void EditarDadosAluno(List<Aluno> lista)
        {
            imprimirlista(lista);

            if (ChecaListaVazia(lista) == false)
            {
                Console.WriteLine();
                Console.WriteLine("Qual aluno deseja alterar os dados(Insira o nome)? ");
                string nome = Console.ReadLine();



                foreach (Aluno aluno in lista)
                {
                    if (aluno.Nome == nome)
                    {
                        Console.WriteLine($"Qual dado de {aluno.Nome} deseja alterar? Opções: (Nome, Nota1, Nota2, Nota3, Nota4)?");
                        string opcaoescolhidaalterar = Console.ReadLine();
                        if (opcaoescolhidaalterar == "Nome" || opcaoescolhidaalterar == "nome")
                        {
                            Console.Write($"Insira o novo nome do aluno {aluno.Nome}: ");
                            string novonome = Console.ReadLine();
                            aluno.Nome = novonome;
                            Console.WriteLine($"Nome alterado de {aluno.Nome} para {novonome}");
                        }
                        else if (opcaoescolhidaalterar == "Nota1" || opcaoescolhidaalterar == "nota1")
                        {
                            Console.Write($"Insira a nova Nota1 do aluno {aluno.Nome}: ");
                            double novanota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            double antiganota = aluno.Nota1;
                            aluno.Nota1 = novanota;
                            Console.WriteLine($"A 1º nota ({antiganota}) do aluno {aluno.Nome} foi alterada para {novanota}");
                        }
                        else if (opcaoescolhidaalterar == "Nota2" || opcaoescolhidaalterar == "nota2")
                        {
                            Console.Write($"Insira a nova Nota2 do aluno {aluno.Nome}: ");
                            double novanota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            double antiganota = aluno.Nota2;
                            aluno.Nota2 = novanota;
                            Console.WriteLine($"A 2º nota ({antiganota}) do aluno {aluno.Nome} foi alterada para {novanota}");
                        }
                        else if (opcaoescolhidaalterar == "Nota3" || opcaoescolhidaalterar == "nota3")
                        {
                            Console.Write($"Insira a nova Nota3 do aluno {aluno.Nome}: ");
                            double novanota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            double antiganota = aluno.Nota3;
                            aluno.Nota3 = novanota;
                            Console.WriteLine($"A 3º nota ({antiganota}) do aluno {aluno.Nome} foi alterada para {novanota}");
                        }
                        else if (opcaoescolhidaalterar == "Nota4" || opcaoescolhidaalterar == "nota4")
                        {
                            Console.Write($"Insira a nova Nota4 do aluno {aluno.Nome}: ");
                            double novanota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            double antiganota = aluno.Nota4;
                            aluno.Nota4 = novanota;
                            Console.WriteLine($"A 4º nota ({antiganota}) do aluno {aluno.Nome} foi alterada para {novanota}");
                        }
                        else { Console.WriteLine("Dado inválido"); }
                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Dados inválidos. Tente novamente.");
                    }
                }
            }
            else { Console.WriteLine("Dados inválidos. Tente novamente."); }
        }

        public bool ChecaListaVazia(List<Aluno> lista)
        {
            if (lista.Count == 0) return true;
            else return false;
        }



        public void SalvaArquivo(List<Aluno> lista, int num)
        {

            string path = @"C:\savingdocs";
            string newfile = path + $@"\saved{num}.txt";

            // if (!File.Exists(path))
            // {
            Directory.CreateDirectory(path);


            // Create a file to write to

            using (StreamWriter sw = File.CreateText(newfile))
            {
                foreach (Aluno aluno in lista)
                {
                    sw.WriteLine($"Aluno: {aluno.Nome}, 1º Nota: {aluno.Nota1}, 2º Nota: {aluno.Nota2}, 3º Nota: {aluno.Nota3}, 4º Nota: 5");
                }
                Console.WriteLine("Documento criado em: $" + newfile);

            }

            // }
            // else
            //{

            /* FileInfo fileInfo = new FileInfo(newfile);
            string[] lines = File.ReadAllLines(newfile);
            foreach (string line in lines)
            {
                string nome = line.Substring(7, 1); // Dps pegar o nome e jogar aqui
               lista.Add(new Aluno(nome, 1));
            } */

            //} 


        }


    }

}