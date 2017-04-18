using System;

namespace GoFStatePattern
{
    public class Flashlight
    {
        private FlashlightState _currentState;

        public Flashlight()
        {
            _currentState = new FlashlightStateOff();
        }

        public void Power()
        {
            _currentState.HandlePower(this);
        }

        public void LightOn()
        {
            Console.WriteLine("Flashlight On");
        }

        public void LightOff()
        {
            Console.WriteLine("Flashlight Off");
        }

        public void SetState(FlashlightState s)
        {
            _currentState = s;
        }
    }
}