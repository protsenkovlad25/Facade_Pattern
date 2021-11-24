using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTheater_Facade.Equipment
{
    class Tuner
    {
        public void On()
        { Console.WriteLine("Включение радио"); }

        public void Off()
        { Console.WriteLine("Выключение радио"); }

        public void Wave(int wave)
        { Console.WriteLine($"Установлена волна: {wave}"); }
    }
}
