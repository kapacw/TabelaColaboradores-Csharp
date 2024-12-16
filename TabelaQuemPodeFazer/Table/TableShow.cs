using TabelaQuemPodeFazer.Menu;
using TabelaQuemPodeFazer.Rows;

namespace TabelaQuemPodeFazer.Table;

internal class TableShow
{
    private TableList _repository;

    public TableShow(TableList repository)
    {
        _repository = repository;
    }
    public void Executar()
    {
        MenuMain menu = new();

        Console.Clear();
        Console.WriteLine(" =============================================");
        Console.WriteLine(" =======           * TABELA *          =======");
        Console.WriteLine(" =============================================");

        if (_repository.Table.Count == 0)
        {
            Console.WriteLine("\n    .... Nem um Colaborador registrado! ....");

            Thread.Sleep(2000);
            menu.MenuShow();
        }
        else
        {
            Console.WriteLine("\n ***");

            foreach (var rows in _repository.Table)
            {
                Console.WriteLine($"\n COLABORADOR: {rows.Colaborador}");
                Console.WriteLine($"\n AÇÃO: {rows.Acao}");
                Console.WriteLine($" CARGO: {rows.Cargo}");
                Console.WriteLine($" FILIAL: {rows.Filial}");
                Console.WriteLine($" DEPARTAMENTO: {rows.Departamento}");
                Console.WriteLine("\n ***");
            }
        }

        Console.WriteLine("\n Digite '0' para sair do Programa");
        Console.WriteLine(" Digite '1' para voltar ao Menu\n");

        switch (Console.ReadLine())
        {
            case "0":
                Console.WriteLine("\n .... Valeu! ....");
                break;

            case "1":
                menu.MenuShow();
                break;

            default:
                Console.WriteLine("\n .... Opção Inválida! Digite novamente! ....");
                Thread.Sleep(2000);
                Executar();
                break;
        }
    }
}
