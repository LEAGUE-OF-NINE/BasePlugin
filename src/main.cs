using System;
using System.Diagnostics;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.IL2CPP;
using HarmonyLib;
using Il2CppDumper;
using Il2CppSystem.IO;
using Il2CppSystem.Security.Cryptography;
using UnhollowerBaseLib;
using UnhollowerRuntimeLib;
using UnityEngine;
using Random = System.Random;

namespace BaseMod;

[BepInPlugin(Guid, Name, Version)]
public class Main : BasePlugin
{
    public const string Guid = Author + "." + Name;
    public const string Name = "TestPlugin";
    public const string Version = "0.0.1";
    public const string Author = "Noop";

    public override void Load()
    {
    }
}