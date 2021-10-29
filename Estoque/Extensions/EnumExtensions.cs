using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Estoque.Extensions
{
    public static class EnumExtensions
    {
        /// <summary>
        /// Otém o valor do enum a ser exibido.
        /// </summary>
        /// <param name="value">valor do enum para exibição.</param>
        /// <returns>valor para exibição.</returns>
        public static string GetDisplayValue(this Enum value)
        {
            try
            {
                var fieldInfo = value.GetType().GetField(value.ToString());
                var descriptionAttributes = fieldInfo.GetCustomAttributes(typeof(DisplayAttribute), false) as DisplayAttribute[];

                if (descriptionAttributes == null || descriptionAttributes.Length == 0)
                    return value.ToString();

                return descriptionAttributes[0].Name;
            }
            catch
            {
                return value.ToString();
            }
        }
    }
}
