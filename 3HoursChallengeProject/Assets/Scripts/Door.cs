using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : Stuff {

    [SerializeField]
    public bool isLocked = true;

	// Use this for initialization
	void Start () {
		
	}
    public override void OnClickDown()
    {
        base.OnClickDown();
    }

    public void MoveRoom(string roomName)
    {
        if (isLocked)
        {
            MyDebug.LogOnText("「鍵がかかっているようだ」", 2f);
            return;
        }
        SceneManager.LoadScene(roomName);
    }
}
