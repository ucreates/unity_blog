//======================================================================
// Project Name    : swift
//
// Copyright © 2018 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
import Foundation
open class TestPlugin: NSObject {
    open func execute() -> Int {
        print(String(format: "%@.%@", NSStringFromClass(type(of: self)), #function))
        return 1 + 1
    }
}
