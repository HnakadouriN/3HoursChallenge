using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    
    void Awake()
    {
#if UNITY_EDITOR
        DestroyImmediate(this);
#endif

        Input.gyro.enabled = true;
    }
    void Update () {
        transform.rotation = Quaternion.AngleAxis(90.0f, Vector3.right) * Input.gyro.attitude * Quaternion.AngleAxis(180.0f, Vector3.forward);
    }
}
