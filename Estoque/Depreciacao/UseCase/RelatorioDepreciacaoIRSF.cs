using Estoque.Depreciacao.DTO;
using Estoque.Depreciacao.EnumType;

namespace Estoque.Depreciacao.UseCase
{
    public class RelatorioDepreciacaoIRSF : RelatorioTemplateMethod
    {
        protected override RelatorioDepreciacaoDTO GeraRelatorio(RelatorioDepreciacaoDTO relatorioDepreciacaoDTO)
        {
            relatorioDepreciacaoDTO.Nome = "RelatorioIRSF.rdlc";
            relatorioDepreciacaoDTO.Titulo = "Relatorio Depreciacao IRSF";
            // relatorioDepreciacaoDTO.DadosRelatorio = CarregarRelatorio(relatorioDepreciacaoDTO.DataInicio, relatorioDepreciacaoDTO.DataFim);
            return relatorioDepreciacaoDTO;
        }

        protected override bool IsRelatorio(DepreciacaoEntity depreciacaoEntity)
        {
            return depreciacaoEntity.Type.Equals(DepreciacaoEnum.IRSF);
        }

        protected override RelatorioDepreciacaoDTO SetProximoRelatorio(DepreciacaoEntity depreciacaoEntity, RelatorioDepreciacaoDTO relatorioDepreciacaoDTO)
        {
            return base.ProximoRelatorio.Gerar(depreciacaoEntity, relatorioDepreciacaoDTO);
        }
    }
}
