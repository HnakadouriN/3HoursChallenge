using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugStuff : Stuff {
    private int a = 0;
    public override void OnClick()
    {
        base.OnClick();
        a++;
        Debug.Log(a);
    }
    void Start() {
        Debug.Log("DebugStart");
    }
    
}
