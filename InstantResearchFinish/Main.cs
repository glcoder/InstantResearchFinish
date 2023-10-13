using HarmonyLib;

namespace InstantResearchFinish
{
    [HarmonyPatch(typeof(ResearchSystem), nameof(ResearchSystem.startResearch))]
    internal class ResearchSystem_startResearch
    {
        static void Postfix()
        {
            ResearchSystem.singleton.finishCurrentResearch();
        }
    }
}
