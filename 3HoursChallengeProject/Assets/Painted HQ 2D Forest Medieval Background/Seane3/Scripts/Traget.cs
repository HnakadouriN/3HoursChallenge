using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traget : MonoBehaviour
{

    public TargetType targetType;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
public enum TargetType{
    itemObject,
    eventObject,
    none,
}

