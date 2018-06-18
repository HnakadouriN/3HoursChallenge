using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

    [HideInInspector]
    public bool hitting;
    public LaserInfo laser;

	public virtual void OnLaserHit()
    {
        if (hitting) return;
        hitting = true;
        //Debug.Log("当たった");
    }
    public virtual void OnLaserLeave()
    {
        if (!hitting) return;
        hitting = false;
        //Debug.Log("離れた");
    }
    public virtual void OnLaserHitting()
    {
        if (!hitting) return;
        //Debug.Log("当たってる");
    }

}
public struct LaserInfo
{
    public Vector3 origin;
    public Vector3 direction;
    public RaycastHit hit;

    public LaserInfo(Vector3 origin, Vector3 direction, RaycastHit hit)
    {
        this.origin = origin;
        this.direction = direction.normalized;
        this.hit = hit;
    }
}
