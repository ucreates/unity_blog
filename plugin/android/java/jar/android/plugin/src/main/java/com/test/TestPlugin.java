//======================================================================
// Project Name    : java
//
// Copyright © 2018 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
package com.test;
import android.util.Log;
public class TestPlugin {
    public int execute() {
        android.util.Log.i("UnityAndroidPlugin", String.format("%s.%s", new Object() {} .getClass().getName(), new Object() {} .getClass().getEnclosingMethod().getName()));
        return 1 + 1;
    }
}
