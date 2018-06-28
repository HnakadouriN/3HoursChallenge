using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    private Rigidbody rb;
    public float direction;
    public float timeOut;
    private float timeElapsed;
	// Use this for initialization
	void Start () {
        rb = this.gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(new Vector3(0, direction, 0),ForceMode.Acceleration);
        rb.AddTorque(0, direction, 0);
        timeElapsed += Time.deltaTime;
        if(timeElapsed >= timeOut){
            Destroy(this.gameObject);
            timeElapsed = 0;
        }
	}
}
