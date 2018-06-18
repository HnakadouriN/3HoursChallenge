using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSwitch : Laser {

    public bool on = false;
    MeshRenderer rend;

	// Use this for initialization
	void Start () {
        rend = this.GetComponent<MeshRenderer>();
	}

    public override void OnLaserHit()
    {
        base.OnLaserHit();
        rend.material.color = Color.red;
        on = true;
    }
    public override void OnLaserLeave()
    {
        base.OnLaserLeave();
        rend.material.color = Color.white;
        on = false;
    }
}
