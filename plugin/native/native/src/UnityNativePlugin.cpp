//======================================================================
// Project Name    : native
//
// Copyright © 2018 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
#include "UnityNativePlugin.h"
#include "LogPlugin.h"
#include "TestPlugin.h"
void UNITY_INTERFACE_EXPORT UNITY_INTERFACE_API UnityPluginLoad(IUnityInterfaces* unityInterfaces) {
    LogPlugin::write(__FUNCTION__);
    return;
}
void UNITY_INTERFACE_EXPORT UNITY_INTERFACE_API UnityPluginUnload() {
    LogPlugin::write(__FUNCTION__);
    return;
}
int UNITY_INTERFACE_EXPORT ExecuteNativePlugin() {
    LogPlugin::write(__FUNCTION__);
    TestPlugin plugin;
    return plugin.execute();
}
