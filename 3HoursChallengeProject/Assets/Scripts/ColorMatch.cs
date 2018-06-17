using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMatch : MonoBehaviour {
    public GameObject[] colors;
    public GameObject Door;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < colors.Length;i++){
            if(colors[i].GetComponent<ChangeColor>().i!=i){
                return;
            }
        }
        Door.GetComponent<Door>().Unlock();
	}
}
