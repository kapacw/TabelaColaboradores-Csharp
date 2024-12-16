using TabelaQuemPodeFazer.Menu;
using TabelaQuemPodeFazer.Table;

namespace TabelaQuemPodeFazer.Rows;

internal class RowDelete
{
    private TableList _repository;

    public RowDelete(TableList repository)
    {
        _repository = repository;
    }

    public void Executar()
    {
        MenuMain menu = new();

        Console.Clear();
        Console.WriteLine("\n >>  Digite '-1' para voltar ao Menu");
        Console.WriteLine("\n =================================");
        Console.WriteLine(" ===  * Excluir Colaborador *  ===");
        Console.WriteLine(" =================================");


        if (_repository.Table.Count == 0)
        {
            Console.WriteLine("\n    .... Nem um Colaborador registrado! ....");

            Thread.Sleep(2000);
            menu.MenuShow();
        }
        else
        {

            Console.Write("\n Digite o nome do Colaborador que deseja excluir: ");

            string name = Console.ReadLine();
            var colaborador = _repository.Table.Find(c => c.Colaborador == name);

            if (name.Equals("-1"))
            {
                menu.BackMenu();
            }

            if (colaborador != null)
            {
                _repository.Table.Remove(colaborador);
                Console.WriteLine("\n .... Colaborador excluído com sucesso! ....");

                Thread.Sleep(2000);
                menu.MenuShow();
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
