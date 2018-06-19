using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMirror : Laser {

    public GameObject lpPrefab;
    private LaserPointer lp;

    void Start () {
        lp = Instantiate(lpPrefab, this.transform).GetComponent<LaserPointer>();
        lp.transform.parent = this.transform;
        lp.emit = false;
    }

    public override void OnLaserHit()
    {
        base.OnLaserHit();
        lp.emit = true;
    }
    public override void OnLaserLeave()
    {
        base.OnLaserLeave();
        lp.emit = false;
    }
    public override void OnLaserHitting()
    {
        base.OnLaserHitting();
        lp.transform.position = laser.hit.point;
        lp.transform.up = laser.direction + 2 * DotVec(-laser.direction, laser.hit.normal) * laser.hit.normal;
        //Debug.DrawRay(laser.hit.point, laser.hit.normal);
    }

    private float DotVec(Vector3 a, Vector3 b)
    {
        return a.x * b.x + a.y * b.y + a.z * b.z;
    }
}
