using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInEditor : MonoBehaviour {

#if UNITY_EDITOR

    private GameObject mainCamera;

    // Use this for initialization
    void Start () {
		mainCamera = Camera.main.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		mainCamera.transform.rotation = Quaternion.Euler(-(Input.mousePosition.y - Screen.height/2), Input.mousePosition.x - Screen.width/2, 0);
	}
#endif
}
