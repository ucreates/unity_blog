//======================================================================
// Project Name    : kotlin
//
// Copyright © 2018 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
package com.test
import android.util.Log
import java.lang.StackTraceElement
import java.lang.Thread
class TestPlugin {
    fun execute(): Int {
        var elements: Array<StackTraceElement?> = Thread.currentThread().stackTrace
        var element: StackTraceElement? = elements[2]
        Log.i("UnityAndroidPlugin", String.format("%s.%s", element?.className, element?.methodName))
        return 1 + 1
    }
}