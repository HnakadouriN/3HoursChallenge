using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	void Awake()
    {
        Input.gyro.enabled = true;
#if UNITY_EDITOR
        Input.gyro.enabled = false;
#endif
    }
	void Update () {
        transform.rotation = Quaternion.AngleAxis(90.0f, Vector3.right) * Input.gyro.attitude * Quaternion.AngleAxis(180.0f, Vector3.forward);
    }
}
