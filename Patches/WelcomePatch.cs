using System;
using GorillaNetworking;
using GorillaOS.Stuff;
using HarmonyLib;

namespace GorillaOS.Patches
{
    [HarmonyPatch(typeof(GorillaComputer), "StartupScreen")]
    class WelcomePatch
    {
        static bool Prefix()
        {
            string bannedUsers = "0";
            try
            {
                bannedUsers = PrivateManager.GetField<int>(GorillaComputer.instance, "usersBanned").ToString();
            }
            catch { }

            GorillaComputer.instance.screenText.Set($"GORILLA OS\n\n{HowManyMonke.ThisMany.ToString()} PLAYERS ONLINE\n\n{bannedUsers} USERS BANNED YESTERDAY\n\nPRESS ANY KEY TO BEGIN");
            return false;
        }
    }
}
