using System.Text;
using GorillaNetworking;
using HarmonyLib;
using UnityEngine;

namespace GorillaOS.Patches
{
    [HarmonyPatch(typeof(GorillaComputer), "AppendColored")]
    class YellowPatch
    {
        public static bool Prefix(StringBuilder builder, string text, Color color)
        {
            builder.Append(text);
            return false;
        }
    }
}
