using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public class BuildAssetBundles
{
    private static string[] args;
    static BuildAssetBundles()
    {
        args = Environment.GetCommandLineArgs();
        Debug.Log("Running BuildAssetBundles");
        string arg = GetArg("-buildassetbundles");
        if (arg != null)
            Debug.Log("Found arg");
        else
            Debug.Log("Missing arg");
        PrintAllArgs();
    }

    private static void PrintAllArgs()
    {
        for (int i = 0; i < args.Length; i++)
        {
            Debug.LogWarning("ARG: " + args[i]);
        }
    }
    private static string GetArg(string name)
    {
        for (int i = 0; i < args.Length; i++)
        {
            if (args[i] == name && args.Length > i + 1)
            {
                return args[i + 1];
            }
        }
        return null;
    }
}
