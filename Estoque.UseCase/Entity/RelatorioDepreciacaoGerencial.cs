using Estoque.DTO;
using Estoque.UseCase.EnumType;
using System;

namespace Estoque.UseCase.Entity
{
    public class RelatorioDepreciacaoGerencial : RelatorioTemplateMethod
    {
        protected override RelatorioDepreciacaoDTO GeraRelatorio(RelatorioDepreciacaoDTO relatorioDepreciacaoDTO)
        {
            relatorioDepreciacaoDTO.Nome = "RelatorioGerencial.rdlc";
            relatorioDepreciacaoDTO.Titulo = "Relatorio Depreciacao Gerencial";
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
