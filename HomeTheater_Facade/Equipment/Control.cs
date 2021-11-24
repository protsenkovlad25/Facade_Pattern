using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeTheater_Facade.Equipment;

namespace HomeTheater_Facade
{
    class Control
    {
        Popper popper;
        Screen screen;
        Projector projector;
        Amplifier amplifier;
        SoundSystem sound;
        DVD dvd;
        CD cd;
        Tuner tuner;

        public Control(Popper p, Screen sc, Projector pr, Amplifier a, SoundSystem s, DVD d, CD c, Tuner t)
        {
            popper = p;
            screen = sc;
            projector = pr;
            amplifier = a;
            sound = s;
            dvd = d;
            cd = c;
            tuner = t;
        }

        public void OnDVD(int volume)
        {
            popper.On();
            popper.Cook();
            screen.On();
            screen.Drop();
            projector.On();
            projector.СontactDVD();
            projector.FullScreenOn();
            amplifier.On();
            amplifier.СontactDVD();
            amplifier.AmbientSoundOn();
            amplifier.Volume(volume);
            dvd.On();
            dvd.Play();
        }

        public void OffDVD()
        {
            popper.Off();
            screen.Off();
            screen.Raise();
            projector.Off();
            amplifier.Off();
            dvd.Off();
        }

        public void OnCD(int volume)
        {
            amplifier.On();
            amplifier.СontactCD();
            amplifier.Volume(volume);
            sound.On();
            cd.On();
            cd.Play();
        }

        public void OffCD()
        {
            amplifier.Off();
            sound.Off();
            cd.Off();
        }

        public void OnTuner(int wave)
        {
            amplifier.On();
            amplifier.СontactTuner();
            tuner.On();
            tuner.Wave(wave);
        }

        public void OffTuner()
        {
            amplifier.Off();
            tuner.Off();
        }
    }
}
