using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR8
{
    class Машины
    {
        public Машины(string Н, string С, int Э)
        {
            Название = Н; Страна = С; СрокЭксплуатации = Э;
        }

        public Машины()
        {
            Название = " "; Страна = " ";
            СрокЭксплуатации = 6;
        }

        public string Название, Страна;
        private DateTime ДатаПроизводства;

        public virtual string Характеристика
        {
            get { return Страна + ", " + Название; }
        }

        public int СрокЭксплуатации
        {
            get { return DateTime.Now.Year - ДатаПроизводства.Year; }
            set
            {
                int ГодСоздания = DateTime.Now.Year - value;

                ДатаПроизводства = Convert.ToDateTime(ГодСоздания.ToString() + ".01.01");
            }
        }
    }

}
