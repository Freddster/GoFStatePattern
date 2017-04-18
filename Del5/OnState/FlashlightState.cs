namespace GoFStatePattern
{
    public abstract class FlashlightState
    {
        public abstract void HandlePower(Flashlight contextFlashlight);
        public abstract void HandleMode(Flashlight contextFlashlight);
    }
}