using GorillaNetworking;
using HarmonyLib;
using UnityEngine;

namespace GorillaOS.Patches
{
    [HarmonyPatch(typeof(GorillaComputer), "BuildFailureScreen")]
    class FailurePatch
    {
        static bool Prefix(ref string __result, string failMessage)
        {
            __result = failMessage;
            GorillaComputer.instance.wrongVersionMaterial.color = Color.red;
            return false;
        }
    }
}
