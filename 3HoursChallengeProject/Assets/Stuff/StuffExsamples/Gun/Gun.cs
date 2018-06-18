using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Gun : Stuff {
    private float clickTime;
    private Vector3 startPos;
    private void Start()
    {
        clickTime = 0;
    }
    public override void OnClickDown()
    {
        base.OnClickDown();
        startPos = transform.position;
    }
    public override void OnClick()
    {
        clickTime += Time.deltaTime;
        transform.eulerAngles += transform.up * clickTime;
        transform.position = startPos;
    }
    public override void OnClickUp()
    {
        base.OnClickUp();
        transform.GetComponent<Rigidbody>().AddForce(transform.forward.normalized * clickTime * 10 ,ForceMode.Impulse);
        clickTime = 0;
    }
}
