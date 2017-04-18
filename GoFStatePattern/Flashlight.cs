using System;

namespace GoFStatePattern
{
    public class Flashlight
    {
        public enum FlashLightEvent { ButtonPressed }

        enum FlashLightstate
        {
            On,
            Off,
        }

        private FlashLightstate _currentState;

        public Flashlight()
        {
            _currentState = FlashLightstate.Off;
        }

        public void SetState(FlashLightEvent evt)
        {
            switch (_currentState)
            {
                case FlashLightstate.On:
                    _currentState = FlashLightstate.Off;
                    Console.WriteLine("Flashlight Off");
                    break;

                case FlashLightstate.Off:
                    _currentState = FlashLightstate.On;
                    Console.WriteLine("Flashlight On");
                    break;
            }
        }

    }
}