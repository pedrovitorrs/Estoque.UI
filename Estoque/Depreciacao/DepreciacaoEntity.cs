using Estoque.Depreciacao.EnumType;
using Estoque.Extensions;

namespace Estoque.Depreciacao
{
    public class DepreciacaoEntity
    {
        public DepreciacaoEnum Type { get; private set; }

        public DepreciacaoEntity(DepreciacaoEnum type)
        {
            Type = type;
        }

        public override string ToString()
        {
            return Type.GetDisplayValue();
        }
    }
}
