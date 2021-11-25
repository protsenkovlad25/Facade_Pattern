using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTheater_Facade.Equipment
{
    class Projector
    {
        public void On()
        { Console.WriteLine("Включение проектора"); }

        public void Off()
        { Console.WriteLine("Выключение проектора"); }

        public void Сontact(string contact)
        { Console.WriteLine($"Связь проектора c {contact}"); }

        public void FullScreenOn()
        { Console.WriteLine("Полноэкранный режим вкл"); }

        public void FullScreenOff()
        { Console.WriteLine("Полноэкранный режим выкл"); }
    }
}
