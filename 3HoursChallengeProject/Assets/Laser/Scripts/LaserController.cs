using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LaserPointer))]
public class LaserController : Stuff {

    public int degree = 90;

    private bool mooving;
    private LaserPointer laser;

	// Use this for initialization
	void Start () {
        laser = this.GetComponent<LaserPointer>();
	}

    public override void OnClickDown()
    {
        if (mooving) return;
        base.OnClickDown();
        StartCoroutine(Rotate());
    }


    IEnumerator Rotate()
    {
        mooving = true;
        laser.emit = false;

        int limit = (int)this.transform.rotation.eulerAngles.y + degree;
        limit = limit - (limit % degree);limit %= 360;
        Debug.Log(limit);

        while (this.transform.rotation.eulerAngles.y <= limit || (limit == 0? this.transform.rotation.eulerAngles.y <= 360 && this.transform.rotation.eulerAngles.y >= 270:false))
        {
            Vector3 rot = this.transform.rotation.eulerAngles;
            this.transform.rotation = Quaternion.Euler(rot.x, (int)(rot.y + 100 * Time.deltaTime), rot.z);
            Debug.Log(this.transform.rotation.eulerAngles.y);
            yield return null;
        }

        laser.emit = true;
        mooving = false;
    }
}
