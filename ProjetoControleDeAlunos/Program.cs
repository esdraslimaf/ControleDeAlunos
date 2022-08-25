using ProjetoControleDeAlunos.Entities;
using ProjetoControleDeAlunos.Services;
using System.Globalization;

namespace ProjetoControleDeAlunos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Aluno> lista = new List<Aluno>();
            bool programaaberto = true;
            int num = 0;
            while (programaaberto)
            {

                Console.WriteLine("Olá, sinta-se livre para utilizar o controle de alunos como preferir!!");
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Adicionar aluno.");
                Console.WriteLine("2 - Ver lista de alunos adicionados.");
                Console.WriteLine("3 - Fazer/ver média dos alunos. ");
                Console.WriteLine("4 - Excluir aluno da lista.");
                Console.WriteLine("5 - Editar dados de alunos.");       
                Console.WriteLine("6 - Salvar");
                Console.WriteLine("7 - Fechar programa. ");
                Console.WriteLine();

                int opcao = int.Parse(Console.ReadLine());
                OpcaoEscolhida Opcao = new OpcaoEscolhida(opcao);

               

                switch (opcao)
                {
                   
                    case 1:
                        try
                        {
                            lista.Add(Opcao.OpcaoEscolhidaAdicionarAluno());
                            Opcao.RemoveAlunoUnknow(lista);
                        }

                        catch (Exception e)
                        {
                           
                            Console.WriteLine("Você cometeu um erro ao insirir os dados. Tente novamente, mas da maneira correta!.");
                            Console.WriteLine("Erro: " + e.Message);

                            Console.WriteLine("Preste atenção, insira valores corretos!!");
                            lista.Add(Opcao.OpcaoEscolhidaAdicionarAluno());
                            Console.Clear();
                            Console.WriteLine("Aluno adicionado.");
                            

                        }

                        break;


                    case 2:

                        Console.Clear();
                        Opcao.imprimirlista(lista);
                        break;


                    case 3: Console.Clear();
                        Opcao.RetornaMedia(lista);
                        break;

                    case 4: Console.Clear();
                        Opcao.imprimirlista(lista);
                        Opcao.RemoveAluno(lista);
                        break;

                    case 5: Console.Clear();
                        Opcao.EditarDadosAluno(lista);
                        break;

                    case 6:
                      
                        Console.Clear();
                        Opcao.SalvaArquivo(lista, num++);
                        break;

                    case 7:

                        Console.Clear();
                        Console.WriteLine("Obrigado pela experiência!");
                        programaaberto = false;
                        break;

                }
                Console.WriteLine();




            }




        }
    }
}
