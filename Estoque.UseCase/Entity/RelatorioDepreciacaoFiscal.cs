﻿using Estoque.DTO;
using Estoque.UseCase.EnumType;
using System;

namespace Estoque.UseCase.Entity
{
    public class RelatorioDepreciacaoFiscal : RelatorioTemplateMethod
    {
        protected override RelatorioDepreciacaoDTO GeraRelatorio(RelatorioDepreciacaoDTO relatorioDepreciacaoDTO)
        {
            relatorioDepreciacaoDTO.Nome = "RelatorioFiscal.rdlc";
            relatorioDepreciacaoDTO.Titulo = "Relatorio Depreciacao Fiscal";
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