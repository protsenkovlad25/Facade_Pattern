using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTheater_Facade.Equipment
{
    class SoundSystem
    {
        public void On()
        { Console.WriteLine("Включение акустики"); }

        public void Off()
        { Console.WriteLine("Выключение акустики"); }
    }
}
