using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonStuff : Stuff {
    [SerializeField]
    private GameObject[] Obj;
    [SerializeField]
    private float size;
    public override void OnClickDown()
    {
        base.OnClickDown();
        Small();
        PushButton();
    }
    public override void OnClickUp()
    {
        base.OnClickUp();
        Big();
    }
    void PushButton()
    {
        for (int i = 0; i < Obj.Length; i++)
        {
            Obj[i].GetComponent<Stuff>().OnClickDown();
        }
    }
    void Big()
    {
        transform.localScale = new Vector3(1, 1, 1);
    }
    void Small() {
        transform.localScale = new Vector3(1, 1, 1) * size;
    }
}
