using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonStuff : Stuff {
    [SerializeField]
    private GameObject[] Obj;
    [SerializeField]
    private float size;
    public override void OnClick()
    {
        base.OnClick();
        PushButton();
    }

    void PushButton()
    {
        for (int i = 0; i < Obj.Length; i++)
        {
            Obj[i].GetComponent<Stuff>().OnClick();
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Small();
            OnClick();
        }
        if (Input.GetKeyUp(KeyCode.A)) {
            Big();
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
