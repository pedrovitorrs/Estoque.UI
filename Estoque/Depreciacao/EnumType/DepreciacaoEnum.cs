using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Depreciacao.EnumType
{
    public enum DepreciacaoEnum
    {
        [Display(Name = "Depreciação Fiscal")]
        FISCAL,
        [Display(Name = "Depreciação Gerencial")]
        GERENCIAL,
        [Display(Name = "Depreciação (IFRS/SIF)")]
        IRSF
    }
}

