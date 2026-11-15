using System.Linq;
using BepInEx;
using GorillaNetworking;
using HarmonyLib;
using static GorillaNetworking.GorillaComputer;

namespace GorillaOS
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Title, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        void Awake() => new Harmony(PluginInfo.GUID).PatchAll();
    }
}
