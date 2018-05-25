//======================================================================
// Project Name    : native
//
// Copyright © 2018 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
using UnityPlugin;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class TestPluginBehaviour : MonoBehaviour {
    private TestPlugin plugin {
        get;
        set;
    }
    // Use this for initialization
    void Start() {
        this.plugin = new TestPlugin();
        return;
    }
    public void OnClick() {
        Debug.Log(string.Format("{0}.{1}", this.GetType().Name, new System.Diagnostics.StackFrame(0, true).GetMethod().Name));
        int ret = this.plugin.Execute();
        string path = System.IO.Path.Combine("Canvas", "Text");
        GameObject textObject = GameObject.Find(path);
        Text text = textObject.GetComponent<Text>();
        text.text = ret.ToString();
        return;
    }
}
