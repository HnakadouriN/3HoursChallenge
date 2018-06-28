using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorController3 : MonoBehaviour {

    public GameObject[] colors;
    public GameObject CubeController;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < colors.Length; i++)
        {
            if (colors[i].GetComponent<ChangeColor>().i != i)
            {
                return;
            }
        }
      }
    public void Activate(){
        CubeController.SetActive(true);
    }
}