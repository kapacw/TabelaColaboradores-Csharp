
namespace TabelaQuemPodeFazer.Rows
{
    internal class Row
    {

        public string Colaborador { get; set; }
        public string Acao { get; set; }
        public string Cargo { get; set; }
        public string Filial { get; set; }
        public string Departamento { get; set; }

        public Row(string colaborador, string acao, string cargo, string filial, string departamento)
        {
            Colaborador = colaborador;
            Acao = acao;    
            Cargo = cargo;
            Filial = filial;
            Departamento = departamento;
        }
    }
}
