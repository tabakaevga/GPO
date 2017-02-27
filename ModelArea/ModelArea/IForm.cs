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
        double GetResult();
    }
}
