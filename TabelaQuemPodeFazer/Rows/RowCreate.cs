using TabelaQuemPodeFazer.Menu;
using TabelaQuemPodeFazer.Table;

namespace TabelaQuemPodeFazer.Rows;

internal class RowCreate
{
    private TableList _repository;

    public RowCreate(TableList repository)
    {
        _repository = repository;
    }
    public void Executar()
    {
        MenuMain menu = new();

        Console.Clear();
        Console.WriteLine("\n >>  Digite '-1' para voltar ao Menu");
        Console.WriteLine("\n ==============================");
        Console.WriteLine(" ===  * Nova Solicitação *  ===");
        Console.WriteLine(" ==============================");
        Console.WriteLine("\n Preencha as informações a seguir:");

        Console.WriteLine("\n >>>");

        Console.Write("\n Digite o nome do COLABORADOR: ");
        string colaborador = Console.ReadLine();

        if (colaborador.Equals("-1"))
        {
            menu.BackMenu();
        }

        Console.Write("\n Digite o nome da AÇÃO: ");
        string acao = Console.ReadLine();

        if (acao.Equals("-1"))
        {
            menu.BackMenu();
        }

        Console.Write("\n Digite o nome do CARGO: ");
        string cargo = Console.ReadLine();

        if (cargo.Equals("-1"))
        {
            menu.BackMenu();
        }

        Console.Write("\n Digite o nome da FILIAL: ");
        string filial = Console.ReadLine();

        if (filial.Equals("-1"))
        {
            menu.BackMenu();
        }

        Console.Write("\n Digite o nome do DEPARTAMENTO: ");
        string departamento = Console.ReadLine();

        if (departamento.Equals("-1"))
        {
            menu.BackMenu();
        }

        Console.WriteLine("\n >>>");

        Row rows = new Row(colaborador, acao, cargo, filial, departamento);

        _repository.Table.Add(rows);

        Console.WriteLine("\n Sua solicitação foi criada com sucesso!!");

        Thread.Sleep(2000);
        menu.MenuShow();
    }
}
