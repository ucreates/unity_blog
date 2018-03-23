//======================================================================
// Project Name    : swift
//
// Copyright © 2018 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
using UnityEngine;
using UnityEditor;
using UnityEditor.iOS.Xcode;
using UnityEditor.Callbacks;
using System.IO;
using System.Collections.Generic;
namespace Editor.Build {
public class BuildPostProcess {
    [PostProcessBuild]
    public static void OnPostProcessBuild(BuildTarget buildTarget, string buildPath) {
        if (buildTarget == BuildTarget.iOS) {
            PBXProject project = new PBXProject();
            string projectPath = PBXProject.GetPBXProjectPath(buildPath);
            project.ReadFromFile(projectPath);
            string targetName = PBXProject.GetUnityTargetName();
            string targetGUID = project.TargetGuidByName(targetName);
            project.SetBuildProperty(targetGUID, "ALWAYS_EMBED_SWIFT_STANDARD_LIBRARIES", "YES");
            project.SetBuildProperty(targetGUID, "EMBEDDED_CONTENT_CONTAINS_SWIFT", "YES");
            project.SetBuildProperty(targetGUID, "LD_RUNPATH_SEARCH_PATHS", "$(inherited) @executable_path/Frameworks\"");
            project.SetBuildProperty(targetGUID, "GCC_OPTIMIZATION_LEVEL", "0");
            project.SetBuildProperty(targetGUID, "SWIFT_OPTIMIZATION_LEVEL", "-Onone");
            project.WriteToFile(projectPath);
        }
        return;
    }
}
}
