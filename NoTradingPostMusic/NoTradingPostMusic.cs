using HarmonyLib;
using UnityEngine;

public class NoTradingPostMusic : Mod
{
    private Harmony harmonyInstance;
    public static JsonModInfo modInfo;
    public void Start()
    {
        modInfo = modlistEntry.jsonmodinfo;
        Debug.Log($"Mod NoTradingPostMusic v{modInfo.version} has been loaded!");
        harmonyInstance = new Harmony("hu.meza.notradingpostmusic");
        harmonyInstance.PatchAll();
    }

    public void OnModUnload()
    {
        harmonyInstance.UnpatchAll("hu.meza.notradingpostmusic");
        Debug.Log("Mod MusicLevelsForAll has been unloaded!");
    }
}