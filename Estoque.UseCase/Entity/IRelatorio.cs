
using Estoque.DTO;

namespace Estoque.UseCase.Entity
{
    public interface IRelatorio
    {
        IRelatorio ProximoRelatorio { get; set; }
        RelatorioDepreciacaoDTO Gerar(DepreciacaoEntity depreciacaoEntity, RelatorioDepreciacaoDTO relatorioDepreciacaoDTO);
    }
}
