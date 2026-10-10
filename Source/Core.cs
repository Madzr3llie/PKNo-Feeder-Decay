using MelonLoader;

[assembly: MelonInfo(typeof(NoFeederDecay.Core), "NoFeederDecay", "1.0.0", "maddi", null)]
[assembly: MelonGame("Blue Meridian", "Prehistoric Kingdom")]

namespace NoFeederDecay
{
    public class Core : MelonMod
    {
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("Initialized.");
        }
    }
}
