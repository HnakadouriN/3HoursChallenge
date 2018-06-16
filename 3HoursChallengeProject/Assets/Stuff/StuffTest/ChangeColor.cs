using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : Stuff {
    private static Vector3[] ColorList = new Vector3[] {
        Vector3.forward ,
        Vector3.right ,
        Vector3.up ,
    };
    private int i = 0;
    public override void OnClick() {
        base.OnClick();
        Change();
    }
    private void Change()
    {
        i++;
        if (i == ColorList.Length) {
            i = 0;
        }
        Vector3 vec = ColorList[i];
        this.transform.GetComponent<MeshRenderer>().material.color = new Color(vec.x, vec.y, vec.z);
    }
}
