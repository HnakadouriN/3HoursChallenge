﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPointer : MonoBehaviour {

    public bool emit = true;

	// Use this for initialization
	void Start () {
		
	}

    GameObject laserObj = null;

    // Update is called once per frame
    void Update () {
        if (emit)
        {
            Ray ray = new Ray(this.transform.position, this.transform.up);
            RaycastHit hit;
            Debug.DrawRay(ray.origin, ray.direction);

            if (Physics.Raycast(ray, out hit))
            {
                var tmpObj = hit.collider.gameObject;
                var laser = tmpObj.GetComponent<Laser>();
                Debug.DrawLine(ray.origin, hit.point, Color.red);

                if (laser)
                {
                    laser.OnLaserHitting();
                    laser.laser = new LaserInfo(ray.origin, ray.direction, hit);
                    if (laserObj)
                    {
                        if (laserObj.GetInstanceID().Equals(tmpObj.GetInstanceID())) return;
                        else laserObj.GetComponent<Laser>().OnLaserLeave();

                    }

                    laserObj = tmpObj;
                    laser.OnLaserHit();
                    return;
                }
                else
                {
                    if (laserObj)
                    {
                        laserObj.GetComponent<Laser>().OnLaserLeave();
                        laserObj = null;
                    }
                }
            }
            else
            {
                if (laserObj)
                {
                    laserObj.GetComponent<Laser>().OnLaserLeave();
                    laserObj = null;
                }
            }
        }
        else
        {
            if (laserObj)
            {
                laserObj.GetComponent<Laser>().OnLaserLeave();
                laserObj = null;
            }
        }
    }
}
