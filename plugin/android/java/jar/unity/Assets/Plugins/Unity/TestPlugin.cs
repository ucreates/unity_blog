﻿//======================================================================
// Project Name    : java
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
    public int Execute() {
        Debug.Log(string.Format("{0}.{1}", this.GetType().Name, new System.Diagnostics.StackFrame(0, true).GetMethod().Name));
        int ret = 0;
        if (RuntimePlatform.Android == Application.platform) {
            AndroidJavaObject plugin = new AndroidJavaObject("com.test.TestPlugin");
            ret = plugin.Call<int>("execute");
        }
        return ret;
    }
}
}
