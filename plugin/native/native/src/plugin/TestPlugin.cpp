//======================================================================
// Project Name    : native
//
// Copyright © 2018 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
#include <regex.h>
#include "LogPlugin.h"
#include "TestPlugin.h"
int TestPlugin::execute() {
    LogPlugin::write(__FUNCTION__);
    return 1 + 1;
}
