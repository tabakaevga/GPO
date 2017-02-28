using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelArea
{
    interface IForm
    {
        FormType GetType { get; }
        double GetArea { get; }
        double GetLength { get; }

        // NOTE: Можно еще сделать получение периметра
    }
}
