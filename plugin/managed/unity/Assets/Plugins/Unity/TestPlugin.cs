//======================================================================
// Project Name    : managed
//
// Copyright © 2018 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
using UnityEngine;
namespace UnityPlugin {
public class TestPlugin {
    public int Execute() {
        Debug.Log(string.Format("{0}.{1}", this.GetType().Name, new System.Diagnostics.StackFrame(0, true).GetMethod().Name));
        int ret = 0;
        if (RuntimePlatform.IPhonePlayer == Application.platform || RuntimePlatform.Android == Application.platform) {
            UnityManagedPlugin.TestPlugin plugin = new UnityManagedPlugin.TestPlugin();
            ret = plugin.Execute();
        }
        return ret;
    }
}
}
