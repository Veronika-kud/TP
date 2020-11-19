using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR8
{
    class Истребитель : Авиасредство
    {
        public Истребитель(string Н, string С, int Э, Принадлежности ПР, Категории К, ПодъемныеСилы ПС, ТипыИстрибителей ТИ)
            : base(Н, С, Э, ПР, К, ПС)
        {
            ТипИстрибителя = ТИ;
        }


        public ТипыИстрибителей ТипИстрибителя;


        public override string Характеристика
        {
            get
            {
                return base.Характеристика + "\n"
                    + "ТипИстрибителя: " + ТипИстрибителя.ToString();
            }
        }
    }
}
