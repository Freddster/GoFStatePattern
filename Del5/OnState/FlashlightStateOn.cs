namespace GoFStatePattern
{
    public class FlashlightStateOn : FlashlightState
    {
        public override void HandlePower(Flashlight contextFlashlight)
        {
            contextFlashlight.LightOff();
            contextFlashlight.SetState(new FlashlightStateOff());
        }

        public override void HandleMode(Flashlight contextFlashlight) { }
    }
}