using Estoque.Depreciacao.DTO;
using Estoque.Depreciacao.UseCase;

namespace Estoque.Depreciacao
{
    public class GeradorRelatorio
    {
        private readonly DepreciacaoEntity DepreciacaoEntity;
        private readonly RelatorioDepreciacaoDTO RelatorioDepreciacaoDTO;

        public GeradorRelatorio(DepreciacaoEntity depreciacaoEntity, RelatorioDepreciacaoDTO relatorioDepreciacaoDTO)
        {
            DepreciacaoEntity = depreciacaoEntity;
            RelatorioDepreciacaoDTO = relatorioDepreciacaoDTO;
        }

        public void Gera()
        {
            IRelatorio relatorioDepreciacaoFiscal = new RelatorioDepreciacaoFiscal();
            IRelatorio relatorioDepreciacaoGerencial = new RelatorioDepreciacaoGerencial();
            IRelatorio relatorioDepreciacaoIRSF = new RelatorioDepreciacaoIRSF();

            relatorioDepreciacaoFiscal.ProximoRelatorio = relatorioDepreciacaoGerencial;
            relatorioDepreciacaoGerencial.ProximoRelatorio = relatorioDepreciacaoIRSF;

            relatorioDepreciacaoFiscal.Gerar(DepreciacaoEntity, RelatorioDepreciacaoDTO);
        }
    }
}
