using HarmonyLib;

[HarmonyPatch(typeof(TradingPost), "Update")]
class TradingPost_Update_Patch
{
    public static void Postfix(TradingPost __instance)
    {
        if (__instance.radioMusic.IsPlaying())
        {
            __instance.radioMusic.Stop();
        }

    }
}
