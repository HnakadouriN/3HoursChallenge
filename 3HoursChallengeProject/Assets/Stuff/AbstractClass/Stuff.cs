using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Stuff : MonoBehaviour {
    public virtual void OnClickDown() {
        Debug.Log(this.transform.name + "がクリックされました");
    }
    public virtual void OnClickUp() {
        Debug.Log(this.transform.name + "がクリック離されました");
    }
    public virtual void OnClick()
    {
        Debug.Log(this.transform.name + "がクリック押されています");
    }
}
