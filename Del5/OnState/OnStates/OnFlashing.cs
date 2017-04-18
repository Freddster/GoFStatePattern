namespace GoFStatePattern.OnStates
{
    public class OnFlashing : FlashlightStateOn
    {
        public override void HandleMode(Flashlight contextFlashlight)
        {
            contextFlashlight.LightSolid();
            contextFlashlight.SetMode(new OnSolid());
        }
    }
}