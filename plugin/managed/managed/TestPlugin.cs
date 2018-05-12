// ======================================================================
// Project Name    : managed
//
// Copyright © 2018 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
using UnityEngine;
namespace UnityManagedPlugin {
public class TestPlugin {
    public int Execute() {
        Debug.Log(string.Format("{0}.{1}", this.GetType().Name, new System.Diagnostics.StackFrame(0, true).GetMethod().Name));
        return 1 + 1;
    }
}
}
