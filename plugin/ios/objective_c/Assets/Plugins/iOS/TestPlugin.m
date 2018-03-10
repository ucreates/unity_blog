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
@implementation TestPlugin
- (int)execute {
    NSLog(@"%s", __FUNCTION__);
    return 1 + 1;
}
@end
