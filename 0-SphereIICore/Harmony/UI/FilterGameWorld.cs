﻿//using Harmony;
//using System.Reflection;
//using UnityEngine;
//using DMT;
//using System;
//using System.Collections.Generic;

////[HarmonyPatch(typeof(PathAbstractions), MethodType.Constructor)]
//[HarmonyPatch(typeof(PathAbstractions))]
//[HarmonyPatch("GetAvailablePathsList")]
//public class SphereII_FilterGameWorld
//{

//    public static List<PathAbstractions.AbstractedLocation> Postfix(List<PathAbstractions.AbstractedLocation> __result, PathAbstractions.SearchPaths _searchPaths)
//    {
//        List < PathAbstractions.AbstractedLocation> newList= new List<PathAbstractions.AbstractedLocation>();
//        foreach (var each in __result)
//        {
//            if (each.Name.Contains("Winter Project"))
//                newList.Add(each);
//        }

//        return newList;
//    }
//}

//[HarmonyPatch(typeof(XUiC_NewContinueGame))]
//[HarmonyPatch("updateWorlds")]
//public class SphereII_UpdateWorlds
//{

//    public static void Postfix( ref XUiC_ComboBoxList<global::XUiC_NewContinueGame.LevelInfo> ___cbxWorldName)
//    {
//         XUiC_NewContinueGame.LevelInfo random = new global::XUiC_NewContinueGame.LevelInfo
//        {
//            RealName = "New Random World",
//            CustName = "New Random World",
//            Description = "Generate New Random World",
//            IsNewRwg = true
//        };
//        if (___cbxWorldName.Elements.Contains(random))
//        {
//            Debug.Log("Removing Random World");
//            ___cbxWorldName.Elements.Remove(random);
//        }

//    }
//}


////[HarmonyPatch(typeof(Prefab))]
////[HarmonyPatch("LoadXMLData")]
////[HarmonyPatch(new Type[] { typeof(string) })]
////public class Prefab_LoadXMLData_Patcher
////{
////    public static bool Postfix(bool __result, string _prefabName, Prefab __instance)
////    {
////        // Found the prefab already, so don't bother looking.
////        if (__result)
////            return __result;

////        // Hard coded read from Mods/MyMod/Prefabs folder
////        return __instance.LoadXMLData(Utils.GetGameDir("Mods/MyMod/Prefabs"), _prefabName);
////    }
////}

