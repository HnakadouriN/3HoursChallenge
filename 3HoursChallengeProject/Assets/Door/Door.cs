using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : Stuff {

    public string doorName;
    public string roomName;
    public bool haveKey = false;

    // Use this for initialization
    void Start () {
		
	}
    public override void OnClickDown()
    {
        base.OnClickDown();
        MoveRoom();
    }

    public void MoveRoom(string doorName,string roomName)
    {
        if (RoomManager.IsLocked(doorName))
        {
            if (haveKey)
            {
                Unlock();
                return;
            }
            MyDebug.LogOnText("「鍵がかかっているようだ」", 2f);
            return;
        }
        SceneManager.LoadScene(roomName);
    }
    private void MoveRoom()
    {
        if (RoomManager.IsLocked(doorName))
        {
            MyDebug.LogOnText("「鍵がかかっているようだ」", 2f);
            return;
        }
        SceneManager.LoadScene(roomName);
    }
    public void Unlock(bool note = true)
    {
        if (note) MyDebug.LogOnText("「鍵の開く音がした」", 2f);
        RoomManager.Unlock(doorName);
    }
    
}
