using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelArea
{
    interface IForm
    {
        FormType Type { get; }
        // NOTE: GetResult получает площадь, логичнее назвать её GetArea. А лучше сделать свойство Area, с возможностью только получения
        // значения
        double GetResult();

        // NOTE: Можно еще сделать получение периметра
    }
}
