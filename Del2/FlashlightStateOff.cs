namespace GoFStatePattern
{
    public class FlashlightStateOff : FlashlightState
    {
        public override void HandlePower(Flashlight contextFlashlight)
        {
            contextFlashlight.LightOn();
            contextFlashlight.SetState(new FlashlightStateOn());
        }
    }
}
