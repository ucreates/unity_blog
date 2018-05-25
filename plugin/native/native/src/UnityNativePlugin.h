//======================================================================
// Project Name    : native
//
// Copyright © 2017 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
#pragma once
#include "PlatformBase.h"
#if UNITY_ANDROID
#include <jni.h>
#include <android/log.h>
#endif
#include "IUnityGraphics.h"
extern "C" {
void UNITY_INTERFACE_EXPORT UNITY_INTERFACE_API UnityPluginLoad(IUnityInterfaces* unityInterfaces);
void UNITY_INTERFACE_EXPORT UNITY_INTERFACE_API UnityPluginUnload();
int UNITY_INTERFACE_EXPORT ExecuteNativePlugin();
}
