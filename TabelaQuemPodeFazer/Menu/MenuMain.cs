using TabelaQuemPodeFazer.Rows;
using TabelaQuemPodeFazer.Table;

namespace TabelaQuemPodeFazer.Menu;

internal class MenuMain
{
    static TableList repository = new();
    public void MenuShow()
    {

        Console.Clear();
        Console.WriteLine(" =================================");
        Console.WriteLine(" ====                         ====");
        Console.WriteLine(" ==  * Ação: Quem pode fazer? * ==");
        Console.WriteLine(" ===                           ===");
        Console.WriteLine(" ===    (1) Nova Solicitação   ===");
        Console.WriteLine(" ====                         ====");
        Console.WriteLine(" ===   (2) Editar Colaborador  ===");
        Console.WriteLine(" ===  (3) Excluir Colaborador  ===");
        Console.WriteLine(" ====                         ====");
        Console.WriteLine(" ===     (4) Exibir Tabela     ===");
        Console.WriteLine(" ===   (-1) Sair do programa   ===");
        Console.WriteLine(" ====                         ====");
        Console.WriteLine(" =================================");

        Console.Write("\n\n Digite sua opção: ");

        switch (Console.ReadLine())
        {
            case "1":
                new RowCreate(repository).Executar();
                break;

            case "2":
                new RowEdit(repository).Executar();  
                break;

            case "3":
                new RowDelete(repository).Executar();   
                break;

            case "4":
                new TableShow(repository).Executar();
                break;

            case "-1":
                Console.WriteLine("\n .... Valeu!! ....");
                break;

            default:
                Console.WriteLine("\n .... Opção Inválida! Digite novamente! ....");
                Thread.Sleep(2000);
                MenuShow();
                break;
        }
    }

    public void BackMenu()
    {
        Console.Clear();
        Console.Write("\n\n  Carregando Menu...");

        Thread.Sleep(2000);
        MenuShow();
    }
}
