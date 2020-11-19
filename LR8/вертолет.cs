using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR8
{
    class Вертолет : Авиасредство
    {
        public Вертолет(string Н, string С, int Э, Принадлежности ПР, Категории К, ПодъемныеСилы ПС, ТипыВертолетов ТВ)
            : base(Н, С, Э, ПР, К, ПС)
        {
            ТипВертолета = ТВ;
        }


        public ТипыВертолетов ТипВертолета;


        public override string Характеристика
        {
            get
            {
                return base.Характеристика + "\n"
                    + "ТипВертолета: " + ТипВертолета.ToString();
            }
        }
    }
}
