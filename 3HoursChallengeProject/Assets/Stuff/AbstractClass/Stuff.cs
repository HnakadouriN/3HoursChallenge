using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Stuff : MonoBehaviour {
    public virtual void OnClickDown() {
        Debug.Log(this.transform.name + "がクリックされました");
    }
    public virtual void OnClick()
    {
        Debug.Log(this.transform.name + "がクリックされています");
    }
    public virtual void OnClickUp() {
        Debug.Log(this.transform.name + "がクリック離されました");
    }
    
    public virtual void OnHoverDown()
    {
        Debug.Log(this.transform.name + "にかざされ始めました");
    }
    public virtual void OnHover()
    {
        Debug.Log(this.transform.name + "にかざされています");
    }
    public virtual void OnHoverUp()
    {
        Debug.Log(this.transform.name + "から離れました");
    }
}
