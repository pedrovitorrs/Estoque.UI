using System;
using System.Data;

namespace Estoque.Depreciacao.DTO
{
    public class RelatorioDepreciacaoDTO
    {
        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }
        public string Titulo { get; set; }
        public string Nome { get; set; }
        public DataTable DadosRelatorio { get; set; }

        public RelatorioDepreciacaoDTO(DateTime dataInicio, DateTime dataFim)
        {
            DataInicio = dataInicio;
            DataFim = dataFim;
        }
    }
}
