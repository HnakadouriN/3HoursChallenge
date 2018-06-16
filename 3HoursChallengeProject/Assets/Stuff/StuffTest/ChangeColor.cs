using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : Stuff {
    private static Color[] ColorList = new Color[] {
        Color.white,
        Color.red ,
        Color.blue,
        Color.green,
        Color.yellow,
        Color.black,
    };
    private int i = 0;
    public override void OnClickDown() {
        base.OnClickDown();
        Change();
    }
    private void Change()
    {
        i++;
        if (i == ColorList.Length) {
            i = 0;
        }
        this.transform.GetComponent<MeshRenderer>().material.color = ColorList[i];
    }
}
