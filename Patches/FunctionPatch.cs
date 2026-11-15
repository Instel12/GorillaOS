using GorillaNetworking;
using HarmonyLib;

namespace GorillaOS.Patches
{
    [HarmonyPatch(typeof(GorillaComputerTerminal), "SetFullScreen")]
    class FunctionPatch
    {
        static void Prefix(ref bool fullScreen)
        {
            if (GorillaComputer.instance.currentState != GorillaComputer.ComputerState.Snake) fullScreen = false;
        }
    }
}
