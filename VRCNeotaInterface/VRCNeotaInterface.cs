using MelonLoader;

namespace VRCNeotaInterface
{
    public class VrcNeotaInterface : MelonMod
    {
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            LoggerInstance.Msg("Nota come back pls");
        }
    }
}