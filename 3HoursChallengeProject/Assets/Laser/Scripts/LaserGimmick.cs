using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserGimmick : MonoBehaviour {

    public Door door;
    private LaserSwitch[] switchs;
    private LaserController[] controllers;

	// Use this for initialization
	void Start () {
        switchs = this.GetComponentsInChildren<LaserSwitch>();
        controllers = this.GetComponentsInChildren<LaserController>();
    }
	
	// Update is called once per frame
	void Update () {
		foreach(LaserSwitch s in switchs)
        {
            if (!s.on) return;
        }

        door.Unlock(true);
        foreach(LaserController lc in controllers)
        {
            Destroy(lc);
        }
        Destroy(this);
	}
}
