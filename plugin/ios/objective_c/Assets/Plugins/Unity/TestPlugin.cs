//======================================================================
// Project Name    : objective_c
//
// Copyright © 2018 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
using UnityEngine;
using System.Runtime.InteropServices;
namespace UnityPlugin {
public class TestPlugin {
    [DllImport("__Internal")]
    private static extern int executeiOSPlugin();
    public int Execute() {
        Debug.Log(string.Format("{0}.{1}", this.GetType().Name, new System.Diagnostics.StackFrame(0, true).GetMethod().Name));
        int ret = 0;
        if (RuntimePlatform.IPhonePlayer == Application.platform) {
            ret = executeiOSPlugin();
        }
        return ret;
    }
}
}
