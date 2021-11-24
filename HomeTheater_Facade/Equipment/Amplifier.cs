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

        public void СontactDVD()
        { Console.WriteLine("Свзязь с DVD-проигрывателем"); }

        public void СontactCD()
        { Console.WriteLine("Свзязь с CD-проигрывателем"); }

        public void СontactTuner()
        { Console.WriteLine("Свзязь с радио"); }

        public void AmbientSoundOn()
        { Console.WriteLine("Режим окр. мира вкл"); }

        public void AmbientSoundOff()
        { Console.WriteLine("Режим окр. мира выкл"); }

        public void Volume(int volume)
        { Console.WriteLine($"Установлена громкость: {volume}"); }
    }
}
