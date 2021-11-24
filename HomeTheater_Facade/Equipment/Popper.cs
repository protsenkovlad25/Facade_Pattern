using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTheater_Facade.Equipment
{
    class Popper
    {
        public void On()
        { Console.WriteLine("Включение аппарата попкорна"); }

        public void Cook()
        { Console.WriteLine("Приготовление попкорна"); }

        public void Off()
        { Console.WriteLine("Выключение аппарата попкорна"); }
    }
}
