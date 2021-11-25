using System;
using HomeTheater_Facade.Equipment;

namespace HomeTheater_Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(1) Просмотр DVD-фильма\n" +
                "(2) Выключение DVD-фильма\n" +
                "(3) Прослушивание CD-диска\n" +
                "(4) Выключение CD-диска\n" +
                "(5) Прослушивание радио\n" +
                "(6) Выключение радио\n" +
                "(7) Выключить пульт");

            Popper popper = new Popper();
            Screen screen = new Screen();
            Projector projector = new Projector();
            Amplifier amplifier = new Amplifier();
            DVD dvd = new DVD();
            CD cd = new CD();
            SoundSystem sound = new SoundSystem();
            Tuner tuner = new Tuner();

            Control control = new Control(popper, screen, projector, amplifier, sound, dvd, cd, tuner);
            int x = 0, vol, wave;
            while (x != 7)
            {
                x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Console.WriteLine("Введите громкость для просмотра фильма (средняя: 5)");
                        vol = Convert.ToInt32(Console.ReadLine());
                        control.OnDVD(vol);
                        break;
                    case 2:
                        control.OffDVD();
                        break;
                    case 3:
                        Console.WriteLine("Введите громкость для прослушивания диска (средняя: 5)");
                        vol = Convert.ToInt32(Console.ReadLine());
                        control.OnCD(vol);
                        break;
                    case 4:
                        control.OffCD();
                        break;
                    case 5:
                        Console.WriteLine("Введите волну для прослушивания радио");
                        wave = Convert.ToInt32(Console.ReadLine());
                        control.OnTuner(wave);
                        break;
                    case 6:
                        control.OffTuner();
                        break;
                    default:
                        x = 7;
                        break;
                }
            }
        }
    }
}
