using System;
using System.Windows.Forms;
using Estoque;
using Estoque.Depreciacao;
using Estoque.Depreciacao.DTO;
using Estoque.Depreciacao.EnumType;
using Estoque.Extensions;

namespace Estoque.UI
{
    public partial class Form1 : Form
    {
        #region Constructor

        public Form1()
        {
            InitializeComponent();
            PreencheCmbBoxTipoDepreciacao();
            PreencheCmbBoxAno();
        }

        #endregion

        #region Metodos do Forms

        private void BtnVisualizar_Click(object sender, EventArgs e)
        {
            DateTime DataInicioAnual, DataFimAnual;
            int Ano = int.Parse(cmbAno.Text.ToString());

            // Se nenhum item foi selecionado
            if (cmbAno.SelectedIndex.Equals(-1) || cmbDepreciacao.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Selecione os itens corretamente");
                return;
            }

            DataInicioAnual = DateTime.Now.AddDays((DateTime.Now.DayOfYear - 1) * -1).SetYearBeforeDate(Ano);
            DataFimAnual = DateTime.Now.AddDays((365 - DateTime.Now.DayOfYear)).SetYearBeforeDate(Ano);

            GeradorRelatorio geradorRelatorio = new GeradorRelatorio(
                cmbDepreciacao.SelectedItem as DepreciacaoEntity,
                new RelatorioDepreciacaoDTO(
                    dataInicio: DataInicioAnual,
                    dataFim: DataFimAnual
                    )
                );

        }

        #endregion

        #region Metodos de Carregamento

        public object[] GetNumberNameRange()
        {
            return new object[]
            {
                new DepreciacaoEntity(DepreciacaoEnum.FISCAL),
                new DepreciacaoEntity(DepreciacaoEnum.GERENCIAL),
                new DepreciacaoEntity(DepreciacaoEnum.IRSF)
            };
        }

        private void PreencheCmbBoxTipoDepreciacao()
        {
            cmbDepreciacao.Items.AddRange(GetNumberNameRange());
        }

        private void PreencheCmbBoxAno()
        {
            for (int i = DateTime.Now.Year; i >= 2015; i--)
                cmbAno.Items.Add(i);
        }

        #endregion
    }
}
