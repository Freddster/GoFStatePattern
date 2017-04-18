namespace GoFStatePattern
{
    public class FlashlightStateOff : FlashlightState
    {
        public override void HandlePower(Flashlight contextFlashlight)
        {
            contextFlashlight.LightSolid();
            contextFlashlight.SetState(new FlashlightStateOn());
        }
        public override void HandleMode(Flashlight contextFlashlight) { }
    }
}
