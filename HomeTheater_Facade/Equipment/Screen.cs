using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTheater_Facade.Equipment
{
    class Screen
    {
        public void On()
        { Console.WriteLine("Включение экрана"); }

        public void Drop()
        { Console.WriteLine("Экран опущен"); }

        public void Raise()
        { Console.WriteLine("Экран поднят"); }

        public void Off()
        { Console.WriteLine("Выключение экрана"); }
    }
}
