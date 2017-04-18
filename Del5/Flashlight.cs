using System;
using GoFStatePattern.OnStates;

namespace GoFStatePattern
{
    public class Flashlight
    {
        private FlashlightState _currentState;
        private FlashlightStateOn _currentMode;

        public Flashlight()
        {
            _currentState = new FlashlightStateOff();
            _currentMode = new OnSolid();
        }

        public void Power()
        {
            _currentState.HandlePower(this);
        }

        public void LightSolid()
        {
            Console.WriteLine("Flashlight On Solid");
        }

        public void LightFlashing()
        {
            Console.WriteLine("Flashlight On Flashing");
        }

        public void LightOff()
        {
            Console.WriteLine("Flashlight Off");
        }

        public void SetState(FlashlightState s)
        {
            _currentState = s;
        }

        public void SetMode(FlashlightStateOn s)
        {
            _currentMode = s;
        }

        public void Mode()
        {
            if(_currentState.GetType() == typeof(FlashlightStateOn))
                _currentMode.HandleMode(this);
        }
    }
}