using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoal.Utils
{
    
    public enum Month
    {
        [Description("Jan")]
        Janeiro,
        [Description("Fev")]
        Fevereiro,
        [Description("Mar")]
        Março,
        [Description("Abr")]
        Abril,
        [Description("Mai")]
        Maio,
        [Description("Jun")]
        Junho,
        [Description("Jul")]
        Julho,
        [Description("Ago")]
        Agosto,
        [Description("Set")]
        Set,
        [Description("Out")]
        Outubro,
        [Description("Nov")]
        Novembro,
        [Description("Dez")]
        Dezembro
    }

    public static class MonthClass
    {

        public static int MonthSize = 12;

        public static List<string> GetAllMonth()
        {
            List<string> months = new List<string>();

            foreach(Month m in Enum.GetValues(typeof(Month)))
            {
                string monthDescription = DescriptionAttr(m);
                months.Add(monthDescription.ToLower());
            }
            return months;
        }

        public static string DescriptionAttr<T>(this T source)
        {
            FieldInfo fi = source.GetType().GetField(source.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0) return attributes[0].Description;
            else return source.ToString();
        }
    }

    
}
