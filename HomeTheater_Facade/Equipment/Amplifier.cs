using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTheater_Facade.Equipment
{
    class Amplifier
    {
        public void On()
        { Console.WriteLine("Включение усилителя"); }

        public void Off()
        { Console.WriteLine("Выключение усилителя"); }

        public void Сontact(string contact)
        { Console.WriteLine($"Свзязь усилителя с {contact}"); }

        public void AmbientSoundOn()
        { Console.WriteLine("Режим окр. мира вкл"); }

        public void AmbientSoundOff()
        { Console.WriteLine("Режим окр. мира выкл"); }

        public void Volume(int volume)
        { Console.WriteLine($"Установлена громкость: {volume}"); }
    }
}
