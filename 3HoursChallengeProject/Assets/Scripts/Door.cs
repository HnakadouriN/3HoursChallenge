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
        MoveRoom("Result");
    }

    private void MoveRoom(string roomName)
    {
        if (isLocked) return;
        SceneManager.LoadScene(roomName);
    }
}
