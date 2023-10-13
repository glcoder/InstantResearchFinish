using HarmonyLib;

namespace InstantResearchFinish
{
    [HarmonyPatch(typeof(ResearchSystem), nameof(ResearchSystem.startResearch))]
    internal class ResearchSystem_startResearch
    {
        static void Postfix(ResearchTemplate value)
        {
            ResearchSystem.singleton.finishCurrentResearch();
        }
    }
}
