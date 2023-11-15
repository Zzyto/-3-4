using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_3_и_4.Dictionary
{
    internal static class DictionaryExtender
    {
        // Получение в строковом виде перечисления вида [переменная] = [значение переменной]
        public static string ToLineString<T, V>(this Dictionary<T, V> dict)
        {
            var str = "";
            foreach (var i in dict)
                str += $"{i.Key} = {i.Value}, ";
            return str.Substring(0, str.Length - 2);
        }
    }
}
