using Estoque.Depreciacao.DTO;
using Estoque.Depreciacao.EnumType;
using System;

namespace Estoque.Depreciacao.UseCase
{
    public class RelatorioDepreciacaoFiscal : RelatorioTemplateMethod
    {
        protected override RelatorioDepreciacaoDTO GeraRelatorio(RelatorioDepreciacaoDTO relatorioDepreciacaoDTO)
        {
            relatorioDepreciacaoDTO.Nome = "RelatorioFiscal.rdlc";
            relatorioDepreciacaoDTO.Titulo = "Relatorio Depreciacao Fiscal";
            // relatorioDepreciacaoDTO.DadosRelatorio = CarregarRelatorio(relatorioDepreciacaoDTO.DataInicio, relatorioDepreciacaoDTO.DataFim);
            return relatorioDepreciacaoDTO;
        }

        protected override bool IsRelatorio(DepreciacaoEntity depreciacaoEntity)
        {
            return depreciacaoEntity.Type.Equals(DepreciacaoEnum.FISCAL);
        }

        protected override RelatorioDepreciacaoDTO SetProximoRelatorio(DepreciacaoEntity depreciacaoEntity, RelatorioDepreciacaoDTO relatorioDepreciacaoDTO)
        {
            return base.ProximoRelatorio.Gerar(depreciacaoEntity, relatorioDepreciacaoDTO);
        }
    }
}
