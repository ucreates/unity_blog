//======================================================================
// Project Name    : unity plugin
//
// Copyright © 2017 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
#include <sstream>
#include "PlatformBase.h"
#if UNITY_ANDROID
#include <android/log.h>
#endif
#include "LogPlugin.h"
void LogPlugin::write(const char* info) {
#if UNITY_IPHONE
    char log[UINT16_MAX];
    sprintf(log, "%s::%s\n", "UnityNativePlugin(iOS)", info);
    printf("%s", log);
#endif
#if UNITY_ANDROID
    __android_log_print(ANDROID_LOG_DEBUG, "UnityNativePlugin(Android)", "%s", info);
#endif
    return;
}
