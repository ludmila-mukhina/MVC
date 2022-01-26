using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp6
{
    public static class Model
    {// блок с данными
        static int count = 0;
        public static List<string> datalist = new List<string> { "Иванов", "Петров", "Сидоров" };
        
        // блок для обращения к текстовым полям
        public static TextBlock tb;
        public static TextBlock tbCombo;
        
        // блок с бизнес-логикой
        public static int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
                tb.Text = count.ToString();
            }
        }
        public static int Combo
        {
            set
            {
                tbCombo.Text = datalist[value];
            }
        }
    }
}
