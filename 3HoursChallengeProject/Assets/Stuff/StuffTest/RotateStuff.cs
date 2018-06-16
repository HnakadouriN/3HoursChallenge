using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateStuff : Stuff {
    private bool isRotate = false;
    [SerializeField]
    private float Speed;
    public override void OnClickDown()
    {
        base.OnClickDown();
        if (!isRotate) {
            isRotate = true;
            StartCoroutine("Rotate");
        }
    }
    IEnumerator Rotate()
    {
        for (int i = 0 ;i <= 90; i++)
        {
            transform.localEulerAngles = transform.localEulerAngles + new Vector3(0, 1, 0);
            yield return new WaitForSeconds(1 / Speed);
        }
        isRotate = false;
    }
}
