using Estoque.UseCase.EnumType;

namespace Estoque.UseCase.Entity
{
    public class DepreciacaoEntity
    {
        public DepreciacaoEnum Type { get; private set; }
        public string Caption { get; private set; }

        public DepreciacaoEntity(DepreciacaoEnum type, string caption)
        {
            Type = type;
            Caption = caption;
        }

        public override string ToString()
        {
            return Caption;
        }
    }
}
