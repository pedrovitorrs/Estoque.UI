using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Extensions
{
    public static class DateTimeExtersions
    {
        public static DateTime SetYearBeforeDate(this DateTime dateTime, int anoAtual)
        {
            return dateTime.AddYears((DateTime.Now.Year - anoAtual) * -1);
        }
    }
}
