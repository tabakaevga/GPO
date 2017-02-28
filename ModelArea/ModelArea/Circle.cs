using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelArea
{
    class Circle : IForm
    {
        //NOTE: Ты устанавливаешь радиус только в конструкторе, а если нужно будет задать радиус отдельно ? 
        private double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException($"Радиус круга не может быть меньше либо равен нулю.");
            }
            else
            {
                _radius = radius;
            }
           
        }
        // NOTE: Есть стандартный метод GetType почему бы не сделать через него
        public FormType Type => FormType.Circle;
        
        //TODO: Обычно GetResult получает какой либо результат, метод возвращает площадь, логичнее назвать его Area и сделать свойством-геттером
        public double GetResult()
        {
            return 3.14 * Math.Pow(_radius, 2);
        }
    }
}
