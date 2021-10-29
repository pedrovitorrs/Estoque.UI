
using Estoque.Depreciacao.DTO;

namespace Estoque.Depreciacao
{
    public interface IRelatorio
    {
        IRelatorio ProximoRelatorio { get; set; }
        RelatorioDepreciacaoDTO Gerar(DepreciacaoEntity depreciacaoEntity, RelatorioDepreciacaoDTO relatorioDepreciacaoDTO);
    }
}
