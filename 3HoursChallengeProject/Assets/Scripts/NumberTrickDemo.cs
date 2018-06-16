using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberTrickDemo : MonoBehaviour {

    private Number[] numbers;
    public int correctNum = 1111;

	// Use this for initialization
	void Start () {
        numbers = this.GetComponentsInChildren<Number>();
	}
	
	// Update is called once per frame
	void Update () {
        int i = 0;
		foreach(Number num in numbers)
        {
            i = i * 10 + num.i;
        }
        if (i == correctNum)
        {
            Debug.Log("correct");
            foreach (Number num in numbers) Destroy(num);
            Destroy(this);
        }
	}
}
