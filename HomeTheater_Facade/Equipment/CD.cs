using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTheater_Facade.Equipment
{
    class CD
    {
        public void On()
        { Console.WriteLine("Включение CD-проигрывателя"); }

        public void Off()
        { Console.WriteLine("Выключение CD-проигрывателя"); }

        public void Play()
        { Console.WriteLine("Воспроизведение"); }
    }
}
