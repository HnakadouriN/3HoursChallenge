using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : Stuff {

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
        SceneManager.LoadScene(roomName);
    }
}
