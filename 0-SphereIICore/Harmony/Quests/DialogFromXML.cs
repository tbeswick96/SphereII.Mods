﻿using DMT;
using Harmony;
using System;
using System.Reflection;
using System.Xml;
using UnityEngine;

public class SphereII_DialogFromXML
{
    [HarmonyPatch(typeof(DialogFromXml))]
    [HarmonyPatch("ParseRequirement")]
    public class SphereII__DialogFromXML_ParseRequirement
    {
        static void Postfix( BaseDialogRequirement __result, XmlElement e)
        {
            if (__result is DialogRequirementHasCVarSDX)
            {
                if (e.HasAttribute("operator"))
                    (__result as DialogRequirementHasCVarSDX).strOperator = e.GetAttribute("operator");
            }
        }
    }


}