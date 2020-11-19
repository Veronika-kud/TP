using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR8
{
    class Авиасредство : Машины
    {
        public Авиасредство(string Н, string С, int Э, Принадлежности ПР, Категории К, ПодъемныеСилы ПС)
            : base(Н, С, Э)
        {
            Принадлежность = ПР;
            Категория = К;
            ПодъемнаяСила = ПС;
        }


        public Принадлежности Принадлежность;
        public Категории Категория;
        public ПодъемныеСилы ПодъемнаяСила;


        public override string Характеристика
        {
            get
            {
                return base.Характеристика + ", " + Принадлежность.ToString() + ", " + "\n"
                    + "Категория: " + Категория.ToString() + ", " + "ПодъемнаяСила: " + ПодъемнаяСила.ToString();
            }
        }
    }
}

