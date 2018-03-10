//======================================================================
// Project Name    : objective_c
//
// Copyright © 2018 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
#import "TestPlugin.h"
extern "C" int executeiOSPlugin() {
    NSLog(@"%s", __FUNCTION__);
    TestPlugin* plugin = [[TestPlugin alloc] init];
    return [plugin execute];
}
