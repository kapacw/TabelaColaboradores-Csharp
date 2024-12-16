using TabelaQuemPodeFazer.Menu;
using TabelaQuemPodeFazer.Table;

namespace TabelaQuemPodeFazer.Rows;

internal class RowEdit
{
    private TableList _repository;

    public RowEdit(TableList repository)
    {
        _repository = repository;
    }
    public void Executar()
    {
        MenuMain menu = new();

        Console.Clear();
        Console.WriteLine("\n >>  Digite '-1' para voltar ao Menu");
        Console.WriteLine("\n ================================");
        Console.WriteLine(" ===  * Editar Colaborador *  ===");
        Console.WriteLine(" ================================");

        if (_repository.Table.Count == 0)
        {
            Console.WriteLine("\n    .... Nem um Colaborador registrado! ....");

            Thread.Sleep(2000);
            menu.MenuShow();
        }
        else
        {
            Console.Write("\n Digite o nome do Colaborador que deseja alterar uma informação: ");

            string name = Console.ReadLine();
            var colaborador = _repository.Table.Find(c => c.Colaborador == name);

            if (name.Equals("-1"))
            {
                menu.BackMenu();
            }

            if (colaborador != null)
            {
                titleEdit();
                void titleEdit()
                {
                    Console.Clear();
                    Console.WriteLine("\n ==========================================");
                    Console.WriteLine(" ===              * Edição *            ===");
                    Console.WriteLine(" ==========================================");

                    Console.WriteLine($"\n >>>     | {name} |    <<<");

                    Console.WriteLine("\n Preencha as informações a seguir:");
                }

                if (colaborador != null)
                {
                    ifAcao();
                    void ifAcao()
                    {
                        Console.WriteLine("\n == AÇÃO ==");
                        Console.Write(" Deseja alterar a AÇÃO? (s/n): ");
                        var answer = Console.ReadLine();

                        if (answer.Equals("s"))
                        {
                            Console.WriteLine($"\n Atual: | {colaborador.Acao} |");
                            Console.Write(" Novo: ");
                            colaborador.Acao = Console.ReadLine();

                            ifCargo();
                        }
                        else if (answer.Equals("n"))
                        {
                            ifCargo();
                        }
                        else
                        {
                            Console.WriteLine("\n .... Opção Inválida! Digite novamente! ....");

                            Thread.Sleep(2000);
                            Console.Clear();
                            titleEdit();
                            ifAcao();
                        }
                    }
                }
                else
                {
                    Console.WriteLine(" .... Colaborador não encontrado! ....");

                    Thread.Sleep(2000);
                    Executar();
                }

                void ifCargo()
                {
                    Console.WriteLine("\n == CARGO ==");
                    Console.Write(" Deseja alterar o CARGO? (s/n): ");
                    var answer = Console.ReadLine();

                    if (answer.Equals("s"))
                    {
                        Console.WriteLine($"\n Atual: | {colaborador.Cargo} |");
                        Console.Write(" Novo: ");
                        colaborador.Cargo = Console.ReadLine();

                        ifFilial();
                    }
                    else if (answer.Equals("n"))
                    {
                        ifFilial();
                    }
                    else
                    {
                        Console.WriteLine("\n .... Opção Inválida! Digite novamente! ....");

                        Thread.Sleep(2000);
                        Console.Clear();
                        titleEdit();
                        ifCargo();
                    }
                }

                void ifFilial()
                {
                    Console.WriteLine("\n == FILIAL ==");
                    Console.Write(" Deseja alterar a FILIAL? (s/n): ");
                    var answer = Console.ReadLine();

                    if (answer.Equals("s"))
                    {
                        Console.WriteLine($"\n Atual: | {colaborador.Filial} |");
                        Console.Write(" Novo: ");
                        colaborador.Filial = Console.ReadLine();

                        ifDepartamento();
                    }
                    else if (answer.Equals("n"))
                    {
                        ifDepartamento();
                    }
                    else
                    {
                        Console.WriteLine("\n .... Opção Inválida! Digite novamente! ....");

                        Thread.Sleep(2000);
                        Console.Clear();
                        titleEdit();
                        ifFilial();
                    }
                }

                void ifDepartamento()
                {
                    Console.WriteLine("\n == DEPARTAMENTO ==");
                    Console.Write(" Deseja alterar o DEPARTAMENTO? (s/n): ");
                    var answer = Console.ReadLine();

                    if (answer.Equals("s"))
                    {
                        Console.WriteLine($"\n Atual: | {colaborador.Departamento} |");
                        Console.Write(" Novo: ");
                        colaborador.Departamento = Console.ReadLine();

                        Console.WriteLine("\n .... Informações atualizadas com sucesso! ....");
                        Thread.Sleep(2000);
                        menu.MenuShow();
                    }
                    else if (answer.Equals("n"))
                    {
                        Console.WriteLine("\n .... Informações atualizadas com sucesso! ....");
                        Thread.Sleep(2000);
                        menu.MenuShow();
                    }
                    else
                    {
                        Console.WriteLine("\n .... Opção Inválida! Digite novamente! ....");

                        Thread.Sleep(2000);
                        Console.Clear();
                        titleEdit();
                        ifDepartamento();
                    }
                }
            }
            else
            {
                Console.WriteLine("\n .... Colaborador não encontrado! ....");

                Thread.Sleep(2000);
                Executar();
            }
        }
    }
}
