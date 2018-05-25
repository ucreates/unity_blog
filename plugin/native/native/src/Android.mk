LOCAL_PATH := $(call my-dir)
include $(CLEAR_VARS)
LOCAL_MODULE = plugin
LOCAL_SRC_FILES := UnityNativePlugin.cpp 
LOCAL_SRC_FILES += $(shell find $(LOCAL_PATH)/plugin/ -name '*.cpp')
LOCAL_SRC_FILES := $(subst jni/,, $(LOCAL_SRC_FILES))
LOCAL_C_INCLUDES := $(shell find $(LOCAL_PATH)/plugin/ -type d)
LOCAL_LDLIBS    := -llog
include $(BUILD_SHARED_LIBRARY)
