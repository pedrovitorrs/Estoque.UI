using Estoque.Depreciacao.DTO;
using Estoque.Depreciacao.EnumType;

namespace Estoque.Depreciacao.UseCase
{
    public class RelatorioDepreciacaoGerencial : RelatorioTemplateMethod
    {
        protected override RelatorioDepreciacaoDTO GeraRelatorio(RelatorioDepreciacaoDTO relatorioDepreciacaoDTO)
        {
            relatorioDepreciacaoDTO.Nome = "RelatorioGerencial.rdlc";
            relatorioDepreciacaoDTO.Titulo = "Relatorio Depreciacao Gerencial";
            // relatorioDepreciacaoDTO.DadosRelatorio = CarregarRelatorio(relatorioDepreciacaoDTO.DataInicio, relatorioDepreciacaoDTO.DataFim);
            return relatorioDepreciacaoDTO;
        }

        protected override bool IsRelatorio(DepreciacaoEntity depreciacaoEntity)
        {
            return depreciacaoEntity.Type.Equals(DepreciacaoEnum.GERENCIAL);
        }

        protected override RelatorioDepreciacaoDTO SetProximoRelatorio(DepreciacaoEntity depreciacaoEntity, RelatorioDepreciacaoDTO relatorioDepreciacaoDTO)
        {
            return base.ProximoRelatorio.Gerar(depreciacaoEntity, relatorioDepreciacaoDTO);
        }
    }
}
