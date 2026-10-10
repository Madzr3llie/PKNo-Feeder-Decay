using HarmonyLib;
using PrehistoricKingdom;
using PrehistoricKingdom.AnimalsV2.Afflictions;

namespace NoFeederDecay
{
    internal class OverrideDecay
    {
        [HarmonyPatch(typeof(ModuleAfflictions), nameof(ModuleAfflictions.Contamination01), MethodType.Setter)]
        internal static class SandboxFeederContaminationPatch
        {
            private static void Prefix(
                ModuleAfflictions __instance,
                ref float value)
            {
                if ((__instance is FeederModuleAfflictions || __instance is BedModuleAfflictions || __instance is TroughModuleAfflictions) &&
                    Game.HasInstance &&
                    SimManager.simSettings.gameMode == SimManager.GameMode.Sandbox)
                {
                    value = 0f;
                }
            }
        }
    }
}
