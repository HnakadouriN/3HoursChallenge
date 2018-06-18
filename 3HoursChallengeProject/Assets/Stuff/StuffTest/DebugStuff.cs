using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugStuff : Stuff {
    public override void OnClickDown()
    {
        base.OnClickDown();
        Debug.Log("OnClickDown");
    }
    public override void OnClickUp()
    {
        base.OnClickUp();
        Debug.Log("OnClickUp");
    }
    public override void OnClick()
    {
        base.OnClick();
        Debug.Log("OnClick");
    }
    public override void OnHoverDown()
    {
        base.OnHoverDown();
        Debug.Log("OnHoverDown");
    }
    public override void OnHoverUp()
    {
        base.OnHoverUp();
        Debug.Log("OnHoverUp");
    }
    public override void OnHover()
    {
        base.OnHover();
        Debug.Log("OnHover");
    }
    void Start() {
        Debug.Log("DebugStart");
    }
    
}
