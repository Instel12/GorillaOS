using GorillaNetworking;
using GorillaOS.Stuff;
using HarmonyLib;

namespace GorillaOS.Patches
{
    [HarmonyPatch(typeof(GorillaComputerTerminal), "SetFullScreen")]
    class FunctionPatch
    {
        static void Prefix(ref bool fullScreen)
        {
            fullScreen = false;
        }
    }
}
