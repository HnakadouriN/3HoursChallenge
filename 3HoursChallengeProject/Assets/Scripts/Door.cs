using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : Stuff {

    [SerializeField]
    private bool isLocked = true;

	// Use this for initialization
	void Start () {
		
	}
    public override void OnClickDown()
    {
        base.OnClickDown();
        MoveRoom("DebugStuff");
    }

    private void MoveRoom(string roomName)
    {
        if (isLocked) return;
        SceneManager.LoadScene(roomName);
    }
}
