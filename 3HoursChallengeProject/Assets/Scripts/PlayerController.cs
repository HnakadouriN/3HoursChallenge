using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlayerController : MonoBehaviour
{

    private UnityEngine.UI.Image aim;
    private GameObject mainCamera;
    // Use this for initialization
    void Start()
    {
        XRSettings.enabled = false;

        aim = this.GetComponent<UnityEngine.UI.Image>();
        mainCamera = Camera.main.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = new Ray(mainCamera.transform.position, mainCamera.transform.forward);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Stuff stuff = hit.collider.gameObject.GetComponent<Stuff>();
                if(stuff){
                    stuff.OnClickDown();
                }
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = new Ray(mainCamera.transform.position, mainCamera.transform.forward);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Stuff stuff = hit.collider.gameObject.GetComponent<Stuff>();
                if (stuff)
                {
                    stuff.OnClickUp();
                }
            }
        }
        if (Input.GetMouseButton(0))
        {
            Ray ray = new Ray(mainCamera.transform.position, mainCamera.transform.forward);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Stuff stuff = hit.collider.gameObject.GetComponent<Stuff>();
                if (stuff)
                {
                    stuff.OnClick();
                }
            }
        }
    }
}