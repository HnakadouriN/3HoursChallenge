using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Stuff : MonoBehaviour {
    public virtual void OnClick() {
        Debug.Log(this.transform.name + "がクリックされました");
    }
}
