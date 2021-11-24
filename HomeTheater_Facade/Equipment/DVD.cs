using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTheater_Facade.Equipment
{
    class DVD
    {
        public void On()
        { Console.WriteLine("Включение DVD-проигрывателя"); }

        public void Off()
        { Console.WriteLine("Выключение DVD-проигрывателя"); }

        public void Play()
        { Console.WriteLine("Воспроизведение"); }
    }
}
