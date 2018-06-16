using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Number : Stuff {

    private Text text;
    public int i;

    void Start()
    {
        text = this.GetComponentInChildren<Text>();
    }

    public override void OnClickDown()
    {
        base.OnClickDown();
        i = ++i % 10;
        text.text = i.ToString();
    }
}
