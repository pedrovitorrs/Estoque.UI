using Estoque.Depreciacao.DTO;

namespace Estoque.Depreciacao
{
    public abstract class RelatorioTemplateMethod : IRelatorio
    {
        public IRelatorio ProximoRelatorio { get; set; }

        public RelatorioDepreciacaoDTO Gerar(DepreciacaoEntity depreciacaoEntity, RelatorioDepreciacaoDTO relatorioDepreciacaoDTO)
        {
            return IsRelatorio(depreciacaoEntity) ? GeraRelatorio(relatorioDepreciacaoDTO) : SetProximoRelatorio(depreciacaoEntity, relatorioDepreciacaoDTO);
        }

        protected abstract RelatorioDepreciacaoDTO GeraRelatorio(RelatorioDepreciacaoDTO relatorioDepreciacaoDTO);
        protected abstract bool IsRelatorio(DepreciacaoEntity depreciacaoEntity);
        protected abstract RelatorioDepreciacaoDTO SetProximoRelatorio(DepreciacaoEntity depreciacaoEntity, RelatorioDepreciacaoDTO relatorioDepreciacaoDTO);
    }
}
