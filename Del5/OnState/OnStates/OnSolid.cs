namespace GoFStatePattern.OnStates
{
    public class OnSolid : FlashlightStateOn
    {
        public override void HandleMode(Flashlight contextFlashlight)
        {
            contextFlashlight.LightFlashing();
            contextFlashlight.SetMode(new OnFlashing());
        }
    }
}